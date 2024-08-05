using ProductsApi.Domains;

namespace ProductsApi.Interfaces
{
    public interface IProductsRepository
    {
        public List<Products> Get();
        public Products GetById(Guid id);

        public void Post(Products products);

        public void Put(Guid id,  Products products);
        public void Delete(Guid id);


    }
}
