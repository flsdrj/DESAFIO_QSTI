using System;
using System.ComponentModel.DataAnnotations;

namespace Projeto.Models
{
    public class Cliente
    {
        public Guid Id { get; set; }

        [Display(Name ="Nome")]
        public string Nome { get; set; }

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
