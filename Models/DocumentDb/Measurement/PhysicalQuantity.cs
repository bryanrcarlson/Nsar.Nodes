using System;
using System.Collections.Generic;
using System.Text;

namespace Nsar.Nodes.Models.DocumentDb.Measurement
{
    public class PhysicalQuantity : Nsar.Common.Measure.Models.PhysicalQuantity
    {
        //public double Value { get { return base.Value; } }
        //public string Unit { get { return base.Unit; } }
        public int QualityCode { get; set; }
        public int QcAppliedCode { get; set; }
        public int QcResultCode { get; set; }
        public DateTime SubmissionDateTime { get; set; }
        public string SourceId { get; set; }

        public PhysicalQuantity(decimal value, string unit, int precision = int.MaxValue) 
            : base(value, unit, precision) { }
    }
}
