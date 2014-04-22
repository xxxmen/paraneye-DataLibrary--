
#region PohistoryDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: PohistoryDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:54 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class PohistoryDTO : DTOBase
    {
        public int POHistoryID { get; set; }
        public int POID { get; set; }
        public int POStatusLUID { get; set; }
        public DateTime ActiveDt { get; set; }
        public DateTime CreatedByDt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedByDt { get; set; }
        public string ModifiedBy { get; set; }
        

        // Constructor
        public PohistoryDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
