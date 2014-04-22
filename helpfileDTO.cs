
#region HelpfileDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: HelpfileDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:47 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class HelpfileDTO : DTOBase
    {
        public int HelpfileID { get; set; }
        public byte[] Video { get; set; }
        public string Video_Name { get; set; }
        public int Video_Size { get; set; }
        public string PageCode { get; set; }
        

        // Constructor
        public HelpfileDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
