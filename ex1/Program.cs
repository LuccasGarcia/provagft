using System;

namespace ex1.Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
            Minha falha nesse exercicio foi não ter praticado tanto os pilares da orientação objetos
            e acabei enrolando e não relembrando corretamente como criar os metodos getter e setter
            */
            
            Colaborador c1 = new Colaborador();
            c1.Nome = "Luccas";
            c1.Matricula = 3;

            EnsinoBasico e1 = new EnsinoBasico();
            e1.Nome = "Marcos";
            e1.Matricula = 4;
            e1.Escola = "ETEC Alcidio";

            EnsinoSuperior e2 = new EnsinoSuperior();
            e2.Nome = "Joao";
            e2.Matricula = 4;
            e2.Escola = "ETEC Ana Lucia";
            e2.Universidade = "Fatec RP";

            Console.WriteLine($"Nome: {c1.Nome}; Matricula: {c1.Matricula}.");
            Console.WriteLine($"Nome: {e1.Nome}; Matricula: {e1.Matricula}; Escola: {e1.Escola}.");
            Console.WriteLine($"Nome: {e2.Nome}; Matricula: {e2.Matricula}; Escola: {e2.Escola}; Universidade: {e2.Universidade}.");
            
        }
    }
}
