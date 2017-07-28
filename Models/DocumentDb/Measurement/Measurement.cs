using System;
using System.Collections.Generic;
using Nsar.Nodes.Models.DocumentDb;
using Newtonsoft.Json;

namespace Nsar.Nodes.Models.DocumentDb.Measurement
{
    /// <summary>
    /// Dto class for data as described by json-schema located in schema\v1\measurement.json or https://raw.githubusercontent.com/bryanrcarlson/Nsar.Nodes/master/Models/DocumentDb/schema/v1/measurement.json#
    /// </summary>
    public class Measurement
    {
        [JsonProperty("partitionKey")]
        public string PartitionKey { get; private set; }

        [JsonProperty("id")]
        public string ID { get; private set; }

        [JsonProperty("type")]
        public string Type { get; private set; }

        [JsonProperty("name")]
        public string Name { get; private set; }

        [JsonProperty("schemaVersion")]
        public string SchemaVersion { get; private set; }

        [JsonProperty("metadataId")]
        public string MetadataID { get; private set; }

        public string _rid { get; private set; }
        public string _self { get; private set; }
        public string _etag { get; private set; }
        public string _attachments { get; private set; }
        public int? _ts { get; private set; }

        [JsonProperty("fieldId")]
        public string FieldID { get; private set; }

        [JsonProperty("location")]
        public Location Location { get; private set; }

        [JsonProperty("measurementDateTime")]
        public DateTime MeasurementDateTime { get; private set; }

        [JsonProperty("physicalQuantities")]
        public List<PhysicalQuantity> PhysicalQuantities { get; set; }

        public Measurement(
            string partitionKey, string id, string type, string name,
            string schemaVersion, string metadataID, string _rid,
            string _self, string _etag, string _attachements,
            int? _ts, string fieldId, Location location,
            DateTime measurementDateTime,
            List<PhysicalQuantity> physicalQuantities)
        {
            PartitionKey = partitionKey;
            ID = id;
            Type = type;
            Name = name;
            SchemaVersion = schemaVersion;
            MetadataID = metadataID;
            this._rid = _rid;
            this._self = _self;
            this._etag = _etag;
            this._attachments = _attachments;
            this._ts = _ts;
            FieldID = fieldId;
            Location = location;
            MeasurementDateTime = measurementDateTime;
            PhysicalQuantities = physicalQuantities;
        }
    }
}
