
#region QaqcformdetailForTestDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: QaqcformdetailForTestDTO.cs
// Author: 
// Date: Tuesday, January 21, 2014
// Time: 5:52:47 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

namespace Element.Reveal.DataLibrary
{
    public class QaqcformdetailForTestDTO 
    {
        public int QAQCFormDetailID { get; set; }
        public int QAQCFormID { get; set; }
        public int InspectionLUID { get; set; }
        public int InspectedValue { get; set; }
        public string StringValue1 { get; set; }
        public string StringValue2 { get; set; }
        public string StringValue3 { get; set; }
        public string StringValue4 { get; set; }
        public string StringValue5 { get; set; }
        public string StringValue6 { get; set; }
        public DateTime DateValue1 { get; set; }
        public DateTime DateValue2 { get; set; }
        public string StringValue7 { get; set; }
        public string StringValue8 { get; set; }
        public string StringValue9 { get; set; }
        public string StringValue10 { get; set; }
        public string StringValue11 { get; set; }
        public string StringValue12 { get; set; }
        public string StringValue13 { get; set; }
        public string StringValue14 { get; set; }
        public string StringValue15 { get; set; }
        public string InspectedKeyValue { get; set; }
        public string StringValue16 { get; set; }
        public string StringValue17 { get; set; }
        

	public int DTOStatus { get; set; }

        // Constructor
        public QaqcformdetailForTestDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
