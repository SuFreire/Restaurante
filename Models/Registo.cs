﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    public class Registo
    {
        [Key]
        public int RegistoID { get; set; }
        [Required(ErrorMessage = "O campo 'nome' é obrigatório")]
        [Column ("varchar(50)")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo 'email' é obrigatório")]
        [Column("varchar(30)")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O campo 'telefone' é obrigatório")]
        [Column("int(9)")]
        public int Telefone { get; set; }
    }
}