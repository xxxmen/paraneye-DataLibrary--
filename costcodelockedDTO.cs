
#region AreaDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: AreaDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:38 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class CostcodelockedDTO : DTOBase
    {
        public int CostCodeLockedID { get; set; }
        public int CostCodeID { get; set; }
        public int ProjectID { get; set; }
        public int CWPID { get; set; }
        public int IsLocked { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }

        public decimal TotalManhours { get; set; }
        public decimal Qty { get; set; }

        // Constructor
        public CostcodelockedDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
