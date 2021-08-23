using System;

namespace ex3.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Moradores morad = new Moradores();

            Console.WriteLine("Informe o Telefone.");
            morad.Telefone = Console.ReadLine();            

            Console.WriteLine("Informe o Numero da Residencia.");
            morad.NumResidencia = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Informe se há cachorros.");
            morad.Cachorro = Console.ReadLine();
            /*
            Deveria ser implementado uma Lista para receber todos os moradores e
            avaliar se a correspondencia foi entregue, realizando a soma de todos que possuem
            residencia impar
            */

            //Confirmação de get/set
            Console.WriteLine($"Telefone do Morador: {morad.Telefone}.");
            Console.WriteLine($"Residencia do Morador: {morad.NumResidencia}.");
            Console.WriteLine($"Há cachorros? {morad.Cachorro}.");
            


            
        }
    }
}
