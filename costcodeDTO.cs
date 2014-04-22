
#region CostcodeDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: CostcodeDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:40 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    [DataContract]
    public class CostcodeDTO : DTOBase
    {
        [DataMember] 
        public int CostCodeID { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string CostCode { get; set; }
        [DataMember] 
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
        [DataMember]
        public int OwnerCompanyID { get; set; }
        [DataMember]
        public int UOMLUID { get; set; }


        // Constructor
        public CostcodeDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
