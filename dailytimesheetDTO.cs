
#region DailytimesheetDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: DailytimesheetDTO.cs
// Author: 
// Date: September-03-13
// Time: 8:38:09 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class DailytimesheetDTO : DTOBase
    {
        public int DailyTimesheetID { get; set; }
        public int DepartStructureID { get; set; }
        public string PersonnelId { get; set; }
        public DateTime WorkDate { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int OwnerID { get; set; }
        public int StatusLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string TimesheetNo { get; set; }
        public int SPCollectionID { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        public DateTime UpdateDate { get; set; }
        

        // Constructor
        public DailytimesheetDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
