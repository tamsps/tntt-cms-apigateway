﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThieuNhiTT.Api.Models;

#nullable disable

namespace ThieuNhiTT.Api.Migrations
{
    [DbContext(typeof(TNContext))]
    [Migration("20230621153608_MigrateDB2")]
    partial class MigrateDB2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ThieuNhiTT.Api.Models.HiepDoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GiaoHat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LienDoanId")
                        .HasColumnType("int");

                    b.Property<string>("TenHiepDoan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("LienDoanId");

                    b.ToTable("HiepDoan");
                });

            modelBuilder.Entity("ThieuNhiTT.Api.Models.KetQuaHocTap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GVCN_PIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KetLuan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ThanhTich")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("KetQuaHocTap");
                });

            modelBuilder.Entity("ThieuNhiTT.Api.Models.LienDoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GiaoPhan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLienDoan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TongLienDoanId")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("TongLienDoanId");

                    b.ToTable("LienDoan");
                });

            modelBuilder.Entity("ThieuNhiTT.Api.Models.LopHoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GVCN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamHoc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nganh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLop")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LopHoc");
                });

            modelBuilder.Entity("ThieuNhiTT.Api.Models.MonHoc", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Diem")
                        .HasColumnType("float");

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KetQuaHocTapId")
                        .HasColumnType("int");

                    b.Property<string>("PIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenMon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("KetQuaHocTapId");

                    b.ToTable("MonHoc");
                });

            modelBuilder.Entity("ThieuNhiTT.Api.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageLargeUri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageSmallUri")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LopHocId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("NhanXet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PIN")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("SoDT1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDT2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenCha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenMe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenThanh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("XuDoanId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LopHocId");

                    b.HasIndex("PIN")
                        .IsUnique()
                        .HasFilter("[PIN] IS NOT NULL");

                    b.ToTable("Profile");
                });

            modelBuilder.Entity("ThieuNhiTT.Api.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CanAccess")
                        .HasColumnType("int");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("ThieuNhiTT.Api.Models.TongLienDoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CountryCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenQuocGia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TongLienDoan");
                });

            modelBuilder.Entity("ThieuNhiTT.Api.Models.XuDoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GiaoXu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HiepDoanId")
                        .HasColumnType("int");

                    b.Property<string>("TenXuDoan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("HiepDoanId");

                    b.ToTable("XuDoan");
                });

            modelBuilder.Entity("ThieuNhiTT.Api.Models.HiepDoan", b =>
                {
                    b.HasOne("ThieuNhiTT.Api.Models.LienDoan", null)
                        .WithMany("HiepDoans")
                        .HasForeignKey("LienDoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ThieuNhiTT.Api.Models.LienDoan", b =>
                {
                    b.HasOne("ThieuNhiTT.Api.Models.TongLienDoan", null)
                        .WithMany("LienDoans")
                        .HasForeignKey("TongLienDoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ThieuNhiTT.Api.Models.MonHoc", b =>
                {
                    b.HasOne("ThieuNhiTT.Api.Models.KetQuaHocTap", null)
                        .WithMany("MonHocs")
                        .HasForeignKey("KetQuaHocTapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ThieuNhiTT.Api.Models.Profile", b =>
                {
                    b.HasOne("ThieuNhiTT.Api.Models.LopHoc", null)
                        .WithMany("DanhSach")
                        .HasForeignKey("LopHocId");
                });

            modelBuilder.Entity("ThieuNhiTT.Api.Models.XuDoan", b =>
                {
                    b.HasOne("ThieuNhiTT.Api.Models.HiepDoan", null)
                        .WithMany("XuDoans")
                        .HasForeignKey("HiepDoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ThieuNhiTT.Api.Models.HiepDoan", b =>
                {
                    b.Navigation("XuDoans");
                });

            modelBuilder.Entity("ThieuNhiTT.Api.Models.KetQuaHocTap", b =>
                {
                    b.Navigation("MonHocs");
                });

            modelBuilder.Entity("ThieuNhiTT.Api.Models.LienDoan", b =>
                {
                    b.Navigation("HiepDoans");
                });

            modelBuilder.Entity("ThieuNhiTT.Api.Models.LopHoc", b =>
                {
                    b.Navigation("DanhSach");
                });

            modelBuilder.Entity("ThieuNhiTT.Api.Models.TongLienDoan", b =>
                {
                    b.Navigation("LienDoans");
                });
#pragma warning restore 612, 618
        }
    }
}
