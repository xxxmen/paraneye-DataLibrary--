
#region LiblightingmanhoursDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LiblightingmanhoursDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:49 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class LiblightingmanhourDTO : DTOBase
    {
        public int LibLightingManhourID { get; set; }
        [XmlElement(IsNullable = true)]
        public string TaskType { get; set; }
        [XmlElement(IsNullable = true)]
        public string PartNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
        [XmlElement(IsNullable = true)]
        public string UOM { get; set; }
        public decimal Manhours { get; set; }
        [XmlElement(IsNullable = true)]
        public string Vendor { get; set; }
        public int UOMID { get; set; }
        public int TaskTypeLUID { get; set; }
        public int VendorID { get; set; }
        public int LightingTypeLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string Series { get; set; }
        [XmlElement(IsNullable = true)]
        public string AccessoriesType { get; set; }
        [XmlElement(IsNullable = true)]
        public string DetailTag { get; set; }
        [XmlElement(IsNullable = true)]
        public string HubSize { get; set; }
        [XmlElement(IsNullable = true)]
        public string Watt { get; set; }
        [XmlElement(IsNullable = true)]
        public string OperatingCurrentAMP { get; set; }
        [XmlElement(IsNullable = true)]
        public string Volt { get; set; }
        [XmlElement(IsNullable = true)]
        public string CableODRange { get; set; }
        [XmlElement(IsNullable = true)]
        public string Manufactory { get; set; }
        public decimal SiteManhours { get; set; }
        [XmlElement(IsNullable = true)]
        public string LightingType { get; set; }
        public int CostCodeID { get; set; }
        [XmlElement(IsNullable = true)]
        public string CostCode { get; set; }

        // Constructor
        public LiblightingmanhourDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class LiblightingmanhourPageTotal
    {
        public List<LiblightingmanhourDTO> lib { get; set; }
        public int TotalPageCount { get; set; }
    }
}
