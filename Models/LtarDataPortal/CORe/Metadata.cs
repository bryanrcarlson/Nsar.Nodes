using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nsar.Nodes.Models.LtarDataPortal.CORe
{
    public class Metadata
    {
        public string LtarSiteAcronym { get; private set; }
        public string StationID { get; private set; }
        public char RecordType { get; private set; }
        public string DataFormatVersion { get; private set; }
        public string Year { get; private set; }
        public string Month { get; private set; }
        public string Day { get; private set; }

        public Metadata(
            string ltarSiteAcronym,
            string stationID,
            char recordType,
            string dataFormatVersion,
            string year,
            string month,
            string day)
        {
            this.LtarSiteAcronym = ltarSiteAcronym;
            this.StationID = stationID;
            this.RecordType = recordType;
            this.DataFormatVersion = dataFormatVersion;
            this.Year = year;
            this.Month = month;
            this.Day = day;
        }
    }
}
