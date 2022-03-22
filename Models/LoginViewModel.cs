using Azure.Core;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Restaurante.Models
{
    public class LoginViewModel
    {
        private string senha;
        [Required(ErrorMessage = "Informe o utilizador")]
        [Display(Name = "Utilizador:")]
        public string Usuario { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^[estarola]*$")]
        public string Senha { get => senha; set => senha = value; }

        [Display(Name = "Lembrar Me")]
        public bool LembrarMe { get; set; }
    }
}
