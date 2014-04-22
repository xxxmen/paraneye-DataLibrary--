
#region ProgresshistoryDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ProgresshistoryDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:56 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;
namespace Element.Reveal.DataLibrary
{
    public class ProgresshistoryDTO : DTOBase
    {
        public int ProgressHistoryID { get; set; }
        public int ProgressID { get; set; }
        public string TagNumber { get; set; }
        public decimal AmountInstalled { get; set; }
        public int UOMID { get; set; }
        public decimal ManhoursEstimate { get; set; }
        public int ComponentID { get; set; }
        public int MaterialCategoryID { get; set; }
        public int TaskCategoryID { get; set; }
        public int SDID { get; set; }
        public DateTime InstalledDate { get; set; }
        public int CWPID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int OwnerID { get; set; }
        public int CostCodeID { get; set; }
        public int OwnerCostCodeID { get; set; }
        public int ProjectScheduleID { get; set; }
        public int FIWPID { get; set; }
        public int IsCompleted { get; set; }
        public DateTime UpdatedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        

        // Constructor
        public ProgresshistoryDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
