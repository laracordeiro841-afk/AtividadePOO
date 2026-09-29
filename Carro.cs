namespace AtividadePOO;

public class Carro : Veiculo
{
    public Carro(string Modelo, int Ano) : base(Modelo, Ano)
    {
        
    }
    
    public override void Acelerar()
    {
        Console.WriteLine($"{Modelo} acelerou rápido pelas cucas!");   
    }
}