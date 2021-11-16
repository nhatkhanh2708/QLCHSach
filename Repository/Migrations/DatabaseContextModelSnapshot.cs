﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Repository;

namespace Repository.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Model.Entities.ChiTietNhap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("HdNhapId")
                        .HasColumnType("int");

                    b.Property<int>("SachId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HdNhapId");

                    b.HasIndex("SachId");

                    b.ToTable("ChiTietNhaps");
                });

            modelBuilder.Entity("Model.Entities.ChiTietXuat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("HdXuatId")
                        .HasColumnType("int");

                    b.Property<int>("SachId")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HdXuatId");

                    b.HasIndex("SachId");

                    b.ToTable("ChiTietXuats");
                });

            modelBuilder.Entity("Model.Entities.HoaDonNhap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("NccId")
                        .HasColumnType("int");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<int>("TaiKhoanId")
                        .HasColumnType("int");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("NccId");

                    b.HasIndex("TaiKhoanId");

                    b.ToTable("HoaDonNhaps");
                });

            modelBuilder.Entity("Model.Entities.HoaDonXuat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<int>("TaiKhoanId")
                        .HasColumnType("int");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("TaiKhoanId");

                    b.ToTable("HoaDonXuats");
                });

            modelBuilder.Entity("Model.Entities.NhaCungCap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NgayHopTac")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("TenNCC")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("nvarchar(60)");

                    b.Property<string>("VietTat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NhaCungCaps");
                });

            modelBuilder.Entity("Model.Entities.NhaXuatBan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TenNxb")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VietTat")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NhaXuatBans");
                });

            modelBuilder.Entity("Model.Entities.NhanVien", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ChucVu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("NhanViens");
                });

            modelBuilder.Entity("Model.Entities.Quyen", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenQuyen")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Quyens");
                });

            modelBuilder.Entity("Model.Entities.Sach", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<decimal>("GiaBan")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GiaNhap")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("MaSach")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NxbId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("TenSach")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Thumbnail")
                        .HasColumnType("image");

                    b.HasKey("Id");

                    b.HasIndex("NxbId");

                    b.ToTable("Sachs");
                });

            modelBuilder.Entity("Model.Entities.SachTacGia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("SachId")
                        .HasColumnType("int");

                    b.Property<int>("TacGiaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SachId");

                    b.HasIndex("TacGiaId");

                    b.ToTable("SachTacGias");
                });

            modelBuilder.Entity("Model.Entities.SachTheLoai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("SachId")
                        .HasColumnType("int");

                    b.Property<int>("TheLoaiId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SachId");

                    b.HasIndex("TheLoaiId");

                    b.ToTable("SachTheLoais");
                });

            modelBuilder.Entity("Model.Entities.TacGia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ButDanh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("GioiTinh")
                        .HasColumnType("bit");

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TacGias");
                });

            modelBuilder.Entity("Model.Entities.TaiKhoan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("NhanVienId")
                        .HasColumnType("int");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("QuyenId")
                        .HasColumnType("int");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NhanVienId")
                        .IsUnique();

                    b.HasIndex("QuyenId");

                    b.ToTable("TaiKhoans");
                });

            modelBuilder.Entity("Model.Entities.TheLoai", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("TenTheLoai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TheLoais");
                });

            modelBuilder.Entity("Model.Entities.ChiTietNhap", b =>
                {
                    b.HasOne("Model.Entities.HoaDonNhap", "HoaDonNhap")
                        .WithMany("ChiTietNhaps")
                        .HasForeignKey("HdNhapId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Sach", "Sach")
                        .WithMany("ChiTietNhaps")
                        .HasForeignKey("SachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDonNhap");

                    b.Navigation("Sach");
                });

            modelBuilder.Entity("Model.Entities.ChiTietXuat", b =>
                {
                    b.HasOne("Model.Entities.HoaDonXuat", "HoaDonXuat")
                        .WithMany("ChiTietXuats")
                        .HasForeignKey("HdXuatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Sach", "Sach")
                        .WithMany("ChiTietXuats")
                        .HasForeignKey("SachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDonXuat");

                    b.Navigation("Sach");
                });

            modelBuilder.Entity("Model.Entities.HoaDonNhap", b =>
                {
                    b.HasOne("Model.Entities.NhaCungCap", "NCC")
                        .WithMany("HoaDonNhaps")
                        .HasForeignKey("NccId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.TaiKhoan", "TaiKhoan")
                        .WithMany("HoaDonNhaps")
                        .HasForeignKey("TaiKhoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NCC");

                    b.Navigation("TaiKhoan");
                });

            modelBuilder.Entity("Model.Entities.HoaDonXuat", b =>
                {
                    b.HasOne("Model.Entities.TaiKhoan", "TaiKhoan")
                        .WithMany("HoaDonXuats")
                        .HasForeignKey("TaiKhoanId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TaiKhoan");
                });

            modelBuilder.Entity("Model.Entities.NhaCungCap", b =>
                {
                    b.OwnsOne("Model.ValueObjects.DiaChi", "DiaChi", b1 =>
                        {
                            b1.Property<int>("NhaCungCapId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<string>("Duong")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Quan")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ThanhPho")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("NhaCungCapId");

                            b1.ToTable("NhaCungCaps");

                            b1.WithOwner()
                                .HasForeignKey("NhaCungCapId");
                        });

                    b.Navigation("DiaChi")
                        .IsRequired();
                });

            modelBuilder.Entity("Model.Entities.NhanVien", b =>
                {
                    b.OwnsOne("Model.ValueObjects.DiaChi", "DiaChi", b1 =>
                        {
                            b1.Property<int>("NhanVienId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .UseIdentityColumn();

                            b1.Property<string>("Duong")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Quan")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("ThanhPho")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("NhanVienId");

                            b1.ToTable("NhanViens");

                            b1.WithOwner()
                                .HasForeignKey("NhanVienId");
                        });

                    b.Navigation("DiaChi");
                });

            modelBuilder.Entity("Model.Entities.Sach", b =>
                {
                    b.HasOne("Model.Entities.NhaXuatBan", "Nxb")
                        .WithMany("Sachs")
                        .HasForeignKey("NxbId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nxb");
                });

            modelBuilder.Entity("Model.Entities.SachTacGia", b =>
                {
                    b.HasOne("Model.Entities.Sach", "Sach")
                        .WithMany("SachTacGias")
                        .HasForeignKey("SachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.TacGia", "TacGia")
                        .WithMany("SachTacGias")
                        .HasForeignKey("TacGiaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sach");

                    b.Navigation("TacGia");
                });

            modelBuilder.Entity("Model.Entities.SachTheLoai", b =>
                {
                    b.HasOne("Model.Entities.Sach", "Sach")
                        .WithMany("SachTheLoais")
                        .HasForeignKey("SachId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.TheLoai", "TheLoai")
                        .WithMany("SachTheLoais")
                        .HasForeignKey("TheLoaiId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sach");

                    b.Navigation("TheLoai");
                });

            modelBuilder.Entity("Model.Entities.TaiKhoan", b =>
                {
                    b.HasOne("Model.Entities.NhanVien", "nhanVien")
                        .WithOne("TaiKhoan")
                        .HasForeignKey("Model.Entities.TaiKhoan", "NhanVienId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Model.Entities.Quyen", "Quyen")
                        .WithMany("TaiKhoans")
                        .HasForeignKey("QuyenId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("nhanVien");

                    b.Navigation("Quyen");
                });

            modelBuilder.Entity("Model.Entities.HoaDonNhap", b =>
                {
                    b.Navigation("ChiTietNhaps");
                });

            modelBuilder.Entity("Model.Entities.HoaDonXuat", b =>
                {
                    b.Navigation("ChiTietXuats");
                });

            modelBuilder.Entity("Model.Entities.NhaCungCap", b =>
                {
                    b.Navigation("HoaDonNhaps");
                });

            modelBuilder.Entity("Model.Entities.NhaXuatBan", b =>
                {
                    b.Navigation("Sachs");
                });

            modelBuilder.Entity("Model.Entities.NhanVien", b =>
                {
                    b.Navigation("TaiKhoan");
                });

            modelBuilder.Entity("Model.Entities.Quyen", b =>
                {
                    b.Navigation("TaiKhoans");
                });

            modelBuilder.Entity("Model.Entities.Sach", b =>
                {
                    b.Navigation("ChiTietNhaps");

                    b.Navigation("ChiTietXuats");

                    b.Navigation("SachTacGias");

                    b.Navigation("SachTheLoais");
                });

            modelBuilder.Entity("Model.Entities.TacGia", b =>
                {
                    b.Navigation("SachTacGias");
                });

            modelBuilder.Entity("Model.Entities.TaiKhoan", b =>
                {
                    b.Navigation("HoaDonNhaps");

                    b.Navigation("HoaDonXuats");
                });

            modelBuilder.Entity("Model.Entities.TheLoai", b =>
                {
                    b.Navigation("SachTheLoais");
                });
#pragma warning restore 612, 618
        }
    }
}
