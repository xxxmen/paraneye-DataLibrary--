
#region TagnumberdrawingDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: TagnumberdrawingDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:08:02 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class TagnumberdrawingDTO : DTOBase
    {
        public int TagnumberDrawingID { get; set; }
        public int ComponentID { get; set; }
        public int DrawingID { get; set; }
        [XmlElement(IsNullable = true)]
        public string TagNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string EngTagNumber { get; set; }
        public int DrawingTypeID { get; set; }
        [XmlElement(IsNullable = true)]
        public string DrawingName { get; set; }
        [XmlElement(IsNullable = true)]
        public string Revision { get; set; }
        

        // Constructor
        public TagnumberdrawingDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
