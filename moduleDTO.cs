
#region ModuleDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: ModuleDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:52 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class ModuleDTO : DTOBase
    {
        public string DisciplineCode { get; set; }
        public string DiciplineName { get; set; }
        public int IsActive { get; set; }
        

        // Constructor
        public ModuleDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
