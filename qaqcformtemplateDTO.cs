
#region QaqcformtemplateDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: QaqcformtemplateDTO.cs
// Author: 
// Date: May-12-11
// Time: 2:26:08 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class QaqcformtemplateDTO : DTOBase
    {
        public int QAQCFormTemplateID { get; set; }
        public string QAQCFormTemplateName { get; set; }
        public string QAQCFormCode { get; set; }
        public string QAQCFormRev { get; set; }
        public int QAQCTypeLUID { get; set; }
        public string Description { get; set; }
        public int QAQCFormTypeLUID { get; set; }
        //2013-12-09 add
        public decimal QAQCFormManhours { get; set; }

        // Constructor
        public QaqcformtemplateDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
