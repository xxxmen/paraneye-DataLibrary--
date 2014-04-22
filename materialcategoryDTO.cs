
#region MaterialcategoryDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: MaterialcategoryDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:51 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class MaterialcategoryDTO : DTOBase
    {
        public int MaterialCategoryID { get; set; }
        public string DisciplineCode { get; set; }
        public string Description { get; set; }
        

        // Constructor
        public MaterialcategoryDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
