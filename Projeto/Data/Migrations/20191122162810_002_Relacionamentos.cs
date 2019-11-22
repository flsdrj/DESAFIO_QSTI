using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto.Data.Migrations
{
    public partial class _002_Relacionamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ClienteId",
                table: "Servico",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ServicoClienteId",
                table: "Servico",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ServicoClienteId",
                table: "Cliente",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servico_ClienteId",
                table: "Servico",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Servico_ServicoClienteId",
                table: "Servico",
                column: "ServicoClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_ExecucaoServico_ServicoClienteId",
                table: "ExecucaoServico",
                column: "ServicoClienteId",
                unique: true,
                filter: "[ServicoClienteId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_ServicoClienteId",
                table: "Cliente",
                column: "ServicoClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_ServicoCliente_ServicoClienteId",
                table: "Cliente",
                column: "ServicoClienteId",
                principalTable: "ServicoCliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ExecucaoServico_ServicoCliente_ServicoClienteId",
                table: "ExecucaoServico",
                column: "ServicoClienteId",
                principalTable: "ServicoCliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servico_Cliente_ClienteId",
                table: "Servico",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servico_ServicoCliente_ServicoClienteId",
                table: "Servico",
                column: "ServicoClienteId",
                principalTable: "ServicoCliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_ServicoCliente_ServicoClienteId",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_ExecucaoServico_ServicoCliente_ServicoClienteId",
                table: "ExecucaoServico");

            migrationBuilder.DropForeignKey(
                name: "FK_Servico_Cliente_ClienteId",
                table: "Servico");

            migrationBuilder.DropForeignKey(
                name: "FK_Servico_ServicoCliente_ServicoClienteId",
                table: "Servico");

            migrationBuilder.DropIndex(
                name: "IX_Servico_ClienteId",
                table: "Servico");

            migrationBuilder.DropIndex(
                name: "IX_Servico_ServicoClienteId",
                table: "Servico");

            migrationBuilder.DropIndex(
                name: "IX_ExecucaoServico_ServicoClienteId",
                table: "ExecucaoServico");

            migrationBuilder.DropIndex(
                name: "IX_Cliente_ServicoClienteId",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Servico");

            migrationBuilder.DropColumn(
                name: "ServicoClienteId",
                table: "Servico");

            migrationBuilder.DropColumn(
                name: "ServicoClienteId",
                table: "Cliente");
        }
    }
}
