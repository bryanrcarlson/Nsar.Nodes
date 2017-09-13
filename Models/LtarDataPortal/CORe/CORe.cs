using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsar.Nodes.Models.LtarDataPortal.CORe
{
    public class CORe
    {
        public Metadata Metadata { get; private set; }
        public List<Observation> Observations { get; private set; }

        public CORe(
            Metadata metadata,
            List<Observation> observations)
        {
            this.Metadata = metadata;
            this.Observations = observations;
        }
    }
}
