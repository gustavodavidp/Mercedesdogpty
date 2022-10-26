﻿using LetrasBlog.Client.Repositories;
using LetrasBlog.Infraestructure.Entities;
using LetrasBlog.Infraestructure;
using LetrasBlog.Infraestructure.Interfaces;
using LetrasBlog.Server.Exceptions;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.CodeAnalysis;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace LetrasBlog.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        private readonly IRepository _RepositoryValidation;
        private readonly SqlConfigurationContext _dbContext;
        protected readonly ILogger<ArticlesController> _logger;

        public UsersController(IRepository Repository, [NotNull] ILogger<ArticlesController> logger)
        {
            _RepositoryValidation = Repository;
            _logger=logger;

        }

        [Route("GetUsers")]
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var post = await _RepositoryValidation.GetUsers();

            if (post == null)
            {
                throw new BusinessExceptions("Error en obtención");
            }
            return Ok(post);
        }
    }
}
