
#region rptDailytoolboxDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: rptDailytoolboxDTO.cs
// Author: 
// Date: August-18-13
// Time: 4:40:09 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class rptDailytoolboxDTO : DTOBase
    {
        public int DailyToolboxID { get; set; }
        public int DailyBrassID { get; set; }
        public int SPCollectionID { get; set; }
        public string DocumentName { get; set; }
        public string DocumentVersion { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string ForemanName { get; set; }

        // Constructor
        public rptDailytoolboxDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
