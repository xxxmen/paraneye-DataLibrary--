
#region LibpipeclassmanhourDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibpipeclassmanhourDTO.cs
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
    public class LibpipeclassmanhourDTO : DTOBase
    {
        public int LibPipeClassManhourID { get; set; }
        public int PipeTypeLUID { get; set; }
        public decimal PipeSize { get; set; }
        [XmlElement(IsNullable = true)]
        public string PipeClass { get; set; }
        public decimal Manhours { get; set; }
        public int CostCodeID { get; set; }
        [XmlElement(IsNullable = true)]
        public string PipeType { get; set; }
        [XmlElement(IsNullable = true)]
        public string CostCode { get; set; }

        // Constructor
        public LibpipeclassmanhourDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class LibpipeclassmanhourPageTotal
    {
        public List<LibpipeclassmanhourDTO> lib { get; set; }
        public int TotalPageCount { get; set; }
    }
}
