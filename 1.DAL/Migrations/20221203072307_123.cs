using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _1.DAL.Migrations
{
    public partial class _123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChucVu",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()"),
                    MaCV = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    TenCV = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChucVu", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CuaHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()"),
                    MaCH = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    TenCH = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    ThanhPho = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    QuocGia = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CuaHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DongSp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()"),
                    MaDsp = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    TenDsp = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DongSp", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()"),
                    MaKH = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    HoTenKH = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KichCo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()"),
                    MaKc = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    TenKc = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KichCo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MauSac",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()"),
                    MaMs = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    TenMs = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MauSac", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nsx",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()"),
                    MaNsx = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    TenNsx = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nsx", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()"),
                    MaSp = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    TenSp = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()"),
                    IdCh = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCv = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaNv = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    HoTenNv = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    GioiTinh = table.Column<int>(type: "int", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "Datetime", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    CCCD = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Sdt = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Anh = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    TrangThai = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NhanVien_ChucVu_IdCv",
                        column: x => x.IdCv,
                        principalTable: "ChucVu",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NhanVien_CuaHang_IdCh",
                        column: x => x.IdCh,
                        principalTable: "CuaHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietSp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()"),
                    IdSp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNsx = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMauSac = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdDongSp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdKichCo = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(300)", nullable: false),
                    SoLuongTon = table.Column<int>(type: "int", nullable: false),
                    Anh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaNhap = table.Column<decimal>(type: "decimal(9,3)", nullable: false),
                    GiaBan = table.Column<decimal>(type: "decimal(9,3)", nullable: false),
                    TinhTrang = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietSp", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChiTietSp_DongSp_IdDongSp",
                        column: x => x.IdDongSp,
                        principalTable: "DongSp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSp_KichCo_IdKichCo",
                        column: x => x.IdKichCo,
                        principalTable: "KichCo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSp_MauSac_IdMauSac",
                        column: x => x.IdMauSac,
                        principalTable: "MauSac",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSp_Nsx_IdNsx",
                        column: x => x.IdNsx,
                        principalTable: "Nsx",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietSp_SanPham_IdSp",
                        column: x => x.IdSp,
                        principalTable: "SanPham",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "newid()"),
                    IdKh = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdNv = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MaHD = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "Datetime", nullable: false),
                    NgayThanhToan = table.Column<DateTime>(type: "Datetime", nullable: false),
                    NgayShip = table.Column<DateTime>(type: "Datetime", nullable: true),
                    TenNguoiShip = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    NgayNhan = table.Column<DateTime>(type: "Datetime", nullable: true),
                    TenNguoiNhan = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(200)", nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    TongTien = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TinhTrang = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_IdKh",
                        column: x => x.IdKh,
                        principalTable: "KhachHang",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_IdNv",
                        column: x => x.IdNv,
                        principalTable: "NhanVien",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    IdHoaDon = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdChiTietSp = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonGia = table.Column<decimal>(type: "decimal(9,3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => new { x.IdHoaDon, x.IdChiTietSp });
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_ChiTietSp_IdChiTietSp",
                        column: x => x.IdChiTietSp,
                        principalTable: "ChiTietSp",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_IdHoaDon",
                        column: x => x.IdHoaDon,
                        principalTable: "HoaDon",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSp_IdDongSp",
                table: "ChiTietSp",
                column: "IdDongSp");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSp_IdKichCo",
                table: "ChiTietSp",
                column: "IdKichCo");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSp_IdMauSac",
                table: "ChiTietSp",
                column: "IdMauSac");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSp_IdNsx",
                table: "ChiTietSp",
                column: "IdNsx");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietSp_IdSp",
                table: "ChiTietSp",
                column: "IdSp");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdKh",
                table: "HoaDon",
                column: "IdKh");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdNv",
                table: "HoaDon",
                column: "IdNv");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdChiTietSp",
                table: "HoaDonChiTiet",
                column: "IdChiTietSp");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdCh",
                table: "NhanVien",
                column: "IdCh");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_IdCv",
                table: "NhanVien",
                column: "IdCv");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "ChiTietSp");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "DongSp");

            migrationBuilder.DropTable(
                name: "KichCo");

            migrationBuilder.DropTable(
                name: "MauSac");

            migrationBuilder.DropTable(
                name: "Nsx");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "ChucVu");

            migrationBuilder.DropTable(
                name: "CuaHang");
        }
    }
}
