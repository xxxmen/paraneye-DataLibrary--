
#region PageusergroupDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: PageusergroupDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:53 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class PageusergroupDTO : DTOBase
    {
        public int PageusergroupID { get; set; }
        public int PageID { get; set; }
        public int UserGroupID { get; set; }
        public int ViewRole { get; set; }
        public int EditRole { get; set; }
        public int NewRole { get; set; }
        public int DeleteRole { get; set; }
        

        // Constructor
        public PageusergroupDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
