﻿using System;
using Microsoft.EntityFrameworkCore;

namespace ThieuNhiTT.Api.Models
{
	public class TNContext:DbContext
	{
        public TNContext(DbContextOptions options) : base(options) { }
        public DbSet<XuDoan> XuDoan
        {
            get;
            set;
        }
        public DbSet<HiepDoan> HiepDoan
        {
            get;
            set;
        }
        public DbSet<LienDoan> LienDoan
        {
            get;
            set;
        }
        public DbSet<TongLienDoan> TongLienDoan
        {
            get;
            set;
        }
        public DbSet<Profile> Profile
        {
            get;
            set;
        }
        public DbSet<KetQuaHocTap> KetQuaHocTap
        {
            get;
            set;
        }
        public DbSet<MonHoc> MonHoc
        {
            get;
            set;
        }
        public DbSet<LopHoc> LopHoc
        {
            get;
            set;
        }
        public DbSet<Role> Role
        {
            get;
            set;
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Profile>()
                .HasIndex(u => u.PIN)
                .IsUnique();
        }
    }
}

