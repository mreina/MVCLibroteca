using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using MVCLibroteca.Models;
using System.ComponentModel.DataAnnotations;

namespace MVCLibroteca.Data
{
    public class ConexionMysqlDataContext : DbContext
    {
        //Constructor de la clase
        public ConexionMysqlDataContext(DbContextOptions<ConexionMysqlDataContext> options) : base(options)
        {
            //Contructor vacío
        }
        //Entidades - Tablas
        public DbSet<Autores> Autores { get; set; }
        public DbSet<Libros> Libros { get; set; }

        public DbSet<servicios> servicios { get; set; }

        public DbSet<Usuarios> usuarios { get; set; }

    }
}