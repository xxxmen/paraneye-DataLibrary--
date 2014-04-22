
#region TimesheetDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: TimesheetDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:08:03 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Element.Reveal.DataLibrary
{
    
    [DataContract]
    public class TimesheetDTO : DTOBase
    {
        [DataMember]
        public int TimeSheetID { get; set; }
        [DataMember]
        public int ProgressID { get; set; }
        [DataMember]
        public int RuleOFCreditWeightID { get; set; }
        [DataMember]
        public string PersonnelId { get; set; }
        [DataMember]
        public int DepartStructureID { get; set; }
        [DataMember]
        public int FiwpID { get; set; }
        [DataMember]
        public int MaterialCategoryID { get; set; }
        [DataMember]
        public DateTime WorkDate { get; set; }
        [DataMember]
        public decimal StraightTime { get; set; }
        [DataMember]
        public decimal TimeAndHalf { get; set; }
        [DataMember]
        public decimal DoubleTime { get; set; }
        [DataMember]
        public int ProjectID { get; set; }
        [DataMember]
        public string DisciplineCode { get; set; }
        [DataMember]
        public int OwnerID { get; set; }
        [DataMember]
        public int CostCodeID { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string Comments { get; set; }
        [DataMember]
        public decimal Amount { get; set; }
        [DataMember]
        public string CostCode { get; set; }
        [DataMember]
        public string EmployeeFullName { get; set; }
        [DataMember]
        public string TagNumber { get; set; }
        [DataMember]
        public string RuleOFCreditWeightName { get; set; }
        [DataMember]
        public int RuleOFCreditLUID { get; set; }
        [DataMember]
        public decimal AmountInstalled { get; set; }
        [DataMember]
        public int IsComplete { get; set; }
        [DataMember]
        public decimal InstalledRate { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string CreatedBy { get; set; }
        [DataMember]
        public DateTime CreatedDate { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string TrackTimeSheetNo { get; set; }
        [DataMember]
        public int TrackTimeSheetID { get; set; }
        [DataMember]
        public int TimeAllocationID { get; set; }
        [DataMember]
        public int DailyTimesheetID { get; set; }

        // Constructor
        public TimesheetDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }

        public decimal GetWorktime()
        {
            return this.StraightTime + this.TimeAndHalf + this.DoubleTime;
        }
    }

    
    public class TimesheetSummaryDTO : DTOBase
    {
        public int DepartStructureID { get; set; }
        public int TaskCategoryID { get; set; }
        public decimal WorkHour { get; set; }
        public decimal ManhoursEstimate { get; set; }
        public decimal StandardHour { get; set; }
        public string CrewName { get; set; }
        public string TaskCategory { get; set; }

        // Constructor
        public TimesheetSummaryDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }



    
    public class TimesheetTaskDTO : DTOBase
    {
        public decimal Task1 { get; set; }
        public decimal Task2 { get; set; }
        public decimal Task3 { get; set; }
        public decimal Task4 { get; set; }
        public decimal Task5 { get; set; }
        public decimal Task6 { get; set; }
        public decimal Task7 { get; set; }
        public decimal Task8 { get; set; }
        public decimal Task9 { get; set; }
        public decimal Total { get; set; }

        public int DepartStructureID { get; set; }
        public string CrewName { get; set; }      

        // Constructor
        public TimesheetTaskDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class TimesheetTaskAndValue
    {
        public decimal Workhour { get; set; }
        public List<TimesheetTaskDTO> TaskList { get; set; }
        public List<string> TaskNameList { get; set; }
    }

    //public class TimesheetprogressDTO : DTOBase
    //{
    //    public int TimeSheetProgressID { get; set; }
    //    public int TimeSheetID { get; set; }
    //    public int ProgressID { get; set; }
    //    public int TimeAllocationID { get; set; }

    //     // Constructor
    //    public TimesheetprogressDTO()
    //    {
    //        DTOStatus = (int)RowStatusNo.None;
    //    }
    //}

    public class TimeallocationDTO : DTOBase
    {
        public int TimeAllocationID { get; set; }
        public int CWPID { get; set; }
        public int FIWPID { get; set; }
        public int MaterialCategoryID { get; set; }
        public DateTime InstalledDate { get; set; }
        public int RuleOfCreditWeightID { get; set; }
        public string Description { get; set; }
        

        // Constructor
        public TimeallocationDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class TimesheetAndProgress
    {
        public int DataID { get; set; }
        public bool Updated { get; set; }
        public List<TimesheetDTO> TimesheetList { get; set; }
        public List<MTODTO> progresseslist { get; set; }
    }
    
}

