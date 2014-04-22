
#region PageDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: PageDTO.cs
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
    public class PageDTO : DTOBase
    {
        public int PageID { get; set; }
        public string PageName { get; set; }
        public string PageCode { get; set; }
        public string DisciplineCode { get; set; }
        

        // Constructor
        public PageDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
    
    public class PageAndPageusergroup
    {
        public PageDTO page { get; set; }
        public List<PageusergroupDTO> pageusergroup { get; set; }
    }
}
