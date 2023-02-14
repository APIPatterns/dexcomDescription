using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Dexcom.Models {
    public class Statistics : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Risk for the patient to have future hypoglycemic events (nullable)</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? HypoglycemiaRisk { get; set; }
#nullable restore
#else
        public string HypoglycemiaRisk { get; set; }
#endif
        /// <summary>Maximum of all EGV data for given date range</summary>
        public float? Max { get; set; }
        /// <summary>Mean of all EGV data for given date range</summary>
        public float? Mean { get; set; }
        /// <summary>Mean number of calibrations per day for given date range</summary>
        public float? MeanDailyCalibrations { get; set; }
        /// <summary>Median of all EGV data for given date range</summary>
        public float? Median { get; set; }
        /// <summary>Minimum of all EGV data for given date range</summary>
        public float? Min { get; set; }
        /// <summary>Number of EGV observations above high bound (exclusive) specified in egvRanges array</summary>
        public int? NAboveRange { get; set; }
        /// <summary>Number of EGV observations below low bound (exclusive) and above urgentLow bound (inclusive) specified in egvRanges array)</summary>
        public int? NBelowRange { get; set; }
        /// <summary>Number of calendar days contributing data to the statistics calculations; only days containing EGV data are included in this count</summary>
        public int? NDays { get; set; }
        /// <summary>Number of EGV observations below urgentLow bound (exclusive) specified in egvRanges array</summary>
        public int? NUrgentLow { get; set; }
        /// <summary>Total number of EGV observations for given date range</summary>
        public int? NValues { get; set; }
        /// <summary>Number of EGV observations between high bound (inclusive) and above low bound (inclusive) specified in egvRanges array</summary>
        public int? NWithinRange { get; set; }
        /// <summary>Percentage of EGV observations above high bound (exclusive) specified in egvRanges array</summary>
        public float? PercentAboveRange { get; set; }
        /// <summary>Percentage of EGV observations below low bound (exclusive) and above urgentLow bound (inclusive) specified in egvRanges array</summary>
        public float? PercentBelowRange { get; set; }
        /// <summary>Percentage of EGV observations below urgentLow bound (exclusive) specified in egvRanges array</summary>
        public float? PercentUrgentLow { get; set; }
        /// <summary>Percentage of EGV observations between high bound (inclusive) and above low bound (inclusive) specified in egvRanges array</summary>
        public float? PercentWithinRange { get; set; }
        /// <summary>First quartile of all EGV data for given date range</summary>
        public float? Q1 { get; set; }
        /// <summary>Second quartile of all EGV data for given date range</summary>
        public float? Q2 { get; set; }
        /// <summary>Third quartile of all EGV data for given date range</summary>
        public float? Q3 { get; set; }
        /// <summary>Standard deviation of all EGV data for given date range</summary>
        public float? StdDev { get; set; }
        /// <summary>Sum of all EGV data for given date range</summary>
        public float? Sum { get; set; }
        /// <summary>Percent CGM sensor was utilized for given date range</summary>
        public float? UtilizationPercent { get; set; }
        /// <summary>Statistical variance of glucose level for given date range</summary>
        public float? Variance { get; set; }
        /// <summary>
        /// Instantiates a new Statistics and sets the default values.
        /// </summary>
        public Statistics() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Statistics CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Statistics();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"hypoglycemiaRisk", n => { HypoglycemiaRisk = n.GetStringValue(); } },
                {"max", n => { Max = n.GetFloatValue(); } },
                {"mean", n => { Mean = n.GetFloatValue(); } },
                {"meanDailyCalibrations", n => { MeanDailyCalibrations = n.GetFloatValue(); } },
                {"median", n => { Median = n.GetFloatValue(); } },
                {"min", n => { Min = n.GetFloatValue(); } },
                {"nAboveRange", n => { NAboveRange = n.GetIntValue(); } },
                {"nBelowRange", n => { NBelowRange = n.GetIntValue(); } },
                {"nDays", n => { NDays = n.GetIntValue(); } },
                {"nUrgentLow", n => { NUrgentLow = n.GetIntValue(); } },
                {"nValues", n => { NValues = n.GetIntValue(); } },
                {"nWithinRange", n => { NWithinRange = n.GetIntValue(); } },
                {"percentAboveRange", n => { PercentAboveRange = n.GetFloatValue(); } },
                {"percentBelowRange", n => { PercentBelowRange = n.GetFloatValue(); } },
                {"percentUrgentLow", n => { PercentUrgentLow = n.GetFloatValue(); } },
                {"percentWithinRange", n => { PercentWithinRange = n.GetFloatValue(); } },
                {"q1", n => { Q1 = n.GetFloatValue(); } },
                {"q2", n => { Q2 = n.GetFloatValue(); } },
                {"q3", n => { Q3 = n.GetFloatValue(); } },
                {"stdDev", n => { StdDev = n.GetFloatValue(); } },
                {"sum", n => { Sum = n.GetFloatValue(); } },
                {"utilizationPercent", n => { UtilizationPercent = n.GetFloatValue(); } },
                {"variance", n => { Variance = n.GetFloatValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("hypoglycemiaRisk", HypoglycemiaRisk);
            writer.WriteFloatValue("max", Max);
            writer.WriteFloatValue("mean", Mean);
            writer.WriteFloatValue("meanDailyCalibrations", MeanDailyCalibrations);
            writer.WriteFloatValue("median", Median);
            writer.WriteFloatValue("min", Min);
            writer.WriteIntValue("nAboveRange", NAboveRange);
            writer.WriteIntValue("nBelowRange", NBelowRange);
            writer.WriteIntValue("nDays", NDays);
            writer.WriteIntValue("nUrgentLow", NUrgentLow);
            writer.WriteIntValue("nValues", NValues);
            writer.WriteIntValue("nWithinRange", NWithinRange);
            writer.WriteFloatValue("percentAboveRange", PercentAboveRange);
            writer.WriteFloatValue("percentBelowRange", PercentBelowRange);
            writer.WriteFloatValue("percentUrgentLow", PercentUrgentLow);
            writer.WriteFloatValue("percentWithinRange", PercentWithinRange);
            writer.WriteFloatValue("q1", Q1);
            writer.WriteFloatValue("q2", Q2);
            writer.WriteFloatValue("q3", Q3);
            writer.WriteFloatValue("stdDev", StdDev);
            writer.WriteFloatValue("sum", Sum);
            writer.WriteFloatValue("utilizationPercent", UtilizationPercent);
            writer.WriteFloatValue("variance", Variance);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
