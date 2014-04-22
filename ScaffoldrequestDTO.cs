
#region ScaffoldrequestDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ScaffoldrequestDTO.cs
// Author: 
// Date: October-26-11
// Time: 5:28:31 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class ScaffoldrequestDTO : DTOBase
    {
        public int ScaffoldRequestID { get; set; }
        public int ScaffoldID { get; set; }
        public string TagNumber { get; set; }
        public int RequestTypeLUID { get; set; }
        public int ScaffoldStatusLUID { get; set; }
        public string RequestedBy { get; set; }
        public DateTime NeedByDate { get; set; }
        public DateTime NotNeedByDate { get; set; }
        public DateTime CompletedOnDate { get; set; }
        public decimal Elevation1 { get; set; }
        public decimal Elevation2 { get; set; }
        public decimal Elevation3 { get; set; }
        public int IsEWO { get; set; }
        public string EWONumber { get; set; }
        public int FIWPID { get; set; }
        public int CWPID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int AreaID { get; set; }
        public decimal GPSNorth { get; set; }
        public decimal GPSWest { get; set; }
        public string LocationAddInfo { get; set; }
        public string WorkDesc { get; set; }
        public string DeckHeight { get; set; }
        public string MinScaffArea { get; set; }
        public string Clearance { get; set; }
        public string Hoarding { get; set; }
        public string SnapShotInfo { get; set; }
        public string Other { get; set; }
        

        // Constructor
        public ScaffoldrequestDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class ScaffoldAndRequest
    {
        public ScaffoldDTO scaffold { get; set; }
        public ScaffoldrequestDTO scaffoldrequest { get; set; }
        public List<ScaffoldrequesthistoryDTO> scaffoldhistory { get; set; }
        public List<ScaffoldtradeDTO> scaffoldtrade { get; set; }
    }
}
