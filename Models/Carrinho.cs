using System.Runtime.CompilerServices;

namespace DevSteamAPI.Models
{
    public class Carrinho
    {
        public Guid CarrinhoId { get; set; }
        public Guid UsuarioId { get; set; }
        public DateTime? DataCriacao { get; set; }
        public Decimal? Total { get; set; } = 0;
        public bool? Finalizado { get; set; } = false;
    }
}
