using System.ComponentModel.DataAnnotations;

namespace Projeto.Models.Enums
{
    public enum ERoles
    {
        [Display(Name = "Usuario")]
        Usuario = 1,
      
    }

    public enum EUserRoles
    {
             [Display(Name = "Colaborador")]
        Employee = 1
    }
}
