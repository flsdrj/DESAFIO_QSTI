using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{
    public class ServicoCliente
    {
        public Guid Id { get; set; }

        [Display(Name = "Id Servico")]
        public Guid? ServicoId { get; set; }

        [Display(Name = "Id Cliente")]
        public Guid? ClienteId { get; set; }

        [Display(Name = "Versao")]
        public int Versao { get; set; }

        public ExecucaoServico ExecucaoServico { get; set; }
   
        public ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();
        public ICollection<Servico> Servicos { get; set; } = new List<Servico>();



        public ServicoCliente()
        {

        }

        public ServicoCliente(Guid id, Guid? servicoId, Guid? clienteId, int versao)
        {
            Id = id;
            ServicoId = servicoId;
            ClienteId = clienteId;
            Versao = versao;
        }
    }
}
