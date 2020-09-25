using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TesteDeConhecimento.Models.Entities;

namespace TesteDeConhecimento.Models.Validation
{
    public class FornecedorValidator : AbstractValidator<Fornecedor>
    {

        public FornecedorValidator()
        {
            RuleFor(f=> f.RazaoSocial)
                .NotEmpty().WithMessage("A Razão Social não pode estar vazia.")
                .MinimumLength(5).WithMessage("A Razão Social deve ter pelo menos 5 caracteres.")
                .MaximumLength(80).WithMessage("A Razão Social deve ter até 80 caracteres.");

            RuleFor(f => f.Nomefantasia)
                .NotEmpty().WithMessage("O Nome de Fantasia não pode estar vazio.")
                .MinimumLength(5).WithMessage("O Nome de Fantasia deve ter pelo menos 5 caracteres.")
                .MaximumLength(60).WithMessage("O Nome de Fantasia deve ter até 60 caracteres.");

            RuleFor(f => f.Cnpj)
                .NotEmpty().WithMessage("O CNPJ não pode estar vazio.")
                .Length(14).WithMessage("O CNPJ deve ter 14 caracteres");

            RuleFor(f => f.Cep)
                .NotEmpty().WithMessage("O CEP não pode estar vazio.")
                .Length(8).WithMessage("O CEP deve ter 8 caracteres");

            RuleFor(f => f.Localidade)
                .NotEmpty().WithMessage("A localidade não pode estar vazia.")
                .MinimumLength(5).WithMessage("A localidade deve ter pelo menos 5 caracteres.")
                .MaximumLength(40).WithMessage("A localidade deve ter até 40 caracteres.");

            RuleFor(f => f.Numero)
                .NotEmpty().WithMessage("O número não pode estar vazio.")
                .MinimumLength(1).WithMessage("O número deve ter pelo menos 1 caracter.")
                .MaximumLength(4).WithMessage("O número deve ter até 4 caracteres.");

            RuleFor(f => f.Complemento)
                .Empty() // testar
                .MinimumLength(3).WithMessage("O complemento deve ter pelo menos 3 caracteres.")
                .MaximumLength(12).WithMessage("O complemento deve ter até 12 caracteres.");

            RuleFor(f => f.Bairro)
                .NotEmpty().WithMessage("O bairro não pode estar vazio.")
                .MinimumLength(3).WithMessage("O bairro deve ter pelo menos 3 caracteres.")
                .MaximumLength(15).WithMessage("O bairro deve ter até 15 caracteres.");

        }

    }
}