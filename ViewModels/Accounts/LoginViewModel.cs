using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.Accounts;

public class LoginViewModel
{
    [Required(ErrorMessage = "O nome e obrigatorio")]
    [EmailAddress(ErrorMessage = "O email e invalido")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Informe a senha")]
    public string Password { get; set; }
}