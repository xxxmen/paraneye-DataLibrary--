
#region ProjscheduleDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ProjscheduleDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:57 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class ProjectscheduleDTO : DTOBase
    {
        public int ProjectScheduleID { get; set; }
        [XmlElement(IsNullable = true)]
        public string ProjectScheduleName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string P6ProjectName { get; set; }
        public int P6ProjectObjectID { get; set; }
        [XmlElement(IsNullable = true)]
        public string P6ActivityID { get; set; }
        public int P6ActivityObjectID { get; set; }
        public decimal P6RemainingDuration { get; set; }
        public int IsWBS { get; set; }
        public int Seq { get; set; }
        public int ProjectID { get; set; }
        [XmlElement(IsNullable = true)]
        public string DisciplineCode { get; set; }
        public int OwnerID { get; set; }
        public int MaterialCategoryID { get; set; }
        public int CWPID { get; set; }
        public int CrewMembersAssigned { get; set; }
        public decimal OriginalDuration { get; set; }
        public int IsReadyToSignOff { get; set; }
        public int P6CalendarID { get; set; }
        public int Completed { get; set; }
        public int P6ParentObjectID { get; set; }
        [XmlElement(IsNullable = true)]
        public string P6WBSCode { get; set; }
        [XmlElement(IsNullable = true)]
        public string PersonnelName { get; set; }

        //Aug 29, 12 These are newly added for tracking.
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int IsActive { get; set; }

        public int ScheduleTypeLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string ScheduleType { get; set; }
        [XmlElement(IsNullable = true)]
        public string CWPName { get; set; }
        [XmlElement(IsNullable = true)]
        public string DiciplineName { get; set; } 

        // 2014-2-19 add 
        public int ExternalScheduleId { get; set; }

        // 2014-2-20 add
        [XmlElement(IsNullable = true)]
        public string LeaderId { get; set; } //General Foreman

        //2014-03-12 add
        public DateTime ExternalStartDate { get; set; }
        public DateTime ExternalFinishDate { get; set; }
        public decimal TotalWorkingHours { get; set; }
        
        // Constructor
        public ProjectscheduleDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
