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
    
    public partial class HoaDon_TTT
    {
        public HoaDon_TTT()
        {
            this.Dong_HDTT = new HashSet<Dong_HDTT>();
        }
    
        public string SoHDTT { get; set; }
        public string SoHD { get; set; }
        public Nullable<System.DateTime> Ngay { get; set; }
        public string HTTT { get; set; }
        public Nullable<int> TongSoXeThue { get; set; }
        public Nullable<double> TraSau { get; set; }
        public Nullable<double> PhiPS { get; set; }
        public string LyDo { get; set; }
        public Nullable<double> TongThanhToan { get; set; }
        public Nullable<double> TraTruoc { get; set; }
        public string TenKeToan { get; set; }
        public string TenLaiXe { get; set; }
    
        public virtual ICollection<Dong_HDTT> Dong_HDTT { get; set; }
        public virtual HopDong HopDong { get; set; }
    }
}
