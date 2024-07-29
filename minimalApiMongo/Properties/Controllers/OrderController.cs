using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using minimalApiMongo.Properties.Domains;
using minimalApiMongo.Properties.Services;
using MongoDB.Driver;
using static minimalApiMongo.Properties.Domains.Order;

namespace minimalApiMongo.Properties.Controllers
{
    [Route("api/[controller]")] 
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMongoCollection<Order> _order;
        private readonly IMongoCollection<Product> _product;
        private readonly IMongoCollection<Client> _client;



        public OrderController(MongoDbService mongoDbService)
        {
            _order = mongoDbService.GetDatabase.GetCollection<Order>("Order");
            _product = mongoDbService.GetDatabase.GetCollection<Product>("product");
            _client = mongoDbService.GetDatabase.GetCollection<Client>("Client");
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Order>>> Get()
        {
            try
            {
                var order = await _order.Find(FilterDefinition<Order>.Empty).ToListAsync();
                return order is not null ? Ok(order) : NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("id")]

        public async Task<ActionResult<OrderResponse>> GetById(string id)
        {
            try
            {
                var order = await _order.Find(x => x.Id == id).FirstOrDefaultAsync();

                //var filter = Builders<Product>.Filter.Eq(p => p.Id, id);

                //var res = await _product.Find(filter).ToListAsync();

                //return Ok(res.First());

                var client = await _client.Find(c => c.Id == order.ClientId).FirstOrDefaultAsync();
                if (client == null)
                {
                    return NotFound("Client not found");
                }

                var products = await _product.Find(p => order.ProductsId.Contains(p.Id)).ToListAsync();
                

                // Montar a resposta
                var response = new OrderResponse
                {
                    Order = order,
                    Client = client,
                    Products = products
                };
                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("Cadastrar")]

        public async Task<ActionResult> Post(Order o)
        {
            try
            {
                Order novoOrder = new Order();
                novoOrder.Date = o.Date;
                novoOrder.Status = o.Status;
                novoOrder.ProductsId = o.ProductsId;
                novoOrder.ClientId = o.ClientId;
                await _order.InsertOneAsync(o);


                return Ok(o);
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
                await _order.DeleteOneAsync(p => p.Id == id);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("Atualizar")]

        public async Task<ActionResult> Put(Order o)
        {
            try
            {
                var filter = Builders<Order>.Filter.Eq(x => x.Id, o.Id);
                //var res = await _order.Find(filter).ToListAsync();

                //var update = Builders<Product>.Update
                //.Set(p => p.Name, product.Name)
                // .Set(p => p.Price, product.Price);
                if (filter != null)
                {
                    await _order.ReplaceOneAsync(filter, o);

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
