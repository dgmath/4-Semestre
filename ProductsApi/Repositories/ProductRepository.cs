using ProductsApi.Context;
using ProductsApi.Domains;
using ProductsApi.Interfaces;

namespace ProductsApi.Repositories
{
    public class ProductRepository : IProductsRepository
    {
        private readonly ProductsContext _ctx;

        public ProductRepository()
        {
            _ctx = new ProductsContext();
        }
        public void Delete(Guid id)
        {
            try
            {
                Products produtoBuscado = _ctx.products.Find(id)!;
                if (produtoBuscado != null) 
                {
                  _ctx.products.Remove(produtoBuscado);
                }

                _ctx.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Products> Get()
        {
            return _ctx.products.ToList();
        }

        public Products GetById(Guid id)
        {
            return _ctx.products.FirstOrDefault(x => x.IdProduct == id)!;
        }

        public void Post(Products products)
        {
            try
            {
                _ctx.products.Add(products);
                _ctx.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Put(Guid id, Products products)
        {
            Products produtoBuscado = _ctx.products.FirstOrDefault(x => x.IdProduct == id)!;

            if (produtoBuscado != null)
            {
                produtoBuscado.Name = products.Name;
                
                produtoBuscado.Price = products.Price;

            }

            _ctx.products.Update(produtoBuscado);
            _ctx.SaveChanges();
        }
    }
}
