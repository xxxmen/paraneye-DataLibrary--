
#region EwrDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: EwrDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:46 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class EwrDTO : DTOBase
    {
        public int EWRID { get; set; }
        public string EWRCode { get; set; }
        public string Description { get; set; }
        public string WPN { get; set; }
        public int ChargeOutRate { get; set; }
        public int ProfitMargin { get; set; }
        public int MatMarkUp { get; set; }
        public int OHMarkUp { get; set; }
        public string RFI { get; set; }
        public string ECN { get; set; }
        public string FCN { get; set; }
        public string TREND { get; set; }
        public string CCN { get; set; }
        public int EstGroundingLabour { get; set; }
        public int EstEquipLabour { get; set; }
        public int EstLightingLabour { get; set; }
        public int EstRacewayLabour { get; set; }
        public int EstInstrLabour { get; set; }
        public int EstEHTLabour { get; set; }
        public int EstCableLabour { get; set; }
        public int EstTermLabour { get; set; }
        public double EstMaterialCosts { get; set; }
        public double EstEquipCosts { get; set; }
        public string CurrentPhase { get; set; }
        public int ProjectID { get; set; }
        

        // Constructor
        public EwrDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
