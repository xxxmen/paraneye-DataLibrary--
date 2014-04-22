using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Element.Reveal.DataLibrary
{
    public class rptProgressDTO : DTOBase
    {
        public int FIWPID { get; set; }
        public int MaterialCategoryID { get; set; }
        public decimal QTY { get; set; }
        public decimal ActualMH { get; set; }
        public decimal CompletedMH { get; set; }
        public decimal EarnedMH { get; set; }
        public decimal PlannedMH { get; set; }

        public string CostCode { get; set; }
        public string Description { get; set; }
        public string FIWPName { get; set; }
        public string CWPName { get; set; }
        public string TaskCategory { get; set; }
        
        public rptProgressDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class rptProjectControlsDTO : DTOBase
    {
        public int ProgressID { get; set; }
        public string MaterialCategory { get; set; }
        public string TaskCategory { get; set; }
        public string TagNumber { get; set; }
        public string UOM { get; set; }

        public string CWA { get; set; }
        public string CWP { get; set; }
        public string FIWP { get; set; }
        public string CostCode { get; set; }
        public string CostCodeDesc { get; set; }
        public decimal EstimatedQty { get; set; }
        public decimal InstalledQty { get; set; }
        public decimal Complete { get; set; }
        public string ClientSignOffIWP { get; set; }
        public decimal ManhoursEstimate { get; set; }
        public decimal ActualHours { get; set; }
        public decimal EarnedHours { get; set; }
        public decimal PF { get; set; }
        public decimal BudgetedHours { get; set; }
        public decimal ForecastedHours { get; set; }

        public DateTime PlannedStartDate { get; set; }
        public DateTime ActualStartDate { get; set; }
        public DateTime PlannedFinishDate { get; set; }
        public DateTime ActualFinishDate { get; set; }

        public rptProjectControlsDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class rptProgressProductivityDTO : DTOBase
    {
        public string CWA { get; set; }
        public string CWP { get; set; }
        public string MaterialCategory { get; set; }
        public string FIWP { get; set; }
        public string WBSCode { get; set; }
        public string CostCode { get; set; }
        public string CostCodeDesc { get; set; }
        public string UOM { get; set; }
        public decimal EstimatedQty { get; set; }
        public decimal ManhoursEstimate { get; set; }
        public decimal UnitRate { get; set; }
        public decimal CP_EarnedQTY { get; set; }
        public decimal CP_EarnedHours { get; set; }
        public decimal CP_ActualHours { get; set; }
        public decimal CP_UnitRate { get; set; }
        public decimal CP_Complete { get; set; }
        public decimal CP_PF { get; set; }
        public decimal TD_EarnedQTY { get; set; }
        public decimal TD_EarnedHours { get; set; }
        public decimal TD_ActualHours { get; set; }
        public decimal TD_UnitRate { get; set; }
        public decimal TD_Complete { get; set; }
        public decimal TD_PF { get; set; }
        public int RFIID { get; set; }
        

        public rptProgressProductivityDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class rptProgressSummaryDTO : DTOBase
    {
        public string Grp1 { get; set; }
        public string Grp2 { get; set; }
        public string Grp3 { get; set; }
        public string Grp4 { get; set; }
        public string Grp5 { get; set; }
        public string Grp6 { get; set; }
        public string Grp7 { get; set; }
        public string Grp8 { get; set; }
        public string Grp9 { get; set; }
        public string Grp10 { get; set; }
        public string Grp11 { get; set; }
        public string Grp12 { get; set; }
        public string Grp13 { get; set; }
        public string Grp14 { get; set; }
        public string Grp15 { get; set; }
        public decimal Val1 { get; set; }
        public decimal Val2 { get; set; }
        public decimal Val3 { get; set; }
        public decimal Val4 { get; set; }
        public decimal Val5 { get; set; }
        public decimal Val6 { get; set; }
        public decimal Val7 { get; set; }
        public decimal Val8 { get; set; }
        public decimal Val9 { get; set; }
        public decimal Val10 { get; set; }
        public decimal Val11 { get; set; }
        public decimal Val12 { get; set; }
        public decimal Val13 { get; set; }
        public decimal Val14 { get; set; }
        public decimal Val15 { get; set; }
        public decimal Val16 { get; set; }
        public decimal Val17 { get; set; }
        public decimal Val18 { get; set; }
        public decimal Val19 { get; set; }
        public decimal Val20 { get; set; }
        public int IntVal1 { get; set; }
        public int IntVal2 { get; set; }
        public int IntVal3 { get; set; }
        public int IntVal4 { get; set; }
        public int IntVal5 { get; set; }



        public rptProgressSummaryDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }

    }
}
