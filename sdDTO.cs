
#region SdDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: SdDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:08:00 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class SdDTO : DTOBase
    {
        public int SDID { get; set; }
        [XmlElement(IsNullable = true)]
        public string SDName { get; set; }
        [XmlElement(IsNullable = true)]
        public string DetailNumber { get; set; }
        public int SDTypeLUID { get; set; }
        public int MaterialCategoryID { get; set; }
        [XmlElement(IsNullable = true)]
        public string RevisionNo { get; set; }
        public int DrawingID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int CompanyID { get; set; }
        public int CostCodeID { get; set; }
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
        [XmlElement(IsNullable = true)]
        public string Comment { get; set; }
        
        [XmlElement(IsNullable = true)]
        public string SDType { get; set; }
        [XmlElement(IsNullable = true)]
        public string MaterialCategory { get; set; }
        [XmlElement(IsNullable = true)]
        public string Company { get; set; }
        [XmlElement(IsNullable = true)]
        public string CostCode { get; set; }
        public decimal Manhours { get; set; }
        public int ReferenceCount { get; set; }
        public int UOMLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string UOM { get; set; }
        public decimal Quantity { get; set; }
        public int PageNumber { get; set; }

        // Constructor
        public SdDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class SdPageTotal
    {
        public List<SdDTO> lib { get; set; }
        public int TotalPageCount { get; set; }
    }

    public class SdAndSdmateriallistDTO
    { 
        public SdDTO sd { get; set; }
        public List<SdmateriallistDTO> sdmateriallist { get; set; }
    }
}
