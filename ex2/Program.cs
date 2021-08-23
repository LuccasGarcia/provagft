using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();  //Uma função para exibir as opções

            while (opcaoUsuario != "3") //Verificar a opcao digitada
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        CalculoIdade();
                        break;
                    case "2":
                        CalculoIMC();
                        break;
                    default:
                        Console.WriteLine("Opção Incorreta");
                        break;
                }


                opcaoUsuario = ObterOpcaoUsuario();
            }

        }








        private static string ObterOpcaoUsuario()
        {
            //Criou um metodo com as chamadas de entrada
            Console.WriteLine();
            Console.WriteLine("Menu de opções:");
            Console.WriteLine("1 - Idade");
            Console.WriteLine("2 - IMC");
            Console.WriteLine("3 - Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }

        private static void CalculoIdade()
        {
            Console.WriteLine("Informe o Ano de Nascimento");
            int anoNasc = Int32.Parse(Console.ReadLine());  //Converter o String em Int

            Console.WriteLine("Informe o Ano Atual");
            int anoAtual = Int32.Parse(Console.ReadLine());

            //Calcula a idade e retorna no console
            Console.WriteLine($"A idade é de: {anoAtual - anoNasc} anos.");
        }

        private static void CalculoIMC()
        {
            Console.WriteLine("Informe a Altura em Metros.");
            float altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o Peso em Kgs.");
            float peso = float.Parse(Console.ReadLine());

            float imc = peso / (altura * altura);
            Console.WriteLine($"peso: {peso} kgs.");
            Console.WriteLine($"Altura: {altura} metros.");

            Console.WriteLine($"O IMC é de: {imc.ToString("N2")}.");
        }

    }
}
