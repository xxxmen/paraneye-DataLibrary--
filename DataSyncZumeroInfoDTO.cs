
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
    public class DataSyncZumeroInfoDTO : DTOBase
    {
        [XmlElement(IsNullable = true)]
        public string ZumeroURL { get; set; }
        [XmlElement(IsNullable = true)]
        public string ZumeroFile { get; set; }
        [XmlElement(IsNullable = true)]
        public string ZumeroUser { get; set; }
        [XmlElement(IsNullable = true)]
        public string ZumeroPassword { get; set; }

        //추가컬럼
        [DataMember]
        public string SigmaOperation { get; set; } // CRUD

        // Constructor
        public DataSyncZumeroInfoDTO()
        {
            DTOStatus = (int)RowStatusNo.New;
        }
    }
}
