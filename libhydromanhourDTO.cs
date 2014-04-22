
#region LibhydromanhourDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibhydromanhourDTO.cs
// Author: 
// Date: January-10-13
// Time: 4:49:02 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class LibhydromanhourDTO : DTOBase
    {
        public int LibHydroManhourID { get; set; }
        public int PipeTypeLUID { get; set; }
        public decimal PipeSize { get; set; }
        public string PipeSchedule { get; set; }
        public string PipeClass { get; set; }
        public decimal Manhours { get; set; }
        public int UOMLUID { get; set; }
        

        // Constructor
        public LibhydromanhourDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
