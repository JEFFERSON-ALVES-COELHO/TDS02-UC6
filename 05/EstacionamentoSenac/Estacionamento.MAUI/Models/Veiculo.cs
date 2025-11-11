namespace Estacionamento.MAUI.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
        public string? Placa { get; set; }
        public string? Modelo { get; set; }
        public int Cor{ get; set; }
        public ICollection<Veiculo> Veiculos { get; set; } = new List<Veiculo>();

    }
}
