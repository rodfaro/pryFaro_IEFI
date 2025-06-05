using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryFaro_IEFI.Models
{
    public class clsTareas
    {
        public int? IdTarea { get; set; }
        public int IdUsuario { get; set; }
        public string Tarea { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }

        //Detalles uniforme
        public bool UniformeInsumo { get; set; }

        //Detalles de Licencias
        public bool LicenciaEstudio { get; set; }
        public bool LicenciaVacacion { get; set; }
        public bool LicenciaMedica { get; set; }
        public bool LicenciaPersonal { get; set; }

        //Detalles de Reclamos
        public bool ReclamoSalario { get; set; }
        public bool ReclamoRecibo { get; set; }
        
        //Detalles de Otros
        public bool HsExtra { get; set; }
        public bool Ausencia { get; set; }
        public bool PermisoTemporal { get; set; }
        public bool Retraso { get; set; }

        public string Comentario{ get; set; }


    }
}
