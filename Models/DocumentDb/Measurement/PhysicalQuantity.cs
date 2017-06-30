using System;
using System.Collections.Generic;
using System.Text;

namespace Nsar.Nodes.Models.DocumentDb.Measurement
{
    public class PhysicalQuantity
    {
        public int Value { get; set; }
        public string Unit { get; set; }
        public int QualityCode { get; set; }
        public int QcAppliedCode { get; set; }
        public int QcResultCode { get; set; }
        public string SubmissionDateTime { get; set; }
        public string SourceId { get; set; }
    }
}
