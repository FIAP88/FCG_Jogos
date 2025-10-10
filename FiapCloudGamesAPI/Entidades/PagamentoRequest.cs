namespace FCG_API_Jogos.Entidades
{
    public class PagamentoRequest
    {
        public decimal Valor { get; set; }
        public long PedidoId { get; set; } = 0;
        public int MetodoDePagamentoId { get; set; } = 1;
        public Guid ClienteId { get; set; }
        public Guid? CorrelationId { get; set; } = null;
    }
}
