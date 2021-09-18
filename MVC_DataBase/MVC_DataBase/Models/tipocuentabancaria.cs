using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_DataBase.Models
{
    public class tipocuentabancaria
    {
        [Key]
        public int id { get; set; }

        [StringLength(100)]
        public string tipoCuentaBancaria { get; set; }
        
        public bool activo { get; set; }
    }
}