using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.ViewModels.Categories
{
    public class EditorCategoryViewModel
    {
        [Required(ErrorMessage = "O nome é obrigatório")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "Esse campo deve conter entre 3 e 40 caracteres")]
        public string Name { get; set; }
        
        [Required(ErrorMessage = "O Slug é obrigatório")]
        public string Slug { get; set; }
    }
}