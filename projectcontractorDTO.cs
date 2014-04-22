using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class ProjectcontractorDTO : DTOBase
    {
        public int ProjectContractorID { get; set; }
        public int ProjectID { get; set; }
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }

        // Constructor
        public ProjectcontractorDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
