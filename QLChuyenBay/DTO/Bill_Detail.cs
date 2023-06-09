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
    using System.ComponentModel;

    public partial class Bill_Detail
    {
        public int BillID { get; set; }
        public int CustomerID { get; set; }
        public int FlightID { get; set; }
        public int EmployeeID { get; set; }
        public string SeatNumber { get; set; }
        public Nullable<bool> SeatClass { get; set; }
        public Nullable<int> BookingState { get; set; }
        public Nullable<decimal> TotalPrice { get; set; }
        public Nullable<System.DateTime> BookingDate { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Flight Flight { get; set; }
        public virtual Employee Employee { get; set; }
    }
}
