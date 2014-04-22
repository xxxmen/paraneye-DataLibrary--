using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class FiwpworkflowDTO : DTOBase
    {
        public int FiwpWorkflowID { get; set; }
        public int FiwpID { get; set; }
        public int DepartStructureID { get; set; }
        public int IsApproved { get; set; }
        public DateTime AssignedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string AssignedBy { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string Comments { get; set; }
        public int ParentWorkflowID { get; set; }
        [XmlElement(IsNullable = true)]
        public string AssignedTo { get; set; }
        public string PersonnelId { get; set; }
        public int DepartmentID { get; set; }

        public int CwpID { get; set; }
        [XmlElement(IsNullable = true)]
        public string CwpName { get; set; }
        [XmlElement(IsNullable = true)]
        public string FiwpName { get; set; }
        [XmlElement(IsNullable = true)]
        public string DepartmentName { get; set; }
        [XmlElement(IsNullable = true)]
        public string EMail { get; set; } //This is for UI to store data 

        //public string AssignedToAcronym { get; set; }

        //public int DepartTypeLUID { get; set; }
        //public int IsFirstAssignment { get; set; }

        // Constructor
        public FiwpworkflowDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
