
#region ProgresslogDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ProgresslogDTO.cs
// Author: 
// Date: August-12-12
// Time: 8:57:09 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class ProgresslogDTO : DTOBase
    {
        public int ProgressLogID { get; set; }
        public int ProgressID { get; set; }
        [XmlElement(IsNullable = true)]
        public string TagNumber { get; set; }
        public decimal AmountInstalled { get; set; }
        public decimal Qty { get; set; }
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
        public decimal PercentComplete { get; set; }
        public decimal InstalledRate { get; set; }
        

        // Constructor
        public ProgresslogDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
