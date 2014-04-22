
#region EmpclassDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: EmpclassDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:45 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class EmpclassDTO : DTOBase
    {
        public int EmpClassID { get; set; }
        public string EmpClassName { get; set; }
        public int EmpClassTypeLUID { get; set; }
        public string DisciplineCode { get; set; }
        

        // Constructor
        public EmpclassDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
