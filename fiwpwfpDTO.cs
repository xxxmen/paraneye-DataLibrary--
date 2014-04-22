
#region FiwpwfpDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: FiwpwfpDTO.cs
// Author: 
// Date: March-01-12
// Time: 4:53:08 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class FiwpwfpDTO : DTOBase
    {
        public int FIWPWFPID { get; set; }
        public int FIWPID { get; set; }
        [XmlElement(IsNullable = true)]
        public string Scope { get; set; }
        [XmlElement(IsNullable = true)]
        public string Lesson { get; set; }
        [XmlElement(IsNullable = true)]
        public string SafetyTrain { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        

        // Constructor
        public FiwpwfpDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
