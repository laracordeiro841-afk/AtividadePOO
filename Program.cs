namespace AtividadePOO;

class Program
{
    static void Main(string[] args)
    {
        Veiculo[] veiculos = 
        [
            new Carro("Civic g10", 2019),
            new Moto("BMW G 310 ", 2018),
            new Caminhao("Scania R450", 2018),
        ];

        foreach (Veiculo veiculoAtual in veiculos)
        {
            veiculoAtual.Ligar();
            veiculoAtual.Acelerar();
            Console.WriteLine();
        }
    }
}