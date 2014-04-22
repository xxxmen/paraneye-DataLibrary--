
#region QuantityserveyDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: QuantityserveyDTO.cs
// Author: 
// Date: Monday, November 18, 2013
// Time: 7:33:56 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class QuantityserveyDTO : DTOBase
    {
        public int QuantityServeyID { get; set; }
        public int ProgressID { get; set; }
        public int MaterialCategoryID { get; set; }
        public int TaskCategoryID { get; set; }
        public int FIWPID { get; set; }
        public int CWPID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int OwnerID { get; set; }
        public int RuleOfCreditWeightID { get; set; }
        public int ResultLUID { get; set; }
        public int CommentLUID { get; set; }
        public string Comments { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        [XmlElement(IsNullable = true)]
        public string TagNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string ComponentDesc { get; set; }
        public decimal Qty { get; set; }
        public int UOMLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string UOM { get; set; }

        // Constructor
        public QuantityserveyDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
