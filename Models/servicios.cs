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
    [Table("servicios")]
    public class servicios
    {
        //Campos - Atributos
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idservicios { get; set; }

        [Required]
        [MaxLength(100)]
        [DefaultValue("Nombre Default")]
        public string nombre { get; set; }

        [Required]
        [MaxLength(200)]
        [DefaultValue("descripcion Default")]
        public string descripcion { get; set; }

        [Required]
        [MaxLength(10)]
        [DefaultValue("presio Default")]
        public string presio { get; set; }

        [Required]
        [MaxLength(200)]
        [DefaultValue("imagen")]
        public string imagen { get; set; }

        [Required]
        [DefaultValue(true)]
        public bool estatus { get; set; }
    }
}