#region LogintraceDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LogintraceDTO.cs
// Author: 
// Date: July-13-12
// Time: 12:45:35 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class LogintraceDTO : DTOBase
    {
        public int TraceID { get; set; }
        public string InstanceDB { get; set; }
        public string LoginAccount { get; set; }
        public string LoginedIP { get; set; }
        public string LoginedIPLocation { get; set; }
        public DateTime CreatedDate { get; set; }


        // Constructor
        public LogintraceDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
