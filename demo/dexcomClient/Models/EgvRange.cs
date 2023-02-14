using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Dexcom.Models {
    public class EgvRange : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The value of the EGV threshold; must follow the rule: &apos;urgentLow&apos; &lt; &apos;low&apos; &lt; &apos;high&apos;</summary>
        public float? Bound { get; set; }
        /// <summary>Name of the EGV threshold used for calculations; one of the following must be included: &apos;urgentLow&apos;, &apos;low&apos;, &apos;high&apos;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>
        /// Instantiates a new egvRange and sets the default values.
        /// </summary>
        public EgvRange() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static EgvRange CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EgvRange();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"bound", n => { Bound = n.GetFloatValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteFloatValue("bound", Bound);
            writer.WriteStringValue("name", Name);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
