﻿// <auto-generated />
using System;
using Controle.Cursos.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Controle.Cursos.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20221016150342_m003")]
    partial class m003
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("Controle.Cursos.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("TurmaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TurmaId");

                    b.ToTable("Aluno");
                });

            modelBuilder.Entity("Controle.Cursos.Models.Curso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("AlunoId")
                        .HasColumnType("int");

                    b.Property<int?>("FornecedorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Horario")
                        .HasColumnType("datetime2");

                    b.Property<int>("Modalidade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AlunoId");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("Controle.Cursos.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Cnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("InscricaoEstadual")
                        .HasColumnType("int");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Fornecedor");
                });

            modelBuilder.Entity("Controle.Cursos.Models.Turma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("Concluida")
                        .HasColumnType("bit");

                    b.Property<int>("CursoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataFinalizacao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Periodo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CursoId");

                    b.ToTable("Turma");
                });

            modelBuilder.Entity("Controle.Cursos.Models.Aluno", b =>
                {
                    b.HasOne("Controle.Cursos.Models.Turma", null)
                        .WithMany("Alunos")
                        .HasForeignKey("TurmaId");
                });

            modelBuilder.Entity("Controle.Cursos.Models.Curso", b =>
                {
                    b.HasOne("Controle.Cursos.Models.Aluno", null)
                        .WithMany("Cursos")
                        .HasForeignKey("AlunoId");

                    b.HasOne("Controle.Cursos.Models.Fornecedor", "Fornecedor")
                        .WithMany()
                        .HasForeignKey("FornecedorId");

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("Controle.Cursos.Models.Turma", b =>
                {
                    b.HasOne("Controle.Cursos.Models.Curso", "Curso")
                        .WithMany("Turmas")
                        .HasForeignKey("CursoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Curso");
                });

            modelBuilder.Entity("Controle.Cursos.Models.Aluno", b =>
                {
                    b.Navigation("Cursos");
                });

            modelBuilder.Entity("Controle.Cursos.Models.Curso", b =>
                {
                    b.Navigation("Turmas");
                });

            modelBuilder.Entity("Controle.Cursos.Models.Turma", b =>
                {
                    b.Navigation("Alunos");
                });
#pragma warning restore 612, 618
        }
    }
}
