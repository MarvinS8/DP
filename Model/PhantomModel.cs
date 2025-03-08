using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP.Model
{
    public class PhantomModel
    {
        public int ID { get; set; }
        public string? Nombre { get; set; }
        public string? Apodo { get; set; }
        public string? Raza { get; set; }
        public string? Dueño { get; set; }
        public string? Personalidad { get; set; }
        public DateTime? PrimeraAparicion { get; set; }
        public string? ImagenURL { get; set; }
    }
}
