
#region ProgressDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ProgressDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:56 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class FileStoreDTO : DTOBase
    {
        public int FileStoreId { get; set; }
        [XmlElement(IsNullable = true)]
        public string FileTitle { get; set; }
        [XmlElement(IsNullable = true)]
        public string FileDescription { get; set; }
        [XmlElement(IsNullable = true)]
        public string FileCategory { get; set; }
        [XmlElement(IsNullable = true)]
        public string FileTypeCode { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedDate { get; set; }
        public int ProjectId { get; set; }

        // Constructor
        public FileStoreDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}