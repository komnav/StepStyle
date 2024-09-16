using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    public class TypeOfCatamaranDbConfiguration : IEntityTypeConfiguration<CatamaranModel>
    {
        public void Configure(EntityTypeBuilder<CatamaranModel> builder)
        {
            builder.HasKey(c => new { c.Data, c.Time, c.TypeOfCatamaran });
            builder.Property(c => c.Data).IsRequired();
            builder.Property(c => c.Time).IsRequired();
            builder.Property(c => c.TypeOfCatamaran).IsRequired();
            builder.Property(c => c.ClientName).IsRequired();
            builder.Property(c => c.PhoneNamber).IsRequired();
            builder.Property(c => c.PassportSeries).IsRequired();
            builder.Property(c => c.PassportNamber).IsRequired();
        }
    }
}
