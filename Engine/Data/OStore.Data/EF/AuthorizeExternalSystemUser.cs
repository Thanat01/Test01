//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OStore.Data.EF
{
    using System;
    using System.Collections.Generic;
    
    [Serializable]
    public partial class AuthorizeExternalSystemUser
    {
        public int ExternalSystemId { get; set; }
        public int AuthorizeUserId { get; set; }
        public string ExternalUserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> CreateBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public Nullable<int> UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    
        public virtual AuthorizeUser AuthorizeUser { get; set; }
        public virtual ExternalSystem ExternalSystem { get; set; }
    }
}
