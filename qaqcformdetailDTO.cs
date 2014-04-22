
#region QaqcformdetailDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: QaqcformDetailDTO.cs
// Author: 
// Date: May-12-11
// Time: 2:26:08 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class QaqcformdetailDTO : DTOBase
    {
        public int QAQCFormDetailID { get; set; }
        public int QAQCFormID { get; set; }
        [XmlElement(IsNullable = true)]
        public string InspectedKeyValue { get; set; }
        public int InspectionLUID { get; set; }
        public int InspectedValue { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringValue1 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringValue2 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringValue3 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringValue4 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringValue5 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringValue6 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringValue7 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringValue8 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringValue9 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringValue10 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringValue11 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringValue12 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringValue13 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringValue14 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringValue15 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringValue16 { get; set; }
        [XmlElement(IsNullable = true)]
        public string StringValue17 { get; set; }
        public DateTime DateValue1 { get; set; }
        public DateTime DateValue2 { get; set; }

        public string DetailName { get; set; } //from lookup

        // Constructor
        public QaqcformdetailDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
            DateValue1 = DateTime.MinValue;
            DateValue2 = DateTime.MinValue;
        }
    }
}
