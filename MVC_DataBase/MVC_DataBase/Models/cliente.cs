using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_DataBase.Models
{
    public class cliente
    {
        [Key]
        public int id { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage ="Campo requrido")]
        public string nombre { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage ="Campo requerido")]
        public string primerApellido { get; set; }

        [StringLength(200)]
        [Required(ErrorMessage ="Campo requerido")]
        public string segundoApellido { get; set; }

        [StringLength(20)]
        public string numeroTelefono { get; set; }

        [StringLength (100)]
        [EmailAddress(ErrorMessage ="El correo no cummple con el formato correcto")]
        public string email { get; set; }
    }
}