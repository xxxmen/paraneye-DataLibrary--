
#region CwaDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: CwaDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:41 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class CwaDTO : DTOBase
    {
        public int CWAID { get; set; }
        public string CWAName { get; set; }
        public int CWPID { get; set; }
        public string Description { get; set; }
        public int ProjectID { get; set; }
        

        // Constructor
        public CwaDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
