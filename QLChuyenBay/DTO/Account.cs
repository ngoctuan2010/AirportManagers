//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account
    {
        public int AccountID { get; set; }
        public Nullable<int> EmployeeID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Nullable<bool> AccessLevel { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
