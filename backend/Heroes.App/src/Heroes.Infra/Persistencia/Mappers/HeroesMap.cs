using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Heroes.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Heroes.Infra.Mappers
{
    internal class HeroesMap : IEntityTypeConfiguration<Hero>
    {
        public void Configure(EntityTypeBuilder<Hero> builder)
        {
            builder.ToTable("GE_HEROES");

            builder.Property(p => p.Id)
                .HasColumnName("SEQHERO");

            builder.Property(p => p.Name)
                .HasColumnName("NAME");
            builder.Property(p => p.Description)
                .HasColumnName("DESCRIPTION");
            builder.Property(p => p.Power)
                .HasColumnName("POWER");
            builder.Property(p => p.Defense)
                .HasColumnName("DEFENSE");
        }
    }
}
