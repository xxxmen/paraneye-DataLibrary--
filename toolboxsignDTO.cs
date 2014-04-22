
#region ToolboxsignDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ToolboxsignDTO.cs
// Author: 
// Date: August-18-13
// Time: 4:40:10 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class ToolboxsignDTO : DTOBase
    {
        public int ToolboxSignID { get; set; }
        public int DailyBrassID { get; set; }
        public int MyDepartStructureID { get; set; }
        public int MyPersonnelID { get; set; }
        public DateTime SignTimestamp { get; set; }
        public int NFCUID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        // Constructor
        public ToolboxsignDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
