//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SaniShop.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public int id { get; set; }
        public int Customer_id { get; set; }
        public Nullable<System.DateTime> Transation_date { get; set; }
        public int Amount_paid { get; set; }
        public int Paid { get; set; }
    }
}