using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quest4
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] letras ={ "A","C", "D", "E", "B" };
            
            foreach(string i in letras)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine("Presisone enter e veja a mágica");

            Console.ReadKey();
            
            Console.Clear();

            Array.Sort(letras);

            foreach(string a in letras)
            {

                Console.WriteLine(a);
            }




            Console.ReadKey();
            /* for (int i = 0; i < numeros.Length; i++)
              {                
                  numeros[i] = Convert.ToInt32(Console.ReadLine());

              } 

              foreach (int i in numeros)
              {
                  Console.WriteLine("Array posição {0} possui {1}", i);
              }*/


        }
    }
}
