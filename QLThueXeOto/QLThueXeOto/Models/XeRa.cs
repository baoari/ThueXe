//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLThueXeOto.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class XeRa
    {
        public System.DateTime NgayRa { get; set; }
        public string MaXe { get; set; }
        public int GioRa { get; set; }
        public string GhiChu { get; set; }
    
        public virtual Xe Xe { get; set; }
    }
}
