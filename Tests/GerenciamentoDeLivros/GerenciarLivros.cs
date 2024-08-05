using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GerenciamentoDeLivros
{
    public class GerenciarLivros
    {
        // Exercício 1: Teste de Gerenciamento de Livros
        // Crie um teste unitário para o método AdicionarLivro que verifica se um livro é adicionado corretamente a uma lista de livros.

        public string nome = "Harry Potter";

        public string sumario = "Um menino que sofre muito";
        public static List<GerenciarLivros> AdicionarLivro(List<GerenciarLivros> livros, GerenciarLivros livro)
        {
            livros.Add(livro);
            
            return livros;
        }
       


    }
}
