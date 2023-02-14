using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Dexcom.Models {
    public class Egvs : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The egvs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Egv>? EgvsProp { get; set; }
#nullable restore
#else
        public List<Egv> EgvsProp { get; set; }
#endif
        /// <summary>The rateUnit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RateUnit { get; set; }
#nullable restore
#else
        public string RateUnit { get; set; }
#endif
        /// <summary>The unit property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Unit { get; set; }
#nullable restore
#else
        public string Unit { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Egvs and sets the default values.
        /// </summary>
        public Egvs() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Egvs CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Egvs();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"egvs", n => { EgvsProp = n.GetCollectionOfObjectValues<Egv>(Egv.CreateFromDiscriminatorValue)?.ToList(); } },
                {"rateUnit", n => { RateUnit = n.GetStringValue(); } },
                {"unit", n => { Unit = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Egv>("egvs", EgvsProp);
            writer.WriteStringValue("rateUnit", RateUnit);
            writer.WriteStringValue("unit", Unit);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
