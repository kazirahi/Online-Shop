//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Online_shop.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Members
    {
        public Tbl_Members()
        {
            this.Tbl_ShippingDetails = new HashSet<Tbl_ShippingDetails>();
        }
    
        public int MemberId { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Password { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
    
        public virtual ICollection<Tbl_ShippingDetails> Tbl_ShippingDetails { get; set; }
    }
}
