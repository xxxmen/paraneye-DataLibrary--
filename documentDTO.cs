
#region DocumentDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: DocumentDTO.cs
// Author: 
// Date: January-10-12
// Time: 10:56:26 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class DocumentDTO : DTOBase
    {
        public int DocumentID { get; set; } //IwpDocumentId
        [XmlElement(IsNullable = true)]
        public string DocumentTypeLUID { get; set; }
        public int CWPID { get; set; }
        public int ProjectID { get; set; }
        [XmlElement(IsNullable = true)]
        public string DisciplineCode { get; set; }
        public int ProjectScheduleID { get; set; }
        public int FIWPID { get; set; }
        [XmlElement(IsNullable = true)]
        public string LocationURL { get; set;}
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int RFIID { get; set; }
        public int SPCollectionID { get; set; } //UploadedFileInfoId
        [XmlElement(IsNullable = true)]
        public string Group { get; set; }
        [XmlElement(IsNullable = true)]
        public string PersonnelID { get; set; }
        //2014.02.26 add
        [XmlElement(IsNullable = true)]
        public string IsDisplayable { get; set; }
        //2014.03.04 add
        [XmlElement(IsNullable = true)]
        public string FileExtension { get; set; }
        //2014.03.05 add        
        public int FileStoreId { get; set; }
        //2014.03.06 add      
        [XmlElement(IsNullable = true)]
        public string FileCategory { get; set; }
        //2014.03.11 add      
        [XmlElement(IsNullable = true)]
        public string FileRef { get; set; }
        //2014.03.20 add      
        [XmlElement(IsNullable = true)]
        public string SortOrder { get; set; }

        // Constructor
        public DocumentDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class FiwpDocument
    {
        public List<DrawingDTO> drawing { get; set; }
        public List<DocumentDTO> WFP { get; set; }
        public List<DocumentDTO> QAQC { get; set; }
        public List<DocumentDTO> SafetyDoc { get; set; }
        public List<DocumentDTO> RFIDoc { get; set; }
    }

    public class DocumentAndDrawing
    {
        public List<DrawingDTO> drawings { get; set; }
        public List<DocumentDTO> documents { get; set; }
    }
}
