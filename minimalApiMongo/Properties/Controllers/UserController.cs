using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using minimalApiMongo.Properties.Domains;
using minimalApiMongo.Properties.Services;
using MongoDB.Driver;

namespace minimalApiMongo.Properties.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UserController : ControllerBase
    {
        private readonly IMongoCollection<User> _user;

        public UserController(MongoDbService mongoDbService)
        {
            _user = mongoDbService.GetDatabase.GetCollection<User>("User");
        }

        [HttpGet("GetAll")]
        public async Task<ActionResult<List<User>>> Get()
        {
            try
            {
                var users = await _user.Find(FilterDefinition<User>.Empty).ToListAsync();
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
                var user = await _user.Find(x => x.Id == id).FirstOrDefaultAsync();

                //var filter = Builders<Product>.Filter.Eq(p => p.Id, id);

                //var res = await _product.Find(filter).ToListAsync();

                //return Ok(res.First());

                //Maneira de verificar o retorno do produto para não existir quebra de código
                return user is not null ? Ok(user) : NotFound();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost("Cadastrar")]

        public async Task<ActionResult> Post(User u)
        {
            try
            {
                User novoUser = new User();
                novoUser.Name = u.Name;
                novoUser.Email = u.Email;
                novoUser.Password = u.Password;
                novoUser.AdditionalAttributes = u.AdditionalAttributes;
                await _user.InsertOneAsync(u);


                return Ok(u);
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
                await _user.DeleteOneAsync(p => p.Id == id);
                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("Atualizar")]

        public async Task<ActionResult> Put(User u)
        {
            try
            {
                var filter = Builders<User>.Filter.Eq(x => x.Id, u.Id);
                var res = await _user.Find(filter).ToListAsync();

                //var update = Builders<Product>.Update
                //.Set(p => p.Name, product.Name)
                // .Set(p => p.Price, product.Price);
                if (filter != null)
                {
                    await _user.ReplaceOneAsync(filter, u);

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
