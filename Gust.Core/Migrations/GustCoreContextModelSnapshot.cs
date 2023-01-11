﻿// <auto-generated />
using System;
using Gust.Core.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gust.Core.Migrations
{
    [DbContext(typeof(GustCoreContext))]
    partial class GustCoreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EquipoTarea", b =>
                {
                    b.Property<int>("EquiposId")
                        .HasColumnType("int");

                    b.Property<int>("TareasId")
                        .HasColumnType("int");

                    b.HasKey("EquiposId", "TareasId");

                    b.HasIndex("TareasId");

                    b.ToTable("EquipoTarea");
                });

            modelBuilder.Entity("Gust.Core.Areas.Identity.Data.Forms.Equipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<string>("CodigoBienesPatrimoniales")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime?>("FechaCompra")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Identificador")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int?>("LaboratorioId")
                        .HasColumnType("int");

                    b.Property<string>("Modelo")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("NombreEquipo")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("VidaUtilEstimada")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id")
                        .HasName("PK_Equipo_Id");

                    b.HasIndex("CodigoBienesPatrimoniales")
                        .IsUnique()
                        .HasFilter("[CodigoBienesPatrimoniales] IS NOT NULL");

                    b.HasIndex("Identificador")
                        .IsUnique()
                        .HasFilter("[Identificador] IS NOT NULL");

                    b.HasIndex("LaboratorioId");

                    b.ToTable("Equipo");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Activo = true,
                            CodigoBienesPatrimoniales = "E_PRUEBA_1",
                            Identificador = "EP1",
                            Modelo = "Modelo1",
                            NombreEquipo = "Equipo Prueba 1"
                        },
                        new
                        {
                            Id = 2,
                            Activo = true,
                            CodigoBienesPatrimoniales = "E_PRUEBA_2",
                            Identificador = "EP2",
                            Modelo = "Modelo2",
                            NombreEquipo = "Equipo Prueba 2"
                        },
                        new
                        {
                            Id = 3,
                            Activo = true,
                            CodigoBienesPatrimoniales = "E_PRUEBA_3",
                            Identificador = "EP3",
                            Modelo = "Modelo3",
                            NombreEquipo = "Equipo Prueba 3"
                        });
                });

            modelBuilder.Entity("Gust.Core.Areas.Identity.Data.Forms.Laboratorio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Activo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasDefaultValue(false);

                    b.Property<int?>("CantidadComputadoras")
                        .HasColumnType("int");

                    b.Property<int?>("CantidadMesas")
                        .HasColumnType("int");

                    b.Property<int?>("CantidadSillas")
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id")
                        .HasName("PK_Laboratorio_Id");

                    b.HasIndex("Codigo")
                        .IsUnique()
                        .HasFilter("[Codigo] IS NOT NULL");

                    b.ToTable("Laboratorio");
                });

            modelBuilder.Entity("Gust.Core.Areas.Identity.Data.Forms.Prestamo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CedulaPersona")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Duracion")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("EquipoId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("FechaDevolucion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("NombrePersona")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("UsuarioEntregaId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UsuarioRecibeId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id")
                        .HasName("PK_Prestamo_Id");

                    b.HasIndex("EquipoId");

                    b.HasIndex("UsuarioEntregaId");

                    b.HasIndex("UsuarioRecibeId");

                    b.ToTable("Prestamo");
                });

            modelBuilder.Entity("Gust.Core.Areas.Identity.Data.Forms.Reserva", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CedulaPersona")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("Duracion")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime?>("FechaDevolucion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("LabId")
                        .HasColumnType("int");

                    b.Property<string>("NombrePersona")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("UsuarioEntregaId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("UsuarioRecibeId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id")
                        .HasName("PK_Reserva_Id");

                    b.HasIndex("LabId");

                    b.HasIndex("UsuarioEntregaId");

                    b.HasIndex("UsuarioRecibeId");

                    b.ToTable("Reserva");
                });

            modelBuilder.Entity("Gust.Core.Areas.Identity.Data.GustCoreUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Cedula")
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nombre")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Posicion")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("Cedula")
                        .IsUnique()
                        .HasFilter("[Cedula] IS NOT NULL");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "77b64aaf-f270-4fe6-b0c6-3718af6ced19",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e90dc5cf-1187-4067-8454-61bf3f45c2ca",
                            Email = "luis.villalaz1@utp.ac.pa",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "LUIS.VILLALAZ1@UTP.AC.PA",
                            NormalizedUserName = "LUIS.VILLALAZ1@UTP.AC.PA",
                            PasswordHash = "AQAAAAEAACcQAAAAEMPxpgnyiQJodQ62KQJrbz5ekoHfBYz4e8R4X0MkZkm/BPbwzIbfae5mVhwOHCNv4g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "64b170e7-4ca3-4594-b64d-ea484fbb2ed5",
                            TwoFactorEnabled = false,
                            UserName = "luis.villalaz1@utp.ac.pa"
                        });
                });

            modelBuilder.Entity("Gust.Core.Areas.Identity.Data.States.EstadoTarea", b =>
                {
                    b.Property<short>("CodigoEstado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<short>("CodigoEstado"), 1L, 1);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CodigoEstado");

                    b.ToTable("EstadoTarea");
                });

            modelBuilder.Entity("Gust.Core.Areas.Identity.Data.Tasks.Tarea", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Especificacion")
                        .IsRequired()
                        .HasMaxLength(35)
                        .HasColumnType("nvarchar(35)");

                    b.Property<string>("EstadoTarea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaAsignacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaFinalizacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("PersonaEncargadaId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("PersonaEncargadaId");

                    b.ToTable("Tarea");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "fc2e50c4-b652-46d7-b025-cbf92b42bb38",
                            ConcurrencyStamp = "501d5b77-8a97-4e71-ab01-222cbf092c71",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "9bb6727e-7751-4754-b332-d89577981437",
                            ConcurrencyStamp = "3c332d7d-d63b-4cd5-bbb1-46c5d0508af2",
                            Name = "Tec",
                            NormalizedName = "TEC"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "77b64aaf-f270-4fe6-b0c6-3718af6ced19",
                            RoleId = "fc2e50c4-b652-46d7-b025-cbf92b42bb38"
                        },
                        new
                        {
                            UserId = "77b64aaf-f270-4fe6-b0c6-3718af6ced19",
                            RoleId = "9bb6727e-7751-4754-b332-d89577981437"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("EquipoTarea", b =>
                {
                    b.HasOne("Gust.Core.Areas.Identity.Data.Forms.Equipo", null)
                        .WithMany()
                        .HasForeignKey("EquiposId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gust.Core.Areas.Identity.Data.Tasks.Tarea", null)
                        .WithMany()
                        .HasForeignKey("TareasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gust.Core.Areas.Identity.Data.Forms.Equipo", b =>
                {
                    b.HasOne("Gust.Core.Areas.Identity.Data.Forms.Laboratorio", "Laboratorio")
                        .WithMany()
                        .HasForeignKey("LaboratorioId")
                        .HasConstraintName("FK_Equipo_LaboratorioId");

                    b.Navigation("Laboratorio");
                });

            modelBuilder.Entity("Gust.Core.Areas.Identity.Data.Forms.Prestamo", b =>
                {
                    b.HasOne("Gust.Core.Areas.Identity.Data.Forms.Equipo", "Equipo")
                        .WithMany("Prestamos")
                        .HasForeignKey("EquipoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gust.Core.Areas.Identity.Data.GustCoreUser", "UsuarioEntrega")
                        .WithMany()
                        .HasForeignKey("UsuarioEntregaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Prestamo_UsuarioEntregaId");

                    b.HasOne("Gust.Core.Areas.Identity.Data.GustCoreUser", "UsuarioRecibe")
                        .WithMany()
                        .HasForeignKey("UsuarioRecibeId")
                        .HasConstraintName("FK_Prestamo_UsuarioRecibeId");

                    b.Navigation("Equipo");

                    b.Navigation("UsuarioEntrega");

                    b.Navigation("UsuarioRecibe");
                });

            modelBuilder.Entity("Gust.Core.Areas.Identity.Data.Forms.Reserva", b =>
                {
                    b.HasOne("Gust.Core.Areas.Identity.Data.Forms.Laboratorio", "Laboratorio")
                        .WithMany("Reservas")
                        .HasForeignKey("LabId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gust.Core.Areas.Identity.Data.GustCoreUser", "UsuarioEntrega")
                        .WithMany()
                        .HasForeignKey("UsuarioEntregaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Reserva_UsuarioEntregaId");

                    b.HasOne("Gust.Core.Areas.Identity.Data.GustCoreUser", "UsuarioRecibe")
                        .WithMany()
                        .HasForeignKey("UsuarioRecibeId")
                        .HasConstraintName("FK_Reserva_UsuarioRecibeId");

                    b.Navigation("Laboratorio");

                    b.Navigation("UsuarioEntrega");

                    b.Navigation("UsuarioRecibe");
                });

            modelBuilder.Entity("Gust.Core.Areas.Identity.Data.Tasks.Tarea", b =>
                {
                    b.HasOne("Gust.Core.Areas.Identity.Data.GustCoreUser", "PersonaEncargada")
                        .WithMany()
                        .HasForeignKey("PersonaEncargadaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PersonaEncargada");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Gust.Core.Areas.Identity.Data.GustCoreUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Gust.Core.Areas.Identity.Data.GustCoreUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gust.Core.Areas.Identity.Data.GustCoreUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Gust.Core.Areas.Identity.Data.GustCoreUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Gust.Core.Areas.Identity.Data.Forms.Equipo", b =>
                {
                    b.Navigation("Prestamos");
                });

            modelBuilder.Entity("Gust.Core.Areas.Identity.Data.Forms.Laboratorio", b =>
                {
                    b.Navigation("Reservas");
                });
#pragma warning restore 612, 618
        }
    }
}
