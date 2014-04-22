
#region SkillDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: SkillDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:08:01 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class SkillDTO : DTOBase
    {
        public int SkillID { get; set; }
        public string SkillName { get; set; }
        public string DisciplineCode { get; set; }
        

        // Constructor
        public SkillDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
