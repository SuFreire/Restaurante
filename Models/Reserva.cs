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
        [DataType(DataType.Date)]
        [DisplayName("Dia da Reserva")]
        [Required(ErrorMessage = "O campo 'Dia da Reserva' é obrigatório")]
        public DateTime DataReserva { get; set; }
        [DataType(DataType.Time)]
        [DisplayName("Hora da Reserva")]
        [Required(ErrorMessage = "O campo 'Hora da Reserva' é obrigatório")]
        public DateTime HoraReserva { get; set; }
        [Required(ErrorMessage = "O campo 'Nº de pessoas' é obrigatório")]
        [Column("int(2)")]
        [DisplayName("Nº de Pessoas")]
        public int NºdePessoas { get; set; }
        [Required(ErrorMessage = "Email inexistente, por favor faça o seu registo")]
        [ForeignKey("Registo")]
        [DisplayName("Email (Se o seu nome não se encontrar na lista abaixo, faça o seu registo antes de avançar.)")]
        public int RegistoID { get; set; }
        public Registo Registo { get; set; }

    }
}
