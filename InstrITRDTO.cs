
#region InstrITRDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: InstrITRDTO.cs
// Author: 
// Date: Tuesday, January 21, 2014
// Time: 5:52:28 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

namespace Element.Reveal.DataLibrary
{
    public class InstrITRDTO 
    {
        public string Instrumentation { get; set; }
        public string Description { get; set; }
        public string TypicalEQTag { get; set; }
        public string MRR { get; set; }
        public string Cal { get; set; }
        public string Install { get; set; }
        public string TubingInstall { get; set; }
        public string TubPressTest { get; set; }
        public string Loop { get; set; }
        

	public int DTOStatus { get; set; }

        // Constructor
        public InstrITRDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
