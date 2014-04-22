using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class FiwpDTO : DTOBase
    {
        public int FiwpID { get; set; }
        [XmlElement(IsNullable = true)]
        public string FiwpName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public decimal TotalManhours { get; set; }
        //public int DepartStructureID { get; set; }
        public int CrewMembersAssigned { get; set; }
        public int IsReadyToSignOff { get; set; }
        public decimal WorkHours { get; set; }
        public int P6ParentObjectID { get; set; }
        [XmlElement(IsNullable = true)]
        public string P6ActivityID { get; set; }
        public int P6ActivityObjectID { get; set; }
        public decimal P6RemainingDuration { get; set; }
        public int P6CalendarID { get; set; }
        public int ProjectScheduleID { get; set; }
        public int ProjectID { get; set; }
        [XmlElement(IsNullable = true)]
        public string DisciplineCode { get; set; }
        public int OwnerID { get; set; }        
        public int TestTypeLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string CWPName { get; set; }
        public int CWPID { get; set; }
        public int P6ProjectObjectID { get; set; }
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
        [XmlElement(IsNullable = true)]
        public string PersonnelName { get; set; }

        //Aug 29, 12 These are newly added for tracking.
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        //used when CrewMembersAssigned or WorkHours fields are changed.
        public DateTime EffectedDate { get; set; }

        //Indicate whether wfp started or not
        //0 is still, 1 is started.
        public int IsFiwpwfpStart { get; set; }

        public int SystemID { get; set; }

        // 2014-2-19 add /modify
        public int ExternalScheduleId { get; set; }
        [XmlElement(IsNullable = true)]
        public string DocEstablishedLUID { get; set; } //AssembleStepCode

        // 2014-2-20 add / modify
        [XmlElement(IsNullable = true)]
        public string LeaderId { get; set; } //Foreman
        [XmlElement(IsNullable = true)]
        public string PackageTypeLUID { get; set; } //PackageTypeCode

        // Constructor
        public FiwpDTO()
        {
            DTOStatus = (int)RowStatusNo.None;

            EffectedDate = DateTime.Today;
        }
    }
}
