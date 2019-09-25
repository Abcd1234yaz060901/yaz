using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapNegocios
{
   public class Productos
    {
        public Productos() { }

        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String detalle { get; set; }
        public String Costo { get; set; }
        public String Precio { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public String Categoria { get; set; }
        public String Estado { get; set; }
       

    }
}
