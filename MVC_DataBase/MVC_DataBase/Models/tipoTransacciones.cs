using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_DataBase.Models
{
    public class tipoTransacciones
    {
        [Key]
        public int id { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage ="Campo Requerido")]
        public string tipoTransaccion
    }
}