using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nsar.Nodes.Models.DocumentDb.Measurement
{
    public class Location
    {
        [JsonProperty("type")]
        public string Type { get; private set; }

        [JsonProperty("coordinates")]
        public List<double> Coordinates { get; private set; }
    }
}
