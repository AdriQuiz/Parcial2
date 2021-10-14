using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SegundoParcialAdrianaQuiroz.Models
{
    public class Suerte
    {
        [Key]
        [Required]
        public int SuerteId { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Escriba el detalle")]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "La suerte debe tener entre 10 y 200 caracteres")]
        public string Detalle { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Ponga el link de la imagen")]
        [Url]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "El link debe tener entre 10 y 200 caracteres")]
        public string Imagen { get; set; }

    }
}
