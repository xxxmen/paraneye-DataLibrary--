
#region RfiDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: RfiDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:08:00 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class RfiDTO : DTOBase
    {
        public int RFIID { get; set; }
        [XmlElement(IsNullable = true)]
        public string RFINumber { get; set; }        
        public DateTime RFIDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string ClientRFINumber { get; set; }
        public int SignedOff { get; set; }        
        public DateTime SignedOffDate { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
        [XmlElement(IsNullable = true)]
        public string ClientRFIFileLocation { get; set; }
        public int CWPID { get; set; }
        public int CWAID { get; set; }
        public int DrawingID { get; set; }
        [XmlElement(IsNullable = true)]
        public string InformationRequested { get; set; }
        [XmlElement(IsNullable = true)]
        public string ReasonRequested { get; set; }
        public DateTime DateReplyRequired { get; set; }
        [XmlElement(IsNullable = true)]
        public string RemindialProposal { get; set; }
        [XmlElement(IsNullable = true)]
        public string PreparedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string ContractorCompany { get; set; }
        public DateTime DateSubmitted { get; set; }
        [XmlElement(IsNullable = true)]
        public string RFICoordinator { get; set; }
        public DateTime RFICoordinatorDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string ReponsibleEngineer { get; set; }
        public DateTime ReponsibleEngineerDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string ResponseImpacts { get; set; }        
        [XmlElement(IsNullable = true)]
        public string ResponseBy { get; set; }
        public DateTime ResponseDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string ChangeManagementCode { get; set; }
        public int IsSubmitted { get; set; }
        public int FollowUPDocTypeLUID { get; set; }

        // Constructor
        public RfiDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
