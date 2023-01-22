using System.ComponentModel.DataAnnotations;

namespace Ms.Paciente.Api.Models
{
    public class Paciente
    {
        [Key]
        public int idPac { get; set; }
        public int dni { get; set; }

        public string nombres { get; set; }

        public string apepa { get; set; }

        public string apema { get; set; }
        public string edad { get; set; }
        public string seguro { get; set; }

        public string fecha_ingreso { get; set; }
        public string genero { get; set; }
    }
}
