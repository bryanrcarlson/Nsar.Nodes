using System;
using System.Collections.Generic;
using System.Text;

namespace Nsar.Nodes.Models.LoggerNet
{
    public class MeteorologyRecord
    {
        public MeteorologyMetadata Metadata { get; set; }
        public List<MeteorologyObservation> Observations { get; set; }
    }
}
