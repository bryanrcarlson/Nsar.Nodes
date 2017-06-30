using System;
using System.Collections.Generic;
using System.Text;

namespace Nsar.Nodes.Models.DocumentDb.Measurement
{
    public class Location
    {
        public string Type { get; set; }
        public List<double> Coordinates { get; set; }
    }
}
