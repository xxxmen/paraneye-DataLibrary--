
#region UsergroupDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: UsergroupDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:08:04 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class UsergroupDTO : DTOBase
    {
        public int UserGroupID { get; set; }
        public string UserGroupName { get; set; }
        

        // Constructor
        public UsergroupDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
