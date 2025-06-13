using Microsoft.AspNetCore.Mvc;
using ProjetoAPIFutebol.Data;
using ProjetoAPIFutebol.Models;

namespace ProjetoAPIFutebol.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JogadoresController : ControllerBase
    {
        private readonly AppDbContext _context;

        public JogadoresController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetJogadores()
        {
            var jogadores = _context.Jogadores.ToList();
            return Ok(jogadores);
        }

        [HttpGet("{id}")]
        public IActionResult GetJogadorPorId(int id)
        {
            var jogador = _context.Jogadores.FirstOrDefault(j => j.Id == id);

            if (jogador == null)
                return NotFound();

            return Ok(jogador);
        }

        [HttpPost]
        public IActionResult AdicionarJogador(Jogador jogador)
        {
            _context.Jogadores.Add(jogador);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetJogadorPorId), new { id = jogador.Id }, jogador);
        }

        [HttpDelete("{id}")]
        public IActionResult RemoverJogador(int id)
        {
            var jogador = _context.Jogadores.FirstOrDefault(j => j.Id == id);

            if (jogador == null)
                return NotFound();

            _context.Jogadores.Remove(jogador);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpGet("buscarPorNome/{nome}")]
        public IActionResult BuscarPorNome(string nome)
        {
            try
            {
                var jogadores = _context.Jogadores
                    .Where(j => j.Nome != null && j.Nome.Contains(nome))
                    .ToList();

                return Ok(jogadores);
            }
            catch
            {
                return StatusCode(500, "Erro ao buscar jogadores.");
            }
        }
    }
}
