using System.ComponentModel.DataAnnotations;

namespace webApiPractica.Models
{
    public class tipo_equipo
    {
        [Key]
        public int id_tipo_equipo { get; set; }
        public String? descripcion { get; set; }
        public bool? estado { get; set; }
    }
}
