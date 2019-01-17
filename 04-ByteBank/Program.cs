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

            Console.WriteLine("-----------Sacar-----------");
            Console.WriteLine("Antes do saque, Pessoa1: " + contaPessoa.saldo);
            bool sacado = contaPessoa.Sacar(50);
            Console.WriteLine("Depois do saque, Pessoa1: " + contaPessoa.saldo);
            Console.WriteLine("Retorno Booleano: " + sacado);

            Console.WriteLine("-----------Depositar-----------");
            contaPessoa.Depositar(100);
            Console.WriteLine("Depois do deposito, Pessoa1: " + contaPessoa.saldo);

            Console.WriteLine("-----------Transferir-----------");
            ContaCorrente contaPessoa2 = new ContaCorrente();
            contaPessoa2.titular = "Pessoa2";

            bool retornoTransferencia = contaPessoa.Transferir(50, contaPessoa2);

            Console.WriteLine("Depois da Transferencia, Pessoa1: " + contaPessoa.saldo);
            Console.WriteLine("Depois da Transferencia, Pessoa2: " + contaPessoa2.saldo);
            Console.WriteLine(retornoTransferencia);

            contaPessoa2.Transferir(100, contaPessoa);
            Console.WriteLine("Depois da Transferencia oposta, Pessoa1: " + contaPessoa.saldo);
            Console.WriteLine("Depois da Transferencia oposta, Pessoa2: " + contaPessoa2.saldo);
            //Console.WriteLine(retornoTransferencia);




            Console.ReadLine();

        }
    }
}
