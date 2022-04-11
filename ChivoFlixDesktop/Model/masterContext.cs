using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ChivoFlixDesktop.Model
{
    public partial class masterContext : DbContext
    {
        public masterContext()
        {
        }

        public masterContext(DbContextOptions<masterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Generos> Generos { get; set; }
        public virtual DbSet<Listado> Listado { get; set; }
        public virtual DbSet<Peliculas> Peliculas { get; set; }
        public virtual DbSet<Planes> Planes { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Tarjetas> Tarjetas { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Initial Catalog=CHIVOFLIX; Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Generos>(entity =>
            {
                entity.HasKey(e => e.IdGeneros)
                    .HasName("PK__GENEROS__525F69B8029B802E");

                entity.ToTable("GENEROS");

                entity.Property(e => e.IdGeneros).HasColumnName("idGeneros");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Listado>(entity =>
            {
                entity.HasKey(e => e.IdListado)
                    .HasName("PK__LISTADO__EEA3B4655F537D8E");

                entity.ToTable("LISTADO");

                entity.Property(e => e.IdListado).HasColumnName("idListado");

                entity.Property(e => e.IdPeliculas).HasColumnName("idPeliculas");

                entity.Property(e => e.IdUsuarios).HasColumnName("idUsuarios");

                entity.HasOne(d => d.IdPeliculasNavigation)
                    .WithMany(p => p.Listado)
                    .HasForeignKey(d => d.IdPeliculas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Listado_Peliculas");

                entity.HasOne(d => d.IdUsuariosNavigation)
                    .WithMany(p => p.Listado)
                    .HasForeignKey(d => d.IdUsuarios)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Listado_Usuarios");
            });

            modelBuilder.Entity<Peliculas>(entity =>
            {
                entity.HasKey(e => e.IdPeliculas)
                    .HasName("PK__PELICULA__71DB443F076FB354");

                entity.ToTable("PELICULAS");

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
                    .HasName("PK__PLANES__31C4681E6A8EB528");

                entity.ToTable("PLANES");

                entity.Property(e => e.IdPlanes)
                    .HasColumnName("idPlanes")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdUsuarios).HasColumnName("idUsuarios");

                entity.Property(e => e.Planes1)
                    .IsRequired()
                    .HasColumnName("planes")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuariosNavigation)
                    .WithMany(p => p.Planes)
                    .HasForeignKey(d => d.IdUsuarios)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Planes_Usuarios");
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.IdRoles)
                    .HasName("PK__roles__C73330E7BED09827");

                entity.ToTable("roles");

                entity.Property(e => e.IdRoles)
                    .HasColumnName("id_roles")
                    .ValueGeneratedNever();

                entity.Property(e => e.Rol).HasColumnName("rol");
            });

            modelBuilder.Entity<Tarjetas>(entity =>
            {
                entity.HasKey(e => e.IdTarjetas)
                    .HasName("PK__TARJETAS__B6CCF1D9550EEA0A");

                entity.ToTable("TARJETAS");

                entity.Property(e => e.IdTarjetas).HasColumnName("idTarjetas");

                entity.Property(e => e.Cvv).HasColumnName("CVV");

                entity.Property(e => e.FechaVencimiento)
                    .IsRequired()
                    .HasColumnName("fechaVencimiento")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IdUsuarios).HasColumnName("idUsuarios");

                entity.Property(e => e.NumeroTarjeta)
                    .IsRequired()
                    .HasColumnName("numeroTarjeta")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdUsuariosNavigation)
                    .WithMany(p => p.Tarjetas)
                    .HasForeignKey(d => d.IdUsuarios)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Tarjetas_Usuarios");
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuarios)
                    .HasName("PK__usuarios__854B73B303E44E5D");

                entity.ToTable("usuarios");

                entity.Property(e => e.IdUsuarios)
                    .HasColumnName("id_usuarios")
                    .ValueGeneratedNever();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
