namespace DevSteamAPI.Models
{
    public class Jogo
    {
        public Guid JogoId { get; set; }
        public string JogoNome { get; set; }
        public int Classificacao { get; set; }
        public string? Descricao { get; set; }
        public string? Imagem { get; set; }

        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
