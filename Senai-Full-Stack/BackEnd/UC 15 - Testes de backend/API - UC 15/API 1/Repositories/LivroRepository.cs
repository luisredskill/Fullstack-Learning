using API_1.Contexts;
using API_1.Models;

namespace API_1.Repositories
{
    public class LivroRepository
    {
        private readonly APIContext _context;
        public LivroRepository(APIContext context)
        {
            _context = context;
        }

        public List<Livros> Listar()
        {
            return _context.Livro.ToList();
        }


        public Livros BuscarPorId(int id)
        {
            return _context.Livro.Find(id);
        }


        public void Cadastrar(Livros livro)
        {
            _context.Livro.Add(livro);
            _context.SaveChanges();
        }


        public void Atualizar (int id, Livros livro)
        {
            Livros livroBuscado = _context.Livro.Find(id);

            if (livroBuscado != null)
            {
                livroBuscado.Titulo = livro.Titulo;
                livroBuscado.QuantidadePaginas = livro.QuantidadePaginas;   
                livroBuscado.Disponivel = livro.Disponivel;
            }

            _context.Livro.Update(livroBuscado);
            _context.SaveChanges();
         }


        public void Deletar (int id)
        {
            Livros livroDeletado = _context.Livro.Find(id);
            _context.Livro.Remove(livroDeletado);
            _context.SaveChanges();
        }
    }
}
