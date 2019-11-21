using System;
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
