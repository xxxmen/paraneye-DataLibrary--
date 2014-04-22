
#region DrawingsdrefDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: DrawingsdrefDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:44 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class DrawingsdrefDTO : DTOBase
    {
        public int DrawingsSDRefID { get; set; }
        public int DrawingID { get; set; }
        public int SDID { get; set; }
        [XmlElement(IsNullable = true)]
        public string DrawingName { get; set; }

        // Constructor
        public DrawingsdrefDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
