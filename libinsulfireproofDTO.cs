
#region LibinsulfireproofDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibinsulfireproofDTO.cs
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
    public class LibinsulfireproofDTO : DTOBase
    {
        public int LibInsulFireproofID { get; set; }
        public int LibInsulFactorID { get; set; }
        public int FireproofTypeLUID { get; set; }
        public string ComponentType { get; set; }
        public decimal Concrete { get; set; }
        public int ConcreteUOMID { get; set; }
        public decimal Forms { get; set; }
        public int FormsUOMID { get; set; }
        public decimal Mesh { get; set; }
        public int MeshUOMID { get; set; }
        public int InsulFactorUOMID { get; set; }
        [XmlElement(IsNullable = true)]
        public string FireproofType { get; set; }
        [XmlElement(IsNullable = true)]
        public string ConcreteUOM { get; set; }
        [XmlElement(IsNullable = true)]
        public string FormsUOM { get; set; }
        [XmlElement(IsNullable = true)]
        public string MeshUOM { get; set; }
        [XmlElement(IsNullable = true)]
        public string InsulFactorUOM { get; set; }
        public decimal Manhours { get; set; }

        [XmlElement(IsNullable = true)]
        public string LibInsulFactor { get; set; }

        // Constructor
        public LibinsulfireproofDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class LibinsulfireproofPageTotal
    {
        public List<LibinsulfireproofDTO> lib { get; set; }
        public int TotalPageCount { get; set; }
    }
}
