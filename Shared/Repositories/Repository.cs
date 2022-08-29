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

    }
}