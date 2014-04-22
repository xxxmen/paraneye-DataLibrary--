
#region LoginaccountDTO.cs
//---------------------------------------------------------------------------------------
//
// Name: LoginaccountDTO.cs
// Author: 
// Date: November-09-10
// Time: 10:07:50 AM
//
//---------------------------------------------------------------------------------------
#endregion
using System;
using System.Collections.Generic;

using System.Xml.Serialization;

namespace Element.Reveal.DataLibrary
{
    public class LoginaccountDTO : DTOBase
    {
        public string LoginAccountID { get; set; }
        [XmlElement(IsNullable = true)]
        public string LoginName { get; set; }
        [XmlElement(IsNullable = true)]
        public string Password { get; set; }
        public DateTime Created { get; set; }
        public string IsActive { get; set; }
        public string PersonnelId { get; set; }
        [XmlElement(IsNullable = true)]
        public string SharePointUser { get; set; }
        public int IsDomainUser { get; set; }
        public PersonnelDTO personnel { get; set; }
        [XmlElement(IsNullable = true)]
        public string LastName { get; set; }
        [XmlElement(IsNullable = true)]
        public string FirstName { get; set; }
        [XmlElement(IsNullable = true)]
        public string EMail { get; set; }
        [XmlElement(IsNullable = true)]
        public string PhoneNumber { get; set; }
        public int DepartmentID {get; set;}
        public int UserGroupID { get; set; }
        public int CurProjectID { get; set; }
        public string CurDisciplineCode { get; set; }
        [XmlElement(IsNullable = true)]
        public string DepartmentName { get; set; }
        [XmlElement(IsNullable = true)]
        public string EmployeeCode { get; set; }
        public int CheckPasswordChange { get; set; }
        [XmlElement(IsNullable = true)]
        public string PhotoUrl { get; set; }
        
        // Constructor
        public LoginaccountDTO()
        {
            DTOStatus = (int)RowStatusNo.None;
            IsActive = "Y";
        }
    }

    public class LoginaccountAndModuleUserGroup
    {
        public LoginaccountDTO login { get; set; }
        public List<LoginaccountmoduleusergroupDTO> moduleusergroup { get; set; }
    }

    public class MobileLoginDTO : DTOBase
    {
        public int SessionID { get; set; }
        public string SessionKey { get; set; }
        [XmlElement(IsNullable = true)]
        public string SPURL { get; set; }
        [XmlElement(IsNullable = true)]
        public string SPUser { get; set; }
        [XmlElement(IsNullable = true)]
        public string SPPassword { get; set; }
        [XmlElement(IsNullable = true)]
        public string WDUser { get; set; }
        [XmlElement(IsNullable = true)]
        public string WDPassword { get; set; }

        [XmlElement(IsNullable = true)]
        public string LastName { get; set; }
        [XmlElement(IsNullable = true)]
        public string FirstName { get; set; }
        [XmlElement(IsNullable = true)]
        public string UserName { get; set; }
        [XmlElement(IsNullable = true)]
        public string EMail { get; set; }
        public int CurProjectID { get; set; }
        public string CurDisciplineCode { get; set; }
        public int UserGroupID { get; set; }
        [XmlElement(IsNullable = true)]
        public string DepartmentName { get; set; }
        public int FIWPID { get; set; }
        public string PersonnelId { get; set; }
        public int IsDailyBrass { get; set; }
        [XmlElement(IsNullable = true)]
        public string LoginName { get; set; }
        [XmlElement(IsNullable = true)]
        public string PhotoUrl { get; set; }
    }

    public class UserInfoDTO : DTOBase
    {
        [XmlElement(IsNullable = true)]
        public string SigmaUserId { get; set; }
        public int CompanyId { get; set; }
        [XmlElement(IsNullable = true)]
        public string CompanyName { get; set; }
        public int ClientCompanyId { get; set; }
        public int CurrentProjectId { get; set; }
        [XmlElement(IsNullable = true)]
        public string CurrentProjectName { get; set; }
        public int CurrentSigmaRoleId { get; set; }
        [XmlElement(IsNullable = true)]
        public string CurrentSigmaRoleName { get; set; }
    }

}
