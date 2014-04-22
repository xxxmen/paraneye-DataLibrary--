
#region LibpipesupmanhourDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibpipesupmanhourDTO.cs
// Author: 
// Date: July-10-11
// Time: 1:41:23 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class LibpipesupmanhourDTO : DTOBase
    {
        public int LibPipeSupManhourID { get; set; }
        public int PipeSupportLUID { get; set; }
        public decimal Manhours { get; set; }
        [XmlElement(IsNullable = true)]
        public string SupportType { get; set; }
        
        // Constructor
        public LibpipesupmanhourDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class LibpipesupmanhourPageTotal
    {
        public List<LibpipesupmanhourDTO> lib { get; set; }
        public int TotalPageCount { get; set; }
    }
}
