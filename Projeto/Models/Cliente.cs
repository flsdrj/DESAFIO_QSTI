using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }

        [Display(Name ="Nome")]
        public string Nome { get; set; }

        public ICollection<Servico> Servicos { get; set; } = new List<Servico>();
        public ServicoCliente ServicoCliente { get; set; }
        
        public Cliente()
        {

        }

        public Cliente(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
