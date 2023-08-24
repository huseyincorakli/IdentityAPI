using Microsoft.Extensions.Configuration;
namespace IdentityAPI.Persistence
{
     static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/IdentityAPI.WebAPI"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("PostgreSQL");
            }
        }
    }
}
