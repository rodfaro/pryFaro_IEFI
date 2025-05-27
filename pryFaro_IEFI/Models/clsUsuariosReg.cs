using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryFaro_IEFI.Models
{
    public class clsUsuariosReg
    {
        public int idUser { get; set; }
        public string Usuario { get; set; }
        public string Passw { get; set; }
        public bool Admin { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }

    }
}
