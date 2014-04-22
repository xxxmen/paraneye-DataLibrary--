using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Element.Reveal.DataLibrary
{
    public class rptScheduleManhourDTO : DTOBase
    {
        public int FIWPID { get; set; }
        public int MaterialCategoryID { get; set; }       
        public int CWPID { get; set; }
        public decimal PlannedMH { get; set; }
        public decimal ActualMH { get; set; }
        public decimal EarnedMH { get; set; }
        public decimal CompleteMH { get; set; }
        public decimal QTY { get; set; }
        

        public string FIWPName { get; set; }
        public string TaskCategory { get; set; }
        public string CWPName { get; set; }

        public DateTime Cycle { get; set; }

        public rptScheduleManhourDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
