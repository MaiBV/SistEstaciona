using SistEstaciona;

class Programa
{
    static void Main(string[] args)
    {
        Estacionamento estacionamento = new Estacionamento();

        Veiculo veiculo1 = new Veiculo("ABC123", "João Doe", "joao.doe@example.com");
        estacionamento.AdicionarVeiculo(veiculo1);

        Veiculo veiculo2 = new Veiculo("XYZ789", "Maria Doe", "maria.doe@example.com");
        estacionamento.AdicionarVeiculo(veiculo2);

        estacionamento.ListarVeiculos();

        estacionamento.RemoverVeiculo(veiculo1);

        Console.ReadLine();
    }
}