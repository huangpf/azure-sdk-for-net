﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.

namespace Microsoft.Azure.Search.Serialization
{
    using System;
    using System.Globalization;
    using System.Reflection;
    using Newtonsoft.Json;

    /// <summary>
    /// Serializes doubles to and from the OData wire format.
    /// </summary>
    internal class DoubleConverter : JsonConverter
    {
        private const string ODataNegativeInfinity = "-INF";
        private const string ODataPositiveInfinity = "INF";

        public override bool CanConvert(Type objectType) =>
            typeof(double?).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo()) ||
            typeof(double).GetTypeInfo().IsAssignableFrom(objectType.GetTypeInfo());

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            if (reader.TokenType == JsonToken.String)
            {
                string strValue = (string)reader.Value;

                switch (strValue)
                {
                    case ODataPositiveInfinity: return Double.PositiveInfinity;
                    case ODataNegativeInfinity: return Double.NegativeInfinity;
                    default: return Double.Parse(strValue, CultureInfo.InvariantCulture);
                }
            }

            // We can't use a direct cast because sometimes we get integers from the reader.
            return Convert.ToDouble(reader.Value);
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteNull();
            }
            else
            {
                double doubleValue = (double)value;

                if (Double.IsNegativeInfinity(doubleValue))
                {
                    writer.WriteValue(ODataNegativeInfinity);
                }
                else if (Double.IsPositiveInfinity(doubleValue))
                {
                    writer.WriteValue(ODataPositiveInfinity);
                }
                else
                {
                    writer.WriteValue(doubleValue);
                }
            }
        }
    }
}
