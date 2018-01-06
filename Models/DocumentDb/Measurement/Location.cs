﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nsar.Nodes.Models.DocumentDb.Measurement
{
    /// <summary></summary>
    public class Location
    {
        /// <summary>
        /// Type maps type
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; private set; }

        /// <summary>
        /// Coordinates maps coordinates
        /// </summary>
        /// <returns>
        /// List of two doubles; Latitude, Longitude
        /// </returns>
        [JsonProperty("coordinates")]
        public List<double> Coordinates { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="type"></param>
        /// <param name="latitude"></param>
        /// <param name="longitude"></param>
        public Location(
            string type,
            double latitude,
            double longitude)
        {
            Type = type;
            Coordinates = new List<double>()
            {
                latitude,
                longitude
            };
        }
    }
}
