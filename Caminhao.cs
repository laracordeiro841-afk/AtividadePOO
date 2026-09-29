namespace AtividadePOO;

public class Caminhao : Veiculo
{
    public Caminhao(string Modelo, int Ano) : base(Modelo, Ano)
    {
        
    }
    
    public override void Acelerar()
    {
        Console.WriteLine($"{Modelo} está acelerando devagar carregando peso!");   
    }
}