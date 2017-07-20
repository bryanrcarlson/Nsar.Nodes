using System;
using System.Collections.Generic;
using System.Text;

namespace Nsar.Nodes.Models.DocumentDb.Measurement
{
    public class PhysicalQuantity : Nsar.Common.Measure.Models.PhysicalQuantity
    {
        //public double Value { get { return base.Value; } }
        //public string Unit { get { return base.Unit; } }
        public int qualityCode { get; set; }
        public int qcAppliedCode { get; set; }
        public int qcResultCode { get; set; }
        public DateTime submissionDateTime { get; set; }
        public string sourceId { get; set; }

        public PhysicalQuantity(decimal value, string unit, int precision = int.MaxValue) 
            : base(value, unit, precision) { }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}
