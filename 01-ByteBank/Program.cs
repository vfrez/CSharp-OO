using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //new ContaCorrente();
            //Objeto                     instância
            ContaCorrente contaPessoa1 = new ContaCorrente();
            //Objeto recebe uma nova instancia da classe na memória

            Console.WriteLine(contaPessoa1.titular);//Nada deve aparecer, pois, o objeto está na memória, porem não há informações atribuidas nele

            contaPessoa1.titular = "Pessoa1";
            contaPessoa1.agencia = 123;
            contaPessoa1.numero = 123654;
            contaPessoa1.saldo = 100;

            Console.WriteLine(contaPessoa1.titular);
            Console.WriteLine("Agencia: " + contaPessoa1.agencia);
            Console.WriteLine("Número: " + contaPessoa1.numero);
            Console.WriteLine("Saldo: " + contaPessoa1.saldo);

            contaPessoa1.saldo += 100;

            Console.WriteLine("Saldo: " + contaPessoa1.saldo);

            Console.ReadLine();

        }
    }
}
