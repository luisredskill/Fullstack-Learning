using API_1.Models;
using API_1.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_1.Controllers
{
    [Produces("application/json")]

    [Route("api/[controller]")]
    [ApiController]
    public class LivroController : ControllerBase
    {
        private readonly LivroRepository _livroRepository;

        public LivroController(LivroRepository livroRepository)
        {
            _livroRepository = livroRepository;
        }

        [HttpGet]
        public IActionResult Listar()
        {
            try
            {
                return Ok(_livroRepository.Listar());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        [HttpGet("{id}")]
        public IActionResult BuscarPorId(int id)
        {
          try {
                Livros livro = _livroRepository.BuscarPorId(id);

                if (livro == null)
                {
                    return NotFound();
                }
                return Ok(livro);
            }
            catch (Exception)
            {
                throw;
            }
        }


        [HttpPost]
        public IActionResult Cadastrar(Livros livro)
        {
            try
            {
                _livroRepository.Cadastrar(livro);

                return StatusCode(201); 
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, Livros livro)
        {
            try
            {
                _livroRepository.Atualizar(id, livro);

                return StatusCode(204);
            }
            catch (Exception)
            {

                throw;
            }
        }


        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            try
            {
                _livroRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception)
            {

                throw;
            }
        }




    } 
}
