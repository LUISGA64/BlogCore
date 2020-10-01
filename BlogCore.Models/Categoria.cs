﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogCore.Models
{
    public class Categoria
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Ingrese un nombre para la categoria")]
        [Display(Name ="Nombre Categoría")]
        public string Nombre { get; set; }

        [Required]
        [Display(Name = "Orden de Visualización")]
        public string Orden { get; set; }
    }
}
