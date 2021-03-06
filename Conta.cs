public class Conta 
{
    public int Codigo { get; }
    public double Saldo { get; private set; }

    public Conta(int codigo)
    {
        Codigo = codigo;
        Saldo = 0.0;
    }

    public void Sacar(double valor) 
    {
        ValidarValor(valor);
        VerificarSaldo(valor);
        Saldo -= valor;
    }

    public void Depositar(double valor)
    {
        ValidarValor(valor);
        Saldo += valor;
    }

    public void Transferir(double valor, Conta conta) {
        Sacar(valor);
        conta.Depositar(valor);
    }

    private void ValidarValor(double valor)
    {
        if(!(valor>0))
        {
            throw new Exception("Por favor, não insira valores negativos!");
        }
    }

    private void VerificarSaldo(double valor)
    {
        if(valor > Saldo)
        {
            throw new Exception("Saldo Insuficiente!");
        }
    }
}