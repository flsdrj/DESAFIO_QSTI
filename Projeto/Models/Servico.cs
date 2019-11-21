using System;
using System.ComponentModel.DataAnnotations;
namespace Projeto.Models
{
    public class Servico
    {
        public Guid Id { get; set; }

        [Display(Name = "Nome")]
        public string  Nome { get; set; }

        [Display(Name = "Descricao")]
        public string Descricao { get; set; }

        public Servico()
        {

        }

        public Servico(Guid id, string nome, string descricao)
        {
            Id = id;
            Nome = nome;
            Descricao = descricao;
        }
    }


}
