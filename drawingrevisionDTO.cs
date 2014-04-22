
#region DrawingrevisionDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: DrawingrevisionDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:43 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class DrawingrevisionDTO : DTOBase
    {
        public int DrawingRevisionID { get; set; }
        public int DrawingID { get; set; }
        [XmlElement(IsNullable = true)]
        public string RevisionNo { get; set; }
        [XmlElement(IsNullable = true)]
        public string DrawingFileURL { get; set; }
        public int OriginalRevID { get; set; }
        public DateTime CreatedDt { get; set; }
        public int CreatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string SPRevisionNo { get; set; }

        // Constructor
        public DrawingrevisionDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
