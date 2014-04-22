using System;
using System.Collections.Generic;

using System.Xml.Serialization;
namespace Element.Reveal.DataLibrary
{
    public class ProgressruleofcreditDTO : DTOBase
    {
        public int ProgressRuleOfCreditID { get; set; }
        public int ProgressID { get; set; }
        public int RuleOfCreditWeightID { get; set; }        
        public decimal AmountInstalled { get; set; }
        public decimal InstalledRate { get; set; }
        public DateTime InstalledDate { get; set; }
        public int IsCompleted { get; set; }
        public int MaterialCategoryID { get; set; }
        public int TaskCategoryID { get; set; }
        public int DepartStructureID { get; set; }
        public int FIWPID { get; set; }
        public int CWPID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int OwnerID { get; set; }
        public decimal ActualManHour { get; set; }
        public decimal ActualInstalled { get; set; }
        public decimal InstalledQtyRatio { get; set; }
        public int TimeAllocationID { get; set; }

        // Constructor
        public ProgressruleofcreditDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class ProgressruleofcreditCompletedDTO : DTOBase
    {
        public string DisciplineCode { get; set; }
        [XmlElement(IsNullable = true)]
        public string DiciplineName { get; set; }
        public int CWPID { get; set; }
        [XmlElement(IsNullable = true)]
        public string CWPName { get; set; }
        public int CWAID { get; set; }
        [XmlElement(IsNullable = true)]
        public string CWAName { get; set; }
        public int ProjectScheduleID { get; set; }
        [XmlElement(IsNullable = true)]
        public string ProjectScheduleName { get; set; }
        public int IsWBS { get; set; }
        [XmlElement(IsNullable = true)]
        public string P6WBSCode { get; set; }
        [XmlElement(IsNullable = true)]
        public string P6ActivityID { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int DepartStructureID { get; set; }
        public int FIWPID { get; set; }
        [XmlElement(IsNullable = true)]
        public string FIWPName { get; set; }
        [XmlElement(IsNullable = true)]
        public string PersonnelName { get; set; }
        public int FIWPSurveyCount { get; set; }

    }

}
