#region UserLookupDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: UserLookupDTO.cs
// Author: Wonjun Cho
// Date: April-12-13
// Time: 04:16:50 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class UserlookupDTO : DTOBase
    {
        public int LookupID { get; set; }
        public string LookupType { get; set; }
        public string LookupValue { get; set; }
        public int DisplayOrder { get; set; }
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
        [XmlElement(IsNullable = true)]
        public string LookupSubType { get; set; }
        public int IsActive { get; set; }
        public int ExtraValue { get; set; }
        
        // Constructor
        public UserlookupDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class UserlookupCityDTO : DTOBase
    {
        public int LookupID { get; set; }
        public string LookupType { get; set; }
        public string LookupValue { get; set; }
        public int DisplayOrder { get; set; }
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
        [XmlElement(IsNullable = true)]
        public string LookupSubType { get; set; }
        public int IsActive { get; set; }
        public int ExtraValue { get; set; }
        public int ProvinceID { get; set; }
        public int CountryID { get; set; }
        [XmlElement(IsNullable = true)]
        public string ProvinceName { get; set; }
        [XmlElement(IsNullable = true)]
        public string CountryName { get; set; }

        // Constructor
        public UserlookupCityDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
