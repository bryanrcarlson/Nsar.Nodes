using System;
using System.Collections.Generic;
using Nsar.Nodes.Models.DocumentDb;

namespace Nsar.Nodes.Models.DocumentDb.Measurement
{
    public class Measurement
    {
        public string type { get; set; }
        public string name { get; set; }
        public DateTime measurementDateTime { get; set; }
        public string metadataId { get; set; }
        public List<PhysicalQuantity> physicalQuantities { get; set; }
        public string schemaVersion { get; set; }
        public Location location { get; set; }
        public string fieldId { get; set; }
        public string id { get; set; }
        public string _rid { get; set; }
        public string _self { get; set; }
        public string _etag { get; set; }
        public string _attachments { get; set; }
        public int? _ts { get; set; }
    }
}
