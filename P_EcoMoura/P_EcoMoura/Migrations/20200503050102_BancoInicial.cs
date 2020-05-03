using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace P_EcoMoura.Migrations
{
    public partial class BancoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    idEmpresa = table.Column<int>(nullable: true),
                    razaoSocial = table.Column<string>(nullable: true),
                    cnpj = table.Column<string>(nullable: true),
                    telefone = table.Column<string>(nullable: true),
                    celular = table.Column<string>(nullable: true),
                    saldoBIN = table.Column<decimal>(nullable: false),
                    idRota = table.Column<int>(nullable: true),
                    situacao = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.id);
                    table.ForeignKey(
                        name: "FK_Clientes_Clientes_idEmpresa",
                        column: x => x.idEmpresa,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Clientes_Clientes_idRota",
                        column: x => x.idRota,
                        principalTable: "Clientes",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_idEmpresa",
                table: "Clientes",
                column: "idEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_idRota",
                table: "Clientes",
                column: "idRota");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
