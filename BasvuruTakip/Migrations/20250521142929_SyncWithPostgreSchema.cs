using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BasvuruTakip.Migrations
{
    /// <inheritdoc />
    public partial class SyncWithPostgreSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PersonelIsBasvurulari_Personeller_PersonelId",
                table: "PersonelIsBasvurulari");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Personeller",
                table: "Personeller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PersonelIsBasvurulari",
                table: "PersonelIsBasvurulari");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Iller",
                table: "Iller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Ilceler",
                table: "Ilceler");

            migrationBuilder.RenameTable(
                name: "Personeller",
                newName: "personeller");

            migrationBuilder.RenameTable(
                name: "PersonelIsBasvurulari",
                newName: "personelisbasvurulari");

            migrationBuilder.RenameTable(
                name: "Iller",
                newName: "iller");

            migrationBuilder.RenameTable(
                name: "Ilceler",
                newName: "ilceler");

            migrationBuilder.RenameColumn(
                name: "IlceId",
                table: "personeller",
                newName: "ilceid");

            migrationBuilder.RenameColumn(
                name: "IlId",
                table: "personeller",
                newName: "ilid");

            migrationBuilder.RenameColumn(
                name: "DogumTarihi",
                table: "personeller",
                newName: "dogumtarihi");

            migrationBuilder.RenameColumn(
                name: "Cinsiyet",
                table: "personeller",
                newName: "cinsiyet");

            migrationBuilder.RenameColumn(
                name: "AdiSoyadi",
                table: "personeller",
                newName: "adisoyadi");

            migrationBuilder.RenameColumn(
                name: "Aciklama",
                table: "personeller",
                newName: "aciklama");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "personeller",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "SeyahatEngeliYok",
                table: "personelisbasvurulari",
                newName: "seyahatengeliyok");

            migrationBuilder.RenameColumn(
                name: "Pozisyon",
                table: "personelisbasvurulari",
                newName: "pozisyon");

            migrationBuilder.RenameColumn(
                name: "PersonelId",
                table: "personelisbasvurulari",
                newName: "personelid");

            migrationBuilder.RenameColumn(
                name: "IsyeriAdi",
                table: "personelisbasvurulari",
                newName: "isyeriadi");

            migrationBuilder.RenameColumn(
                name: "IlId",
                table: "personelisbasvurulari",
                newName: "ilid");

            migrationBuilder.RenameColumn(
                name: "BasvuruTarihi",
                table: "personelisbasvurulari",
                newName: "basvurutarihi");

            migrationBuilder.RenameColumn(
                name: "Aciklama",
                table: "personelisbasvurulari",
                newName: "aciklama");

            migrationBuilder.RenameIndex(
                name: "IX_PersonelIsBasvurulari_PersonelId",
                table: "personelisbasvurulari",
                newName: "IX_personelisbasvurulari_personelid");

            migrationBuilder.RenameColumn(
                name: "Adi",
                table: "iller",
                newName: "adi");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "iller",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "IlId",
                table: "ilceler",
                newName: "ilid");

            migrationBuilder.RenameColumn(
                name: "Adi",
                table: "ilceler",
                newName: "adi");

            migrationBuilder.RenameColumn(
                name: "IlceId",
                table: "ilceler",
                newName: "ilceid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_personeller",
                table: "personeller",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_personelisbasvurulari",
                table: "personelisbasvurulari",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_iller",
                table: "iller",
                column: "id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ilceler",
                table: "ilceler",
                column: "ilceid");

            migrationBuilder.AddForeignKey(
                name: "FK_personelisbasvurulari_personeller_personelid",
                table: "personelisbasvurulari",
                column: "personelid",
                principalTable: "personeller",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personelisbasvurulari_personeller_personelid",
                table: "personelisbasvurulari");

            migrationBuilder.DropPrimaryKey(
                name: "PK_personeller",
                table: "personeller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_personelisbasvurulari",
                table: "personelisbasvurulari");

            migrationBuilder.DropPrimaryKey(
                name: "PK_iller",
                table: "iller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ilceler",
                table: "ilceler");

            migrationBuilder.RenameTable(
                name: "personeller",
                newName: "Personeller");

            migrationBuilder.RenameTable(
                name: "personelisbasvurulari",
                newName: "PersonelIsBasvurulari");

            migrationBuilder.RenameTable(
                name: "iller",
                newName: "Iller");

            migrationBuilder.RenameTable(
                name: "ilceler",
                newName: "Ilceler");

            migrationBuilder.RenameColumn(
                name: "ilid",
                table: "Personeller",
                newName: "IlId");

            migrationBuilder.RenameColumn(
                name: "ilceid",
                table: "Personeller",
                newName: "IlceId");

            migrationBuilder.RenameColumn(
                name: "dogumtarihi",
                table: "Personeller",
                newName: "DogumTarihi");

            migrationBuilder.RenameColumn(
                name: "cinsiyet",
                table: "Personeller",
                newName: "Cinsiyet");

            migrationBuilder.RenameColumn(
                name: "adisoyadi",
                table: "Personeller",
                newName: "AdiSoyadi");

            migrationBuilder.RenameColumn(
                name: "aciklama",
                table: "Personeller",
                newName: "Aciklama");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Personeller",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "seyahatengeliyok",
                table: "PersonelIsBasvurulari",
                newName: "SeyahatEngeliYok");

            migrationBuilder.RenameColumn(
                name: "pozisyon",
                table: "PersonelIsBasvurulari",
                newName: "Pozisyon");

            migrationBuilder.RenameColumn(
                name: "personelid",
                table: "PersonelIsBasvurulari",
                newName: "PersonelId");

            migrationBuilder.RenameColumn(
                name: "isyeriadi",
                table: "PersonelIsBasvurulari",
                newName: "IsyeriAdi");

            migrationBuilder.RenameColumn(
                name: "ilid",
                table: "PersonelIsBasvurulari",
                newName: "IlId");

            migrationBuilder.RenameColumn(
                name: "basvurutarihi",
                table: "PersonelIsBasvurulari",
                newName: "BasvuruTarihi");

            migrationBuilder.RenameColumn(
                name: "aciklama",
                table: "PersonelIsBasvurulari",
                newName: "Aciklama");

            migrationBuilder.RenameIndex(
                name: "IX_personelisbasvurulari_personelid",
                table: "PersonelIsBasvurulari",
                newName: "IX_PersonelIsBasvurulari_PersonelId");

            migrationBuilder.RenameColumn(
                name: "adi",
                table: "Iller",
                newName: "Adi");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Iller",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ilid",
                table: "Ilceler",
                newName: "IlId");

            migrationBuilder.RenameColumn(
                name: "adi",
                table: "Ilceler",
                newName: "Adi");

            migrationBuilder.RenameColumn(
                name: "ilceid",
                table: "Ilceler",
                newName: "IlceId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Personeller",
                table: "Personeller",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PersonelIsBasvurulari",
                table: "PersonelIsBasvurulari",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Iller",
                table: "Iller",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Ilceler",
                table: "Ilceler",
                column: "IlceId");

            migrationBuilder.AddForeignKey(
                name: "FK_PersonelIsBasvurulari_Personeller_PersonelId",
                table: "PersonelIsBasvurulari",
                column: "PersonelId",
                principalTable: "Personeller",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
