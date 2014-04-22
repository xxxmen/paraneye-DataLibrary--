using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Element.Reveal.DataLibrary
{
    public class DrawingcwpDTO : DTOBase
    {
        public int DrawingCWPID { get; set; }
        public int DrawingID { get; set; }
        public int CWPID { get; set; }
        public string CWPName { get; set; }


        // Constructor
        public DrawingcwpDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
