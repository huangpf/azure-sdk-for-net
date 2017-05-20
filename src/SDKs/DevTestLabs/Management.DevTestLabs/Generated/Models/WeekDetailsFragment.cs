// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Properties of a weekly schedule.
    /// </summary>
    public partial class WeekDetailsFragment
    {
        /// <summary>
        /// Initializes a new instance of the WeekDetailsFragment class.
        /// </summary>
        public WeekDetailsFragment() { }

        /// <summary>
        /// Initializes a new instance of the WeekDetailsFragment class.
        /// </summary>
        public WeekDetailsFragment(IList<string> weekdays = default(IList<string>), string time = default(string))
        {
            Weekdays = weekdays;
            Time = time;
        }

        /// <summary>
        /// The days of the week for which the schedule is set (e.g. Sunday,
        /// Monday, Tuesday, etc.).
        /// </summary>
        [JsonProperty(PropertyName = "weekdays")]
        public IList<string> Weekdays { get; set; }

        /// <summary>
        /// The time of the day the schedule will occur.
        /// </summary>
        [JsonProperty(PropertyName = "time")]
        public string Time { get; set; }

    }
}
