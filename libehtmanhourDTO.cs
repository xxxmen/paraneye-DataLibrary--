
#region LibehtmanhourDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibehtmanhourDTO.cs
// Author: 
// Date: June-17-11
// Time: 10:04:44 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class LibehtmanhourDTO : DTOBase
    {
        public int LibEHTmanhourID { get; set; }
        [XmlElement(IsNullable = true)]
        public string EHTTaskType { get; set; }
        [XmlElement(IsNullable = true)]
        public string PartNo { get; set; }
        [XmlElement(IsNullable = true)]
        public string NAME { get; set; }
        [XmlElement(IsNullable = true)]
        public string UOM { get; set; }
        public decimal Manhours { get; set; }
        [XmlElement(IsNullable = true)]
        public string Vendor { get; set; }
        public int UOMLUID { get; set; }
        public int TaskTypeLUID { get; set; }
        public int EHTTypeLUID { get; set; }
        public int Volt { get; set; }
        public int VendorLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string HCableConfigure { get; set; }
        [XmlElement(IsNullable = true)]
        public string HCableRef { get; set; }
        [XmlElement(IsNullable = true)]
        public string HCableRef2 { get; set; }
        public int HCableLen { get; set; }
        public int HCableWAT { get; set; }
        public int HCableVolt { get; set; }
        public int ColdLeadLen { get; set; }
        [XmlElement(IsNullable = true)]
        public string ColdLeadCode { get; set; }
        [XmlElement(IsNullable = true)]
        public string ColdJointXAlloy825HCables { get; set; }
        public int GlandSize { get; set; }
        public int SRPowerRate { get; set; }
        [XmlElement(IsNullable = true)]
        public string SRHCable { get; set; }
        public int SRVolt { get; set; }
        [XmlElement(IsNullable = true)]
        public string SROuterJacket { get; set; }
        [XmlElement(IsNullable = true)]
        public string TempRate { get; set; }
        [XmlElement(IsNullable = true)]
        public string RecReeQCForm { get; set; }
        public decimal RecReelQCManHrs { get; set; }
        [XmlElement(IsNullable = true)]
        public string QC2Form { get; set; }
        public decimal QC2Manhrs { get; set; }
        [XmlElement(IsNullable = true)]
        public string QC3Form { get; set; }
        public decimal QC3Manhrs { get; set; }
        [XmlElement(IsNullable = true)]
        public string QC4Form { get; set; }
        public decimal QC4Manhrs { get; set; }
        public int TaskCode { get; set; }
        [XmlElement(IsNullable = true)]
        public string EHTType { get; set; }
        public int CostCodeID { get; set; }
        [XmlElement(IsNullable = true)]
        public string CostCode { get; set; }

        // Constructor
        public LibehtmanhourDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class LibehtmanhourPageTotal
    {
        public List<LibehtmanhourDTO> lib { get; set; }
        public int TotalPageCount { get; set; }
    }
}
