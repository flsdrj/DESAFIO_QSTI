using Projeto.Data;
using Projeto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Services
{
    public class ClienteService
    {
        private readonly ApplicationDbContext _context;

        public ClienteService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Cliente> ClienteGetAll()
        {
            return _context.Cliente.ToList();
        }

        public void AddCliente(Cliente obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
        
    }
}
