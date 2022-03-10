using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Models
{
    
    public class Reserva
        
    {
        [Key]
        public int ReservaID { get; set; }
        [Required(ErrorMessage = "O campo 'nome' é obrigatório")]
        [Column("varchar(50)")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "O campo 'telefone' é obrigatório")]
        [Column("int(9)")]
        public int Telefone { get; set; }
        [Required(ErrorMessage = "O campo 'Nº de pessoas' é obrigatório")]
        [Column("int(2)")]
        public int NºdePessoas { get; set; }
        [Required]
        [ForeignKey("Registo")]
        [DisplayName("Email")]
        public int RegistoID { get; set; }
        public Registo Registo { get; set; }

    }
}
