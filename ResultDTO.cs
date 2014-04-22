
#region AreaDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: AreaDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:38 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class ResultDTO : DTOBase
    {
        public string KeyName {get; set;} //tagnumber, drawingName, etc or 'Exception'
        public string Message { get; set;} //description
        public string Source { get; set; }
        public string StackTrace { get; set; }

        // Constructor
        public ResultDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
