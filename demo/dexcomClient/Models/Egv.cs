using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Dexcom.Models {
    public class Egv : IAdditionalDataHolder, IParsable {
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
        /// <summary>The systemTime property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SystemTime { get; set; }
#nullable restore
#else
        public string SystemTime { get; set; }
#endif
        /// <summary>The trend property</summary>
        public float? Trend { get; set; }
        /// <summary>The trendRate property</summary>
        public float? TrendRate { get; set; }
        /// <summary>The value property</summary>
        public float? Value { get; set; }
        /// <summary>
        /// Instantiates a new egv and sets the default values.
        /// </summary>
        public Egv() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Egv CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Egv();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"displayTime", n => { DisplayTime = n.GetStringValue(); } },
                {"systemTime", n => { SystemTime = n.GetStringValue(); } },
                {"trend", n => { Trend = n.GetFloatValue(); } },
                {"trendRate", n => { TrendRate = n.GetFloatValue(); } },
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
            writer.WriteStringValue("systemTime", SystemTime);
            writer.WriteFloatValue("trend", Trend);
            writer.WriteFloatValue("trendRate", TrendRate);
            writer.WriteFloatValue("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
