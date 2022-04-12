﻿// <auto-generated />
using System;
using ChivoFlixDesktop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ChivoFlixDesktop.Migrations
{
    [DbContext(typeof(CHIVOFLIXContext))]
    [Migration("20220412032454_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ChivoFlixDesktop.Models.DuracionPlanes", b =>
                {
                    b.Property<int>("IdDuracionPlanes")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idDuracionPlanes")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnName("nombre")
                        .HasColumnType("varchar(200)")
                        .HasMaxLength(200)
                        .IsUnicode(false);

                    b.HasKey("IdDuracionPlanes")
                        .HasName("PK__duracion__812FA85D5C9C4FEC");

                    b.ToTable("duracionPlanes");
                });

            modelBuilder.Entity("ChivoFlixDesktop.Models.Facturaciones", b =>
                {
                    b.Property<int>("IdFacturaciones")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idFacturaciones")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("FechaAdquirido")
                        .HasColumnName("fechaAdquirido")
                        .HasColumnType("datetime");

                    b.Property<int>("IdPlanes")
                        .HasColumnName("idPlanes")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuarios")
                        .HasColumnName("idUsuarios")
                        .HasColumnType("int");

                    b.Property<string>("Plann")
                        .IsRequired()
                        .HasColumnName("plann")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<double>("Precio")
                        .HasColumnName("precio")
                        .HasColumnType("float");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnName("tipo")
                        .HasColumnType("varchar(30)")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<double>("Total")
                        .HasColumnName("total")
                        .HasColumnType("float");

                    b.HasKey("IdFacturaciones")
                        .HasName("PK__facturac__85C535F2CEB63A25");

                    b.HasIndex("IdPlanes");

                    b.HasIndex("IdUsuarios");

                    b.ToTable("facturaciones");
                });

            modelBuilder.Entity("ChivoFlixDesktop.Models.Generos", b =>
                {
                    b.Property<int>("IdGeneros")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idGeneros")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnName("nombre")
                        .HasColumnType("varchar(25)")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.HasKey("IdGeneros")
                        .HasName("PK__generos__525F69B89698BFBB");

                    b.ToTable("generos");
                });

            modelBuilder.Entity("ChivoFlixDesktop.Models.Listados", b =>
                {
                    b.Property<int>("IdListado")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idListado")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdPeliculas")
                        .HasColumnName("idPeliculas")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuarios")
                        .HasColumnName("idUsuarios")
                        .HasColumnType("int");

                    b.HasKey("IdListado")
                        .HasName("PK__listados__EEA3B4656600FBF7");

                    b.HasIndex("IdPeliculas");

                    b.HasIndex("IdUsuarios");

                    b.ToTable("listados");
                });

            modelBuilder.Entity("ChivoFlixDesktop.Models.Peliculas", b =>
                {
                    b.Property<int>("IdPeliculas")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idPeliculas")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnioEstreno")
                        .HasColumnName("anioEstreno")
                        .HasColumnType("int");

                    b.Property<string>("Banner")
                        .IsRequired()
                        .HasColumnName("banner")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Calidad")
                        .IsRequired()
                        .HasColumnName("calidad")
                        .HasColumnType("varchar(5)")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<string>("CategoriaEdad")
                        .IsRequired()
                        .HasColumnName("categoriaEdad")
                        .HasColumnType("varchar(3)")
                        .HasMaxLength(3)
                        .IsUnicode(false);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnName("descripcion")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnName("director")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<int>("IdGeneros")
                        .HasColumnName("idGeneros")
                        .HasColumnType("int");

                    b.HasKey("IdPeliculas")
                        .HasName("PK__pelicula__71DB443FC4F322C9");

                    b.HasIndex("IdGeneros");

                    b.ToTable("peliculas");
                });

            modelBuilder.Entity("ChivoFlixDesktop.Models.Planes", b =>
                {
                    b.Property<int>("IdPlanes")
                        .HasColumnName("idPlanes")
                        .HasColumnType("int");

                    b.Property<int>("IdDuracionPlanes")
                        .HasColumnName("idDuracionPlanes")
                        .HasColumnType("int");

                    b.Property<int>("IdUsuarios")
                        .HasColumnName("idUsuarios")
                        .HasColumnType("int");

                    b.Property<string>("Plann")
                        .IsRequired()
                        .HasColumnName("plann")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.Property<double>("PrecioPlan")
                        .HasColumnName("precioPlan")
                        .HasColumnType("float");

                    b.HasKey("IdPlanes")
                        .HasName("PK__planes__31C4681EE8F4D2A7");

                    b.HasIndex("IdDuracionPlanes");

                    b.HasIndex("IdUsuarios");

                    b.ToTable("planes");
                });

            modelBuilder.Entity("ChivoFlixDesktop.Models.Roles", b =>
                {
                    b.Property<int>("IdRol")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idRol")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Rol")
                        .HasColumnName("rol")
                        .HasColumnType("int");

                    b.HasKey("IdRol")
                        .HasName("PK__roles__3C872F766BA21F45");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("ChivoFlixDesktop.Models.Usuarios", b =>
                {
                    b.Property<int>("IdUsuarios")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("idUsuarios")
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("email")
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.Property<int?>("IdRol")
                        .HasColumnName("idRol")
                        .HasColumnType("int");

                    b.Property<string>("Imagen")
                        .HasColumnName("imagen")
                        .HasColumnType("varchar(max)")
                        .IsUnicode(false);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("password")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<int?>("Perfiles")
                        .HasColumnName("perfiles")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnName("username")
                        .HasColumnType("varchar(15)")
                        .HasMaxLength(15)
                        .IsUnicode(false);

                    b.HasKey("IdUsuarios")
                        .HasName("PK__usuarios__3940559A97851C3F");

                    b.HasIndex("IdRol");

                    b.ToTable("usuarios");
                });

            modelBuilder.Entity("ChivoFlixDesktop.Models.Facturaciones", b =>
                {
                    b.HasOne("ChivoFlixDesktop.Models.Planes", "IdPlanesNavigation")
                        .WithMany("Facturaciones")
                        .HasForeignKey("IdPlanes")
                        .HasConstraintName("fk_Facuraciones_Planes")
                        .IsRequired();

                    b.HasOne("ChivoFlixDesktop.Models.Usuarios", "IdUsuariosNavigation")
                        .WithMany("Facturaciones")
                        .HasForeignKey("IdUsuarios")
                        .HasConstraintName("fk_Facturaciones_Usuarios")
                        .IsRequired();
                });

            modelBuilder.Entity("ChivoFlixDesktop.Models.Listados", b =>
                {
                    b.HasOne("ChivoFlixDesktop.Models.Peliculas", "IdPeliculasNavigation")
                        .WithMany("Listados")
                        .HasForeignKey("IdPeliculas")
                        .HasConstraintName("fk_Listado_Peliculas")
                        .IsRequired();

                    b.HasOne("ChivoFlixDesktop.Models.Usuarios", "IdUsuariosNavigation")
                        .WithMany("Listados")
                        .HasForeignKey("IdUsuarios")
                        .HasConstraintName("fk_Listado_Usuarios")
                        .IsRequired();
                });

            modelBuilder.Entity("ChivoFlixDesktop.Models.Peliculas", b =>
                {
                    b.HasOne("ChivoFlixDesktop.Models.Generos", "IdGenerosNavigation")
                        .WithMany("Peliculas")
                        .HasForeignKey("IdGeneros")
                        .HasConstraintName("fk_Peliculas_Generos")
                        .IsRequired();
                });

            modelBuilder.Entity("ChivoFlixDesktop.Models.Planes", b =>
                {
                    b.HasOne("ChivoFlixDesktop.Models.DuracionPlanes", "IdDuracionPlanesNavigation")
                        .WithMany("Planes")
                        .HasForeignKey("IdDuracionPlanes")
                        .HasConstraintName("fk_Planes_DuracionP")
                        .IsRequired();

                    b.HasOne("ChivoFlixDesktop.Models.Usuarios", "IdUsuariosNavigation")
                        .WithMany("Planes")
                        .HasForeignKey("IdUsuarios")
                        .HasConstraintName("fk_Planes_Usuarios")
                        .IsRequired();
                });

            modelBuilder.Entity("ChivoFlixDesktop.Models.Usuarios", b =>
                {
                    b.HasOne("ChivoFlixDesktop.Models.Roles", "IdRolNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdRol")
                        .HasConstraintName("fk_Usuarios_Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
