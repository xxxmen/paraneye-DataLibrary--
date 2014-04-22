
#region LibpipeschmanhourDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibpipeschmanhourDTO.cs
// Author: 
// Date: July-10-11
// Time: 1:41:23 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class LibpipeschmanhourDTO : DTOBase
    {
        public int LibPipeSchManhourID { get; set; }
        public int PipeTypeLUID { get; set; }
        public decimal PipeSize { get; set; }
        [XmlElement(IsNullable = true)]
        public string PipeThickSch { get; set; }
        public decimal Manhours { get; set; }
        public int CostCodeID { get; set; }
        [XmlElement(IsNullable = true)]
        public string PipeType { get; set; }
        [XmlElement(IsNullable = true)]
        public string CostCode { get; set; }

        // Constructor
        public LibpipeschmanhourDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class LibpipeschmanhourPageTotal
    {
        public List<LibpipeschmanhourDTO> lib { get; set; }
        public int TotalPageCount { get; set; }
    }
}
