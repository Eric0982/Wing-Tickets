//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tenant.Mvc.Core.Contexts
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ticket
    {
        public int TicketId { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public string Name { get; set; }
        public Nullable<int> TicketLevelId { get; set; }
        public Nullable<int> ConcertId { get; set; }
        public Nullable<System.DateTime> PurchaseDate { get; set; }
        public Nullable<int> SeatNumber { get; set; }
    }
}