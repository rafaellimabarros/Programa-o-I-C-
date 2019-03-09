using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class idade
    {
        int a1 = 10, a2 = 15, a3 = 10;
        public void idadeamigos()
        {
            Console.WriteLine("Suas idades são {0}, {1}, {2}", a1,a2,a3);
        }
        
        public void mediaidade()
        {
            int media = (a1 + a2 + a3) / 3;
            Console.WriteLine("a media das idades é {0}", media);
        }
    }
}
