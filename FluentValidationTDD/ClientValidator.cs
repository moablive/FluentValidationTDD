using FluentValidation;

    //REFERENCIA PARA CLASS CLIENT
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(n => n.Nome)
                .NotEmpty() //Não Vaziu
                .WithName("Nome do Cliente") //{PropertyName}
                .WithMessage("O {PropertyName} deve ser Preenchido"); //Propriedade para mensagem Customizada

            RuleFor(sn => sn.SobreNome)
                .NotEmpty() //Não Vaziu
                .WithName("Sobre Nome do Cliente") //{PropertyName}
                .WithMessage("O {PropertyName} deve ser Preenchido"); //Propriedade para mensagem Customizada
        }
    }