
#region LibpipemanhourratioDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibpipemanhourratioDTO.cs
// Author: 
// Date: July-10-11
// Time: 1:41:22 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class LibpipemanhourratioDTO : DTOBase
    {
        public int LibPipeManhourRatioID { get; set; }
        public int PipeTypeLUID { get; set; }
        public decimal PipeSize { get; set; }
        public int LibPipeMaterailGrpID { get; set; }
        public float ManhourRatio { get; set; }
        public int CostCodeID { get; set; }
        [XmlElement(IsNullable = true)]
        public string PipeType { get; set; }
        [XmlElement(IsNullable = true)]
        public string CostCode { get; set; }
        [XmlElement(IsNullable = true)]
        public string LibPipeMaterialGrp { get; set; }

        // Constructor
        public LibpipemanhourratioDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class LibpipemanhourratioPageTotal
    {
        public List<LibpipemanhourratioDTO> lib { get; set; }
        public int TotalPageCount { get; set; }
    }
}
