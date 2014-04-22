
#region rptDailybrasssignDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: rptDailybrasssignDTO.cs
// Author: 
// Date: August-18-13
// Time: 4:40:09 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class rptDailybrasssignDTO : DTOBase
    {
        public int DailyBrassSignID { get; set; }
        public int DailyBrassID { get; set; }
        public int MyDepartStructureID { get; set; }
        public int MyPersonnelID { get; set; }
        public int ParentDepartStructureID { get; set; }
        public int ParentPersonnelID { get; set; }
        public DateTime SignTimestamp { get; set; }
        public int GateNo { get; set; }
        public int NFCUID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public DateTime SignOutTimestamp { get; set; }
        public DateTime ToolboxSignTimestamp { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string PersonnelName { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string ForemanPersonnelName { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string EmployeeCode { get; set; }

        // Constructor
        public rptDailybrasssignDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class rptDailyBrassInOutDTO
    {
        public int DailyBrassSignID { get; set; }
        public int DailyBrassID { get; set; }
        public int PersonnelID { get; set; }
        [XmlElement(IsNullable = true)]
        public string PersonnelName { get; set; }
        public DateTime SignInDate { get; set; }
        public DateTime SignOutDate { get; set; }
        public DateTime ToolboxSignedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string NfcCardId { get; set; }
        [XmlElement(IsNullable = true)]
        public string PinCode { get; set; }
        [XmlElement(IsNullable = true)]
        public string EmployeeId { get; set; }
    }

    public class rptCrewAttendanceHeader
    {
        public string ClientName { get; set; }
        public string ProjectName { get; set; }
        public string WorkDate { get; set; }
        public string ForemanName { get; set; }
        public string ToolboxTopics { get; set; }
        public int ProjectId { get; set; }
        public string ForemanId { get; set; }
    }
}
