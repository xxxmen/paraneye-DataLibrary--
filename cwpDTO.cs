
#region CwpDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: CwpDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:41 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class CwpDTO : DTOBase
    {
        public int CWPID { get; set; }
        [XmlElement(IsNullable = true)]
        public string CWPName { get; set; }
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
        public int CWAID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int OwnerID { get; set; }
        [XmlElement(IsNullable = true)]
        public string ModuleTypeDesc { get; set; }
        [XmlElement(IsNullable = true)]
        public string CWAName { get; set; }
        [XmlElement(IsNullable = true)]
        public string DisciplineName { get; set; }

        // Constructor
        public CwpDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
