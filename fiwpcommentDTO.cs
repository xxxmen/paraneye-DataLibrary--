
#region FiwpcommentDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: FiwpcommentDTO.cs
// Author: 
// Date: November-28-11
// Time: 6:46:41 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class FiwpcommentDTO : DTOBase
    {
        public int FIWPCommentID { get; set; }
        public int FIWPID { get; set; }
        public DateTime WorkDate { get; set; }
        public string Activities { get; set; }
        public string LookHead { get; set; }
        public string Concern { get; set; }
        

        // Constructor
        public FiwpcommentDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
