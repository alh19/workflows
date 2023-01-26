﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sandwich2Go.Data;

namespace Sandwich2Go.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
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

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
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

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
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

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Sandwich2Go.Models.AlergSandw", b =>
                {
                    b.Property<int>("IngredienteId")
                        .HasColumnType("int");

                    b.Property<int>("AlergenoId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("IngredienteId", "AlergenoId");

                    b.HasIndex("AlergenoId");

                    b.ToTable("AlergSandws");
                });

            modelBuilder.Entity("Sandwich2Go.Models.Alergeno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("id");

                    b.ToTable("Alergeno");
                });

            modelBuilder.Entity("Sandwich2Go.Models.IngrPedProv", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("IngrProvId")
                        .HasColumnType("int");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int>("PedidoProvId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IngrProvId");

                    b.HasIndex("PedidoId");

                    b.ToTable("IngrPedProv");
                });

            modelBuilder.Entity("Sandwich2Go.Models.IngrProv", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IngredienteId")
                        .HasColumnType("int");

                    b.Property<int>("ProveedorId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IngredienteId");

                    b.HasIndex("ProveedorId");

                    b.ToTable("IngrProv");
                });

            modelBuilder.Entity("Sandwich2Go.Models.Ingrediente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int>("PrecioUnitario")
                        .HasColumnType("int");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasAlternateKey("Nombre");

                    b.ToTable("Ingrediente");
                });

            modelBuilder.Entity("Sandwich2Go.Models.IngredienteSandwich", b =>
                {
                    b.Property<int>("IngredienteId")
                        .HasColumnType("int");

                    b.Property<int>("SandwichId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("IngredienteId", "SandwichId");

                    b.HasIndex("SandwichId");

                    b.ToTable("IngredienteSandwich");
                });

            modelBuilder.Entity("Sandwich2Go.Models.MetodoDePago", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MetodoDePago");

                    b.HasDiscriminator<string>("Discriminator").HasValue("MetodoDePago");
                });

            modelBuilder.Entity("Sandwich2Go.Models.Oferta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("datetime2");

                    b.Property<string>("GerenteId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("GerenteId");

                    b.ToTable("Oferta");
                });

            modelBuilder.Entity("Sandwich2Go.Models.OfertaSandwich", b =>
                {
                    b.Property<int>("OfertaId")
                        .HasColumnType("int");

                    b.Property<int>("SandwichId")
                        .HasColumnType("int");

                    b.Property<double>("Porcentaje")
                        .HasColumnType("float");

                    b.HasKey("OfertaId", "SandwichId");

                    b.HasIndex("SandwichId");

                    b.ToTable("OfertaSandwich");
                });

            modelBuilder.Entity("Sandwich2Go.Models.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<string>("ClienteId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("MetodoDePagoId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Preciototal")
                        .HasColumnType("float");

                    b.Property<int?>("SandwCreadoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("MetodoDePagoId");

                    b.HasIndex("SandwCreadoId");

                    b.ToTable("Pedido");
                });

            modelBuilder.Entity("Sandwich2Go.Models.PedidoProv", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DireccionEnvio")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaPedido")
                        .HasColumnType("datetime2");

                    b.Property<string>("GerenteId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("MetodoDePagoId")
                        .HasColumnType("int");

                    b.Property<double>("PrecioTotal")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("GerenteId");

                    b.HasIndex("MetodoDePagoId");

                    b.ToTable("PedidoProv");
                });

            modelBuilder.Entity("Sandwich2Go.Models.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cif")
                        .IsRequired()
                        .HasMaxLength(8)
                        .HasColumnType("nvarchar(8)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Cif");

                    b.ToTable("Proveedor");
                });

            modelBuilder.Entity("Sandwich2Go.Models.Sandwich", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.Property<string>("SandwichName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.HasAlternateKey("SandwichName");

                    b.ToTable("Sandwich");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Sandwich");
                });

            modelBuilder.Entity("Sandwich2Go.Models.SandwichPedido", b =>
                {
                    b.Property<int>("SandwichId")
                        .HasColumnType("int");

                    b.Property<int>("PedidoId")
                        .HasColumnType("int");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.HasKey("SandwichId", "PedidoId");

                    b.HasIndex("PedidoId");

                    b.ToTable("SandwichPedido");
                });

            modelBuilder.Entity("Sandwich2Go.Models.Cliente", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("FechaUltimaCompra")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("TarjetaCredito")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Cliente");
                });

            modelBuilder.Entity("Sandwich2Go.Models.Gerente", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("FechaContratacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .ValueGeneratedOnUpdateSometimes()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<double>("Salario")
                        .HasColumnType("float");

                    b.HasDiscriminator().HasValue("Gerente");
                });

            modelBuilder.Entity("Sandwich2Go.Models.Efectivo", b =>
                {
                    b.HasBaseType("Sandwich2Go.Models.MetodoDePago");

                    b.Property<bool>("NecesitasCambio")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("Efectivo");
                });

            modelBuilder.Entity("Sandwich2Go.Models.Tarjeta", b =>
                {
                    b.HasBaseType("Sandwich2Go.Models.MetodoDePago");

                    b.Property<int>("AnoCaducidad")
                        .HasColumnType("int");

                    b.Property<int>("CCV")
                        .HasColumnType("int");

                    b.Property<int>("MesCaducidad")
                        .HasColumnType("int");

                    b.Property<long>("Numero")
                        .HasColumnType("bigint");

                    b.Property<string>("Titular")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Tarjeta");
                });

            modelBuilder.Entity("Sandwich2Go.Models.SandwCreado", b =>
                {
                    b.HasBaseType("Sandwich2Go.Models.Sandwich");

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("SandwCreado");
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Sandwich2Go.Models.AlergSandw", b =>
                {
                    b.HasOne("Sandwich2Go.Models.Alergeno", "Alergeno")
                        .WithMany("AlergSandws")
                        .HasForeignKey("AlergenoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sandwich2Go.Models.Ingrediente", "Ingrediente")
                        .WithMany("AlergSandws")
                        .HasForeignKey("IngredienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Alergeno");

                    b.Navigation("Ingrediente");
                });

            modelBuilder.Entity("Sandwich2Go.Models.IngrPedProv", b =>
                {
                    b.HasOne("Sandwich2Go.Models.IngrProv", "IngrProv")
                        .WithMany("IngrPedProvs")
                        .HasForeignKey("IngrProvId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sandwich2Go.Models.PedidoProv", "PedidoProv")
                        .WithMany("IngrPedProv")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IngrProv");

                    b.Navigation("PedidoProv");
                });

            modelBuilder.Entity("Sandwich2Go.Models.IngrProv", b =>
                {
                    b.HasOne("Sandwich2Go.Models.Ingrediente", "Ingrediente")
                        .WithMany("IngrProv")
                        .HasForeignKey("IngredienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sandwich2Go.Models.Proveedor", "Proveedor")
                        .WithMany("IngrProv")
                        .HasForeignKey("ProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingrediente");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("Sandwich2Go.Models.IngredienteSandwich", b =>
                {
                    b.HasOne("Sandwich2Go.Models.Ingrediente", "Ingrediente")
                        .WithMany("IngredienteSandwich")
                        .HasForeignKey("IngredienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sandwich2Go.Models.Sandwich", "Sandwich")
                        .WithMany("IngredienteSandwich")
                        .HasForeignKey("SandwichId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ingrediente");

                    b.Navigation("Sandwich");
                });

            modelBuilder.Entity("Sandwich2Go.Models.Oferta", b =>
                {
                    b.HasOne("Sandwich2Go.Models.Gerente", "Gerente")
                        .WithMany("Oferta")
                        .HasForeignKey("GerenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Gerente");
                });

            modelBuilder.Entity("Sandwich2Go.Models.OfertaSandwich", b =>
                {
                    b.HasOne("Sandwich2Go.Models.Oferta", "Oferta")
                        .WithMany("OfertaSandwich")
                        .HasForeignKey("OfertaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sandwich2Go.Models.Sandwich", "Sandwich")
                        .WithMany("OfertaSandwich")
                        .HasForeignKey("SandwichId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Oferta");

                    b.Navigation("Sandwich");
                });

            modelBuilder.Entity("Sandwich2Go.Models.Pedido", b =>
                {
                    b.HasOne("Sandwich2Go.Models.Cliente", "Cliente")
                        .WithMany("Pedidos")
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sandwich2Go.Models.MetodoDePago", "MetodoDePago")
                        .WithMany("Pedidos")
                        .HasForeignKey("MetodoDePagoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sandwich2Go.Models.SandwCreado", "SandwCreado")
                        .WithMany("Pedidos")
                        .HasForeignKey("SandwCreadoId");

                    b.Navigation("Cliente");

                    b.Navigation("MetodoDePago");

                    b.Navigation("SandwCreado");
                });

            modelBuilder.Entity("Sandwich2Go.Models.PedidoProv", b =>
                {
                    b.HasOne("Sandwich2Go.Models.Gerente", "Gerente")
                        .WithMany("PedidoProv")
                        .HasForeignKey("GerenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sandwich2Go.Models.MetodoDePago", "MetodoDePago")
                        .WithMany("PedidoProvs")
                        .HasForeignKey("MetodoDePagoId");

                    b.Navigation("Gerente");

                    b.Navigation("MetodoDePago");
                });

            modelBuilder.Entity("Sandwich2Go.Models.SandwichPedido", b =>
                {
                    b.HasOne("Sandwich2Go.Models.Pedido", "Pedido")
                        .WithMany("sandwichesPedidos")
                        .HasForeignKey("PedidoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sandwich2Go.Models.Sandwich", "Sandwich")
                        .WithMany("SandwichPedido")
                        .HasForeignKey("SandwichId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pedido");

                    b.Navigation("Sandwich");
                });

            modelBuilder.Entity("Sandwich2Go.Models.Alergeno", b =>
                {
                    b.Navigation("AlergSandws");
                });

            modelBuilder.Entity("Sandwich2Go.Models.IngrProv", b =>
                {
                    b.Navigation("IngrPedProvs");
                });

            modelBuilder.Entity("Sandwich2Go.Models.Ingrediente", b =>
                {
                    b.Navigation("AlergSandws");

                    b.Navigation("IngredienteSandwich");

                    b.Navigation("IngrProv");
                });

            modelBuilder.Entity("Sandwich2Go.Models.MetodoDePago", b =>
                {
                    b.Navigation("PedidoProvs");

                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Sandwich2Go.Models.Oferta", b =>
                {
                    b.Navigation("OfertaSandwich");
                });

            modelBuilder.Entity("Sandwich2Go.Models.Pedido", b =>
                {
                    b.Navigation("sandwichesPedidos");
                });

            modelBuilder.Entity("Sandwich2Go.Models.PedidoProv", b =>
                {
                    b.Navigation("IngrPedProv");
                });

            modelBuilder.Entity("Sandwich2Go.Models.Proveedor", b =>
                {
                    b.Navigation("IngrProv");
                });

            modelBuilder.Entity("Sandwich2Go.Models.Sandwich", b =>
                {
                    b.Navigation("IngredienteSandwich");

                    b.Navigation("OfertaSandwich");

                    b.Navigation("SandwichPedido");
                });

            modelBuilder.Entity("Sandwich2Go.Models.Cliente", b =>
                {
                    b.Navigation("Pedidos");
                });

            modelBuilder.Entity("Sandwich2Go.Models.Gerente", b =>
                {
                    b.Navigation("Oferta");

                    b.Navigation("PedidoProv");
                });

            modelBuilder.Entity("Sandwich2Go.Models.SandwCreado", b =>
                {
                    b.Navigation("Pedidos");
                });
#pragma warning restore 612, 618
        }
    }
}