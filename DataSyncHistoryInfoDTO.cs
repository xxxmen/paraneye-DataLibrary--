
#region DataSyncHistoryInfoDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: DataSyncHistoryInfoDTO.cs
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
    public class DataSyncHistoryInfoDTO : DTOBase
    {
        public int HistoryId { get; set; }
        public int FromFileVerSionId { get; set; }
        public int ToFileVerSionId { get; set; }
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
        public DataSyncHistoryInfoDTO()
        {
            DTOStatus = (int)RowStatusNo.New;
        }
    }
}
