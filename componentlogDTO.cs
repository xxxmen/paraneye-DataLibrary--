
#region ComponentlogDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ComponentlogDTO.cs
// Author: 
// Date: August-12-12
// Time: 8:57:09 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class ComponentlogDTO : DTOBase
    {
        public int ComponentLogID { get; set; }
        public int ComponentID { get; set; }
        [XmlElement(IsNullable = true)]
        public string TagNumber { get; set; }
        public decimal Qty { get; set; }
        public int UOMLUID { get; set; }
        public int CWPID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int OwnerID { get; set; }
        public int MaterialCategoryID { get; set; }
        public int SystemID { get; set; }
        public int DrawingID { get; set; }
        public int DrawingRevisionID { get; set; }
        public int RFIID { get; set; }
        public int MaterialStatusLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string EngTagNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string ISOLineNo { get; set; }
        [XmlElement(IsNullable = true)]
        public string ComponentDesc { get; set; }
        public int CWAID { get; set; }
        public int SourceLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }
        

        // Constructor
        public ComponentlogDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
