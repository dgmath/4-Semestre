using Microsoft.EntityFrameworkCore.Infrastructure;
using Moq;
using ProductsApi.Domains;
using ProductsApi.Interfaces;
using ProductsApi.Repositories;

namespace testApiUnit.Test
{
    public class ProductsTest
    {
        [Fact]
        public void GetTest()
        {
            //Arrange

            //Lista de produtos

            List<Products> productList = new List<Products>
            {
                new Products {IdProduct = Guid.NewGuid(), Name = "Produto 1", Price = 22},
                new Products {IdProduct = Guid.NewGuid(), Name = "Produto 2", Price = 40},
                new Products {IdProduct = Guid.NewGuid(), Name = "Produto 3", Price = 88}

            };

            //Criar um objeto de simulação do tipo IProductsRepository(onde foram setados os métodos)

            var mockRepository = new Mock<IProductsRepository>();

            //Configura o método get para retornar a lista que foi criada acima, visto que não utilizaremos dados do banco

            mockRepository.Setup(x => x.Get()).Returns(productList);

            //Act

            //Acessar o metodo get atribuindo a sua resposta dentro da variavel, rodar o método configurado a lista e atribui-lo a variavel

            var result = mockRepository.Object.Get();

            //Assert

            //Result.count pois precisa trazer apenas a quantidade e nao todos os objetos da lista
            Assert.Equal(3, result.Count);
        }

        [Fact]

        public void PostTest()
        {
            List<Products> productList = new List<Products>();

            Products product = new Products { IdProduct = Guid.NewGuid(), Name = "Unha falsa", Price = 22 };

            productList.Add(product);

            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(x => x.Post(product)).Callback<Products>(
                p =>
                {
                    productList.Add(product);
                });

            mockRepository.Object.Post(product);

            Assert.Contains(product, productList); 

        }

        [Fact]
        public void GetTestById()
        {
            //Arrange

            //Lista de produtos
            var productId = Guid.NewGuid();

            List<Products> productList = new List<Products>
            {
                new Products {IdProduct = productId, Name = "Produto 1", Price = 22},


            };

            //Criar um objeto de simulação do tipo IProductsRepository(onde foram setados os métodos)

            var mockRepository = new Mock<IProductsRepository>();

            //Configura o método get para retornar a lista que foi criada acima, visto que não utilizaremos dados do banco

            mockRepository.Setup(x => x.GetById(productId)).Returns(productList.FirstOrDefault(x => x.IdProduct == productId));

            //Act

            //Acessar o metodo get atribuindo a sua resposta dentro da variavel, rodar o método configurado a lista e atribui-lo a variavel

            var result = mockRepository.Object.GetById(productId);

            //Assert

            //Result.count pois precisa trazer apenas a quantidade e nao todos os objetos da lista
            Assert.Equal(productId, result.IdProduct);
        }

        [Fact]
        public void DeleteTest()
        {
            //Arrange

            //Lista de produtos
            var productId = Guid.NewGuid();

            List<Products> productList = new List<Products>();

            Products product = new Products { IdProduct = productId, Name = "Produto 1", Price = 22 };


            //Criar um objeto de simulação do tipo IProductsRepository(onde foram setados os métodos)

            var mockRepository = new Mock<IProductsRepository>();

            //Configura o método get para retornar a lista que foi criada acima, visto que não utilizaremos dados do banco

            mockRepository.Setup(x => x.Delete(productId)).Callback<Guid>(
                p =>
                {
                    var item = productList.FirstOrDefault(x => x.IdProduct == productId);

                    if (item != null)
                    {
                        productList.Remove(item);
                    };

                });

            //Act

            //Acessar o metodo get atribuindo a sua resposta dentro da variavel, rodar o método configurado a lista e atribui-lo a variavel

            mockRepository.Object.Delete(productId);

            //Assert

            //Result.count pois precisa trazer apenas a quantidade e nao todos os objetos da lista
            Assert.DoesNotContain(product, productList);
        }

        [Fact]

        public void UpdateTest()
        {
            List<Products> productList = new List<Products>();

            var productId = Guid.NewGuid();

            Products product = new Products { IdProduct = productId, Name = "Unha falsa", Price = 22 };

            productList.Add(product);

            var mockRepository = new Mock<IProductsRepository>();

            mockRepository.Setup(x => x.Put(productId, product)).Callback<Guid, Products>((
                id, p) =>
                {
                    var item = productList.FirstOrDefault(x => x.IdProduct == id);
                    if (item != null)
                    {
                        p.Name = "Unha verdadeira";
                        p.Price = 42;
                        productList.Add(product);
                    }

                });

            mockRepository.Object.Put(productId, product);

            //var result = mockRepository.Object.GetById(productId);

            Assert.Equal("Unha verdadeira", product.Name);
        }

    }
}
