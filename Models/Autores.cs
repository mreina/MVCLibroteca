using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
//Libreria para las anotaciones
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace MVCLibroteca.Models
{
    [Table("autores")]
    public class Autores
    {
        //Campos - Atributos
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idAutor {get; set;}

        [Required]
        [MaxLength(100)]
        [DefaultValue("Nombre Default")]
        public string nombre{get; set;}

        [Required]
        [MaxLength(100)]
        [DefaultValue("Apellido Default")]
        public string aPaterno{get; set;}

        [MaxLength(100)]
        public string aMaterno{get; set;}

        [Required]
        [MaxLength(100)]
        [DefaultValue("Mexicana")]
        public string nacionalidad{get; set;}

        [Required]
        [DefaultValue(true)]
        public Boolean estatus{get; set;}

    }
}