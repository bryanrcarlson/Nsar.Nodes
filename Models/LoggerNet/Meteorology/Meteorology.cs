using System;
using System.Collections.Generic;
using System.Text;

namespace Nsar.Nodes.Models.LoggerNet.Meteorology
{
    public class Meteorology
    {
        public Metadata Metadata { get; set; }
        public List<Observation> Observations { get; set; }
    }
}
