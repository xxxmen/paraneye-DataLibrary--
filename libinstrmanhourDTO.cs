
#region LibinstrmanhoursDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibinstrmanhoursDTO.cs
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
    public class LibinstrmanhourDTO : DTOBase
    {
        public int LibInstrManHourID { get; set; }
        public int TaskTypeLUID { get; set; }
        public int FunctionTypeLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string FunctionCode { get; set; }
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
        public int UOMID { get; set; }
        public decimal Manhours { get; set; }
        public int VendorID { get; set; }
        [XmlElement(IsNullable = true)]
        public string Partnumber { get; set; }
        public decimal Quantity { get; set; }
        [XmlElement(IsNullable = true)]
        public string ConnectionType { get; set; }
        public string ElectricalRatings { get; set; }
        public Double MaxOperatingPressure_psi { get; set; }
        public int CostCodeID { get; set; }
        
        [XmlElement(IsNullable = true)]
        public string UOM { get; set; }
        [XmlElement(IsNullable = true)]
        public string TaskType { get; set; }
        [XmlElement(IsNullable = true)]
        public string FunctionType { get; set; }
        [XmlElement(IsNullable = true)]
        public string Vendor { get; set; }
        [XmlElement(IsNullable = true)]
        public string CostCode { get; set; }

        // Constructor
        public LibinstrmanhourDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

        public class LibinstrmanhourPageTotal
    {
        public List<LibinstrmanhourDTO> lib { get; set; }
        public int TotalPageCount { get; set; }
    }
}

