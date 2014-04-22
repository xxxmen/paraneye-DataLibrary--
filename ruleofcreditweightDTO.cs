
#region RuleofcreditweightDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: RuleofcreditweightDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:08:00 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class RuleofcreditweightDTO : DTOBase
    {
        public int RuleOfCreditWeightID { get; set; }
        public int RuleOfCreditLUID { get; set; }
        public int MaterialCategoryID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public decimal Percentage { get; set; }
        public string RuleOfCreditName { get; set; }

        // Constructor
        public RuleofcreditweightDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
