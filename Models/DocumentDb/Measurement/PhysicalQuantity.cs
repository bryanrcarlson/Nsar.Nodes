using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nsar.Nodes.Models.DocumentDb.Measurement
{
    public class PhysicalQuantity// : Nsar.Common.Measure.Models.PhysicalQuantity
    {
        [JsonProperty("value")]
        public decimal Value { get; private set; }

        [JsonProperty("unit")]
        public string Unit { get; private set; }

        [JsonProperty("qualityCode")]
        public int QualityCode { get; private set; }

        [JsonProperty("qcAppliedCode")]
        public int QCAppliedCode { get; private set; }

        [JsonProperty("qcResultCode")]
        public int QCResultCode { get; private set; }

        [JsonProperty("submissionDateTime")]
        public DateTime SubmissionDateTime { get; private set; }

        [JsonProperty("sourceId")]
        public string SourceID { get; private set; }

        //public PhysicalQuantity(decimal value, string unit, int precision = int.MaxValue) 
        //    : base(value, unit, precision) { }

        //public override bool Equals(object obj)
        //{
        //    return base.Equals(obj);
        //}

        public PhysicalQuantity(
            decimal value, string unit, int qualityCode,
            int qcAppliedCode, int qcResultCode,
            DateTime submissionDateTime, string sourceID)
        {
            Value = value;
            Unit = unit;
            QualityCode = qualityCode;
            QCAppliedCode = qcAppliedCode;
            QCResultCode = qcResultCode;
            SubmissionDateTime = submissionDateTime;
            SourceID = sourceID;
        }
    }
}
