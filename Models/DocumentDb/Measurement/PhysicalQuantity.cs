using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nsar.Nodes.Models.DocumentDb.Measurement
{
    public class PhysicalQuantity// : Nsar.Common.Measure.Models.PhysicalQuantity
    {
        [JsonProperty("value")]
        public decimal Value { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("qualityCode")]
        public int QualityCode { get; set; }

        [JsonProperty("qcAppliedCode")]
        public int QCAppliedCode { get; set; }

        [JsonProperty("qcResultCode")]
        public int QCResultCode { get; set; }

        [JsonProperty("submissionDateTime")]
        public DateTime SubmissionDateTime { get; set; }

        [JsonProperty("sourceId")]
        public string SourceId { get; set; }

        //public PhysicalQuantity(decimal value, string unit, int precision = int.MaxValue) 
        //    : base(value, unit, precision) { }

        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}
    }
}
