
#region LookupDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LookupDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:50 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class LookupDTO : DTOBase
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
        public LookupDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
