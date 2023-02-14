using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Dexcom.Models {
    public class Device : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The alertScheduleList property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AlertScheduleSetting>? AlertScheduleList { get; set; }
#nullable restore
#else
        public List<AlertScheduleSetting> AlertScheduleList { get; set; }
#endif
        /// <summary>The displayDevice property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayDevice { get; set; }
#nullable restore
#else
        public string DisplayDevice { get; set; }
#endif
        /// <summary>The lastUploadDate property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastUploadDate { get; set; }
#nullable restore
#else
        public string LastUploadDate { get; set; }
#endif
        /// <summary>The transmitterGeneration property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TransmitterGeneration { get; set; }
#nullable restore
#else
        public string TransmitterGeneration { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Device and sets the default values.
        /// </summary>
        public Device() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Device CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Device();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"alertScheduleList", n => { AlertScheduleList = n.GetCollectionOfObjectValues<AlertScheduleSetting>(AlertScheduleSetting.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayDevice", n => { DisplayDevice = n.GetStringValue(); } },
                {"lastUploadDate", n => { LastUploadDate = n.GetStringValue(); } },
                {"transmitterGeneration", n => { TransmitterGeneration = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AlertScheduleSetting>("alertScheduleList", AlertScheduleList);
            writer.WriteStringValue("displayDevice", DisplayDevice);
            writer.WriteStringValue("lastUploadDate", LastUploadDate);
            writer.WriteStringValue("transmitterGeneration", TransmitterGeneration);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
