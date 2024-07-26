using MongoDB.Driver;

namespace minimalApiMongo.Properties.Services
{
    public class MongoDbService
    {
        //Armazenar a configuração da apicação

        private readonly IConfiguration _configuration;

        //Armazenar uma referência ao mongoDb
        private readonly IMongoDatabase _database;

        //Contém a configuração necessária para o acesso ao mongoDb
        public MongoDbService(IConfiguration configuration)
        {
            _configuration = configuration;

            var connectionString = _configuration.GetConnectionString("DbConnection");
            //var connectionString = "mongodb://localhost:27017/ProductDataBase_Tarde"

            //Criando uma variavel para armazenar uma url que recebe como parametro a string de conexão
            var mongoUrl = MongoUrl.Create(connectionString);

            //Adicipnando ao MongoClient
            var mongoClient = new MongoClient(mongoUrl);

            //Acessando o servidor do mongoDb
            _database = mongoClient.GetDatabase(mongoUrl.DatabaseName);
        }

        //Fora do Construtor

        //Propriedade que retorna o _database que é o nosso banco
        public IMongoDatabase GetDatabase => _database;
    }
}
