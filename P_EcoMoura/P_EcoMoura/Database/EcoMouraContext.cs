using Microsoft.EntityFrameworkCore;
using P_EcoMoura.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P_EcoMoura.Database
{
    public class EcoMouraContext : DbContext
    {
        /*
         * EF Core - ORM
         *  ORM -> Biblioteca para mapear Objetos pra Banco de Dados Relacionais
         */
        public EcoMouraContext(DbContextOptions<EcoMouraContext> options) : base(options)
        {

        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
