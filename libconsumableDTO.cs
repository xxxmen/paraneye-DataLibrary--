
#region LibconsumableDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibconsumableDTO.cs
// Author: 
// Date: August-23-12
// Time: 3:33:07 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class LibconsumableDTO : DTOBase
    {
        public int LibConsumableID { get; set; }
        public int LibTypeLUID { get; set; }
        public string PartNumber { get; set; }
        public string Description { get; set; }
        public string TypeLUID { get; set; }
        public int VendorLUID { get; set; }
        public string UOMLUID { get; set; }
        public decimal Manhours { get; set; }
        [XmlElement(IsNullable = true)]
        public string LibType { get; set; }
        [XmlElement(IsNullable = true)]
        public string Type { get; set; }
        [XmlElement(IsNullable = true)]
        public string Vendor { get; set; }
        [XmlElement(IsNullable = true)]
        public string UOM { get; set; }
        public int CostCodeID { get; set; }
        [XmlElement(IsNullable = true)]
        public string CostCode { get; set; }

        // Constructor
        public LibconsumableDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
