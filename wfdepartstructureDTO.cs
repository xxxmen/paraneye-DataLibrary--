
#region WfdepartstructureDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: WfdepartstructureDTO.cs
// Author: 
// Date: Tuesday, January 21, 2014
// Time: 5:53:01 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

namespace Element.Reveal.DataLibrary
{
    public class WfdepartstructureDTO 
    {
        public int wfdepartstructureID { get; set; }
        public int departstructureID { get; set; }
        public int departmentID { get; set; }
        public int ClassLevel { get; set; }
        public byte IsActive { get; set; }
        public int ProjectID { get; set; }
        public string DisciplineCode { get; set; }
        

	public int DTOStatus { get; set; }

        // Constructor
        public WfdepartstructureDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
