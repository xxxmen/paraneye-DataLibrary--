
#region PolineitemDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: PolineitemDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:55 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class PolineitemDTO : DTOBase
    {
        public int POLineItemID { get; set; }
        public int QuantityOrdered { get; set; }
        public int UOMID { get; set; }
        public DateTime OrderedDate { get; set; }
        public int Received { get; set; }
        public DateTime ReceivedDate { get; set; }
        public string BOM { get; set; }
        public int CostCodeID { get; set; }
        public double Cost { get; set; }
        public double GST { get; set; }
        public double TotalCost { get; set; }
        public string Comments { get; set; }
        public int POID { get; set; }
        

        // Constructor
        public PolineitemDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
