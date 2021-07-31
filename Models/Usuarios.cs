using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;


namespace MVCLibroteca.Models
{
    public class Usuarios
    {
        //Llave primaria
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idUsuario { get; set; }

        //Campo nombre
        [Required]
        [MaxLength(100)]
        public string nombre { get; set; }

        //Campo correo
        [Required]
        [MaxLength(100)]
        [DataType(DataType.EmailAddress)]
        public string correo { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "El password debe tener al menos 6 caractéres", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "El password no coincide. Intentar nuevamente.")]
        public string confirmarPassword { get; set; }

        //Campo Rol (Administrador, Cliente, X)
        [Required]
        [MaxLength(100)]
        public string rol { get; set; }


        [Comment("Campo para determinar si esta activo")]
        public Boolean estatus { get; set; }
    }
}