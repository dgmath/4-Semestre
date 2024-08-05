using GerenciamentoDeLivros;

namespace GerenciarLivro.Test
{
    public class GerenciarLivrosUnitTest
    {
        [Fact]
        public void AdicionarLivroTeste()
        {
            var lista = new List<GerenciarLivros>();

            var livro = new GerenciarLivros();

            GerenciarLivros.AdicionarLivro(lista, livro);

            var result = lista.FirstOrDefault(x => x.nome == livro.nome);

            Assert.NotNull(result); 
        }
    }
}