using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace MeusFilmes.Data.Repositories
{
    public abstract class RepositoryBase<T>
    {
    
        
 public static IConfiguration _configuration
    {
        get
        {
            IConfigurationRoot Configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            return Configuration;
        }
    }
        protected readonly SQLiteConnection conn;

        public RepositoryBase(IConfiguration configuration)
        {            
            conn = new SQLiteConnection(_configuration.GetConnectionString("DefaultConnection"));
           // var connection = _configuration.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;
        }


        public abstract void Alterar(T model);
        public abstract void Cadastrar(T model);
        public abstract T Consultar(int? id);
        public abstract IEnumerable<T> Consultar();
        public abstract void Excluir(T model);

    }
}