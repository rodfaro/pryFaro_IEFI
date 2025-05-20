using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryFaro_IEFI.Models
{
    public class clsAuditar
    {
        public int Id{ get; set; }
        public int IdUsuario { get; set; }
        public int TiempoTrabajado { get;set;}
        public string Descripcion{ get; set; }
    }
}
