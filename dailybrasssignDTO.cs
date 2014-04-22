
#region DailybrasssignDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: DailybrasssignDTO.cs
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
    public class DailybrasssignDTO : DTOBase
    {
        public int DailyBrassSignId { get; set; }
        public int DailyBrassId { get; set; }
        public int PersonnelId { get; set; }
        public DateTime SignInDate { get; set; }
        public DateTime SignOutDate { get; set; }
        public DateTime ToolboxSignedDate { get; set; }
        public int NfcUid { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedDate { get; set; }

        //테이블외 추가구성
        [XmlElement(IsNullable = true)]
        public string PersonnelName { get; set; }

        // Constructor
        public DailybrasssignDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
