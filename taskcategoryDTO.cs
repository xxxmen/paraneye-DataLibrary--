
#region TaskcategoryDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: TaskcategoryDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:08:03 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class TaskcategoryDTO : DTOBase
    {
        public int TaskCategoryID { get; set; }
        public string Description { get; set; }
        public string DisciplineCode { get; set; }
        public int MaterialCategoryID { get; set; }
        public string MaterialCategory { get; set; }
       

        // Constructor
        public TaskcategoryDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
