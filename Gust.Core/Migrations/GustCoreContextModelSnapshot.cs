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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-401"
                        },
                        new
                        {
                            Id = 2,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-402"
                        },
                        new
                        {
                            Id = 3,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-403"
                        },
                        new
                        {
                            Id = 4,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-404"
                        },
                        new
                        {
                            Id = 5,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-405"
                        },
                        new
                        {
                            Id = 6,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-406"
                        },
                        new
                        {
                            Id = 7,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-407"
                        },
                        new
                        {
                            Id = 8,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-408"
                        },
                        new
                        {
                            Id = 9,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-409"
                        },
                        new
                        {
                            Id = 10,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-410"
                        },
                        new
                        {
                            Id = 11,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-BG01"
                        },
                        new
                        {
                            Id = 12,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-411"
                        },
                        new
                        {
                            Id = 13,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-412"
                        },
                        new
                        {
                            Id = 14,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-413"
                        },
                        new
                        {
                            Id = 15,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-414"
                        },
                        new
                        {
                            Id = 16,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-415"
                        },
                        new
                        {
                            Id = 17,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-416"
                        },
                        new
                        {
                            Id = 18,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-417"
                        },
                        new
                        {
                            Id = 19,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-418"
                        },
                        new
                        {
                            Id = 20,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-419"
                        },
                        new
                        {
                            Id = 21,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-420"
                        },
                        new
                        {
                            Id = 22,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-421"
                        },
                        new
                        {
                            Id = 23,
                            Activo = true,
                            CantidadComputadoras = 20,
                            CantidadMesas = 20,
                            CantidadSillas = 20,
                            Codigo = "3-422"
                        });
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

                    b.Property<string>("FechaDevolucion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FechaInicio")
                        .HasColumnType("nvarchar(max)");

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
                            Id = "6393cacd-3132-4f24-8e83-196bcdb0499f",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bd4e563f-9f06-476d-9758-a755051c0e0e",
                            Email = "omar.carvajal@utp.ac.pa",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "OMAR.CARVAJAL@UTP.AC.PA",
                            NormalizedUserName = "OMAR.CARVAJAL@UTP.AC.PA",
                            PasswordHash = "AQAAAAEAACcQAAAAEHuPi39aQxPP+3jSquWPIe76M54P1WfttpjaCkZNZu4eeyRj7lvjg1wwOwujQzxT6w==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "86a81e9e-c9b1-4fba-9067-08d8e25bf474",
                            TwoFactorEnabled = false,
                            UserName = "omar.carvajal@utp.ac.pa"
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EstadoTarea")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaAsignacion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaFinalizacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

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
                            Id = "332584b2-2d0e-4167-93d4-f51ca98936fc",
                            ConcurrencyStamp = "bc34bb8e-ad8f-40c4-a59c-316efa543fc5",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        },
                        new
                        {
                            Id = "8605fa21-d350-485f-a9fb-958ae7a8772d",
                            ConcurrencyStamp = "68c0052e-a690-41a9-acc6-9988db014fe2",
                            Name = "Tecnico",
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
                            UserId = "6393cacd-3132-4f24-8e83-196bcdb0499f",
                            RoleId = "332584b2-2d0e-4167-93d4-f51ca98936fc"
                        },
                        new
                        {
                            UserId = "6393cacd-3132-4f24-8e83-196bcdb0499f",
                            RoleId = "8605fa21-d350-485f-a9fb-958ae7a8772d"
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
