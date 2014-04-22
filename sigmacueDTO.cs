
#region SigmacueDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: SigmacueDTO.cs
// Author: 
// Date: September-03-13
// Time: 8:38:09 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;
namespace Element.Reveal.DataLibrary
{
    public class SigmacueDTO : DTOBase
    {
        public int SigmaCueID { get; set; }
        [XmlElement(IsNullable = true)]
        public string SentBy { get; set; }
        public DateTime SentDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string SentTo { get; set; }
        public int SentToPersonnelId { get; set; }
        public DateTime DueDate { get; set; }
        [XmlElement(IsNullable = true)]
        public string Task { get; set; }
        public int SPCollectionID { get; set; }
        public int DataID { get; set; }
        public int StatusID { get; set; }
        public int IsActive { get; set; }
        [XmlElement(IsNullable = true)]
        public string Comments { get; set; }
        

        // Constructor
        public SigmacueDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
