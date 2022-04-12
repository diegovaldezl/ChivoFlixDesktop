using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ChivoFlixDesktop.Models
{
    public partial class CHIVOFLIXContext : DbContext
    {
        public CHIVOFLIXContext()
        {
        }

        public CHIVOFLIXContext(DbContextOptions<CHIVOFLIXContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DuracionPlanes> DuracionPlanes { get; set; }
        public virtual DbSet<Facturaciones> Facturaciones { get; set; }
        public virtual DbSet<Generos> Generos { get; set; }
        public virtual DbSet<Listados> Listados { get; set; }
        public virtual DbSet<Peliculas> Peliculas { get; set; }
        public virtual DbSet<Planes> Planes { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLExpress;Database=CHIVOFLIX;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DuracionPlanes>(entity =>
            {
                entity.HasKey(e => e.IdDuracionPlanes)
                    .HasName("PK__duracion__812FA85D5C9C4FEC");

                entity.ToTable("duracionPlanes");

                entity.Property(e => e.IdDuracionPlanes).HasColumnName("idDuracionPlanes");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Facturaciones>(entity =>
            {
                entity.HasKey(e => e.IdFacturaciones)
                    .HasName("PK__facturac__85C535F2CEB63A25");

                entity.ToTable("facturaciones");

                entity.HasIndex(e => e.IdPlanes);

                entity.HasIndex(e => e.IdUsuarios);

                entity.Property(e => e.IdFacturaciones).HasColumnName("idFacturaciones");

                entity.Property(e => e.FechaAdquirido)
                    .HasColumnName("fechaAdquirido")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdPlanes).HasColumnName("idPlanes");

                entity.Property(e => e.IdUsuarios).HasColumnName("idUsuarios");

                entity.Property(e => e.Plann)
                    .IsRequired()
                    .HasColumnName("plann")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Precio).HasColumnName("precio");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasColumnName("total");

                entity.HasOne(d => d.IdPlanesNavigation)
                    .WithMany(p => p.Facturaciones)
                    .HasForeignKey(d => d.IdPlanes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Facuraciones_Planes");

                entity.HasOne(d => d.IdUsuariosNavigation)
                    .WithMany(p => p.Facturaciones)
                    .HasForeignKey(d => d.IdUsuarios)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Facturaciones_Usuarios");
            });

            modelBuilder.Entity<Generos>(entity =>
            {
                entity.HasKey(e => e.IdGeneros)
                    .HasName("PK__generos__525F69B89698BFBB");

                entity.ToTable("generos");

                entity.Property(e => e.IdGeneros).HasColumnName("idGeneros");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Listados>(entity =>
            {
                entity.HasKey(e => e.IdListado)
                    .HasName("PK__listados__EEA3B4656600FBF7");

                entity.ToTable("listados");

                entity.HasIndex(e => e.IdPeliculas);

                entity.HasIndex(e => e.IdUsuarios);

                entity.Property(e => e.IdListado).HasColumnName("idListado");

                entity.Property(e => e.IdPeliculas).HasColumnName("idPeliculas");

                entity.Property(e => e.IdUsuarios).HasColumnName("idUsuarios");

                entity.HasOne(d => d.IdPeliculasNavigation)
                    .WithMany(p => p.Listados)
                    .HasForeignKey(d => d.IdPeliculas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Listado_Peliculas");

                entity.HasOne(d => d.IdUsuariosNavigation)
                    .WithMany(p => p.Listados)
                    .HasForeignKey(d => d.IdUsuarios)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Listado_Usuarios");
            });

            modelBuilder.Entity<Peliculas>(entity =>
            {
                entity.HasKey(e => e.IdPeliculas)
                    .HasName("PK__pelicula__71DB443FC4F322C9");

                entity.ToTable("peliculas");

                entity.HasIndex(e => e.IdGeneros);

                entity.Property(e => e.IdPeliculas).HasColumnName("idPeliculas");

                entity.Property(e => e.AnioEstreno).HasColumnName("anioEstreno");

                entity.Property(e => e.Banner)
                    .IsRequired()
                    .HasColumnName("banner")
                    .IsUnicode(false);

                entity.Property(e => e.Calidad)
                    .IsRequired()
                    .HasColumnName("calidad")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CategoriaEdad)
                    .IsRequired()
                    .HasColumnName("categoriaEdad")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Director)
                    .IsRequired()
                    .HasColumnName("director")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdGeneros).HasColumnName("idGeneros");

                entity.HasOne(d => d.IdGenerosNavigation)
                    .WithMany(p => p.Peliculas)
                    .HasForeignKey(d => d.IdGeneros)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Peliculas_Generos");
            });

            modelBuilder.Entity<Planes>(entity =>
            {
                entity.HasKey(e => e.IdPlanes)
                    .HasName("PK__planes__31C4681EE8F4D2A7");

                entity.ToTable("planes");

                entity.HasIndex(e => e.IdDuracionPlanes);

                entity.HasIndex(e => e.IdUsuarios);

                entity.Property(e => e.IdPlanes)
                    .HasColumnName("idPlanes")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdDuracionPlanes).HasColumnName("idDuracionPlanes");

                entity.Property(e => e.IdUsuarios).HasColumnName("idUsuarios");

                entity.Property(e => e.Plann)
                    .IsRequired()
                    .HasColumnName("plann")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioPlan).HasColumnName("precioPlan");

                entity.HasOne(d => d.IdDuracionPlanesNavigation)
                    .WithMany(p => p.Planes)
                    .HasForeignKey(d => d.IdDuracionPlanes)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Planes_DuracionP");

                entity.HasOne(d => d.IdUsuariosNavigation)
                    .WithMany(p => p.Planes)
                    .HasForeignKey(d => d.IdUsuarios)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Planes_Usuarios");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__roles__3C872F766BA21F45");

                entity.ToTable("roles");

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.Rol).HasColumnName("rol");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuarios)
                    .HasName("PK__usuarios__3940559A97851C3F");

                entity.ToTable("usuarios");

                entity.HasIndex(e => e.IdRol);

                entity.Property(e => e.IdUsuarios).HasColumnName("idUsuarios");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IdRol).HasColumnName("idRol");

                entity.Property(e => e.Imagen)
                    .HasColumnName("imagen")
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Perfiles).HasColumnName("perfiles");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasColumnName("username")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("fk_Usuarios_Roles");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
