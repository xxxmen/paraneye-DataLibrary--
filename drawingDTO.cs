
#region DrawingDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: DrawingDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:42 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace Element.Reveal.DataLibrary
{
    
    [DataContract]
    public class DrawingDTO : DTOBase
    {   
        [DataMember]
        public int DrawingID { get; set; }
        [DataMember]
        public string DrawingName { get; set; }        
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string DrawingSheetNo { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string DrawingSequenceNo { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string Description { get; set; }
        [DataMember]
        public int MaterialCategoryID { get; set; }
        [DataMember]
        public int CWPID { get; set; }
        [DataMember]
        public int ProjectID { get; set; }
        [DataMember]
        public string DisciplineCode { get; set; }        
        [DataMember]
        public int ChangeOrderNo { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string Comments { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string TypeDesc { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string DrawingFilePath { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string DrawingFileURL { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string DrawingTypeLUID { get; set; }
        [DataMember]
        public int DrawingRevisionID { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string RevisionNo { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string Rev { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string CWPName { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string DrawingType { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string DrawingNo { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string ParentDrawingName { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string PID { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string RefDrawingName { get; set; }
        [DataMember]
        public int RefDrawingTypeLUID { get; set; }
        [DataMember]
        public int SPCollectionID { get; set; }
        [DataMember]
        public int IsActive { get; set; }
        [DataMember]
        public int IsRedline { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string OriginalDrawingFileURL { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public string SPRevisionNo { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public List<DrawingcwpDTO> drawingcwp { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public List<DrawingreferenceDTO> drawingref { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public List<ComboBoxDTO> mto { get; set; }
        [DataMember]
        [XmlElement(IsNullable = true)]
        public byte[] DrawingFileByte { get; set; }
        //2014.03.26 add
        [DataMember]
        public int FileStoreId { get; set; }

        // Constructor
        public DrawingDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class DrawingPageTotal
    {
        public List<DrawingDTO> drawing { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPageCount { get; set; }
        public int TotalRowCount { get; set; }
    }

    public class DrawingAndMarkup
    {
        public DrawingDTO drawing { get; set; }
        public List<DocumentmarkupDTO> markup { get; set; }
    }

    public class ByteTypeDTO
    {
        public string DrawingName { get; set; }
        public byte[] DrawingFileByte { get; set; }
        public string DrawingBase64 { get; set; }
    }
}
