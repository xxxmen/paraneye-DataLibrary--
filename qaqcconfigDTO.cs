
#region QaqcconfigDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: QaqcconfigDTO.cs
// Author: Woojong You
// Date: Oct-27-13
// Time: 8:44:08 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class QaqcconfigDTO : DTOBase
    {
        public int QAQCConfigID { get; set; }
        public int QAQCFormTemplateID { get; set; }
        public string QAQCFormName { get; set; }
        public int RespLUID { get; set; }
        public int DisplayOrder { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        
        // Constructor
        public QaqcconfigDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
