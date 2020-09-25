using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TesteDeConhecimento.Models.Entities;
using TesteDeConhecimento.Models.Mapping;

namespace TesteDeConhecimento.Models.Context
{
    public class TesteDeConhecimentoContext : DbContext
    {
        public TesteDeConhecimentoContext() : base("ConexaoFornecedor")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add<Fornecedor>(new FornecedorMapping());
        }

        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}