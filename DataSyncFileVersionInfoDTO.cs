
#region DataSyncFileVersionInfoDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: DataSyncFileVersionInfoDTO.cs
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
    public class DataSyncFileVersionInfoDTO : DTOBase
    {
        public int VerSionId { get; set; }
        [XmlElement(IsNullable = true)]
        public string FileName { get; set; }
        [XmlElement(IsNullable = true)]
        public string FilePath { get; set; }
        [XmlElement(IsNullable = true)]
        public string RelationTable { get; set; }
        public int RelationKey { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedDate { get; set; }
        
        //추가컬럼
        [DataMember]
        public string SigmaOperation { get; set; } // CRUD

        // Constructor
        public DataSyncFileVersionInfoDTO()
        {
            DTOStatus = (int)RowStatusNo.New;
        }
    }
}
