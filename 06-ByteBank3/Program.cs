using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_ByteBank3
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaPessoa = new ContaCorrente();
            Cliente cliente1 = new Cliente();
            cliente1.nome = "Pessoa1";
            cliente1.cpf = "123.123.123-45";
            cliente1.profissao = "Trabalhadô";

            contaPessoa.Titular = cliente1;

            /*contaPessoa.SetSaldo(-10);//Esta maneira é utilizando com o metodo SetSaldo, criado separadamente */

            /*Console.WriteLine(contaPessoa.GetSaldo());// Esta maneira é utilizando com o metodo GetSaldo, criado separadamente*/

            contaPessoa.Saldo = -10;
            Console.WriteLine(contaPessoa.Titular.nome);
            Console.WriteLine(contaPessoa.Saldo);

            Console.ReadLine();
        }
    }
}
