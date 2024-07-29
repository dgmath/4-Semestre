using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using minimalApiMongo.Properties.Domains;
using minimalApiMongo.Properties.Services;
using MongoDB.Driver;

namespace minimalApiMongo.Properties.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly IMongoCollection<Client> _client;

        public ClientController(MongoDbService mongoDbService)
        {
            _client = mongoDbService.GetDatabase.GetCollection<Client>("Client");
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Client>>> Get()
        {
            try
            {
                var users = await _client.Find(FilterDefinition<Client>.Empty).ToListAsync();
                return users is not null ? Ok(users) : NoContent();
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
                var client = await _client.Find(x => x.Id == id).FirstOrDefaultAsync();

                //var filter = Builders<Product>.Filter.Eq(p => p.Id, id);

                //var res = await _product.Find(filter).ToListAsync();

                //return Ok(res.First());

                //Maneira de verificar o retorno do produto para não existir quebra de código
                return client is not null ? Ok(client) : NotFound();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("Cadastrar")]

        public async Task<ActionResult> Post(Client c)
        {
            try
            {
                Client novoClient = new Client();
                novoClient.UserId = c.UserId;
                novoClient.Cpf = c.Cpf;
                novoClient.Phone = c.Phone;
                novoClient.Address = c.Address;
                novoClient.AdditionalAttributes = c.AdditionalAttributes;
                await _client.InsertOneAsync(c);


                return Ok(c);
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
                await _client.DeleteOneAsync(p => p.Id == id);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("Atualizar")]

        public async Task<ActionResult> Put(Client c)
        {
            try
            {
                var filter = Builders<Client>.Filter.Eq(x => x.Id, c.Id);
                var res = await _client.Find(filter).ToListAsync();

                //var update = Builders<Product>.Update
                //.Set(p => p.Name, product.Name)
                // .Set(p => p.Price, product.Price);
                if (filter != null)
                {
                    await _client.ReplaceOneAsync(filter, c);

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
