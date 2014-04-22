
#region QaqcformDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: QaqcformDTO.cs
// Author: 
// Date: May-12-11
// Time: 2:26:07 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class QaqcformDTO : DTOBase
    {
        public int QAQCFormID { get; set; }
        public int QAQCFormTemplateID { get; set; }
        public int ComponentID { get; set; }
        [XmlElement(IsNullable = true)]
        public string KeyValue { get; set; }
        public int FIWPID { get; set; }
        public int ProjectScheduleID { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        public int IsSubmitted { get; set; }
        [XmlElement(IsNullable = true)]
        public string SavedFileURL { get; set; }

        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        [XmlElement(IsNullable = true)]
        public string ContractorSignOffBy { get; set; }
        public DateTime ContractorSignOffDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string ClientSignOffBy { get; set; }
        public DateTime ClientSignOffDate { get; set; }

        [XmlElement(IsNullable = true)]
        public string TechnicianSignOffBy { get; set; }
        public DateTime TechnicianOffDate { get; set; }

        [XmlElement(IsNullable = true)]
        public string ContractorTitle { get; set; }
        [XmlElement(IsNullable = true)]
        public string ClientTitle { get; set; }
        [XmlElement(IsNullable = true)]
        public string TechnicianTitle { get; set; }

        [XmlElement(IsNullable = true)]
        public string Comments { get; set; }
        public string Inspector { get; set; } //full name of updatedBy
        public string KeyType { get; set; } // type of KeyValue

        public int SystemID { get; set; }
        public int DrawingID { get; set; }        
        [XmlElement(IsNullable = true)]
        public string DrawingName { get; set; }
        
        public List<QaqcformdetailDTO> QaqcfromDetails { get; set; }
        public List<DrawingDTO> QaqcrefDrawing { get; set; }
        
        public int SPCollectionID { get; set; }        

        [XmlElement(IsNullable = true)]
        public string TagNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string ProjectName { get; set; }
        [XmlElement(IsNullable = true)]
        public string ProjectNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string JobNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string SystemNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string SystemName { get; set; }
        [XmlElement(IsNullable = true)]
        public string CWPName { get; set; }
        [XmlElement(IsNullable = true)]
        public string FIWPName { get; set; }

        public int ApprovalStatusLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string ApprovalStatus { get; set; }
        public int DownloadStatus { get; set; }
        public DateTime PartialDate { get; set; }
        public DateTime AssembledDate { get; set; }
        public int QAQCDataTypeLUID { get; set; }
        
        // Constructor
        public QaqcformDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
            QaqcfromDetails = new List<QaqcformdetailDTO>();
            QaqcrefDrawing = new List<DrawingDTO>();            
        }
    }
    
    public class LineDesignationDTO : DTOBase
    {
        public int LineDesignationID { get; set; }
        [XmlElement(IsNullable = true)]
        public string LineClass { get; set; }

        [XmlElement(IsNullable = true)]
        public string ISOLineNo { get; set; }

        [XmlElement(IsNullable = true)]
        public string TestType { get; set; }

        [XmlElement(IsNullable = true)]
        public string TestPres { get; set; }

        [XmlElement(IsNullable = true)]
        public string TestMedium { get; set; }

        [XmlElement(IsNullable = true)]
        public string FlowFrom { get; set; }

        [XmlElement(IsNullable = true)]
        public string FlowTo { get; set; }
    }
}
    