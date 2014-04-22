
#region LibinsulpaintmanhourDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibinsulpaintmanhourDTO.cs
// Author: 
// Date: January-24-13
// Time: 3:14:18 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;
namespace Element.Reveal.DataLibrary
{
    public class LibinsulpaintmanhourDTO : DTOBase
    {
        public int LibInsulPaintManhourID { get; set; }
        public int PaintLibTypeLUID { get; set; }
        public int MaterialCategoryID { get; set; }
        public int MethodTypeLUID { get; set; }
        public string ComponentType { get; set; }
        public string CoatType { get; set; }
        public decimal Manhours { get; set; }
        public decimal AddedManhours { get; set; }
        public int UOMLUID { get; set; }

        [XmlElement(IsNullable = true)]
        public string PaintLibType { get; set; }
        [XmlElement(IsNullable = true)]
        public string MaterialCategory { get; set; }
        [XmlElement(IsNullable = true)]
        public string MethodType { get; set; }
        [XmlElement(IsNullable = true)]
        public string UOM { get; set; }

        // Constructor
        public LibinsulpaintmanhourDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class LibinsulpaintmanhourPageTotal
    {
        public List<LibinsulpaintmanhourDTO> lib { get; set; }
        public int TotalPageCount { get; set; }
    }
}
