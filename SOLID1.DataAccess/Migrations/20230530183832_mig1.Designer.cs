﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SOLID1.DataAccess;

#nullable disable

namespace SOLID1.DataAccess.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230530183832_mig1")]
    partial class mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("SOLID1.Entity.Concrate.EnCokSatanUrunler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("GuncellemeTarih")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("EnCokSatanUrunler");
                });

            modelBuilder.Entity("SOLID1.Entity.Concrate.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GuncellemeTarih")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Kategori");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Adi = "Siyah Zeytin",
                            GuncellemeTarih = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OlusturmaTarihi = new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(707)
                        },
                        new
                        {
                            Id = 2,
                            Adi = "Yeşil Zeytin",
                            GuncellemeTarih = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OlusturmaTarihi = new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(722)
                        },
                        new
                        {
                            Id = 3,
                            Adi = "Zeytin Yağı",
                            GuncellemeTarih = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OlusturmaTarihi = new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(723)
                        });
                });

            modelBuilder.Entity("SOLID1.Entity.Concrate.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdSoyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Eposta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GuncellemeTarih")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Kullanici");
                });

            modelBuilder.Entity("SOLID1.Entity.Concrate.Sepet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("GuncellemeTarih")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Sepet");
                });

            modelBuilder.Entity("SOLID1.Entity.Concrate.Stok", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Barkod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Baslik")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("EnCokSatanUrunlerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("GuncellemeTarih")
                        .HasColumnType("datetime2");

                    b.Property<int>("KategoriId")
                        .HasColumnType("int");

                    b.Property<string>("Kod")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TavsiyeEdilenUrunlerId")
                        .HasColumnType("int");

                    b.Property<int?>("UrunAciklamaId")
                        .HasColumnType("int");

                    b.Property<int?>("VitrinId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EnCokSatanUrunlerId");

                    b.HasIndex("KategoriId");

                    b.HasIndex("TavsiyeEdilenUrunlerId");

                    b.HasIndex("UrunAciklamaId");

                    b.HasIndex("VitrinId");

                    b.ToTable("Stok");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Barkod = "8698943124586",
                            Baslik = "Taş Baskı Siyah Zeytin",
                            GuncellemeTarih = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriId = 1,
                            Kod = "TDR01",
                            OlusturmaTarihi = new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(921),
                            UrunAciklamaId = 1
                        },
                        new
                        {
                            Id = 2,
                            Barkod = "8698943124587",
                            Baslik = "Gold Siyah Zeytin",
                            GuncellemeTarih = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriId = 1,
                            Kod = "TDR02",
                            OlusturmaTarihi = new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(927),
                            UrunAciklamaId = 2
                        },
                        new
                        {
                            Id = 3,
                            Barkod = "8698943124588",
                            Baslik = "Sele Siyah Zeytin",
                            GuncellemeTarih = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriId = 1,
                            Kod = "TDR03",
                            OlusturmaTarihi = new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(928),
                            UrunAciklamaId = 3
                        },
                        new
                        {
                            Id = 4,
                            Barkod = "8698943124590",
                            Baslik = "Gemlik Kızıl Yeşil Zeytin",
                            GuncellemeTarih = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriId = 2,
                            Kod = "TDR04",
                            OlusturmaTarihi = new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(930)
                        },
                        new
                        {
                            Id = 5,
                            Barkod = "8698943124590",
                            Baslik = "Edremit Yeşil Zeytin",
                            GuncellemeTarih = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriId = 2,
                            Kod = "TDR05",
                            OlusturmaTarihi = new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(931)
                        },
                        new
                        {
                            Id = 6,
                            Barkod = "8698943124591",
                            Baslik = "Bademli Yeşil Zeytin",
                            GuncellemeTarih = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriId = 2,
                            Kod = "TDR06",
                            OlusturmaTarihi = new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(932)
                        },
                        new
                        {
                            Id = 7,
                            Barkod = "8698943124592",
                            Baslik = "Naturel Sızma Zeytin Yağı",
                            GuncellemeTarih = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriId = 3,
                            Kod = "TDR07",
                            OlusturmaTarihi = new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(934)
                        },
                        new
                        {
                            Id = 8,
                            Barkod = "8698943124593",
                            Baslik = "Taş Baskı Sızma Zeytin Yağı",
                            GuncellemeTarih = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriId = 3,
                            Kod = "TDR09",
                            OlusturmaTarihi = new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(935)
                        },
                        new
                        {
                            Id = 9,
                            Barkod = "86989431245494",
                            Baslik = "İlk Aşk Zeytin Yağı",
                            GuncellemeTarih = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            KategoriId = 3,
                            Kod = "TDR10",
                            OlusturmaTarihi = new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(936)
                        });
                });

            modelBuilder.Entity("SOLID1.Entity.Concrate.TavsiyeEdilenUrunler", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("GuncellemeTarih")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TavsiyeEdilenUrunler");
                });

            modelBuilder.Entity("SOLID1.Entity.Concrate.UrunAciklama", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Brim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GuncellemeTarih")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<float?>("Tutar")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("UrunAciklama");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Aciklama = "Taş baskı siyah zeytin gemligin cocudur",
                            Brim = "ADET",
                            GuncellemeTarih = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OlusturmaTarihi = new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(961),
                            Tutar = 500f
                        },
                        new
                        {
                            Id = 2,
                            Aciklama = "Gold siyah zeytin gemligin altınıdır",
                            Brim = "ADET",
                            GuncellemeTarih = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OlusturmaTarihi = new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(965),
                            Tutar = 200f
                        },
                        new
                        {
                            Id = 3,
                            Aciklama = "Sele   zeytin gemligin fakirlerine hitap eder",
                            Brim = "ADET",
                            GuncellemeTarih = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            OlusturmaTarihi = new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(966),
                            Tutar = 100f
                        });
                });

            modelBuilder.Entity("SOLID1.Entity.Concrate.Vitrin", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("GuncellemeTarih")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OlusturmaTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Vitrin");
                });

            modelBuilder.Entity("SOLID1.Entity.Concrate.Stok", b =>
                {
                    b.HasOne("SOLID1.Entity.Concrate.EnCokSatanUrunler", "EnCokSatanUrunler")
                        .WithMany("Stok")
                        .HasForeignKey("EnCokSatanUrunlerId");

                    b.HasOne("SOLID1.Entity.Concrate.Kategori", "Kategori")
                        .WithMany("Stok")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SOLID1.Entity.Concrate.TavsiyeEdilenUrunler", "TavsiyeEdilenUrunler")
                        .WithMany("Stok")
                        .HasForeignKey("TavsiyeEdilenUrunlerId");

                    b.HasOne("SOLID1.Entity.Concrate.UrunAciklama", "UrunAciklama")
                        .WithMany("Stok")
                        .HasForeignKey("UrunAciklamaId");

                    b.HasOne("SOLID1.Entity.Concrate.Vitrin", "Vitrin")
                        .WithMany("Stok")
                        .HasForeignKey("VitrinId");

                    b.Navigation("EnCokSatanUrunler");

                    b.Navigation("Kategori");

                    b.Navigation("TavsiyeEdilenUrunler");

                    b.Navigation("UrunAciklama");

                    b.Navigation("Vitrin");
                });

            modelBuilder.Entity("SOLID1.Entity.Concrate.EnCokSatanUrunler", b =>
                {
                    b.Navigation("Stok");
                });

            modelBuilder.Entity("SOLID1.Entity.Concrate.Kategori", b =>
                {
                    b.Navigation("Stok");
                });

            modelBuilder.Entity("SOLID1.Entity.Concrate.TavsiyeEdilenUrunler", b =>
                {
                    b.Navigation("Stok");
                });

            modelBuilder.Entity("SOLID1.Entity.Concrate.UrunAciklama", b =>
                {
                    b.Navigation("Stok");
                });

            modelBuilder.Entity("SOLID1.Entity.Concrate.Vitrin", b =>
                {
                    b.Navigation("Stok");
                });
#pragma warning restore 612, 618
        }
    }
}
