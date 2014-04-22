using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class LibinsulpipemanhourDTO : DTOBase
    {
        public int LibInsulPipeManhourID { get; set; }
        public decimal PipeSize { get; set; }
        public int Layer { get; set; }
        public decimal Manhours { get; set; }

        // Constructor
        public LibinsulpipemanhourDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class LibinsulpipemanhourPageTotal
    {
        public List<LibinsulpipemanhourDTO> lib { get; set; }
        public int TotalPageCount { get; set; }
    }

}

