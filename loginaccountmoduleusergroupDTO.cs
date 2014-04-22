
#region LoginaccountmoduleusergroupDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LoginaccountmoduleusergroupDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:50 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class LoginaccountmoduleusergroupDTO : DTOBase
    {
        public int LoginAccountID { get; set; }
        public int UserGroupID { get; set; }
        public string DisciplineCode { get; set; }

        public string UserGroup { get; set; }
        public string Module { get; set; }
        

        // Constructor
        public LoginaccountmoduleusergroupDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
