namespace Auth.API.Repository
{
    public class BaseRepositoryService
    {
        public IConfiguration _configuration;
        public string connectionString { get; set; }
        public BaseRepositoryService(IConfiguration config)
        {
            _configuration = config;
            connectionString = _configuration.GetConnectionString("dbConnection");
        }
    }
}
