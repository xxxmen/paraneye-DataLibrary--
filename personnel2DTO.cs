
#region Personnel2DTO.cs
//---------------------------------------------------------------------------------------
//
// Name: Personnel2DTO.cs
// Author: 
// Date: Tuesday, January 21, 2014
// Time: 5:52:41 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

namespace Element.Reveal.DataLibrary
{
    public class Personnel2DTO 
    {
        public string PersonnelId { get; set; }
        public string EmployeeCode { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string EMail { get; set; }
        public string PhoneNumber { get; set; }
        public string CellNumber { get; set; }
        public string ClientName { get; set; }
        public string ContractorCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte IsActive { get; set; }
        public int SkillLUID { get; set; }
        public string Description { get; set; }
        public int CompanyID { get; set; }
        public int CurProjectID { get; set; }
        public string CurDisciplineCode { get; set; }
        public int CurDepartStructureID { get; set; }
        public int CurProjectScheduleID { get; set; }
        public int CurFIWPID { get; set; }
        public int DepartmentID { get; set; }
        

	public int DTOStatus { get; set; }

        // Constructor
        public Personnel2DTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
