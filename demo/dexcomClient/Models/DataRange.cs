using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Dexcom.Models {
    public class DataRange : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The calibrations property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DataRangeItem? Calibrations { get; set; }
#nullable restore
#else
        public DataRangeItem Calibrations { get; set; }
#endif
        /// <summary>The egvs property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DataRangeItem? Egvs { get; set; }
#nullable restore
#else
        public DataRangeItem Egvs { get; set; }
#endif
        /// <summary>The events property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DataRangeItem? Events { get; set; }
#nullable restore
#else
        public DataRangeItem Events { get; set; }
#endif
        /// <summary>
        /// Instantiates a new DataRange and sets the default values.
        /// </summary>
        public DataRange() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DataRange CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DataRange();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"calibrations", n => { Calibrations = n.GetObjectValue<DataRangeItem>(DataRangeItem.CreateFromDiscriminatorValue); } },
                {"egvs", n => { Egvs = n.GetObjectValue<DataRangeItem>(DataRangeItem.CreateFromDiscriminatorValue); } },
                {"events", n => { Events = n.GetObjectValue<DataRangeItem>(DataRangeItem.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DataRangeItem>("calibrations", Calibrations);
            writer.WriteObjectValue<DataRangeItem>("egvs", Egvs);
            writer.WriteObjectValue<DataRangeItem>("events", Events);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
