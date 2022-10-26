using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LetrasBlog.Infraestructure.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace LetrasBlog.Client.Repositories
{
    public class Repository : IRepository
    {
        private string ConnectionString;
        public IConfiguration Configuration { get;}
        public string path = null;
        private static readonly HttpClient client = new HttpClient();

        public Repository(string connectionString)
        {
            ConnectionString = connectionString;
        }

        protected SqlConnection dbConection()
        {
            return new SqlConnection(ConnectionString);
        }
        public async Task<Articles.response> GetArticles()
        {
            Articles.response ArticlesData = new Articles.response();
            Articles.Data responseDetail = new Articles.Data();

            var db = dbConection();
            var procedure = "[dbo].[GET_ARTICLES]";

            var Data = await db.QueryAsync<Articles.Data>(procedure, commandType: CommandType.StoredProcedure); ;

            ArticlesData = new Articles.response
            {
                Code = 0,
                Message = "Success",
                Detail = Data.Select(c => new Articles.Data()
                {
                    IdArticle = c.IdArticle,
                    IdCategory = c.IdCategory,
                    IdUser = c.IdUser,
                    Title = c.Title,
                    Body = c.Body,
                    Created = c.Created,
                    Updated = c.Updated
                }).ToList()
            };

            return ArticlesData;
        }

        //GET ENTIDADES
        public async Task<Users.response> GetUsers()
        {
            Users.response ArticlesData = new Users.response();
            Users.Data responseDetail = new Users.Data();

            var db = dbConection();
            var procedure = "[dbo].[SP_OBTENER_USUARIOS]";

            var Data = await db.QueryAsync<Users.Data>(procedure, commandType: CommandType.StoredProcedure); ;

            ArticlesData = new Users.response
            {
                Code = 0,
                Message = "Success",
                Detail = Data.Select(c => new Users.Data()
                {
                    Id = c.Id,
                    Username = c.Username
                    
                }).ToList()
            };

            return ArticlesData;
        }
        public async Task<Contabilidades.response> GetContabilidades()
        {
            Contabilidades.response ArticlesData = new Contabilidades.response();
            Contabilidades.Data responseDetail = new Contabilidades.Data();

            var db = dbConection();
            var procedure = "[dbo].[SP_OBTENER_CONTABILIDADES]";

            var Data = await db.QueryAsync<Contabilidades.Data>(procedure, commandType: CommandType.StoredProcedure); ;

            ArticlesData = new Contabilidades.response
            {
                Code = 0,
                Message = "Success",
                Detail = Data.Select(c => new Contabilidades.Data()
                {
                    Id = c.Id,
                    Tipo = c.Tipo,
                    Servicio_Id = c.Servicio_Id,
                    Perro_Id = c.Perro_Id,
                    Monto = c.Monto,
                    Metodo = c.Metodo,
                    Fecha = c.Fecha,
                    Observacion = c.Observacion

                }).ToList()
            };

            return ArticlesData;
        }
        public async Task<Perros.response> GetPerros()
        {
            Perros.response ArticlesData = new Perros.response();
            Perros.Data responseDetail = new Perros.Data();

            var db = dbConection();
            var procedure = "[dbo].[SP_OBTENER_PERROS]";

            var Data = await db.QueryAsync<Perros.Data>(procedure, commandType: CommandType.StoredProcedure); ;

            ArticlesData = new Perros.response
            {
                Code = 0,
                Message = "Success",
                Detail = Data.Select(c => new Perros.Data()
                {
                    Id = c.Id,
                    Raza = c.Raza,
                    Nombre = c.Nombre,
                    Edad = c.Edad,
                    Dueno = c.Dueno,
                    CreadoPor = c.CreadoPor,
                    Observacion = c.Observacion

                }).ToList()
            };

            return ArticlesData;
        }
    }
}