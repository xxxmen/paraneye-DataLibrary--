
#region CompanyDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: CompanyDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:38 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class CompanyDTO : DTOBase
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public int CompanyTypeLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string CompanyAddress { get; set; }
        [XmlElement(IsNullable = true)]
        public string ContactName { get; set; }
        [XmlElement(IsNullable = true)]
        public string ContactPhone { get; set; }
        [XmlElement(IsNullable = true)]
        public string ContactCell { get; set; }
        [XmlElement(IsNullable = true)]
        public string ContactFax { get; set; }
        [XmlElement(IsNullable = true)]
        public string ContactEmail { get; set; }
        [XmlElement(IsNullable = true)]
        public string LogoFileName { get; set; }
        [XmlElement(IsNullable = true)]
        public string CompanyType { get; set; }
        // Constructor
        public CompanyDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
