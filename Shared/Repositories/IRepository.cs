using LetrasBlog.Client.Repositories;
using LetrasBlog.Infraestructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LetrasBlog.Client.Repositories
{
    public interface IRepository
    {
        //GETS DE ENTIDADES
        Task<Articles.response> GetArticles();
        Task<Users.response> GetUsers();
        Task<Contabilidades.response> GetContabilidades();
        //Task<Duenos.response> GetDuenos();
        //Task<Entrenamientos.response> GetEntrenamientos();
        //Task<Guarderias.response> GetGuarderias();
        //Task<Hospedajes.response> GetHospedajes();
        //Task<Pasadias.response> GetPasadias();
        //Task<Perros.response> GetPerros();

    }
}