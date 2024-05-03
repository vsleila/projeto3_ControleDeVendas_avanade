﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoControleVendas.Data;

#nullable disable

namespace MiniMundo.Migrations
{
    [DbContext(typeof(ProjetoControleVendasContext))]
    [Migration("20240503120952_ClienteAdd")]
    partial class ClienteAdd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MiniMundo.Models.Clientes", b =>
                {
                    b.Property<int>("ClientesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClientesID"));

                    b.Property<string>("Atividade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Bairro")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CPF")
                        .HasColumnType("int");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.HasKey("ClientesID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("MiniMundo.Models.NivelDeAcesso", b =>
                {
                    b.Property<int>("NivelDeAcessoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NivelDeAcessoID"));

                    b.HasKey("NivelDeAcessoID");

                    b.ToTable("NivelDeAcesso");
                });

            modelBuilder.Entity("ProjetoControleVendas.Models.Funcionarios", b =>
                {
                    b.Property<int>("FuncionariosID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FuncionariosID"));

                    b.Property<DateTime>("DtCad")
                        .HasColumnType("datetime2");

                    b.Property<string>("Funcao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Salario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Senha")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Telefone")
                        .HasColumnType("int");

                    b.HasKey("FuncionariosID");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("ProjetoControleVendas.Models.Produtos", b =>
                {
                    b.Property<int>("ProdutosID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdutosID"));

                    b.Property<string>("Categoria")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuantidadeEmEstoque")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProdutosID");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("ProjetoControleVendas.Models.Vendas", b =>
                {
                    b.Property<int>("VendasID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VendasID"));

                    b.Property<string>("FuncionarioVenda")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<int>("ValorTotal")
                        .HasColumnType("int");

                    b.HasKey("VendasID");

                    b.ToTable("Vendas");
                });
#pragma warning restore 612, 618
        }
    }
}
