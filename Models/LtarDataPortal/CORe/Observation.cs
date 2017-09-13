using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsar.Nodes.Models.LtarDataPortal.CORe
{
    public class Observation
    {
        public string LTARSiteAcronym { get; private set; }
        public string StationID { get; private set; }
        public DateTimeOffset DateTime { get; private set; }
        public char RecordType { get; private set; }
        public decimal? AirTemperature { get; private set; }
        public decimal? WindSpeed { get; private set; }
        public decimal? WindDirection { get; private set; }
        public decimal? RelativeHumidity { get; private set; }
        public decimal? Precipitation { get; private set; }
        public decimal? AirPressure { get; private set; }
        public decimal? PAR { get; private set; }
        public decimal? ShortWaveIn { get; private set; }
        public decimal? LongWaveIn { get; private set; }
        public decimal? BatteryVoltage { get; private set; }
        public decimal? LoggerTemperature { get; private set; }

        public Observation(
            string ltarSiteAcronym,
            string stationID,
            DateTimeOffset dateTime,
            char recordType,
            decimal? airTemperature,
            decimal? windSpeed,
            decimal? windDirection,
            decimal? relativeHumidity,
            decimal? precipitation,
            decimal? airPressure,
            decimal? par,
            decimal? shortWaveIn,
            decimal? longWaveIn,
            decimal? batteryVoltage,
            decimal? loggerTemperature)
        {
            this.LTARSiteAcronym = ltarSiteAcronym;
            this.StationID = stationID;
            this.DateTime = dateTime;
            this.RecordType = recordType;
            this.AirTemperature = airTemperature;
            this.WindSpeed = windSpeed;
            this.WindDirection = windDirection;
            this.RelativeHumidity = relativeHumidity;
            this.Precipitation = precipitation;
            this.AirPressure = airPressure;
            this.PAR = par;
            this.ShortWaveIn = shortWaveIn;
            this.LongWaveIn = LongWaveIn;
            this.BatteryVoltage = batteryVoltage;
            this.LoggerTemperature = loggerTemperature;
        }
    }
}
