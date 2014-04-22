
#region ProgressDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ProgressDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:56 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class UploadedFileInfoDTO : DTOBase
    {
        public int UploadedFileInfoId { get; set; }
        public int FileStoreId { get; set; }
        [XmlElement(IsNullable = true)]
        public string Name { get; set; }
        public int Size { get; set; }
        [XmlElement(IsNullable = true)]
        public string Path { get; set; }
        [XmlElement(IsNullable = true)]
        public string UploadedBy { get; set; }
        public DateTime UploadedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string FileExtension { get; set; }
        public int Revision { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string CreatedDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedBy { get; set; }
        [XmlElement(IsNullable = true)]
        public string UpdatedDate { get; set; }

        //upload file byte
        [XmlElement(IsNullable = true)]
        public byte[] byteFile { get; set; }

        // Constructor
        public UploadedFileInfoDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class UpfileDTOS
    {
        public List<FileStoreDTO> fileStoreDTOList { get; set; }
        public List<UploadedFileInfoDTO> uploadedFileDTOList { get; set; }
    }

    public class UploadFileDTO
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public byte[] FileByte { get; set; }
    }

}