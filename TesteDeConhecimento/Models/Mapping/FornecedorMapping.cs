using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using TesteDeConhecimento.Models.Entities;

namespace TesteDeConhecimento.Models.Mapping
{
    public class FornecedorMapping : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorMapping()
        {
            ToTable("Fornecedor");

            HasKey(f => f.Id);

            Property(f => f.RazaoSocial).IsRequired().HasMaxLength(80);

            Property(f => f.Nomefantasia).IsRequired().HasMaxLength(60);

            Property(f => f.Cnpj).IsRequired().HasMaxLength(14);

            Property(f => f.Cep).IsRequired().HasMaxLength(8);

            Property(f => f.Localidade).IsRequired().HasMaxLength(40);

            Property(f => f.Numero).IsRequired().HasMaxLength(4);

            Property(f => f.Complemento).IsOptional().HasMaxLength(12);

            Property(f => f.Bairro).IsRequired().HasMaxLength(15);

            Property(f => f.DataDeInclusao).IsRequired();
        }
    }
}