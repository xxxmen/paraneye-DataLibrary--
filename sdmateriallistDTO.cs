
#region SdmateriallistDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: SdmateriallistDTO.cs
// Author: 
// Date: May-18-11
// Time: 3:35:49 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;
namespace Element.Reveal.DataLibrary
{
    public class SdmateriallistDTO : DTOBase
    {
        public int MaterialListID { get; set; }
        public int SDID { get; set; }
        public int MaterialCategoryID { get; set; }
        public int LibID { get; set; }
        public int ItemNo { get; set; }
        [XmlElement(IsNullable = true)]
        public string PartNumber { get; set; }
        public int UOMLUID { get; set; }
        public decimal Quantity { get; set; }
        public decimal Manhours { get; set; }
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
        [XmlElement(IsNullable = true)]
        public string Comments { get; set; }

        [XmlElement(IsNullable = true)]
        public string SDName { get; set; }
        [XmlElement(IsNullable = true)]
        public string DetailNumber { get; set; }
        public int SDTypeLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string UOM { get; set; }
        
        // Constructor
        public SdmateriallistDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
