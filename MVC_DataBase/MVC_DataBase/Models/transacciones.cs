using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_DataBase.Models
{
    public class transacciones
    {
        [Key]
        public int id { get; set; }

        public int IdCuentaBancaria { get; set; }

        [StringLength (200)]
        [Required(ErrorMessage ="Campo requerido")]
        public string tipoTransaccion { get; set; }

        public Double monto { get; set; }

        [StringLength (100)]
        public string estado { get; set; }

        [Required]
        [DisplayFormat (DataFormatString = "dd/mm/yyyy")]
        public DateTime fecha_transaccion { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "dd/mm/yyyy")]
        public DateTime fecha_aplicacion { get; set; }
    }
}