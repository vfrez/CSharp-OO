using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaPessoa = new ContaCorrente();


            Console.WriteLine("Antes do saque: " + contaPessoa.saldo);
            bool sacado = contaPessoa.Sacar(50);
            Console.WriteLine("Depois do saque: " + contaPessoa.saldo);
            Console.WriteLine("Retorno Booleano: " + sacado);

            contaPessoa.Depositar(125);
            Console.WriteLine("Depois do deposito: " + contaPessoa.saldo);

            Console.ReadLine();
        }
    }
}
