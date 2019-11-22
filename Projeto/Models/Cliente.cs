using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public Guid ServicoClienteId { get; set;) }

        [Display(Name ="Nome")]
        public string Nome { get; set; }

        public ICollection<Servico> Servicos { get; set; } = new List<Servico>();
        public ServicoCliente ServicoCliente { get; set; }
        
        public Cliente()
        {

        }
        
        public Cliente(Guid id, string nome, ServicoCliente servicoCliente )
        {
            Id = id;
            Nome = nome;
            ServicoCliente = servicoCliente;
        }
        public void AddServico(Servico sv)
        {
            Servicos.Add(sv);
        }

        public void RemoveServico(Servico sv)
        {
            Servicos.Remove(sv);
        }
    }
}
