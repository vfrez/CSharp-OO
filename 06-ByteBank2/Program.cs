using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank2
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaPessoa = new ContaCorrente();

            contaPessoa.SetSaldo(-10);//Esta maneira é utilizando com o metodo SetSaldo, criado separadamente 

            Console.WriteLine(contaPessoa.GetSaldo());// Esta maneira é utilizando com o metodo GetSaldo, criado separadamente

           

            Console.ReadLine();
        }
    }
}
