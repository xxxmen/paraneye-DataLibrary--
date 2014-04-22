
#region TracktimesheetDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: TracktimesheetDTO.cs
// Author: 
// Date: July-24-12
// Time: 6:20:17 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class TracktimesheetDTO : DTOBase
    {
        public int TrackTimeSheetID { get; set; }
        public DateTime WorkDate { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int OwnerID { get; set; }
        public int StatusLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string TrackTimeSheetNo { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        public DateTime UpdateDate { get; set; }
        

        // Constructor
        public TracktimesheetDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
