
#region DocumentmarkupDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: DocumentmarkupDTO.cs
// Author: Woojong You
// Date: June-24-13
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class DocumentmarkupDTO : DTOBase
    {
        public int DocumentMarkupID { get; set; }
        [XmlElement(IsNullable = true)]
        public string DocumentMarkupURL { get; set; }
        [XmlElement(IsNullable = true)]
        public string PersonnelID { get; set; }
        public int SPCollectionID { get; set; }
        public int DocumentID { get; set; }
        public int DrawingID { get; set; }
        public int IsActive { get; set; }
        public int RFIID { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        //2014.03.07 add        
        public int FileStoreId { get; set; }

        // Constructor
        public DocumentmarkupDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
