using FluentValidation.Results;

    class Program
    {
        static void Main(string[] args)
        {
            //TRUE "VALOR" FALSE ""
            Client client = new Client()
            {
                Nome = "",
                SobreNome = ""
            };

            //VALIDA
            Console.WriteLine("Validando Cliente:" + client.Nome);

            ClientValidator clientValidator = new ClientValidator();
            ValidationResult validationResult = clientValidator.Validate(client);

            Console.WriteLine("Resultado Validação: " + validationResult.IsValid);

            if (!validationResult.IsValid)
            {
                foreach (var erro in validationResult.Errors)
                {
                    Console.WriteLine("Propriedade:" + erro.PropertyName + "Msg:" + erro.ErrorMessage);
                    Console.WriteLine(erro.ErrorMessage);
                }
            }

        }
    }