namespace Estacionamento.MAUI.Models
{
    public class Motorista
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public int Cpf { get; set; }
        public string? Telefone { get; set; }
        public int? VeiculoId { get; set; }
        public ICollection<Veiculo>? Veiculos { get; set; }
    }
}
