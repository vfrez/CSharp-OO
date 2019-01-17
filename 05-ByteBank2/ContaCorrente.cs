//using _05_ByteBank; //Para não precisar indicar o nameSpace na frente da Classe, pode-se adicionar o mesmo no using, no inicio no arquivo.

namespace _05_ByteBank2 //Desta maneira, todas as classes que estão neste nameSpace são encontradas pelo C#
{
    public class ContaCorrente
    {
        //Quando não declararmos valores para os objetos instanciados, será atribuido um valor padrão
        //Caso não indicarmos aqui na criação da classe o valor, o mesmo sera: vazio para string, e 0 para numeros
        //Caso queiramos trocar este valor padrão, só atribuir na criação dos atributos o valor que queira

        //public string titular;
        //public _05_ByteBank.Cliente titular; //Para usar classes de outros nameSpaces, é necessário informar a classe nameSpace.Classe, desta maneira ele encontra a Classe
        //public Cliente titular;//utilizando using
        public Cliente titular;// Referencia a classe pessoa e todos os seus atributos e talvez métodos;
        public int agencia;
        public int numero;
        public double saldo = 100; //Novo valor padrão

        public bool Sacar(double valor)
        {
            if (this.saldo <= valor)
            {
                return false;
            }
            else
            {
                this.saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this.saldo += valor;
        }
        //Chama outra referencia, com todos os metodos e atributos.
        public bool Transferir(double valor, ContaCorrente contaTransferir)
        {
            if (this.saldo < valor)
            {
                return true;//Return true para a função no momento de sua execução
            }

            this.saldo -= valor;
            contaTransferir.saldo += valor;
            return true;
        }

    }
}
