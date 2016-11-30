// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Insights.Models
{
    using System.Linq;

    /// <summary>
    /// A specific date-time for the profile.
    /// </summary>
    public partial class TimeWindow
    {
        /// <summary>
        /// Initializes a new instance of the TimeWindow class.
        /// </summary>
        public TimeWindow() { }

        /// <summary>
        /// Initializes a new instance of the TimeWindow class.
        /// </summary>
        /// <param name="start">the start time for the profile in ISO 8601
        /// format.</param>
        /// <param name="end">the end time for the profile in ISO 8601
        /// format.</param>
        /// <param name="timeZone">the timezone of the start and end times for
        /// the profile. Some examples of valid timezones are: Dateline
        /// Standard Time, UTC-11, Hawaiian Standard Time, Alaskan Standard
        /// Time, Pacific Standard Time (Mexico), Pacific Standard Time, US
        /// Mountain Standard Time, Mountain Standard Time (Mexico), Mountain
        /// Standard Time, Central America Standard Time, Central Standard
        /// Time, Central Standard Time (Mexico), Canada Central Standard Time,
        /// SA Pacific Standard Time, Eastern Standard Time, US Eastern
        /// Standard Time, Venezuela Standard Time, Paraguay Standard Time,
        /// Atlantic Standard Time, Central Brazilian Standard Time, SA Western
        /// Standard Time, Pacific SA Standard Time, Newfoundland Standard
        /// Time, E. South America Standard Time, Argentina Standard Time, SA
        /// Eastern Standard Time, Greenland Standard Time, Montevideo Standard
        /// Time, Bahia Standard Time, UTC-02, Mid-Atlantic Standard Time,
        /// Azores Standard Time, Cape Verde Standard Time, Morocco Standard
        /// Time, UTC, GMT Standard Time, Greenwich Standard Time, W. Europe
        /// Standard Time, Central Europe Standard Time, Romance Standard Time,
        /// Central European Standard Time, W. Central Africa Standard Time,
        /// Namibia Standard Time, Jordan Standard Time, GTB Standard Time,
        /// Middle East Standard Time, Egypt Standard Time, Syria Standard
        /// Time, E. Europe Standard Time, South Africa Standard Time, FLE
        /// Standard Time, Turkey Standard Time, Israel Standard Time,
        /// Kaliningrad Standard Time, Libya Standard Time, Arabic Standard
        /// Time, Arab Standard Time, Belarus Standard Time, Russian Standard
        /// Time, E. Africa Standard Time, Iran Standard Time, Arabian Standard
        /// Time, Azerbaijan Standard Time, Russia Time Zone 3, Mauritius
        /// Standard Time, Georgian Standard Time, Caucasus Standard Time,
        /// Afghanistan Standard Time, West Asia Standard Time, Ekaterinburg
        /// Standard Time, Pakistan Standard Time, India Standard Time, Sri
        /// Lanka Standard Time, Nepal Standard Time, Central Asia Standard
        /// Time, Bangladesh Standard Time, N. Central Asia Standard Time,
        /// Myanmar Standard Time, SE Asia Standard Time, North Asia Standard
        /// Time, China Standard Time, North Asia East Standard Time, Singapore
        /// Standard Time, W. Australia Standard Time, Taipei Standard Time,
        /// Ulaanbaatar Standard Time, Tokyo Standard Time, Korea Standard
        /// Time, Yakutsk Standard Time, Cen. Australia Standard Time, AUS
        /// Central Standard Time, E. Australia Standard Time, AUS Eastern
        /// Standard Time, West Pacific Standard Time, Tasmania Standard Time,
        /// Magadan Standard Time, Vladivostok Standard Time, Russia Time Zone
        /// 10, Central Pacific Standard Time, Russia Time Zone 11, New Zealand
        /// Standard Time, UTC+12, Fiji Standard Time, Kamchatka Standard Time,
        /// Tonga Standard Time, Samoa Standard Time, Line Islands Standard
        /// Time</param>
        public TimeWindow(System.DateTime start, System.DateTime end, string timeZone = default(string))
        {
            TimeZone = timeZone;
            Start = start;
            End = end;
        }

        /// <summary>
        /// Gets or sets the timezone of the start and end times for the
        /// profile. Some examples of valid timezones are: Dateline Standard
        /// Time, UTC-11, Hawaiian Standard Time, Alaskan Standard Time,
        /// Pacific Standard Time (Mexico), Pacific Standard Time, US Mountain
        /// Standard Time, Mountain Standard Time (Mexico), Mountain Standard
        /// Time, Central America Standard Time, Central Standard Time, Central
        /// Standard Time (Mexico), Canada Central Standard Time, SA Pacific
        /// Standard Time, Eastern Standard Time, US Eastern Standard Time,
        /// Venezuela Standard Time, Paraguay Standard Time, Atlantic Standard
        /// Time, Central Brazilian Standard Time, SA Western Standard Time,
        /// Pacific SA Standard Time, Newfoundland Standard Time, E. South
        /// America Standard Time, Argentina Standard Time, SA Eastern Standard
        /// Time, Greenland Standard Time, Montevideo Standard Time, Bahia
        /// Standard Time, UTC-02, Mid-Atlantic Standard Time, Azores Standard
        /// Time, Cape Verde Standard Time, Morocco Standard Time, UTC, GMT
        /// Standard Time, Greenwich Standard Time, W. Europe Standard Time,
        /// Central Europe Standard Time, Romance Standard Time, Central
        /// European Standard Time, W. Central Africa Standard Time, Namibia
        /// Standard Time, Jordan Standard Time, GTB Standard Time, Middle East
        /// Standard Time, Egypt Standard Time, Syria Standard Time, E. Europe
        /// Standard Time, South Africa Standard Time, FLE Standard Time,
        /// Turkey Standard Time, Israel Standard Time, Kaliningrad Standard
        /// Time, Libya Standard Time, Arabic Standard Time, Arab Standard
        /// Time, Belarus Standard Time, Russian Standard Time, E. Africa
        /// Standard Time, Iran Standard Time, Arabian Standard Time,
        /// Azerbaijan Standard Time, Russia Time Zone 3, Mauritius Standard
        /// Time, Georgian Standard Time, Caucasus Standard Time, Afghanistan
        /// Standard Time, West Asia Standard Time, Ekaterinburg Standard Time,
        /// Pakistan Standard Time, India Standard Time, Sri Lanka Standard
        /// Time, Nepal Standard Time, Central Asia Standard Time, Bangladesh
        /// Standard Time, N. Central Asia Standard Time, Myanmar Standard
        /// Time, SE Asia Standard Time, North Asia Standard Time, China
        /// Standard Time, North Asia East Standard Time, Singapore Standard
        /// Time, W. Australia Standard Time, Taipei Standard Time, Ulaanbaatar
        /// Standard Time, Tokyo Standard Time, Korea Standard Time, Yakutsk
        /// Standard Time, Cen. Australia Standard Time, AUS Central Standard
        /// Time, E. Australia Standard Time, AUS Eastern Standard Time, West
        /// Pacific Standard Time, Tasmania Standard Time, Magadan Standard
        /// Time, Vladivostok Standard Time, Russia Time Zone 10, Central
        /// Pacific Standard Time, Russia Time Zone 11, New Zealand Standard
        /// Time, UTC+12, Fiji Standard Time, Kamchatka Standard Time, Tonga
        /// Standard Time, Samoa Standard Time, Line Islands Standard Time
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "timeZone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the start time for the profile in ISO 8601 format.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "start")]
        public System.DateTime Start { get; set; }

        /// <summary>
        /// Gets or sets the end time for the profile in ISO 8601 format.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "end")]
        public System.DateTime End { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
