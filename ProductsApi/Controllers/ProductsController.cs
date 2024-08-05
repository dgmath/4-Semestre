using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsApi.Domains;
using ProductsApi.Interfaces;
using ProductsApi.Repositories;

namespace ProductsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductsController : ControllerBase
    {
        private IProductsRepository _productsRepository { get; set; }

        public ProductsController()
        {
            _productsRepository = new ProductRepository();
        }

        [HttpPost("Cadastrar")]

        public IActionResult Post(Products products) 
        {
            try
            {
                _productsRepository.Post(products);
                return StatusCode(201, products);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete]

        public IActionResult Delete(Guid id) 
        {
            try
            {
                _productsRepository.Delete(id);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("BuscarTodos")]
        public IActionResult Get() 
        {
            try
            {
                List<Products> listaProduto = _productsRepository.Get();

                return Ok(listaProduto);

            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("BuscarPorId")]

        public IActionResult Get(Guid id) 
        { 
            try
            {
                return Ok(_productsRepository.GetById(id));
            }
            catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("Atualizar")]
        public IActionResult Put(Guid id, Products products) 
        {
            try
            {
                _productsRepository.Put(id, products);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
