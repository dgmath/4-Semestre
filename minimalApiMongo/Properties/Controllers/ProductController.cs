﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using minimalApiMongo.Properties.Domains;
using minimalApiMongo.Properties.Services;
using MongoDB.Driver;

namespace minimalApiMongo.Properties.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductController : ControllerBase
    {
        private readonly IMongoCollection<Product> _product;

        public ProductController(MongoDbService mongoDbService)
        {
            _product = mongoDbService.GetDatabase.GetCollection<Product>("product");
        }
        [HttpGet("GetAll")]   
        public async Task<ActionResult<List<Product>>> Get()
        {
            try
            {
                var products = await _product.Find(FilterDefinition<Product>.Empty).ToListAsync();
                return products is not null ? Ok(products) : NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("id")]

        public async Task<ActionResult> GetById(string id)
        {
            try
            {
                var product = await _product.Find(x => x.Id == id).FirstOrDefaultAsync();

                //var filter = Builders<Product>.Filter.Eq(p => p.Id, id);

                //var res = await _product.Find(filter).ToListAsync();

                //return Ok(res.First());

                //Maneira de verificar o retorno do produto para não existir quebra de código
                return product is not null ? Ok(product) : NotFound();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("Cadastrar")]

        public async Task<ActionResult> Post(Product product) {
            try
            {
               Product novoProduto = new Product();
                novoProduto.Name = product.Name;
                novoProduto.Price = product.Price;  
                novoProduto.AdditionalAttributes = product.AdditionalAttributes;
                await _product.InsertOneAsync(product);
                

                return Ok(product);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("Deletar")]

        public async Task<ActionResult> Delete(string id)
        {
            try
            {
                await _product.DeleteOneAsync(p => p.Id == id);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("Atualizar")]

        public async Task<ActionResult> Put(Product p)
        {
            try
            {
                var filter = Builders<Product>.Filter.Eq(x => x.Id, p.Id);
                var res = await _product.Find(filter).ToListAsync();

                if (p.Name == null) 
                {
                    p.Name = res.First().Name;
                }
                
                if (p.Price == 0) 
                {
                    p.Price = res.First().Price;
                }

                //var update = Builders<Product>.Update
                //.Set(p => p.Name, product.Name)
                // .Set(p => p.Price, product.Price);
                if (filter != null)
                {
                    await _product.ReplaceOneAsync(filter, p);

                    return Ok();
                }
               

                return NotFound();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }

        }
    }
}
