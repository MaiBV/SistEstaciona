using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistEstaciona
{
    public class Veiculo
{
    public string Placa { get; set; }
    public DateTime HoraEntrada { get; set; }
    public DateTime HoraSaida { get; set; }
    public string NomeProprietario { get; set; }
    public string InformacaoContato { get; set; }
    public int HorasEstacionadas { get; set; }

    public Veiculo(string placa, string nomeProprietario, string informacaoContato)
    {
        Placa = placa;
        NomeProprietario = nomeProprietario;
        InformacaoContato = informacaoContato;
        HoraEntrada = DateTime.Now;
        HoraSaida = DateTime.MinValue;
        HorasEstacionadas = 0;
    }
}
}