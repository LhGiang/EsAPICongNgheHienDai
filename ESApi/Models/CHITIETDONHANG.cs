//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ESApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHITIETDONHANG
    {
        public string DONHANG { get; set; }
        public string SANPHAM { get; set; }
        public Nullable<int> SOLUONG { get; set; }
        public Nullable<double> THANHTIEN { get; set; }
        public Nullable<bool> DAXOA { get; set; }
    
        public virtual DONHANG DONHANG1 { get; set; }
        public virtual SANPHAM SANPHAM1 { get; set; }
    }
}
