﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad3.Models
{
    public class Denuncia:Incidente
    {
        public Denuncia(Policia oficial, Persona sujeto):base(oficial, sujeto) 
        {
        }

        override public string VerDescripcion()
        {
            string descripcion =
$@"Denuncia Policial, Emitida a las {Hora}:{Minuto} 
Motivo: {Motivo}
Agente policial inteviniente: {OficialACargo.VerDatos()}
Sujeto Denunciante:{Sujeto.VerDatos()}
";
                   
            return descripcion;
        }
    }
}
