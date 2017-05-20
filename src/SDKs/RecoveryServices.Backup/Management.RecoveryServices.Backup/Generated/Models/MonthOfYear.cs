// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.Backup;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for MonthOfYear.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MonthOfYear
    {
        [EnumMember(Value = "Invalid")]
        Invalid,
        [EnumMember(Value = "January")]
        January,
        [EnumMember(Value = "February")]
        February,
        [EnumMember(Value = "March")]
        March,
        [EnumMember(Value = "April")]
        April,
        [EnumMember(Value = "May")]
        May,
        [EnumMember(Value = "June")]
        June,
        [EnumMember(Value = "July")]
        July,
        [EnumMember(Value = "August")]
        August,
        [EnumMember(Value = "September")]
        September,
        [EnumMember(Value = "October")]
        October,
        [EnumMember(Value = "November")]
        November,
        [EnumMember(Value = "December")]
        December
    }
}
