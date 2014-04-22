using System;
#region SigmaResultTypeDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: SigmaResultTypeDTO.cs
// Author: 
// Date: Monday, March 3, 2014
// Time: 1:48:00 AM
//
//---------------------------------------------------------------------------------------
#endregion
namespace Element.Reveal.DataLibrary
{
    public class SigmaResultTypeDTO
    {
        public string JsonDataSet { get; set; }
        public bool IsSuccessful { get; set; }
        public int AffectedRow { get; set; }  // DataSet Count
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
        public int ScalarValue { get; set; }  // Total Count
        public string StringValue { get; set; }  // Multi
    }

    public class TypeTransition
    {
        /// <summary>
        /// Row는 0부터 시작
        /// </summary>
        public int Row { get; set; }
        public int Role { get; set; }
        public string UserId { get; set; }
    }

    public class WorkflowByIWPID
    {
        public int Seq { get; set; }
        public int SchemeSeq { get; set; }
        public int SchemeDetSeq { get; set; }
        public int ActivityLevel { get; set; }
        public string OriginPosId { get; set; }
        public string SchemePosId { get; set; }
        public string SchemeSteps { get; set; }
        public string ReportToPosI { get; set; }
        public string HierachyStatus { get; set; }
        public int MemberCount { get; set; }
        public long TransitionStatusSeq { get; set; }

        public int AffectedRow { get; set; }  // DataSet Count
    }

    public class Department
    {
        public int SigmaRoleId { get; set; }
        public string SigmaRoleName { get; set; }

        public int AffectedRow { get; set; }  // DataSet Count
    }

    public class CrewByDepartmentID
    {
        public string SigmaUserId { get; set; }
        public string SigmaUserName { get; set; }
        public Guid SigmaUserGuid { get; set; }
        public string PhotoUrl { get; set; }
        public string Email { get; set; }
        public int SigmaRoleId { get; set; }
        public Guid SigmaRoleGuid { get; set; }
        public string SigmaRoleName { get; set; }

        public Uri imageurl { get; set; }

        public int AffectedRow { get; set; }  // DataSet Count
    }

    public class IWPWorkflowStatusBypersonnelid_type_term
    {
        public Guid ProcessId {get; set; }
        public string ProcessTitle { get; set; }
        public Guid AuthorId { get; set; }
        public string StateName { get; set; }
        public long TransitionStatusSeq { get; set; }
        public int DetSeq { get; set; }
        public int UserSeq { get; set; }
        public string IsProcessStatus { get; set; }
        public string Comment { get; set; }
        public string WorkflowStatusCd { get; set; }
        public string MyStep { get; set; }
        public Guid SigmaUserGuid { get; set; }
        public Guid SigmaRoleGuid { get; set; }
        public string TransitionTime { get; set; }  // Completed Date
        public string PackageTypeCode { get; set; }
        public string PackageTypeName { get; set; }  // Type
        public string RecievedDt { get; set; }  // Date
        public string DurationDt { get; set; }  // IWP Schedule
        public string IWPName { get; set; }  // IWP Name
        public int TargetId { get; set; }  // Workflow Type = IWP : IWP 테이블의 키값(IwpId) / Workflow Type = ITR : IWPDocument 테이블의 키값 / Workflow Type = RFI : RFI 테이블의 키값
        public int TargetSeq { get; set; }
        public int IwpId { get; set; }

        public Uri imageurl { get; set; }
        public int AffectedRow { get; set; }  // DataSet Count
    }

    public class WorkflowDetailByIWPID
    {
        public long TransitionStatusSeq { get; set; }  //level 구분 order by  시작점은 모름(0이 아님)
        public int DetSeq { get; set; }
        public int UserSeq { get; set; }  //같은 level의 순서 order By 로 
        public Guid SigmaUserGuid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid SigmaRoleGuid { get; set; }
        public string SigmaRoleName { get; set; }
        public string IsProcessStatus { get; set; }
        public string Comment { get; set; }
        public Guid WorkFlowId { get; set; }
        public string WorkflowStatusCd { get; set; }
        public string TransitionTime { get; set; }
        public string ProcessTitle { get; set; }
        public string SchemeCode { get; set; }
        public string StateName { get; set; }

        public int AffectedRow { get; set; }  // DataSet Count
    }

    public class PendingWorkflow
    {
        public Guid WorkFlowId { get; set; }
        public string ProcessTitle { get; set; }
        public string AuthorId { get; set; }
        public string StateName { get; set; }
        public long TransitionStatusSeq { get; set; }
        public string SchemeCode { get; set; }
        public int DetSeq { get; set; }
        public int UserSeq { get; set; }
        public string IsProcessStatus { get; set; }

        public string Comment { get; set; }
        public Guid SigmaUserGuid { get; set; }
        public Guid SigmaRoleGuid { get; set; }
        public string PackageTypeCode { get; set; }
        public string SigmaUserName { get; set; }
        public string SigmaUserId { get; set; }
        public string IsModified { get; set; }  //Y 일때만 신규저장이 가능 (아닐때는 이미 상신이 올라가있는 상태로 신규 저장 불가능)
        public string IsNewer { get; set; }
        public string SigmaRoleName { get; set; }
        public int SigmaRoleId { get; set; }

        public string statuscolor { get; set; }
        
        public int AffectedRow { get; set; }  // DataSet Count
    }

    //public class WorkflowRoleTitle
    //{
    //    public int Seq { get; set; }
        
    //    public int SchemeSeq { get; set; }
    //    public int SchemeDetSeq { get; set; }
    //    public int TransitionStatusSeq { get; set; }
    //    public int TransitionStatusDetSeq { get; set; }
    //    public string PositionTitle { get; set; }
    //    public string SchemePosId { get; set; }
    //    public string ReportToPosId { get; set; }
    //    public string stringCommand { get; set; }
    //    public int MemberCount  { get; set; }

    //    public int AffectedRow { get; set; }  // DataSet Count
    //}


}
