
#region LibequipmanhoursDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibequipmanhoursDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:48 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class LibequipmanhourDTO : DTOBase
    {
        public int LibEquipManhourID { get; set; }
        [XmlElement(IsNullable = true)]
        public string EquipType { get; set; }
        [XmlElement(IsNullable = true)]
        public string PartNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
        [XmlElement(IsNullable = true)]
        public string UOM { get; set; }
        public decimal Manhours { get; set; }
        [XmlElement(IsNullable = true)]
        public string Vendor { get; set; }
        public int UOMLUID { get; set; }
        public int EquipTypeLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string Material { get; set; }
        [XmlElement(IsNullable = true)]
        public string Style { get; set; }
        [XmlElement(IsNullable = true)]
        public string Series { get; set; }
        public decimal Quantity { get; set; }
        public decimal SiteManhours { get; set; }
        public int VendorLUID { get; set; }
        public double Wattage_kw { get; set; }
        public double Voltage { get; set; }
        public int SDID { get; set; }
        [XmlElement(IsNullable = true)]
        public string MaterialItemNo { get; set; }
        [XmlElement(IsNullable = true)]
        public string SD { get; set; }
        public int CostCodeID { get; set; }
        [XmlElement(IsNullable = true)]
        public string CostCode { get; set; }

        // Constructor
        public LibequipmanhourDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class LibequipmanhourPageTotal
    {
        public List<LibequipmanhourDTO> lib { get; set; }
        public int TotalPageCount { get; set; }
    }
}
