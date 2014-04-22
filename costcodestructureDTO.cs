
#region CostcodestructureDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: CostcodestructureDTO.cs
// Author: 
// Date: April-17-12
// Time: 6:38:31 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class CostcodestructureDTO : DTOBase
    {
        public int CostCodeStructureID { get; set; }
        public int CostCodeID { get; set; }
        public int ParentCostCodeStructureID { get; set; }
        public int RootCostCodeStructureID { get; set; }
        public int ClassLevel { get; set; }
        public int IsActive { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
        public decimal EstQty { get; set; }
        public decimal EstManhours { get; set; }
        public decimal EstAmount { get; set; }
        public decimal BudgetAmount { get; set; }        
        public int UOMLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string ClientCostCode { get; set; }
        public int CWPID { get; set; }
        [XmlElement(IsNullable = true)]
        public string NetworkCode { get; set; }
        [XmlElement(IsNullable = true)]
        public string ActvityCode { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int FIWPID { get; set; }
        public decimal BaseQty { get; set; }
        public int ProjectScheduleID { get; set; }
        [XmlElement(IsNullable = true)]
        public string ProjectScheduleName { get; set; }
        [XmlElement(IsNullable = true)]
        public string P6ActivityID { get; set; }
        [XmlElement(IsNullable = true)]
        public string P6WBSCode { get; set; }
        public int CostCodeTypeLUID { get; set; }

        [XmlElement(IsNullable = true)]
        public string CostCode { get; set; }
        [XmlElement(IsNullable = true)]
        public string CostCodeType { get; set; }
        [XmlElement(IsNullable = true)]
        public string TableName { get; set; }
        public int ColumnID { get; set; }

        [XmlElement(IsNullable = true)]
        public string UOM { get; set; }

        // Constructor
        public CostcodestructureDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
            StartDate = new DateTime(1753, 1, 1);
            FinishDate = new DateTime(1753, 1, 1);
        }
    }
}
