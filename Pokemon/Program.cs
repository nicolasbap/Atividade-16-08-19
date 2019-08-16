using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            int  vida = 10,  vidainimigo = 10, opc1, opc2;


            Console.Write("Você está com um pikachu em campo vs um blastoide");

            Console.WriteLine("Ações");

            Console.WriteLine("1- Atacar");
            Console.WriteLine("2 Esquivar");
            opc1 = int.Parse(Console.ReadLine());


            if ( opc1 == 1)
            {
                Console.WriteLine();
               Console.WriteLine(" O inimigo perdeu 2 de vida ");
                vidainimigo += -2;
                Console.WriteLine(" O inimigo te atacou e você perdeu 1 de vida ");
                Console.WriteLine(" Sua vida atual é:{0}", vida);
                vida += -1;
                    

            }

            if (opc1 == 2)
            {
                Console.WriteLine();
                Console.WriteLine(" Você perdeu não de vida ");
                Console.WriteLine(" Sua vida atual é:{0}", vida);
                


            }


            while (vidainimigo != 0)
            {
                Console.WriteLine();
                Console.WriteLine("1- Atacar");
                Console.WriteLine("2 Esquivar");
                Console.WriteLine("3 Especial");
                opc2 = int.Parse(Console.ReadLine());


                if (opc2 == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine(" O inimigo perdeu 2 de vida ");
                    Console.WriteLine(" O inimigo te atacou e você perdeu 1 de vida ");
                    Console.WriteLine(" Sua vida atual é:{0}",vida);
                    vida += -1;
                    vida += -1;
                    vidainimigo += -2;


                }


                if (opc2 == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine(" O inimigo perdeu 8 de vida ");
                    Console.WriteLine(" O inimigo te atacou e você perdeu 1 de vida ");
                    Console.WriteLine(" Sua vida atual é:{0}", vida);
                    vida += -1;
                    vidainimigo += -8;


                }

                if (opc2 == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine(" Você não perdeu vida ");
                    Console.WriteLine(" Sua vida atual é:{0}", vida);
                    


                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Inimigo Perdeu");
            Console.WriteLine();
            Console.WriteLine("Você ganhou a Liga Pokemon");

            Console.ReadKey();


           





        }
    }
}
