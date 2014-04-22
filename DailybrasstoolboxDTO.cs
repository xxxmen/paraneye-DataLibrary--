
#region DailytoolboxDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: DailytoolboxDTO.cs
// Author: 
// Date: August-18-13
// Time: 4:40:09 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class DailybrasstoolboxDTO : DTOBase
    {
        public int DailyBrassToolboxId { get; set; }
        public int DailyBrassId { get; set; }
        public int SafetyDocId { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedDate { get; set; }
        
        // Constructor
        public DailybrasstoolboxDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

}
