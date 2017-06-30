using System.Collections.Generic;

namespace Nsar.Nodes.Models.LoggerNet.Meteorology
{
    public class Metadata
    {
        public string   FileFormat                  { get; set; }
        public string   StationName                 { get; set; }
        public string   DataLoggerType              { get; set; }
        public int      SerialNumber                { get; set; }
        public string   OperatingSystemVersion      { get; set; }
        public string   DataloggerProgramName       { get; set; }
        public int      DataloggerProgramSignature  { get; set; }
        public string   TableName                   { get; set; }

        public List<Variable> Variables { get; set; }
    }
}
