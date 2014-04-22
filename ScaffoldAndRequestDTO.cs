using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;


namespace Element.Reveal.DataLibrary
{
    public class ScaffoldAndRequestDTO : DTOBase
    {
        //ScaffoldDTO Fields
        public int ScaffoldID { get; set; }
        [XmlElement(IsNullable = true)]
        public string TagNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string FieldTagNumber { get; set; }
        public int ScaffTypeLUID { get; set; }
        [XmlElement(IsNullable = true)]
        public string FEPNumber { get; set; }
        [XmlElement(IsNullable = true)]
        public string ScaffoldDesc { get; set; }
        public int CWPID { get; set; }
        public int ProjectID { get; set; }
        public int ECoord { get; set; }
        [XmlElement(IsNullable = true)]
        public string ECoordLoc { get; set; }
        public int WestGridID { get; set; }
        public int NCoord { get; set; }
        [XmlElement(IsNullable = true)]
        public string NCoordLoc { get; set; }
        public int NorthGridID { get; set; }
        public float Elevation { get; set; }
        public float Elevation1 { get; set; }
        public float Elevation2 { get; set; }
        [XmlElement(IsNullable = true)]
        public string LocDescription { get; set; }
        public float Length { get; set; }
        public float Height { get; set; }
        public float Width { get; set; }
        public float Weight { get; set; }
        public int IsNewConstr { get; set; }
        public int IsMaint { get; set; }
        public int IsRevamp { get; set; }
        public DateTime ErectedDate { get; set; }
        public DateTime RemovedDate { get; set; }
        public int ISRFO { get; set; }
        public DateTime RFODate { get; set; }
        public decimal DailyRent { get; set; }
        public int IsActive { get; set; }
        public int SystemType { get; set; }

        //ScaffoldRequestDTO Fields
        public int ScaffoldRequestID { get; set; }        
        public int ScaffoldReqNumber { get; set; }
        public int RequestedBy { get; set; }
        public DateTime NeedByDate { get; set; }
        public DateTime NotNeedByDate { get; set; }
        public decimal ManhoursEstimate { get; set; }
        [XmlElement(IsNullable = true)]
        public string AddInfo { get; set; }
        [XmlElement(IsNullable = true)]
        public string WorkDesc { get; set; }
        [XmlElement(IsNullable = true)]
        public string DeckHeight { get; set; }
        [XmlElement(IsNullable = true)]
        public string MinScaffArea { get; set; }
        [XmlElement(IsNullable = true)]
        public string Clearance { get; set; }
        [XmlElement(IsNullable = true)]
        public string Hoarding { get; set; }
        [XmlElement(IsNullable = true)]
        public string SnapShot { get; set; }
        [XmlElement(IsNullable = true)]
        public string Other { get; set; }
        public int IsErect { get; set; }
        public int IsModify { get; set; }
        public int IsDismantle { get; set; }
        public int IsUse { get; set; }
        public int IsSubmited { get; set; }
        public DateTime SubmitDate { get; set; }
        public int IsApproved { get; set; }
        public DateTime ApprovedDate { get; set; }
        public int IsCompleted { get; set; }
        public DateTime CompletedDate { get; set; }
        public int IsEWO { get; set; }
        [XmlElement(IsNullable = true)]
        public string EWONumber { get; set; }  
        [XmlElement(IsNullable = true)]
        public string FullName { get; set; }
      
        // Constructor
        public ScaffoldAndRequestDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
