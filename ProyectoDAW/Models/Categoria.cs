﻿using System.ComponentModel.DataAnnotations;

namespace ProyectoDAW.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        public string CategoriaNombre { get; set; }
        public string Descripcion { get; set; }
        public bool CategoriaEstado { get; set; }
    }
}
