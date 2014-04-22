
#region UploadFileHistoryInfoDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: UploadFileHistoryInfoDTO.cs
// Author: Kate Kim
// Date: Sunday, March 2, 2014
// Time: 7:10:53 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class UploadFileHistoryInfoDTO : DTOBase
    {
        [XmlElement(IsNullable = true)]
        public string FileName { get; set; }
        [XmlElement(IsNullable = true)]
        public string FilePath { get; set; }
        [XmlElement(IsNullable = true)]
        public string RelationTable { get; set; }
        [XmlElement(IsNullable = true)]
        public string MobileLoginId { get; set; }
        [XmlElement(IsNullable = true)]
        public string MobileUdId { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedDate { get; set; }

        //추가컬럼
        [DataMember]
        public string SigmaOperation { get; set; } // CRUD

        // Constructor
        public UploadFileHistoryInfoDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
