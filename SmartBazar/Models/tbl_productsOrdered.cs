//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SmartBazar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_productsOrdered
    {
        public int op_id { get; set; }
        public Nullable<int> op_pro_id { get; set; }
        public Nullable<int> op_qty { get; set; }
        public Nullable<double> op_unitprice { get; set; }
        public Nullable<double> op_total { get; set; }
        public Nullable<int> op_fk_o_id { get; set; }
    
        public virtual tbl_Order tbl_Order { get; set; }
        public virtual tbl_product tbl_product { get; set; }
    }
}
