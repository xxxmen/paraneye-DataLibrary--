
#region ScaffoldrequesthistoryDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ScaffoldrequesthistoryDTO.cs
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
    public class ScaffoldrequesthistoryDTO : DTOBase
    {
        public int ScaffoldRequestHistoryID { get; set; }
        public int ScaffoldStatusTypeLUID { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int ScaffoldRequestID { get; set; }
        public int ScaffoldID { get; set; }
        

        // Constructor
        public ScaffoldrequesthistoryDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
