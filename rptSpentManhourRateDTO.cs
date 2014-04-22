#region rptSpentManhourRateDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: rptSpentManhourRateDTO.cs
// Author: Dongok An
// Date: March-11-11
// Time: 13:20 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class rptSpentManhourRateDTO : DTOBase
    {
        public decimal ManhoursSpent { get; set; }
        public decimal ManhoursEstimate { get; set; }
        public string ForemanName { get; set; }
        public int ForemanStructureID { get; set; }
        public DateTime Cycle { get; set; }

        public rptSpentManhourRateDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
