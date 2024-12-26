﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLiDiem.Data;

#nullable disable

namespace QuanLiDiem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Diem", b =>
                {
                    b.Property<string>("MSSV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Diem10")
                        .HasColumnType("float");

                    b.Property<double>("Diem4")
                        .HasColumnType("float");

                    b.Property<double>("DiemCuoiKy")
                        .HasColumnType("float");

                    b.Property<double>("DiemQuaTrinh")
                        .HasColumnType("float");

                    b.Property<int>("HocKy")
                        .HasColumnType("int");

                    b.Property<string>("KetQua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaHP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NamHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoTinChi")
                        .HasColumnType("int");

                    b.HasKey("MSSV");

                    b.ToTable("Diem");
                });

            modelBuilder.Entity("QuanLiDiem.Models.DanhSachSinhVien", b =>
                {
                    b.Property<string>("MSSV")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CanCuocCongDan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaNganh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MatKhau")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenTaiKhoan")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VaiTro")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MSSV");

                    b.ToTable("DanhSachSinhVien");
                });

            modelBuilder.Entity("QuanLiDiem.Models.RegistrationModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CCCD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("DTB1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DTB2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DTB3")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NganhHoc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("XepLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DanhSachDK");
                });

            modelBuilder.Entity("Diem", b =>
                {
                    b.HasOne("QuanLiDiem.Models.DanhSachSinhVien", "SinhVien")
                        .WithMany("Diem")
                        .HasForeignKey("MSSV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SinhVien");
                });

            modelBuilder.Entity("QuanLiDiem.Models.DanhSachSinhVien", b =>
                {
                    b.Navigation("Diem");
                });
#pragma warning restore 612, 618
        }
    }
}
