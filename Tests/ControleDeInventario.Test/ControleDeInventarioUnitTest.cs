namespace ControleDeInventario.Test
{
    public class ControleDeInventarioUnitTest
    {
        [Fact]
        public void ControleTest()
        {
            var prod = new Controle.Produto();
            prod.Nome = "Macaco";
            prod.Quantidade = 1;

            var list = new List<Controle.Produto>();

            var res = Controle.AdicionarProduto(list, prod);

            var ver = list.FirstOrDefault(x => x.Nome == "Macaco");

            Assert.NotNull(ver);

            var prod2 = new Controle.Produto();
            prod2.Nome = "Macaco";


            var res2 = Controle.AdicionarProduto(list, prod2);

            var ver2 = list.FirstOrDefault(x => x.Nome == "Macaco");

            Assert.Equal(2, ver2.Quantidade);

        }
    }
}