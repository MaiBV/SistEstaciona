using SistEstaciona;

class Programa
{
    static void Main(string[] args)
    {
        Estacionamento estacionamento = new Estacionamento();

        Veiculo veiculo1 = new Veiculo("ABC123", "Leonardo Buta", "Leonardo.buta@example.com");
        estacionamento.AdicionarVeiculo(veiculo1);

        Veiculo veiculo2 = new Veiculo("XYZ789", "MaiBV", "maibv@example.com");
        estacionamento.AdicionarVeiculo(veiculo2);

        estacionamento.ListarVeiculos();

        estacionamento.RemoverVeiculo(veiculo1);

        Console.ReadLine();
    }
}