
#region LibgroundinglocknutDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibgroundinglocknutDTO.cs
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
    public class LibgroundingmanhourDTO : DTOBase
    {
        public int LibGroundingManhourID { get; set; }
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
        public int UOMLUID { get; set; }
        public int TaskTypeLUID { get; set; }
        public int VendorID { get; set; }
        public int CostCodeID { get; set; }
        [XmlElement(IsNullable = true)]
        public string CostCode { get; set; }

        // Constructor
        public LibgroundingmanhourDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class LibgroundingmanhourPageTotal
    {
        public List<LibgroundingmanhourDTO> lib { get; set; }
        public int TotalPageCount { get; set; }
    }
}
