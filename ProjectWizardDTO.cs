#region ProjectWizardDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ProjectWizardDTO.cs
// Author: PhileSeung Lee
// Date: June-16-13
// Time: 6:02:34 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class ProjectWizardDTO : DTOBase
    {
        // Constructor
        public ProjectWizardDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class Project
    {
        public List<ProjectDTO> project { get; set; }
    }

    public class ProjectModule
    {
        public List<ProjectmoduleDTO> projectModule { get; set; }
    }

    public class Projectcontractor
    {
        public List<ProjectcontractorDTO> projectcontractor { get; set; }
    }
}