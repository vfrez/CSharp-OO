public class ContaCorrente
{
    //Quando não declararmos valores para os objetos instanciados, será atribuido um valor padrão
    //Caso não indicarmos aqui na criação da classe o valor, o mesmo sera: vazio para string, e 0 para numeros
    //Casi queiramos trocar este valor padrão, só atribuir na criação dos atributos o valor que queira
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100; //Novo valor padrão
}