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
using Microsoft.AspNetCore.Http;

namespace MVCLibroteca.Models
{
    [Table("libros")]
    public class Libros
    {
        //Campos - Atributos
        //Llave primaria
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idLibro { get; set; }

        //Llave Foránea
        [ForeignKey("Libro_Autor")]
        public int idAutor { get; set; }
        public Autores autores { get; set; }


        [Required]
        [MaxLength(100)]
        public string titulo { get; set; }

        [Required]
        [MaxLength(100)]
        public string ISBN { get; set; }

        [Required]
        [MaxLength(100)]
        public string Editorial { get; set; }

        //Imagen de la portad
        [MaxLength(300)]
        public string portada { get; set; }
        [NotMapped]
        public IFormFile archivo { get; set; }

        [Required]
        [Range(1, 1000000)]
        [DisplayFormat(DataFormatString = "{0:C}")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(10,2")]
        public decimal precio { get; set; }


        [Required]
        [DataType(DataType.Date)]
        public DateTime fechaPublicacion { get; set; }


        [Required]
        [Range(0, 1000000)]
        public int stock { get; set; }


        [Required]
        [DefaultValue(true)]
        public Boolean estatus { get; set; }

    }
}