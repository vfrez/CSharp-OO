using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaDaGabriela = new ContaCorrente();
            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.agencia = 863;
            contaDaGabriela.numero = 863146;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863146;

            Console.WriteLine("Igualdade de tipo de referência: " + (contaDaGabriela == contaDaGabrielaCosta));
            //DIferente pois, o endereço(referência) na memória é diferente.

            int idade = 27;
            int idadeMaisUmaVez = 27;

            Console.WriteLine("Igualdade de tipo de valor: " + (idade == idadeMaisUmaVez));

            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine(contaDaGabriela == contaDaGabrielaCosta);//indicando o mesmo local na memória para os dois objetos

            contaDaGabriela.saldo = 300;
            Console.WriteLine(contaDaGabriela.saldo);
            Console.WriteLine(contaDaGabrielaCosta.saldo);
            //O valor é o mesmo agora para os 2 objetos, pois a referencia de ambos é o mesmo tambem, alterando em um será alterado no outro tambem
            Console.ReadLine();
        }
    }
}
