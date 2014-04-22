
#region SystemDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: SystemDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:08:02 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class SystemDTO : DTOBase
    {
        public int SystemID { get; set; }
        [XmlElement(IsNullable = true)]
        public string SystemName { get; set; }
        [XmlElement(IsNullable = true)]
        public string SystemNumber { get; set; }
        public int SystemTypeLUID { get; set; }
        public int ProjectID { get; set; }
        public int OwnerID { get; set; }
        [XmlElement(IsNullable = true)]
        public string SystemTypeDesc { get; set; }
        public int SystemGroupLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string SystemGroupDesc { get; set; }
        public int Priority { get; set; }
        public DateTime CWD_Date { get; set; }
        public DateTime CC_Date { get; set; }
        public DateTime FWD_Date { get; set; }
        public DateTime MC_Date { get; set; }
        public DateTime TCCC_Date { get; set; }

        // Constructor
        public SystemDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
