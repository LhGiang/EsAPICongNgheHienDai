﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ESDBEntities : DbContext
    {
        public ESDBEntities()
            : base("name=ESDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<CHITIETDONHANG> CHITIETDONHANGs { get; set; }
        public DbSet<DONHANG> DONHANGs { get; set; }
        public DbSet<HOTROONLINE> HOTROONLINEs { get; set; }
        public DbSet<KHUYENMAI> KHUYENMAIs { get; set; }
        public DbSet<LOAISANPHAM> LOAISANPHAMs { get; set; }
        public DbSet<LOAITHANHVIEN> LOAITHANHVIENs { get; set; }
        public DbSet<NHASANXUAT> NHASANXUATs { get; set; }
        public DbSet<SANPHAM> SANPHAMs { get; set; }
        public DbSet<THANHTOANONLINE> THANHTOANONLINEs { get; set; }
        public DbSet<THANHVIEN> THANHVIENs { get; set; }
        public DbSet<TRANGTHAIDONHANG> TRANGTHAIDONHANGs { get; set; }
    }
}
