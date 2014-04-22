using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Element.Reveal.DataLibrary
{
    public class ProjectcostcodeDTO : DTOBase
    {
        public int CostCodeID { get; set; }
        public string CostCode { get; set; }
        public string Description { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int ManhoursEstimate { get; set; }
        public int MinManhours { get; set; }
        public int MaxManhours { get; set; }
        public int CostCodeLockedID { get; set; }
        public int IsLocked { get; set; }
        public int CWPID { get; set; }
        public string CWPName { get; set; }
        public string UOM { get; set; }
        public decimal EstQty { get; set; }
        public decimal EstManhours { get; set; }
        public decimal BaseQty { get; set; }
        public decimal Qty { get; set; }

        public string ClientCostCode { get; set; }
        
        // Constructor
        public ProjectcostcodeDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}

