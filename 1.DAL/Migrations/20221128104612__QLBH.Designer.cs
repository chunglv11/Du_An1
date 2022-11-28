﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1.DAL.Context;

#nullable disable

namespace _1.DAL.Migrations
{
    [DbContext(typeof(QLBH_Context))]
    [Migration("20221128104612__QLBH")]
    partial class _QLBH
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_1.DAL.Entities.ChiTietSp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal(9,3)");

                    b.Property<decimal>("GiaNhap")
                        .HasColumnType("decimal(9,3)");

                    b.Property<Guid>("IdDongSp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdKichCo")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdMauSac")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNsx")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdSp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("SoLuongTon")
                        .HasColumnType("int");

                    b.Property<int>("TinhTrang")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdDongSp");

                    b.HasIndex("IdKichCo");

                    b.HasIndex("IdMauSac");

                    b.HasIndex("IdNsx");

                    b.HasIndex("IdSp");

                    b.ToTable("ChiTietSp", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Entities.ChucVu", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaCV")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenCV")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("ChucVu", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Entities.CuaHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("MaCH")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("QuocGia")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenCH")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ThanhPho")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("CuaHang", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Entities.DongSp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaDsp")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenDsp")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("DongSp", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Entities.HoaDon", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .HasColumnType("nvarchar(200)");

                    b.Property<Guid>("IdKh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdNv")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaHD")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<DateTime?>("NgayNhan")
                        .HasColumnType("Datetime");

                    b.Property<DateTime?>("NgayShip")
                        .HasColumnType("Datetime");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("Datetime");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("Datetime");

                    b.Property<string>("Sdt")
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TenNguoiNhan")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TenNguoiShip")
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("TinhTrang")
                        .HasColumnType("int");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IdKh");

                    b.HasIndex("IdNv");

                    b.ToTable("HoaDon", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Entities.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("IdHoaDon")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdChiTietSp")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DonGia")
                        .HasColumnType("decimal(9,3)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("IdHoaDon", "IdChiTietSp");

                    b.HasIndex("IdChiTietSp");

                    b.ToTable("HoaDonChiTiet", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Entities.KhachHang", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("HoTenKH")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MaKH")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("KhachHang", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Entities.KichCo", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaKc")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenKc")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("KichCo", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Entities.MauSac", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaMs")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenMs")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("MauSac", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Entities.NhanVien", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("CCCD")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("HoTenNv")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("IdCh")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdCv")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaNv")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("Datetime");

                    b.Property<string>("Sdt")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IdCh");

                    b.HasIndex("IdCv");

                    b.ToTable("NhanVien", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Entities.Nsx", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaNsx")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenNsx")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Nsx", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Entities.SanPham", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MaSp")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("TenSp")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("SanPham", (string)null);
                });

            modelBuilder.Entity("_1.DAL.Entities.ChiTietSp", b =>
                {
                    b.HasOne("_1.DAL.Entities.DongSp", "DongSp")
                        .WithMany()
                        .HasForeignKey("IdDongSp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Entities.KichCo", "KichCo")
                        .WithMany()
                        .HasForeignKey("IdKichCo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Entities.MauSac", "MauSac")
                        .WithMany()
                        .HasForeignKey("IdMauSac")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Entities.Nsx", "Nsx")
                        .WithMany()
                        .HasForeignKey("IdNsx")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Entities.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("IdSp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DongSp");

                    b.Navigation("KichCo");

                    b.Navigation("MauSac");

                    b.Navigation("Nsx");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("_1.DAL.Entities.HoaDon", b =>
                {
                    b.HasOne("_1.DAL.Entities.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("IdKh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Entities.NhanVien", "NhanVien")
                        .WithMany()
                        .HasForeignKey("IdNv")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("_1.DAL.Entities.HoaDonChiTiet", b =>
                {
                    b.HasOne("_1.DAL.Entities.ChiTietSp", "ChiTietSp")
                        .WithMany()
                        .HasForeignKey("IdChiTietSp")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Entities.HoaDon", "HoaDon")
                        .WithMany()
                        .HasForeignKey("IdHoaDon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChiTietSp");

                    b.Navigation("HoaDon");
                });

            modelBuilder.Entity("_1.DAL.Entities.NhanVien", b =>
                {
                    b.HasOne("_1.DAL.Entities.CuaHang", "CuaHang")
                        .WithMany()
                        .HasForeignKey("IdCh")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1.DAL.Entities.ChucVu", "ChucVu")
                        .WithMany()
                        .HasForeignKey("IdCv")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChucVu");

                    b.Navigation("CuaHang");
                });
#pragma warning restore 612, 618
        }
    }
}
