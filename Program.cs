using System;
using _Polimorfismo_Override.classes;

namespace _Polimorfismo_Override
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varáveis
            char personagem;

            //Objetos
            Megamen p1m = new Megamen();
            Player p1 = new Player();
            Zero p1z = new Zero();

            //Menu
            Console.WriteLine("-----    -------------------------");
            Console.WriteLine("-----    MEGAMEN 2.0 EDITION      ");
            Console.WriteLine("-----    -------------------------");
            Console.WriteLine("-----    Selecione o Personagem");
            Console.WriteLine("-----    -------------------------");
            Console.WriteLine("-----    [1] MEGAMEN");
            Console.WriteLine("-----    [2] ZERO");
            Console.WriteLine("-----    -------------------------");
            personagem = char.Parse( Console.ReadLine() );
            Console.WriteLine("-----    -------------------------");

            switch (personagem)
            {
                case '1':

                    Console.WriteLine("-----    MEGAMEN");
                    
                    Console.WriteLine($"-----    { p1m.Correr() } ");
                    Console.WriteLine($"-----    { p1.Pular() } ");
                    Console.WriteLine("-----    -------------------------");

                    break;

                case '2':

                    Console.WriteLine("-----    ZERO");

                    Console.WriteLine($"-----    { p1.Correr() }" );
                    Console.WriteLine($"-----    { p1z.Pular() }" );
                    Console.WriteLine("-----    -------------------------");

                    break;

                default: 
                
                    Console.WriteLine("-----    -------------------------");
                    Console.WriteLine(" OPERAÇÃO NÃO VÁLIDA ");
                    Console.WriteLine("-----    -------------------------");

                    break;
            }
            
        }
    }
}
