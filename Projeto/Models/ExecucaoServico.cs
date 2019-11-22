using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Projeto.Models
{
    public class ExecucaoServico
    {
        public Guid Id { get; set; }

        [Display(Name = "Id Servico Cliente")]
        public Guid? ServicoClienteId { get; set; }

        [Display(Name = "Data Execucao Servico")]
        public DateTime Data { get; set; }

        public ICollection<ServicoCliente> ServicoCliente { get; set; } = new List<ServicoCliente>();

        public ExecucaoServico()
        {

        }

        public ExecucaoServico(Guid id, Guid? servicoClienteId, DateTime data)
        {
            Id = id;
            ServicoClienteId = servicoClienteId;
            Data = data;
        }
    }
}
