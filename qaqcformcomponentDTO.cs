using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Element.Reveal.DataLibrary
{
    public class QaqcformcomponentDTO : DTOBase
    {
        public int QAQCFormComponentID { get; set; }
        public int QAQCFormID { get; set; }
        public int ComponentID { get; set; }

        // Constructor
        public QaqcformcomponentDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
