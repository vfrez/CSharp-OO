using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente pessoa1 = new Cliente();
            pessoa1.nome = "Pessoa1";
            pessoa1.cpf = "123.456.789.-12";
            pessoa1.profissao = "Sô trabalhadô";

            ContaCorrente contaPessoa1 = new ContaCorrente();
            contaPessoa1.titular = pessoa1; //Apontando a referencia do objeto criado pessoa1, com todos os dados presentes nesta referencia.
            contaPessoa1.numero = 123;
            contaPessoa1.agencia = 123456;

            Console.WriteLine("Nome Pessoa: " + pessoa1.nome);
            Console.WriteLine("Titular conta: " + contaPessoa1.titular.nome); // pode-se acessar os dados do objeto pessoa1 que foi refenciado no contaPessoa1, adicionando todo o caminho, no caso, nome da pessoa.

            //se alterar o nome da pessoa a partir da classe contaPessoa 1, será alterado tambem para o objeto pessoa1, pois  a referencia na memoria do computador é a mesma para os dois.
            contaPessoa1.titular.nome = "Pessoa1 Alterada";
            Console.WriteLine("Nome Pessoa depois de alterar: " + pessoa1.nome);
            Console.WriteLine("Titular conta depois de alterar: " + contaPessoa1.titular.nome);

            Console.ReadLine();
        }
    }
}
