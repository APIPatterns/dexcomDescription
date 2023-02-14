using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Dexcom.Models {
    public class StatisticsRequest : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Array containing the minimum and maximum EGV defining the target range</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<EgvRange>? EgvRanges { get; set; }
#nullable restore
#else
        public List<EgvRange> EgvRanges { get; set; }
#endif
        /// <summary>End of the time window</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EndTime { get; set; }
#nullable restore
#else
        public string EndTime { get; set; }
#endif
        /// <summary>Reference name for the time window</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Beginning of the time window</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StartTime { get; set; }
#nullable restore
#else
        public string StartTime { get; set; }
#endif
        /// <summary>
        /// Instantiates a new StatisticsRequest and sets the default values.
        /// </summary>
        public StatisticsRequest() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static StatisticsRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StatisticsRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"egvRanges", n => { EgvRanges = n.GetCollectionOfObjectValues<EgvRange>(EgvRange.CreateFromDiscriminatorValue)?.ToList(); } },
                {"endTime", n => { EndTime = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"startTime", n => { StartTime = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<EgvRange>("egvRanges", EgvRanges);
            writer.WriteStringValue("endTime", EndTime);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("startTime", StartTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
