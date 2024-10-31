using System.ComponentModel.DataAnnotations;

namespace Blog.ViewModels.Accounts;

public class RegisterViewModel
{
    [Required(ErrorMessage = "O nome e obrigatorio")]
    public string Name { get; set; }

    [EmailAddress(ErrorMessage = "O email e invalido")]
    [Required(ErrorMessage = "O nome e obrigatorio")]
    public string Email { get; set; }
}