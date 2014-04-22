
#region FiwpmanonsiteDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: FiwpmanonsiteDTO.cs
// Author: 
// Date: November-29-11
// Time: 9:48:46 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class FiwpmanonsiteDTO : DTOBase
    {
        public int FiwpManOnSiteID { get; set; }
        public int FIWPID { get; set; }
        public DateTime WorkDate { get; set; }
        public int ForemanDepartStructureID { get; set; }
        public int DepartStructureID { get; set; }
        public int StatusLUID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public string PersonnelId { get; set; }
        [XmlElement(IsNullable = true)]
        public string FullName { get; set; }
        [XmlElement(IsNullable = true)]
        public string SkillLevel { get; set; }
        [XmlElement(IsNullable = true)]
        public string StatusName { get; set; }
        // Constructor
        public FiwpmanonsiteDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
