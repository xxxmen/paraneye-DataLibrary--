
#region FiwpmaterialDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: FiwpmaterialDTO.cs
// Author: 
// Date: March-12-12
// Time: 12:22:38 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class FiwpmaterialDTO : DTOBase
    {
        public int FIWPMaterialID { get; set; }
        public int FIWPID { get; set; }
        public int MaterialCategoryID { get; set; }
        public int MaterialLibID { get; set; }
        public int EstMHLibID { get; set; }
        [XmlElement(IsNullable = true)]
        public string EngTagNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string PartNo { get; set; }
        public string UOMLUID { get; set; }
        public decimal Qty { get; set; }
        public decimal QtyAdd { get; set; }
        public decimal QtySum { get; set; }        
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
        [XmlElement(IsNullable = true)]
        public string PONo { get; set; }
        [XmlElement(IsNullable = true)]
        public string RequisitionNo { get; set; }
        public int VendorLUID { get; set; }
        public DateTime PromisedDeliveryDate { get; set; }
        public DateTime RevisedDeliveryDate { get; set; }
        public DateTime DelieveryDate { get; set; }
        public DateTime ETADate { get; set; }
        public DateTime ROSDate { get; set; }
        public int LocationLUID { get; set; }
        public int MaterialStatusLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string RowTagging { get; set; }
        [XmlElement(IsNullable = true)]
        public string ShelfTagging { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string UOM { get; set; }
        [XmlElement(IsNullable = true)]
        public string Vendor { get; set; }
        [XmlElement(IsNullable = true)]
        public string Location { get; set; }
        [XmlElement(IsNullable = true)]
        public string SDName { get; set; }
        [XmlElement(IsNullable = true)]
        public string IsConsumable { get; set; }
        [XmlElement(IsNullable = true)]
        public string CostCode { get; set; }

        // Constructor
        public FiwpmaterialDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
            PromisedDeliveryDate = new DateTime(1753, 1, 1);
            RevisedDeliveryDate = new DateTime(1753, 1, 1);
            DelieveryDate = new DateTime(1753, 1, 1);
            ETADate = new DateTime(1753, 1, 1);
            ROSDate = new DateTime(1753, 1, 1);
            UpdatedDate = new DateTime(1753, 1, 1);

        }
    }
}
