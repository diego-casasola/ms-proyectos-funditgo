﻿using Domain.Model.Proyectos;
using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.EntityFramework.Config.WriteConfig.Proyectos
{
    public class DonacionWriteConfig : IEntityTypeConfiguration<Donacion>
    {
        public void Configure(EntityTypeBuilder<Donacion> builder)
        {
            var donacionConverter = new ValueConverter<DonacionValue, decimal>(
                donacionValue => donacionValue.Value,
                decimalValue => new DonacionValue(decimalValue)
            );

            builder.ToTable("Donacion");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UsuarioId).HasColumnName("usuarioId");
            builder.Property(x => x.Estado).HasColumnName("estado");
            builder.Property(x => x.Monto).HasColumnName("monto").HasConversion(donacionConverter);

            builder.Ignore("_domainEvents");
            builder.Ignore(x => x.DomainEvents);
        }
    }
}
