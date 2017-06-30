using System;
using System.Collections.Generic;
using Nsar.Nodes.Models.DocumentDb;

namespace Nsar.Nodes.Models.DocumentDb.Measurement
{
    public class Measurement
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public DateTime MeasurementDateTime { get; set; }
        public string MetadataId { get; set; }
        public List<PhysicalQuantity> PhysicalQuantities { get; set; }
        public string SchemaVersion { get; set; }
        public Location Location { get; set; }
        public string FieldId { get; set; }
        public string Id { get; set; }
        public string _rid { get; set; }
        public string _self { get; set; }
        public string _etag { get; set; }
        public string _attachments { get; set; }
        public int _ts { get; set; }
    }
}
