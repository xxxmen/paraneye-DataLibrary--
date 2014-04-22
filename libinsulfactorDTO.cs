
#region LibinsulfactorDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibinsulfactorDTO.cs
// Author: 
// Date: January-15-13
// Time: 4:02:34 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class LibinsulfactorDTO : DTOBase
    {
        public int LibInsulFactorID { get; set; }
        public int LibTypeLUID { get; set; }
        public int ShapeLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string Type { get; set; }
        [XmlElement(IsNullable = true)]
        public string ConditionVariable { get; set; }
        public decimal MinValue { get; set; }
        public decimal MaxValue { get; set; }
        public decimal Factor { get; set; }
        public int UOMLUID { get; set; }
        public decimal Manhours { get; set; }
        [XmlElement(IsNullable = true)]
        public string DiffFactorVariable { get; set; }
        public decimal AddFactor { get; set; }
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
        public int FormulaLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string FactorDes { get; set; }
        [XmlElement(IsNullable = true)]
        public string Shape { get; set; }
        [XmlElement(IsNullable = true)]
        public string UOM { get; set; }
        [XmlElement(IsNullable = true)]
        public string Formula { get; set; }
        [XmlElement(IsNullable = true)]
        public string LibType { get; set; }

        // Constructor
        public LibinsulfactorDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class LibinsulfactorPageTotal
    {
        public List<LibinsulfactorDTO> lib { get; set; }
        public int TotalPageCount { get; set; }
    }
}
