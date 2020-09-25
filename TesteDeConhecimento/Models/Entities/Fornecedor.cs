using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TesteDeConhecimento.Models.Entities
{
    public class Fornecedor
    {
        public int Id { get; set; }

        public string RazaoSocial { get; set; }

        public string Nomefantasia { get; set; }

        public string Cnpj { get; set; }

        public string Cep { get; set; }

        public string Localidade { get; set; }

        public string Numero { get; set; }

        public string Complemento { get; set; }

        public string Bairro { get; set; } 

        public DateTime DataDeInclusao { get; private set; } = DateTime.Today;

    }
}