using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SOLID1.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EnCokSatanUrunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuncellemeTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EnCokSatanUrunler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncellemeTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kullanici",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Eposta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GuncellemeTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanici", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sepet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuncellemeTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sepet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TavsiyeEdilenUrunler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuncellemeTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TavsiyeEdilenUrunler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UrunAciklama",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tutar = table.Column<float>(type: "real", nullable: true),
                    Aciklama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GuncellemeTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UrunAciklama", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vitrin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GuncellemeTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vitrin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stok",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Barkod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KategoriId = table.Column<int>(type: "int", nullable: false),
                    UrunAciklamaId = table.Column<int>(type: "int", nullable: true),
                    VitrinId = table.Column<int>(type: "int", nullable: true),
                    EnCokSatanUrunlerId = table.Column<int>(type: "int", nullable: true),
                    TavsiyeEdilenUrunlerId = table.Column<int>(type: "int", nullable: true),
                    GuncellemeTarih = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OlusturmaTarihi = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stok", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stok_EnCokSatanUrunler_EnCokSatanUrunlerId",
                        column: x => x.EnCokSatanUrunlerId,
                        principalTable: "EnCokSatanUrunler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Stok_Kategori_KategoriId",
                        column: x => x.KategoriId,
                        principalTable: "Kategori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stok_TavsiyeEdilenUrunler_TavsiyeEdilenUrunlerId",
                        column: x => x.TavsiyeEdilenUrunlerId,
                        principalTable: "TavsiyeEdilenUrunler",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Stok_UrunAciklama_UrunAciklamaId",
                        column: x => x.UrunAciklamaId,
                        principalTable: "UrunAciklama",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Stok_Vitrin_VitrinId",
                        column: x => x.VitrinId,
                        principalTable: "Vitrin",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Kategori",
                columns: new[] { "Id", "Adi", "GuncellemeTarih", "OlusturmaTarihi" },
                values: new object[,]
                {
                    { 1, "Siyah Zeytin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(707) },
                    { 2, "Yeşil Zeytin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(722) },
                    { 3, "Zeytin Yağı", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(723) }
                });

            migrationBuilder.InsertData(
                table: "UrunAciklama",
                columns: new[] { "Id", "Aciklama", "Brim", "GuncellemeTarih", "OlusturmaTarihi", "Tutar" },
                values: new object[,]
                {
                    { 1, "Taş baskı siyah zeytin gemligin cocudur", "ADET", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(961), 500f },
                    { 2, "Gold siyah zeytin gemligin altınıdır", "ADET", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(965), 200f },
                    { 3, "Sele   zeytin gemligin fakirlerine hitap eder", "ADET", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(966), 100f }
                });

            migrationBuilder.InsertData(
                table: "Stok",
                columns: new[] { "Id", "Barkod", "Baslik", "EnCokSatanUrunlerId", "GuncellemeTarih", "KategoriId", "Kod", "OlusturmaTarihi", "TavsiyeEdilenUrunlerId", "UrunAciklamaId", "VitrinId" },
                values: new object[,]
                {
                    { 1, "8698943124586", "Taş Baskı Siyah Zeytin", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "TDR01", new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(921), null, 1, null },
                    { 2, "8698943124587", "Gold Siyah Zeytin", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "TDR02", new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(927), null, 2, null },
                    { 3, "8698943124588", "Sele Siyah Zeytin", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "TDR03", new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(928), null, 3, null },
                    { 4, "8698943124590", "Gemlik Kızıl Yeşil Zeytin", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "TDR04", new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(930), null, null, null },
                    { 5, "8698943124590", "Edremit Yeşil Zeytin", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "TDR05", new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(931), null, null, null },
                    { 6, "8698943124591", "Bademli Yeşil Zeytin", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "TDR06", new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(932), null, null, null },
                    { 7, "8698943124592", "Naturel Sızma Zeytin Yağı", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "TDR07", new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(934), null, null, null },
                    { 8, "8698943124593", "Taş Baskı Sızma Zeytin Yağı", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "TDR09", new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(935), null, null, null },
                    { 9, "86989431245494", "İlk Aşk Zeytin Yağı", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "TDR10", new DateTime(2023, 5, 30, 21, 38, 32, 523, DateTimeKind.Local).AddTicks(936), null, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stok_EnCokSatanUrunlerId",
                table: "Stok",
                column: "EnCokSatanUrunlerId");

            migrationBuilder.CreateIndex(
                name: "IX_Stok_KategoriId",
                table: "Stok",
                column: "KategoriId");

            migrationBuilder.CreateIndex(
                name: "IX_Stok_TavsiyeEdilenUrunlerId",
                table: "Stok",
                column: "TavsiyeEdilenUrunlerId");

            migrationBuilder.CreateIndex(
                name: "IX_Stok_UrunAciklamaId",
                table: "Stok",
                column: "UrunAciklamaId");

            migrationBuilder.CreateIndex(
                name: "IX_Stok_VitrinId",
                table: "Stok",
                column: "VitrinId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kullanici");

            migrationBuilder.DropTable(
                name: "Sepet");

            migrationBuilder.DropTable(
                name: "Stok");

            migrationBuilder.DropTable(
                name: "EnCokSatanUrunler");

            migrationBuilder.DropTable(
                name: "Kategori");

            migrationBuilder.DropTable(
                name: "TavsiyeEdilenUrunler");

            migrationBuilder.DropTable(
                name: "UrunAciklama");

            migrationBuilder.DropTable(
                name: "Vitrin");
        }
    }
}
