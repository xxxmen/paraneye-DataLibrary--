
#region LibcablemanhourDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibcablemanhourDTO.cs
// Author: 
// Date: May-24-11
// Time: 12:24:40 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class LibcablemanhourDTO : DTOBase
    {
        public int LibCablemanhourID { get; set; }
        [XmlElement(IsNullable = true)]
        public string CableType { get; set; }
        [XmlElement(IsNullable = true)]
        public string PartNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string CableLibName { get; set; }
        [XmlElement(IsNullable = true)]
        public string UOM { get; set; }
        public decimal CablePullUnitRate { get; set; }
        [XmlElement(IsNullable = true)]
        public string Vendor { get; set; }
        public int UOMLUID { get; set; }
        public int CableTaskTypeLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string Type2 { get; set; }
        public int VendorLUID { get; set; }
        public int NoOfCond { get; set; }
        [XmlElement(IsNullable = true)]
        public string TypeOfCond { get; set; }
        [XmlElement(IsNullable = true)]
        public string AWG { get; set; }
        [XmlElement(IsNullable = true)]
        public string Shield { get; set; }
        public double InsulRating { get; set; }
        public int InsulVolt { get; set; }
        [XmlElement(IsNullable = true)]
        public string QC1Form { get; set; }
        public decimal QC1ManHrs { get; set; }
        public int TeckConnectorQty { get; set; }
        [XmlElement(IsNullable = true)]
        public string TBStarTeckExtreamCatNo { get; set; }
        public decimal GlandToManHrs { get; set; }
        public decimal GlandFromManHrs { get; set; }
        public int SSTagQty { get; set; }
        public decimal SSTagManHrsFrom { get; set; }
        public decimal SSTagManHrsTo { get; set; }
        [XmlElement(IsNullable = true)]
        public string QC2Form { get; set; }
        public decimal QC2ManHrs { get; set; }
        public decimal UnitRate { get; set; }
        public int WMQty { get; set; }
        public decimal TermManHrsTo { get; set; }
        public decimal TermManHrsFrom { get; set; }
        [XmlElement(IsNullable = true)]
        public string QC3Form { get; set; }
        public decimal QC3ManHrs { get; set; }
        [XmlElement(IsNullable = true)]
        public string QC4Form { get; set; }
        public decimal QC4ManHrs { get; set; }
        [XmlElement(IsNullable = true)]
        public string ReelNo { get; set; }
        public int CostCodeID { get; set; }
        [XmlElement(IsNullable = true)]
        public string CostCode { get; set; }

        // Constructor
        public LibcablemanhourDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class LibcablemanhourPageTotal
    {
        public List<LibcablemanhourDTO> lib { get; set; }
        public int TotalPageCount { get; set; }
    }
}
