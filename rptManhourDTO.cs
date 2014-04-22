using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class rptManhourDTO : DTOBase
    {
        public DateTime Cycle { get; set; }
        public decimal EarnedMH { get; set; }
        public decimal PlannedMH { get; set; }
        public decimal ActualMH { get; set; }
        public decimal CompleteMH { get; set; }
        public decimal AccumulateEarnedMH { get; set; }
        public decimal AccumulatePlannedMH { get; set; }
        public decimal AccumulateActualMH { get; set; }

        public rptManhourDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class rptEarnedQtyMhrsDTO : DTOBase
    {
        public string Costcode { get; set; }
        public string Description { get; set; }
        public string UOM { get; set; }
        public decimal Qty { get; set; }
        public decimal ManhoursEstimate { get; set; }

        public rptEarnedQtyMhrsDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class rptCostCodeSummaryDTO : DTOBase
    {
        public int CwpId { get; set; }
        public string Costcode { get; set; }
        public string Description { get; set; }
        public string UOM { get; set; }
        public decimal BudgetQty { get; set; }
        public decimal BudgetManhoursEstimate { get; set; }
        public decimal Qty { get; set; }
        public decimal ManhoursEstimate { get; set; }

        public rptCostCodeSummaryDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class rptCostCodeMTODetailDTO : DTOBase
    {
        public string FIWPName { get; set; }
        public string Costcode { get; set; }
        public string Description { get; set; }
        public string MaterialCategory { get; set; }
        public string TaskCategory { get; set; }
        public string TagNumber { get; set; }
        public string UOM { get; set; }
        public string EngTagNumber { get; set; }
        public decimal Qty { get; set; }
        public decimal ManhoursEstimate { get; set; }
        public string TaskType { get; set; }
        public string StringVar1 { get; set; }
        public string StringVar7 { get; set; }
        public string StringVar11 { get; set; }
        public string ComponentDesc { get; set; }
        [XmlElement(IsNullable = true)]
        public string DrawingNo { get; set; }
        public decimal CompletedQty { get; set; }

        public rptCostCodeMTODetailDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

}
