﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Teste_Piloto.Server.Data;

namespace Teste_Piloto.Server.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200612231839_MigrationChefia")]
    partial class MigrationChefia
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Faculdade_FUP_Project.Server.Models.Aluno", b =>
                {
                    b.Property<int>("AlunoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<int?>("CursoId_Curso")
                        .HasColumnType("int");

                    b.Property<int>("CursosId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataInicioCurso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataTerminoCurso")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Datanascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FinanceiroId")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.Property<string>("Telefone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AlunoId");

                    b.HasIndex("CursoId_Curso");

                    b.HasIndex("FinanceiroId");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("Faculdade_FUP_Project.Server.Models.Chefia", b =>
                {
                    b.Property<int>("ChefiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeChefia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Setor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ChefiaId");

                    b.ToTable("Chefias");
                });

            modelBuilder.Entity("Faculdade_FUP_Project.Server.Models.Curso", b =>
                {
                    b.Property<int>("Id_Curso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("NomeCurso")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("ProfessorCurso")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<decimal>("ValorCurso")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id_Curso");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("Faculdade_FUP_Project.Server.Models.Financeiro", b =>
                {
                    b.Property<int>("FinanceiroId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("FinanceiroId");

                    b.ToTable("Finaiceiros");
                });

            modelBuilder.Entity("Faculdade_FUP_Project.Server.Models.Funcionario", b =>
                {
                    b.Property<int>("FuncionarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(11)")
                        .HasMaxLength(11);

                    b.Property<DateTime>("DataContratacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DataDemissao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Datanascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FinanceiroId")
                        .HasColumnType("int");

                    b.Property<int?>("Funcionario")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.Property<string>("NomeFuncionario")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<string>("Rg")
                        .IsRequired()
                        .HasColumnType("nvarchar(9)")
                        .HasMaxLength(9);

                    b.Property<decimal>("SalarioFuncionario")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FuncionarioId");

                    b.HasIndex("FinanceiroId");

                    b.HasIndex("Funcionario");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("Faculdade_FUP_Project.Server.Models.Aluno", b =>
                {
                    b.HasOne("Faculdade_FUP_Project.Server.Models.Curso", "Curso")
                        .WithMany("Aluno")
                        .HasForeignKey("CursoId_Curso");

                    b.HasOne("Faculdade_FUP_Project.Server.Models.Financeiro", null)
                        .WithMany("Alunos")
                        .HasForeignKey("FinanceiroId");
                });

            modelBuilder.Entity("Faculdade_FUP_Project.Server.Models.Funcionario", b =>
                {
                    b.HasOne("Faculdade_FUP_Project.Server.Models.Financeiro", null)
                        .WithMany("Funcionarios")
                        .HasForeignKey("FinanceiroId");

                    b.HasOne("Faculdade_FUP_Project.Server.Models.Chefia", "Chefia")
                        .WithMany("Funcionarios")
                        .HasForeignKey("Funcionario");
                });
#pragma warning restore 612, 618
        }
    }
}
