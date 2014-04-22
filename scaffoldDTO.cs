
#region ScaffoldDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ScaffoldDTO.cs
// Author: 
// Date: October-26-11
// Time: 5:28:31 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class ScaffoldDTO : DTOBase
    {
        public int ScaffoldID { get; set; }
        public string TagNumber { get; set; }
        public int ScaffoldStyleLUID { get; set; }
        public int CWPID { get; set; }
        public int ProjectID { get; set; }
        public decimal Elevation { get; set; }
        public decimal Elevation1 { get; set; }
        public decimal Elevation2 { get; set; }
        public decimal Length { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Weight { get; set; }
        public int ScaffoldStatusLUID { get; set; }
        public DateTime ErectedDate { get; set; }
        public DateTime RemovedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int ISRFO { get; set; }
        public DateTime RFODate { get; set; }
        public int IsActive { get; set; }
        public int SystemType { get; set; }
        public string LocationDesc { get; set; }

        // Constructor
        public ScaffoldDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
