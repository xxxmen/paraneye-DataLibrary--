
#region QclistDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: QclistDTO.cs
// Author: 
// Date: Tuesday, January 21, 2014
// Time: 5:52:48 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

namespace Element.Reveal.DataLibrary
{
    public class QclistDTO 
    {
        public string CODE1 { get; set; }
        public string CODE2 { get; set; }
        public string REV { get; set; }
        public string Desc { get; set; }
        

	public int DTOStatus { get; set; }

        // Constructor
        public QclistDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
