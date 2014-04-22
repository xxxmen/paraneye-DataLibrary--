
#region LibracewaymanhourDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibracewaymanhourDTO.cs
// Author: 
// Date: November-28-11
// Time: 6:46:41 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class LibracewaymanhourDTO : DTOBase
    {
        public int LibRacewaymanhourID { get; set; }
        [XmlElement(IsNullable = true)]
        public string RacewayType { get; set; }
        public string PartNo { get; set; }
        [XmlElement(IsNullable = true)]
        public string RacewayName { get; set; }
        [XmlElement(IsNullable = true)]
        public string UOM { get; set; }
        public decimal ManHours { get; set; }
        [XmlElement(IsNullable = true)]
        public string Vendor { get; set; }
        public int UOMLUID { get; set; }
        public int TaskTypeLUID { get; set; }
        public int TrayTypeLUID { get; set; }
        public int MaterialTypeLUID { get; set; }
        public int VendorLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string Material { get; set; }
        [XmlElement(IsNullable = true)]
        public string FittingStyle { get; set; }
        [XmlElement(IsNullable = true)]
        public string Style { get; set; }
        public int Series { get; set; }
        public int SiderailLen { get; set; }
        public double Width1 { get; set; }
        public double Width2 { get; set; }
        [XmlElement(IsNullable = true)]
        public string BottonStyle { get; set; }
        [XmlElement(IsNullable = true)]
        public string FittingType { get; set; }
        public double AngleDegree { get; set; }
        public double NominalRadius { get; set; }
        [XmlElement(IsNullable = true)]
        public string CoverType { get; set; }
        public double Length { get; set; }
        public int CostCodeID { get; set; }
        [XmlElement(IsNullable = true)]
        public string TrayType { get; set; }
        [XmlElement(IsNullable = true)]
        public string MaterialType { get; set; }
        [XmlElement(IsNullable = true)]
        public string CostCode { get; set; }

        // Constructor
        public LibracewaymanhourDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class LibracewaymanhourPageTotal
    {
        public List<LibracewaymanhourDTO> lib { get; set; }
        public int TotalPageCount { get; set; }
    }
}
