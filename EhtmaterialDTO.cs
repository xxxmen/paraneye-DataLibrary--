
#region EhtmaterialDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: EhtmaterialDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:44 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class EhtmaterialDTO : DTOBase
    {
        public int EhtMaterialID { get; set; }
        public int MaterialID { get; set; }
        public string CatalogueNumber { get; set; }
        public string LineNumber { get; set; }
        public string LineSize { get; set; }
        public string PPLocationNorth { get; set; }
        public string PPLocationEast { get; set; }
        public string PPLocationElev { get; set; }
        public string CablePowerFrom { get; set; }
        public string CablePowerTo { get; set; }
        public string EHTPowerJBNorth { get; set; }
        public string EHTPowerJBEast { get; set; }
        public string EHTPowerJBElev { get; set; }
        public string EHTPowerJBID { get; set; }
        public string RTD1_ID { get; set; }
        public string RTD1LocationNorth { get; set; }
        public string RTD1LocationEast { get; set; }
        public string RTD1LocationElev { get; set; }
        public string RTD1TermBlockNumber1 { get; set; }
        public string RTD1TermBlockNumber2 { get; set; }
        public string RTD1TermBlockNumber3 { get; set; }
        public string RTD1CableFrom { get; set; }
        public string RTD1CableTo { get; set; }
        public int RTD1Shield { get; set; }
        public string RTD2_ID { get; set; }
        public string RTD2LocationNorth { get; set; }
        public string RTD2LocationEast { get; set; }
        public string RTD2LocationElev { get; set; }
        public string RTD2TermBlockNumber1 { get; set; }
        public string RTD2TermBlockNumber2 { get; set; }
        public string RTD2TermBlockNumber3 { get; set; }
        public string RTD2CableFrom { get; set; }
        public string RTD2CableTo { get; set; }
        public int RTD2Shield { get; set; }
        public string PanelID { get; set; }
        public string CCTNumber { get; set; }
        public string ControlPanelID { get; set; }
        public string HTCNumber { get; set; }
        public string ContactorID { get; set; }
        public double SetPointTemp { get; set; }
        public string TSControlMode { get; set; }
        public double GroundFaultAlarm { get; set; }
        public double GroundFaultTripSetPoint { get; set; }
        public double TS1LowTempAlarm { get; set; }
        public double TS2LowTempAlarm { get; set; }
        public double HighLoadCurrentAlarm { get; set; }
        public double LowLoadCurrentAlarm { get; set; }
        

        // Constructor
        public EhtmaterialDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
