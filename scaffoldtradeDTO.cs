
#region ScaffoldtradeDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ScaffoldtradeDTO.cs
// Author: 
// Date: October-26-11
// Time: 5:28:32 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class ScaffoldtradeDTO : DTOBase
    {
        public int ScaffoldTradeID { get; set; }
        public int ScaffoldRequestID { get; set; }
        public int ScaffoldID { get; set; }
        public int TradeTypeLUID { get; set; }
        public string TradeType { get; set; }
        

        // Constructor
        public ScaffoldtradeDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
