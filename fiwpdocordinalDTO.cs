
#region FiwpdocordinalDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: FiwpdocordinalDTO.cs
// Author: 
// Date: January-10-12
// Time: 10:56:26 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class FiwpdocordinalDTO : DTOBase
    {
        public int FIWPDocOrdinalID { get; set; }
        public int FIWPID { get; set; }
        public int DocTypeLUID { get; set; }
        public int Ordinal { get; set; }
        public int ProjectScheduleID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public string DocTypeName { get; set; }

        // Constructor
        public FiwpdocordinalDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
