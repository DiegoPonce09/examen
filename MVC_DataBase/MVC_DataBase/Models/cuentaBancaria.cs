using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_DataBase.Models
{
    public class cuentaBancaria
    {
        [Key]
        public int id { get; set; }

        public int IdCliente { get; set; }

        [StringLength (100)]
        public string tipo { get; set; }

        [StringLength (100)]
        public string moneda { get; set; }
    }
}