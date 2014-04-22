
#region DepartstructureDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: DepartstructureDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:42 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class DepartstructureDTO : DTOBase
    {
        public int DepartStructureID { get; set; }
        public int DepartmentID { get; set; }
        public string PersonnelId { get; set; }
        public int ParentDepartStructureID { get; set; }
        public int RootDepartStructureID { get; set; }
        public int ClassLevel { get; set; }
        public int IsActive { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int ParentPersonnelID { get; set; }
        [XmlElement(IsNullable = true)]
        public string DepartmentName {get; set;}
        [XmlElement(IsNullable = true)]
        public string FullName { get; set; }
        [XmlElement(IsNullable = true)]
        public string Module { get; set; }
        [XmlElement(IsNullable = true)]
        public string EMail { get; set; }
        
        // Constructor
        public DepartstructureDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
