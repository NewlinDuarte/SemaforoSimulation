using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SemaforoSimulation
{


    public class Carros : IEquatable<Carros>
    {
        public int TiempoDeEspera;

        public Rutas RutaInicio;
        public Rutas RutaDestino;


        public Carros(Rutas RutaInicio)
        {
            this.RutaInicio = RutaInicio;
        }


        public bool Equals(Carros other)
        {
            // Would still want to check for null etc. first.
            return this.
        }
    }


}
