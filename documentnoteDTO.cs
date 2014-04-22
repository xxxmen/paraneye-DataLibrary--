using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class DocumentnoteDTO : DTOBase
    {
        public int DocumentNoteID { get; set; }
        public int DocumentID { get; set; }
        public int DrawingID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int CWPID { get; set; }
        public int ProjectScheduleID { get; set; }
        public int FIWPID { get; set; }
        public DateTime UpdatedDate { get; set; }
        public decimal LocationX { get; set; }
        public decimal LocationY { get; set; }
        
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }

        public DocumentnoteDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
