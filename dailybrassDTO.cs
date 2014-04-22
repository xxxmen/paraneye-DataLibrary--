
#region DailybrassDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: DailybrassDTO.cs
// Author: 
// Date: August-19-13
// Time: 7:13:37 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class DailybrassDTO : DTOBase
    {
        public int DailyBrassID { get; set; }
        public int ProjectID { get; set; }
        [XmlElement(IsNullable = true)]
        public string ForemanID { get; set; }
        [XmlElement(IsNullable = true)]
        public string DisciplineCode { get; set; }
        public DateTime WorkDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedDate { get; set; }

        // Constructor
        public DailybrassDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
