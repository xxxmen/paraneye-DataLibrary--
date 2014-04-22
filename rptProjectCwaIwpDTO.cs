using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class rptProjectCwaIwpDTO : DTOBase
    {
        public int ProjectID { get; set; }
        [XmlElement(IsNullable = true)]
        public string ProjectName { get; set; } //Ledcor Project
        [XmlElement(IsNullable = true)]
        public string LogoFilePath { get; set; } //Ledcor Logo        
        [XmlElement(IsNullable = true)]
        public string ClientProjectID { get; set; }
        [XmlElement(IsNullable = true)]
        public string ClientProjectName { get; set; } //Project
        public int ClientCompanyID { get; set; }
        [XmlElement(IsNullable = true)]
        public string ClientCompanyName { get; set; } //Client
        public int CwaID { get; set; }
        [XmlElement(IsNullable = true)]
        public string CwaName { get; set; } //CWA Ref        
        public int ProjectScheduleID { get; set; }
        [XmlElement(IsNullable = true)]
        public string ProjectScheduleName { get; set; } //Sch ID        
        public int FiwpID { get; set; }
        [XmlElement(IsNullable = true)]   
        public string FiwpName { get; set; } //FIWP
        [XmlElement(IsNullable = true)]
        public string Description { get; set; } //TITLE
        [XmlElement(IsNullable = true)]
        public string LeaderId { get; set; } //Foreman ID
        [XmlElement(IsNullable = true)]
        public string LeaderName { get; set; } //Foreman Name
        public DateTime StartDate { get; set; } //IWP StartDate
        public DateTime EndDate { get; set; } //IWP EndDate
        public Decimal TotalManhours { get; set; } //IWP TotalManhours
        
        public rptProjectCwaIwpDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
