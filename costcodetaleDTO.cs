
#region CostcodetaleDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: CostcodetaleDTO.cs
// Author: 
// Date: April-17-12
// Time: 6:38:31 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class CostcodetaleDTO : DTOBase
    {
        public int CostCodeTaleID { get; set; }
        public int CostCodeID { get; set; }
        public string ClassColumnName { get; set; }
        public string ClassColumnType { get; set; }
        public string ClassColumnValue { get; set; }
        

        // Constructor
        public CostcodetaleDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
