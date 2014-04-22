
#region FiwpqaqcDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: FiwpqaqcDTO.cs
// Author: Woojong You
// Date: Oct-27-13
// Time: 7:42:08 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class FiwpqaqcDTO : DTOBase
    {
        public int FIWPQAQCID { get; set; }
        public int FIWPID { get; set; }
        public int CWPID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int Qty { get; set; }
        public int QAQCFormTemplateID { get; set; }
        public int QAQCFormTypeLUID { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public string QAQCFormTemplateName { get; set; }
        public string QAQCFormCode { get; set; }
        public string QAQCFormRev { get; set; }
        public int QAQCTypeLUID { get; set; }
        public string Description { get; set; }
        public int Downloaded { get; set; }
        public int IsCreated { get; set; }

        // Constructor
        public FiwpqaqcDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
