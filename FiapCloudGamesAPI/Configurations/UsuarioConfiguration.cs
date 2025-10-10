using FCG_API_Jogos.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace FCG_API_Jogos.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).HasColumnType("BIGINT").ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(p => p.DataCriacao).HasColumnType("DATETIME2").IsRequired().Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            builder.Property(p => p.Nome).HasColumnType("VARCHAR(100)").IsRequired();
            builder.Property(p => p.Sobrenome).HasColumnType("VARCHAR(100)");
            builder.Property(p => p.Apelido).HasColumnType("VARCHAR(50)");
            builder.HasIndex(p => p.Apelido).IsUnique();
            builder.Property(p => p.Email).HasColumnType("VARCHAR(150)").IsRequired();
            builder.HasIndex(e => e.Email).IsUnique();
            builder.Property(p => p.HashSenha).HasColumnType("VARCHAR(255)").IsRequired();
            builder.Property(p => p.DataNascimento).HasColumnType("DATETIME2");
            builder.Property(p => p.CriadoPor).HasColumnType("VARCHAR(100)").Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            builder.Property(p => p.DataAtualizacao).HasColumnType("DATETIME2");
            builder.Property(p => p.AtualizadoPor).HasColumnType("VARCHAR(100)");

            builder.Property(p => p.PerfilId).HasColumnType("BIGINT");

            builder.HasOne(p => p.Perfil)
                .WithMany(p => p.Usuarios)
                .HasForeignKey(p => p.PerfilId);

            builder.HasMany(p => p.Avaliacoes)
                .WithOne(p => p.Usuario)
                .HasForeignKey(p => p.IdUsuario);

            
            builder.HasData(
                new Usuario("João", "Silva", "joaos", "joao@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("2000-01-01 00:00:00"), 1, "system") { Id = 1, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Alice", "Bezerra", "alice02", "alice02@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("2000-02-01"), 2, "system") { Id = 2, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Alice", "Silva", "alice01", "alice01@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("2000-02-01"), 2, "system") { Id = 3, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Bruno", "Souza", "bruno02", "bruno02@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("1995-06-15"), 2, "system") { Id = 4, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Carla", "Oliveira", "carla03", "carla03@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("1998-09-23"), 2, "system") { Id = 5, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Daniel", "Costa", "daniel04", "daniel04@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("1992-12-11"), 2, "system") { Id = 6, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Eva", "Martins", "eva05", "eva05@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("2001-04-05"), 2, "system") { Id = 7, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Felipe", "Almeida", "felipe06", "felipe06@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("1999-08-19"), 2, "system") { Id = 8, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Gabriela", "Pereira", "gabriela07", "gabriela07@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("1997-07-07"), 2, "system") { Id = 9, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Henrique", "Ribeiro", "henrique08", "henrique08@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("1993-11-30"), 2, "system") { Id = 10, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Isabela", "Fernandes", "isabela09", "isabela09@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("2000-05-20"), 2, "system") { Id = 11, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("João", "Lima", "joao10", "joao10@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("1996-03-12"), 2, "system") { Id = 12, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },

                new Usuario("Karen", "Barbosa", "karen11", "karen11@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("1998-01-28"), 2, "system") { Id = 13, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Leonardo", "Moura", "leonardo12", "leonardo12@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("1995-10-02"), 2, "system") { Id = 14, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Mariana", "Teixeira", "mariana13", "mariana13@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("2001-09-14"), 2, "system") { Id = 15, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Nicolas", "Cardoso", "nicolas14", "nicolas14@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("1999-07-09"), 2, "system") { Id = 16, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Olivia", "Azevedo", "olivia15", "olivia15@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("2000-12-17"), 2, "system") { Id = 17, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Pedro", "Santos", "pedro16", "pedro16@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("1997-06-06"), 2, "system") { Id = 18, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Quintina", "Faria", "quintina17", "quintina17@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("1994-08-22"), 2, "system") { Id = 19, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Rafael", "Mendes", "rafael18", "rafael18@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("1996-05-30"), 2, "system") { Id = 20, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Sofia", "Cunha", "sofia19", "sofia19@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("2002-03-03"), 2, "system") { Id = 21, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Thiago", "Lopes", "thiago20", "thiago20@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("1995-09-18"), 2, "system") { Id = 22, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },

                new Usuario("Úrsula", "Gomes", "ursula21", "ursula21@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("1998-11-11"), 2, "system") { Id = 23, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Vinícius", "Dias", "vinicius22", "vinicius22@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("1993-10-25"), 2, "system") { Id = 24, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Wesley", "Rocha", "wesley23", "wesley23@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("1999-04-14"), 2, "system") { Id = 25, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Ximena", "Nogueira", "ximena24", "ximena24@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("2001-08-29"), 2, "system") { Id = 26, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Yasmin", "Freitas", "yasmin25", "yasmin25@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("2002-02-19"), 2, "system") { Id = 27, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Zeca", "Machado", "zeca26", "zeca26@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("1997-12-01"), 2, "system") { Id = 28, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Amanda", "Pinto", "amanda27", "amanda27@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("1998-06-08"), 2, "system") { Id = 29, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Breno", "Batista", "breno28", "breno28@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("1995-07-15"), 2, "system") { Id = 30, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Camila", "Correia", "camila29", "camila29@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("2000-11-23"), 2, "system") { Id = 31, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") },
                new Usuario("Diego", "Rezende", "diego30", "diego30@email.com", "7+D7gmaWMXRYtMBOLDAtRSgnqJoQ5H62L1setgRLRCx68knp71V1pdUZV6KfWoiT", DateTime.Parse("1994-09-09"), 2, "system") { Id = 32, DataCriacao = DateTime.Parse("2025-01-01 00:00:00") }
            );
        }
    }
}
