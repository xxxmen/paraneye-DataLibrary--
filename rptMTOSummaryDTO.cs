using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Element.Reveal.DataLibrary
{
    public class rptMTOSummaryDTO : DTOBase
    {
        public string CWPName { get; set; }
        public string ProjectScheduleName { get; set; }
        public string FIWPName { get; set; }
        public string DrawingName { get; set; }
        public string Group1 { get; set; }
        public string Group2 { get; set; }
        public string Group3 { get; set; }
        public string Group4 { get; set; }
        public string Group5 { get; set; }
        public string Group6 { get; set; }
        public string Group7 { get; set; }
        public string Group8 { get; set; }
        public string Group9 { get; set; }
        public string Group10 { get; set; }
        public string Group11 { get; set; }
        public string Group12 { get; set; }
        public string Group13 { get; set; }
        public string Group14 { get; set; }
        public string Group15 { get; set; }
        public string Group16 { get; set; }
        public string Group17 { get; set; }
        public string Group18 { get; set; }
        public decimal Value1 { get; set; }
        public decimal Value2 { get; set; }
        public decimal Value3 { get; set; }
        public decimal Value4 { get; set; }
        public decimal Value5 { get; set; }
        public DateTime DateValue1 { get; set; }
        public DateTime DateValue2 { get; set; }

        public rptMTOSummaryDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }

    }
}

