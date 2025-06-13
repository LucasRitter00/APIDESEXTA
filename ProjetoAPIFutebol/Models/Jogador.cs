using System;

namespace ProjetoAPIFutebol.Models
{
    public class Jogador
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Posicao { get; set; }
        public int NumeroCamisa { get; set; }
        public string? Time { get; set; }
        public DateTime DataNascimento { get; set; }
        public float Altura { get; set; }
        public float Peso { get; set; }
        public string? Nacionalidade { get; set; }
    }
}
