using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gust.Core.Migrations
{
    public partial class Migrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Cedula = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    Posicion = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoTarea",
                columns: table => new
                {
                    CodigoEstado = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoTarea", x => x.CodigoEstado);
                });

            migrationBuilder.CreateTable(
                name: "Laboratorio",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Codigo = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    CantidadSillas = table.Column<int>(type: "int", nullable: true),
                    CantidadMesas = table.Column<int>(type: "int", nullable: true),
                    CantidadComputadoras = table.Column<int>(type: "int", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laboratorio_Id", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Especificacion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaAsignacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaFinalizacion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EstadoTarea = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PersonaEncargadaId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tarea_AspNetUsers_PersonaEncargadaId",
                        column: x => x.PersonaEncargadaId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Equipo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodigoBienesPatrimoniales = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Identificador = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    NombreEquipo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Modelo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    VidaUtilEstimada = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FechaCompra = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaRegistro = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LaboratorioId = table.Column<int>(type: "int", nullable: true),
                    Activo = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipo_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipo_LaboratorioId",
                        column: x => x.LaboratorioId,
                        principalTable: "Laboratorio",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reserva",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePersona = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CedulaPersona = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Duracion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FechaInicio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FechaDevolucion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LabId = table.Column<int>(type: "int", nullable: false),
                    UsuarioEntregaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UsuarioRecibeId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reserva_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reserva_Laboratorio_LabId",
                        column: x => x.LabId,
                        principalTable: "Laboratorio",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reserva_UsuarioEntregaId",
                        column: x => x.UsuarioEntregaId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reserva_UsuarioRecibeId",
                        column: x => x.UsuarioRecibeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Prestamo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePersona = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    CedulaPersona = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Duracion = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FechaInicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FechaDevolucion = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EquipoId = table.Column<int>(type: "int", nullable: false),
                    UsuarioEntregaId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UsuarioRecibeId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prestamo_Id", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prestamo_Equipo_EquipoId",
                        column: x => x.EquipoId,
                        principalTable: "Equipo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prestamo_UsuarioEntregaId",
                        column: x => x.UsuarioEntregaId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Prestamo_UsuarioRecibeId",
                        column: x => x.UsuarioRecibeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "332584b2-2d0e-4167-93d4-f51ca98936fc", "bc34bb8e-ad8f-40c4-a59c-316efa543fc5", "Administrador", "ADMINISTRADOR" },
                    { "8605fa21-d350-485f-a9fb-958ae7a8772d", "68c0052e-a690-41a9-acc6-9988db014fe2", "Tecnico", "TEC" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Cedula", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Nombre", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Posicion", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6393cacd-3132-4f24-8e83-196bcdb0499f", 0, null, "bd4e563f-9f06-476d-9758-a755051c0e0e", "omar.carvajal@utp.ac.pa", true, false, null, null, "OMAR.CARVAJAL@UTP.AC.PA", "OMAR.CARVAJAL@UTP.AC.PA", "AQAAAAEAACcQAAAAEHuPi39aQxPP+3jSquWPIe76M54P1WfttpjaCkZNZu4eeyRj7lvjg1wwOwujQzxT6w==", null, false, null, "86a81e9e-c9b1-4fba-9067-08d8e25bf474", false, "omar.carvajal@utp.ac.pa" });

            migrationBuilder.InsertData(
                table: "Laboratorio",
                columns: new[] { "Id", "Activo", "CantidadComputadoras", "CantidadMesas", "CantidadSillas", "Codigo" },
                values: new object[,]
                {
                    { 1, true, 20, 20, 20, "3-401" },
                    { 2, true, 20, 20, 20, "3-402" },
                    { 3, true, 20, 20, 20, "3-403" },
                    { 4, true, 20, 20, 20, "3-404" },
                    { 5, true, 20, 20, 20, "3-405" },
                    { 6, true, 20, 20, 20, "3-406" },
                    { 7, true, 20, 20, 20, "3-407" },
                    { 8, true, 20, 20, 20, "3-408" },
                    { 9, true, 20, 20, 20, "3-409" },
                    { 10, true, 20, 20, 20, "3-410" },
                    { 11, true, 20, 20, 20, "3-BG01" },
                    { 12, true, 20, 20, 20, "3-411" },
                    { 13, true, 20, 20, 20, "3-412" },
                    { 14, true, 20, 20, 20, "3-413" },
                    { 15, true, 20, 20, 20, "3-414" },
                    { 16, true, 20, 20, 20, "3-415" },
                    { 17, true, 20, 20, 20, "3-416" },
                    { 18, true, 20, 20, 20, "3-417" },
                    { 19, true, 20, 20, 20, "3-418" },
                    { 20, true, 20, 20, 20, "3-419" },
                    { 21, true, 20, 20, 20, "3-420" },
                    { 22, true, 20, 20, 20, "3-421" },
                    { 23, true, 20, 20, 20, "3-422" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "332584b2-2d0e-4167-93d4-f51ca98936fc", "6393cacd-3132-4f24-8e83-196bcdb0499f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8605fa21-d350-485f-a9fb-958ae7a8772d", "6393cacd-3132-4f24-8e83-196bcdb0499f" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_Cedula",
                table: "AspNetUsers",
                column: "Cedula",
                unique: true,
                filter: "[Cedula] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_CodigoBienesPatrimoniales",
                table: "Equipo",
                column: "CodigoBienesPatrimoniales",
                unique: true,
                filter: "[CodigoBienesPatrimoniales] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_Identificador",
                table: "Equipo",
                column: "Identificador",
                unique: true,
                filter: "[Identificador] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Equipo_LaboratorioId",
                table: "Equipo",
                column: "LaboratorioId");

            migrationBuilder.CreateIndex(
                name: "IX_Laboratorio_Codigo",
                table: "Laboratorio",
                column: "Codigo",
                unique: true,
                filter: "[Codigo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_EquipoId",
                table: "Prestamo",
                column: "EquipoId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_UsuarioEntregaId",
                table: "Prestamo",
                column: "UsuarioEntregaId");

            migrationBuilder.CreateIndex(
                name: "IX_Prestamo_UsuarioRecibeId",
                table: "Prestamo",
                column: "UsuarioRecibeId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_LabId",
                table: "Reserva",
                column: "LabId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_UsuarioEntregaId",
                table: "Reserva",
                column: "UsuarioEntregaId");

            migrationBuilder.CreateIndex(
                name: "IX_Reserva_UsuarioRecibeId",
                table: "Reserva",
                column: "UsuarioRecibeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_PersonaEncargadaId",
                table: "Tarea",
                column: "PersonaEncargadaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "EstadoTarea");

            migrationBuilder.DropTable(
                name: "Prestamo");

            migrationBuilder.DropTable(
                name: "Reserva");

            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Equipo");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Laboratorio");
        }
    }
}
