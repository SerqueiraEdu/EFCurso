using EFCurso.Curso.ValueObjects;

namespace EFCurso.Curso.Domain
{
    public class Pedido
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente? Cliente { get; set; }
        public TipoFrete TipoFrete { get; set; }
        public DateTime Iniciado { get; set; }
        public DateTime Finalizado { get; set; }
        public StatusPedido StatusPedido { get; set; }
        public string? Observacao { get; set; }
        public ICollection<PedidoItem>? Items { get; set; }
    }
}
