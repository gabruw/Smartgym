﻿using Domain.DTO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.HasKey(p => p.IdProfessor);

            builder.HasOne(p => p.UnidadeProfessor).WithMany().HasForeignKey(p => p.IdUnidadeProfessor);
            builder.HasOne(p => p.AgendaProfessor).WithMany().HasForeignKey(p => p.IdAgendaProfessor);

            builder.Property(p => p.PermissaoProfessor).IsRequired().HasMaxLength(1).HasColumnType("int(1)");
            builder.Property(p => p.EmailProfessor).IsRequired().HasMaxLength(60).HasColumnType("varchar(60)");
            builder.Property(p => p.SenhaProfessor).IsRequired().HasMaxLength(40).HasColumnType("varchar(40)");

            builder.Property(p => p.CrefProfessor).IsRequired().HasMaxLength(9).HasColumnType("varchar(9)");
            builder.Property(p => p.NomeProfessor).IsRequired().HasMaxLength(120).HasColumnType("varchar(120)");
            builder.Property(p => p.CpfProfessor).IsRequired().HasMaxLength(11).HasColumnType("varchar(11)");
            builder.Property(p => p.DataNascimentoProfessor).IsRequired().HasColumnType("date");
            builder.Property(p => p.DataAdmissaoProfessor).IsRequired().HasColumnType("date");
            builder.Property(p => p.TelefoneProfessor).HasMaxLength(11).HasColumnType("int(11)");
            builder.Property(p => p.CelularProfessor).HasMaxLength(11).HasColumnType("int(11)");
            builder.Property(p => p.SexoProfessor).IsRequired().HasMaxLength(1).HasColumnType("int(1)");

            builder.Property(p => p.RuaEnderecoProfessor).IsRequired().HasMaxLength(80).HasColumnType("varchar(80)");
            builder.Property(p => p.BairroEnderecoProfessor).IsRequired().HasMaxLength(80).HasColumnType("varchar(80)");
            builder.Property(p => p.NumeroEnderecoProfessor).IsRequired().HasMaxLength(5).HasColumnType("int(5)");
            builder.Property(p => p.ComplementoEnderecoProfessor).HasMaxLength(5).HasColumnType("int(5)");
            builder.Property(p => p.CepProfessor).IsRequired().HasMaxLength(8).HasColumnType("int(8)");

            builder.Property(p => p.ImagemProfessor).HasMaxLength(64).HasColumnType("varchar(64)");
        }
    }
}