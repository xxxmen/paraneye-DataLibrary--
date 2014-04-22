
#region rptToolboxsignDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: rptToolboxsignDTO.cs
// Author: 
// Date: August-18-13
// Time: 4:40:10 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class rptToolboxsignDTO : DTOBase
    {
        public int ToolboxSignID { get; set; }
        public int DailyBrassID { get; set; }
        public int MyDepartStructureID { get; set; }
        public int MyPersonnelID { get; set; }
        public DateTime SignTimestamp { get; set; }
        public int NFCUID { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string PersonnelName { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string EmployeeCode { get; set; }

        // Constructor
        public rptToolboxsignDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
