using System.Collections.Generic;

namespace Projeto.Models.ViewModel
{
    public class ServiçoClienteFormViewModel
    {
        public ServicoCliente ServicoCliente { get; set; }
    
        public ICollection<Servico> Serviços { get; set; }
        public ICollection<Cliente> Clientes { get; set; }

    }
}
