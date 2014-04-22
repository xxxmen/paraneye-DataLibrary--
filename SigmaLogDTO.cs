
#region SigmaLogDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: SigmaLogDTO.cs
// Author: 
// Date: Tuesday, January 21, 2014
// Time: 5:52:52 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

namespace Element.Reveal.DataLibrary
{
    public class SigmaLogDTO 
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Thread { get; set; }
        public string Level { get; set; }
        public string Logger { get; set; }
        public string Message { get; set; }
        public string Exception { get; set; }
        

	public int DTOStatus { get; set; }

        // Constructor
        public SigmaLogDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
