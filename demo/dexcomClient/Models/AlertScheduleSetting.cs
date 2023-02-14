using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Dexcom.Models {
    public class AlertScheduleSetting : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the alert schedule</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AlertScheduleName { get; set; }
#nullable restore
#else
        public string AlertScheduleName { get; set; }
#endif
        /// <summary>An array containing the days of the week this alert schedule value applies to; this array must contain one (or more) of the following strings in English: &apos;sunday&apos;, &apos;monday&apos;, &apos;tuesday&apos;, &apos;wednesday&apos;, &apos;thursday&apos;, &apos;friday&apos; and/or &apos;saturday&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? DaysOfWeek { get; set; }
#nullable restore
#else
        public List<string> DaysOfWeek { get; set; }
#endif
        /// <summary>The time each day when the alert schedule begins corresponds to the device&apos;s display time</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EndTime { get; set; }
#nullable restore
#else
        public string EndTime { get; set; }
#endif
        /// <summary>The default schedule is the alert schedule used in the absence of other applicable alert schedules</summary>
        public bool? IsDefaultSchedule { get; set; }
        /// <summary>Describes whether the user has the alert schedule enabled on their display device</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>The time each day when the alert schedule begins corresponds to the device&apos;s display time</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StartTime { get; set; }
#nullable restore
#else
        public string StartTime { get; set; }
#endif
        /// <summary>
        /// Instantiates a new alertScheduleSetting and sets the default values.
        /// </summary>
        public AlertScheduleSetting() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AlertScheduleSetting CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AlertScheduleSetting();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"alertScheduleName", n => { AlertScheduleName = n.GetStringValue(); } },
                {"daysOfWeek", n => { DaysOfWeek = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"endTime", n => { EndTime = n.GetStringValue(); } },
                {"isDefaultSchedule", n => { IsDefaultSchedule = n.GetBoolValue(); } },
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"startTime", n => { StartTime = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("alertScheduleName", AlertScheduleName);
            writer.WriteCollectionOfPrimitiveValues<string>("daysOfWeek", DaysOfWeek);
            writer.WriteStringValue("endTime", EndTime);
            writer.WriteBoolValue("isDefaultSchedule", IsDefaultSchedule);
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteStringValue("startTime", StartTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
