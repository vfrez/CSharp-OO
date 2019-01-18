using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente.TotalDeContasCriadas = 10;

            Console.WriteLine("Criação da conta1");
            ContaCorrente conta1 = new ContaCorrente(123, 123456);

            Console.WriteLine(conta1.Agencia);
            Console.WriteLine(conta1.Numero);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

            Console.WriteLine("Criação da conta2");
            ContaCorrente conta2 = new ContaCorrente(123, 123456);

            Console.WriteLine(conta2.Agencia);
            Console.WriteLine(conta2.Numero);
            Console.WriteLine(ContaCorrente.TotalDeContasCriadas);


            Console.ReadLine();

        }
    }
}
