using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Challenges
{
    class CircularArrayRotation
    {
        /*
        n = número de elementos
        k = número de rotações
        q = número de queries
        */

        public void Run()
        {
            int n, k, q;

            Console.WriteLine("Primeira Linha (Parâmetros): ");
            string line1 = Console.ReadLine();

            n = int.Parse(line1.Split(' ')[0]);
            k = int.Parse(line1.Split(' ')[1]);
            q = int.Parse(line1.Split(' ')[2]);


            Console.WriteLine("Segunda Linha (Elementos): ");
            string line2 = Console.ReadLine();
            int[] elementos = Array.ConvertAll(line2.Split(' '), s => int.Parse(s));


            while (k > 0)
            {


            }


            for (int i = 0; i < q; i++)
            {
                Console.WriteLine("Consulta (Elementos): ");
                int query = int.Parse(Console.ReadLine());
                Console.WriteLine(elementos[query]);
            }





            throw new NotImplementedException();
        }
    }
}
