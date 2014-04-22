using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class RfidrawingDTO : DTOBase
    {
        public int RFIDrawingID { get; set; }        
        public int RFIID { get; set; }    
        public int CWPID { get; set; }
        public int DrawingID { get; set; }
        [XmlElement(IsNullable = true)]
        public string RevisionNo { get; set; }    
        
        // Constructor
        public RfidrawingDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

}