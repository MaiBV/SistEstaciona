using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistEstaciona
{
    public class Estacionamento
{
    private List<Veiculo> veiculos;

    public Estacionamento()
    {
        veiculos = new List<Veiculo>();
    }

    public void AdicionarVeiculo(Veiculo veiculo)
    {
        veiculos.Add(veiculo);
    }

    public void RemoverVeiculo(Veiculo veiculo)
    {
        veiculos.Remove(veiculo);
        CalcularTaxaEstacionamento(veiculo);
    }

    public void ListarVeiculos()
    {
        foreach (var veiculo in veiculos)
        {
            Console.WriteLine($"Placa: {veiculo.Placa}, Hora de Entrada: {veiculo.HoraEntrada}, Proprietário: {veiculo.NomeProprietario}, Contato: {veiculo.InformacaoContato}, Horas Estacionadas: {veiculo.HorasEstacionadas}");
        }
    }

    private void CalcularTaxaEstacionamento(Veiculo veiculo)
    {
        decimal taxaEstacionamento = veiculo.HorasEstacionadas * 5.00m;
        Console.WriteLine($"Veículo {veiculo.Placa} removido. Taxa de estacionamento: {taxaEstacionamento:C}");
    }
}
}