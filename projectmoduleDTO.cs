#region ProjectmoduleDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ProjectModuleDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:57 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class ProjectmoduleDTO : DTOBase
    {
        public int ProjectModuleID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public string DisciplineName { get; set; }
        public int Checked { get; set; }

        // Constructor
        public ProjectmoduleDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
