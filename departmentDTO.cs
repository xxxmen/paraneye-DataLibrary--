
#region DepartmentDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: DepartmentDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:42 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class DepartmentDTO : DTOBase
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public int ClassLevel { get; set; }
        public int Order { get; set; }
        public int DepartTypeLUID { get; set; }
        public int UserGroupID { get; set; }
        public int IsApprovalGroup { get; set; }

        // Constructor
        public DepartmentDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
