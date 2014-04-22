
#region LibpipemanhourDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibpipemanhourDTO.cs
// Author: 
// Date: May-03-13
// Time: 4:59:16 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class LibpipemanhourDTO : DTOBase
    {
        public int LibPipeManhourID { get; set; }
        public int LibTypeLUID { get; set; }
        public int MaterialTypeLUID { get; set; }
        public decimal PipeSize { get; set; }
        public string PipeClass { get; set; }
        public string PipeSCH { get; set; }
        public decimal Manhours { get; set; }
        public int CostCodeID { get; set; }

        public string PipeType { get; set; }
        public string MaterialType { get; set; }
        public string CostCode { get; set; }
        public int PipeLUID { get; set; }

        // Constructor
        public LibpipemanhourDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class LibpipemanhourPageTotal
    {
        public List<LibpipemanhourDTO> lib { get; set; }
        public int TotalPageCount { get; set; }
    }
}
