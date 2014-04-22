
#region LibpipematerialgrpDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LibpipematerialgrpDTO.cs
// Author: 
// Date: July-10-11
// Time: 1:41:23 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class LibpipematerialgrpDTO : DTOBase
    {
        public int LibPipeMaterialGrpID { get; set; }
        public string MaterialCode { get; set; }
        

        // Constructor
        public LibpipematerialgrpDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
