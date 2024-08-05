using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ControleDeInventario
{
    public class Controle
    {
        //      Exercício 4: Teste de Controle de Inventário
        //Crie um teste unitário para o método AdicionarProduto que verifica se um produto(nome e quantidade) é adicionado corretamente ao inventário(se já houver um produto incrementar a quantidade, senão adicione).
        //Teste também um método para obter a quantidade de um produto buscando pelo nome.

        public class Produto
        {
            public string Nome { get; set; }

            public int Quantidade { get; set; }

        }
        public int Quantidade = 10;
        public static List<Produto> AdicionarProduto(List<Produto> produtos, Produto produto)
        {
            var res = produtos.FirstOrDefault(x => x.Nome == produto.Nome);

            if (res != null)
            {
                res.Quantidade += 1;

            }
            else
            {
                produtos.Add(produto);
            }


            return produtos;




        }
    }
}
