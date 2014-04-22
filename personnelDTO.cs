
#region PersonnelDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: PersonnelDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:53 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;
namespace Element.Reveal.DataLibrary
{
    public class PersonnelDTO : DTOBase
    {
        public string PersonnelId { get; set; }
        [XmlElement(IsNullable = true)]
        public string EmployeeCode { get; set; }
        [XmlElement(IsNullable = true)]        
        public string FName { get; set; }
        [XmlElement(IsNullable = true)]
        public string LName { get; set; }
        [XmlElement(IsNullable = true)]
        public string EMail { get; set; }
        [XmlElement(IsNullable = true)]
        public string PhoneNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string CellNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string ClientName { get; set; }
        [XmlElement(IsNullable = true)]
        public string ContractorCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string IsActive { get; set; }
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
        public int SkillLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string Skill { get; set; }
        public int CompanyID { get; set; }
        [XmlElement(IsNullable = true)]
        public string CompanyName { get; set; }
        public int CurProjectID { get; set; }
        public string CurDisciplineCode { get; set; }
        [XmlElement(IsNullable = true)]
        public string CurDiciplineName { get; set; }
        public int CurDepartStructureID { get; set; }
        public int CurProjectScheduleID { get; set; }
        public int CurFIWPID { get; set; }
        public int DepartmentID { get; set; }
        [XmlElement(IsNullable = true)]
        public string DepartmentName { get; set; }
        public string FullName { get; set; }

        [XmlElement(IsNullable = true)]
        public string Camp { get; set; }
        [XmlElement(IsNullable = true)]
        public string CampRoomNo { get; set; }
        public int RoomType { get; set; }
                
        // Constructor
        public PersonnelDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
