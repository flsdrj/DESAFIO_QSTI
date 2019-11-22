using System;
using System.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projeto.Models;

namespace Projeto.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<ExecucaoServico> ExecucaoServico { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<ServicoCliente> ServicoCliente { get; set; }

    }
}
