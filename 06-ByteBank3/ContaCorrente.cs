//using _05_ByteBank; //Para não precisar indicar o nameSpace na frente da Classe, pode-se adicionar o mesmo no using, no inicio no arquivo.

namespace _06_ByteBank3 //Desta maneira, todas as classes que estão neste nameSpace são encontradas pelo C#
{
    public class ContaCorrente
    {
        //Quando não declararmos valores para os objetos instanciados, será atribuido um valor padrão
        //Caso não indicarmos aqui na criação da classe o valor, o mesmo sera: vazio para string, e 0 para numeros
        //Caso queiramos trocar este valor padrão, só atribuir na criação dos atributos o valor que queira

        //public string titular;
        //public _05_ByteBank.Cliente titular; //Para usar classes de outros nameSpaces, é necessário informar a classe nameSpace.Classe, desta maneira ele encontra a Classe
        //public Cliente titular;//utilizando using
        //public Cliente titular;// Referencia a classe pessoa e todos os seus atributos e talvez métodos;

        public int agencia;
        public int numero;
        private double _saldo = 100; //Novo valor padrão

        //criamos propriedes sem logicas necessárias, apenas retorno, como esta abaixo, podemos criar na mesma linha public Cliente Titular { get; set; }
        private Cliente _titular;
        public Cliente Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                _titular = value;
            }
        }

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                //Value é a palavra recervada que indica o valor passado por parâmetro na chamada do método, como SetSaldo(double valor), valor é representado por value neste contexto
                if (value < 0)
                {
                    return;
                }
                this._saldo -= value;
            }
        }

        /*  Foi trocado para o get e set mais facil acima.
        public void SetSaldo(double saldo)
        {
            if(saldo < 0)
            {
                return;
            }
            this.saldo -= saldo;
        }

        public double GetSaldo ()
        {
            return saldo;
        }
        */
        public bool Sacar(double valor)
        {
            if (this._saldo <= valor)
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            this._saldo += valor;
        }
        //Chama outra referencia, com todos os metodos e atributos.
        public bool Transferir(double valor, ContaCorrente contaTransferir)
        {
            if (this._saldo < valor)
            {
                return true;//Return true para a função no momento de sua execução
            }

            this._saldo -= valor;
            contaTransferir._saldo += valor;
            return true;
        }

    }
}
