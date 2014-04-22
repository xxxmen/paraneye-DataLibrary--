
#region PoDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: PoDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:54 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class PoDTO : DTOBase
    {
        public int POID { get; set; }
        public string PONumber { get; set; }
        public int ProjectID { get; set; }
        public int MaterialCategoryID { get; set; }
        public int SupplierID { get; set; }
        public string Description { get; set; }
        public int IsActive { get; set; }
        public DateTime NeedDt { get; set; }
        public DateTime CreatedDt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime ModifiedDt { get; set; }
        public string ModifiedBy { get; set; }
        

        // Constructor
        public PoDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
