namespace AtividadePOO;

public class Moto : Veiculo
{
    public Moto(string Modelo, int Ano) : base(Modelo, Ano)
    {
        
    }
    
    public override void Acelerar()
    {
        Console.WriteLine($"{Modelo} acelerou e cortou giro!");   
    }
}