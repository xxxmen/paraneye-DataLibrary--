
#region ProjectDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ProjectDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:57 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class ProjectDTO : DTOBase
    {
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        [XmlElement(IsNullable = true)]
        public string ProjectNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string ClientName { get; set; }
        [XmlElement(IsNullable = true)]
        public string ClientLogoFileName { get; set; }
        [XmlElement(IsNullable = true)]
        public string ClientProjName { get; set; }
        [XmlElement(IsNullable = true)]
        public string GeneralContractor { get; set; }
        [XmlElement(IsNullable = true)]
        public string SPURL { get; set; }
        [XmlElement(IsNullable = true)]
        public string JobNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string ContractNumber { get; set; }
        public int OwnerID { get; set; }
        public int CompanyID { get; set; }
        [XmlElement(IsNullable = true)]
        public string LogoFileName { get; set; }
        [XmlElement(IsNullable = true)]
        public string IFCImageLocation { get; set; }
        [XmlElement(IsNullable = true)]
        public string CityName { get; set; }
        public DateTime CreatedDt { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedBy { get; set; }
        public DateTime UpdatedDt { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        public int IsLocal { get; set; }
        public int WizardStep { get; set; }

        /// <summary>
        /// Additional Project Information for mpp project
        /// </summary>
        public int ProjectFileInfoID { get; set; }
        public string ProjectFileName { get; set; }
        public Nullable<DateTime> ProjectFileCreate { get; set; }
        public Nullable<DateTime> ProjectFileModify { get; set; }
        public string LastModifier { get; set; }


        // Constructor
        public ProjectDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class ProjectAndModule
    {
        public List<ProjectDTO> project { get; set; }
        public List<ProjectmoduleDTO> projectmodule { get; set; }
    }

    public class ProjectWizard
    {
        public int WizardStep { get; set; }
        public ProjectDTO project { get; set; }
        public List<ProjectmoduleDTO> projectmodule { get; set; }
        public List<ProjectcontractorDTO> projectcontractor { get; set; }
    }


}
