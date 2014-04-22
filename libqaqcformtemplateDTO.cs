
#region LibqaqcformtemplateDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibqaqcformtemplateDTO.cs
// Author: 
// Date: June-17-11
// Time: 4:53:22 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class LibqaqcformtemplateDTO : DTOBase
    {
        public int LibQaqcformtemplateID { get; set; }
        public int LibID { get; set; }
        public int QAQCFormTemplateID { get; set; }
        public int TaskCategoryID { get; set; }
        public int ProjectID { get; set; }

        // Constructor
        public LibqaqcformtemplateDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
