using System;
using System.Collections.Generic;
using System.Text;

namespace Nsar.Nodes.Models.LoggerNet.Meteorology
{
    public class Observation
    {
        //public DateTime TIMESTAMP { get; set; }
        //public int RECORD { get; set; }
        //public double amb_tmpr_Avg { get; set; }
        //public double rslt_wnd_spd { get; set; }
        //public double wnd_dir_compass { get; set; }
        //public double RH_Avg { get; set; }
        //public double Precipitation_Tot { get; set; }
        //public double amb_press_Avg { get; set; }
        //public double PAR_density_Avg { get; set; }
        //public double batt_volt_Avg { get; set; }
        //public double panel_tmpr_Avg { get; set; }
        //public double std_wnd_dir { get; set; }
        //public double VPD_air { get; set; }
        //public double Rn_meas_Avg { get; set; }

        public DateTime Timestamp { get; set; }
        public int Record { get; set; }
        public double AmbTemprAvg { get; set; }
        public double RsltWndSpd { get; set; }
        public double WndDirCompass { get; set; }
        public double RHAvg { get; set; }
        public double PrcipitationTot { get; set; }
        public double AmbPressAvg { get; set; }
        public double ParDensityAvg { get; set; }
        public double BattVoltAvg { get; set; }
        public double PanelTmprAvg { get; set; }
        public double StdWndDir { get; set; }
        public double VpdAir { get; set; }
        public double RNMeasAvg { get; set; }
    }
}