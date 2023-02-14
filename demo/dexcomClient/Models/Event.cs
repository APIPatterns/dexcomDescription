using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Dexcom.Models {
    public class Event : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The displayTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayTime { get; set; }
#nullable restore
#else
        public string DisplayTime { get; set; }
#endif
        /// <summary>The eventId property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventId { get; set; }
#nullable restore
#else
        public string EventId { get; set; }
#endif
        /// <summary>The eventStatus property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventStatus { get; set; }
#nullable restore
#else
        public string EventStatus { get; set; }
#endif
        /// <summary>The eventSubType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventSubType { get; set; }
#nullable restore
#else
        public string EventSubType { get; set; }
#endif
        /// <summary>The eventType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EventType { get; set; }
#nullable restore
#else
        public string EventType { get; set; }
#endif
        /// <summary>The systemTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SystemTime { get; set; }
#nullable restore
#else
        public string SystemTime { get; set; }
#endif
        /// <summary>The unit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Unit { get; set; }
#nullable restore
#else
        public string Unit { get; set; }
#endif
        /// <summary>The value property</summary>
        public float? Value { get; set; }
        /// <summary>
        /// Instantiates a new Event and sets the default values.
        /// </summary>
        public Event() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Event CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Event();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayTime", n => { DisplayTime = n.GetStringValue(); } },
                {"eventId", n => { EventId = n.GetStringValue(); } },
                {"eventStatus", n => { EventStatus = n.GetStringValue(); } },
                {"eventSubType", n => { EventSubType = n.GetStringValue(); } },
                {"eventType", n => { EventType = n.GetStringValue(); } },
                {"systemTime", n => { SystemTime = n.GetStringValue(); } },
                {"unit", n => { Unit = n.GetStringValue(); } },
                {"value", n => { Value = n.GetFloatValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayTime", DisplayTime);
            writer.WriteStringValue("eventId", EventId);
            writer.WriteStringValue("eventStatus", EventStatus);
            writer.WriteStringValue("eventSubType", EventSubType);
            writer.WriteStringValue("eventType", EventType);
            writer.WriteStringValue("systemTime", SystemTime);
            writer.WriteStringValue("unit", Unit);
            writer.WriteFloatValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
