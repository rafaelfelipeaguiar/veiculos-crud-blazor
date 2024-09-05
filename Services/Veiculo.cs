using System.ComponentModel.DataAnnotations;

namespace atividade_veiculos.Services
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string Placa { get; set; } = string.Empty;
        public string AnoFabricacaoModelo { get; set; } = string.Empty;
        public string Modelo { get; set; } = string.Empty;
        public string Chassis { get; set; } = string.Empty;
        public string RenavamVeiculo { get; set; } = string.Empty;
        public int IdMarca { get; set; }
        public int IdCor { get; set; }
    }
    public class Marca
    {
        public int IdMarca { get; set; }
        public string NomeMarca { get; set; }
    }

    public class Cor
    {
        public int IdCor { get; set; }
        public string NomeCor { get; set; }

    }
}
