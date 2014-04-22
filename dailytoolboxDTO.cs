
#region DailytoolboxDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: DailytoolboxDTO.cs
// Author: 
// Date: August-18-13
// Time: 4:40:09 PM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class DailytoolboxDTO : DTOBase
    {
        public int DailyToolboxID { get; set; }
        public int DailyBrassID { get; set; }
        public int SPCollectionID { get; set; }
        public string DocumentName { get; set; }
        public string DocumentVersion { get; set; }
        

        // Constructor
        public DailytoolboxDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }

    public class DailytoolboxAndToolboxsign
    {
        public List<DailytoolboxDTO> dailytoolbox { get; set; }
        public List<ToolboxsignDTO> toolboxsign { get; set; }
    }
}
