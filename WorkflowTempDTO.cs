using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Element.Reveal.DataLibrary
{
    public class WorkflowTempDTO : DTOBase
    {
        public int WorkflowID { get; set; }
        public string PersonnelName { get; set; }
        public string Status { get; set; }
        public string FiwpName { get; set; }
        public string WorkflowType { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public DateTime WorkflowStartDate { get; set; }
        public DateTime WorkflowSaveDate { get; set; }
        public DateTime FiwpDate { get; set; }
        public string WorkflowLevel { get; set; }
                                                           
         // Constructor
        public WorkflowTempDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
