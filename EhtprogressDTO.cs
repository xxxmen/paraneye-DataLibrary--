
#region EhtprogressDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: EhtprogressDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:45 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;


namespace Element.Reveal.DataLibrary
{
    public class EhtprogressDTO : DTOBase
    {
        public int ProgressID { get; set; }
        public int Received { get; set; }
        public DateTime ReceivedDate { get; set; }
        public int FieldMeas { get; set; }
        public DateTime FieldMeasDate { get; set; }
        public string FieldMeasValue { get; set; }
        public int MegUponRecFieldMeas { get; set; }
        public DateTime MegUponRecFieldMeasDate { get; set; }
        public string MegUponRecFieldMeasValue { get; set; }
        public int MechLineRelease { get; set; }
        public DateTime MechLineReleaseDate { get; set; }
        public int MegBeforeInstall { get; set; }
        public DateTime MegBeforeInstallDate { get; set; }
        public string MegBeforeInstallValue { get; set; }
        public int PPInstalled { get; set; }
        public DateTime PPInstalledDate { get; set; }
        public int CLeadInstalled { get; set; }
        public DateTime CLeadInstalledDate { get; set; }
        public int RTD1Installed { get; set; }
        public DateTime RTD1InstalledDate { get; set; }
        public int RTD2Installed { get; set; }
        public DateTime RTD2InstalledDate { get; set; }
        public int Installed { get; set; }
        public DateTime InstalledDate { get; set; }
        public int AmountInstalled { get; set; }
        public int UOMID { get; set; }
        public int CSR { get; set; }
        public DateTime CSRDate { get; set; }
        public int MegAfterInstall { get; set; }
        public DateTime MegAfterInstallDate { get; set; }
        public string MegAfterInstallValue { get; set; }
        public int ReleasedToInsul { get; set; }
        public DateTime ReleasedToInsulDate { get; set; }
        public int MegAfterInsul { get; set; }
        public DateTime MegAfterInsulDate { get; set; }
        public string MegAfterInsulValue { get; set; }
        public int QCComplete { get; set; }
        public DateTime QCDate { get; set; }
        public string TagNumber { get; set; }
        public int ProjectScheduleID { get; set; }
        public int WorkPackageID { get; set; }
        public double PercentComplete { get; set; }
        public int SDID { get; set; }
        public int CostCodeID { get; set; }
        public double ManhoursEstimate { get; set; }
        

        // Constructor
        public EhtprogressDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
        }
    }
}
