using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SemaforoSimulation
{
    public class Semaforo
    {
        public bool Rojo;
        public bool Verde;
        public bool Amarillo;
        public bool VerdeDoblar;
        public int TiempoRojo;
        public int TiempoVerde;
        public int TiempoAmarillo;
        public int TiempoVerdeDoblar;
        public int CarrosPorSegundo;


        public Semaforo(int TiempoRojo, int TiempoVerde, int TiempoAmarillo, int CarrosPorSegundo)
        {
            Rojo = false;
            Verde = false;
            Amarillo = false;
            VerdeDoblar = false;
            this.TiempoRojo = TiempoRojo;
            this.TiempoVerde = TiempoVerde;
            this.TiempoAmarillo = TiempoAmarillo;
            TiempoVerdeDoblar = 0;
            this.CarrosPorSegundo = CarrosPorSegundo;

        }

        public Semaforo(int TiempoRojo, int TiempoVerde, int TiempoAmarillo, int TiempoVerdeDoblar, int CarrosPorSegundo)
        {
            Rojo = false;
            Verde = false;
            Amarillo = false;
            VerdeDoblar = false;
            this.TiempoRojo = TiempoRojo;
            this.TiempoVerde = TiempoVerde;
            this.TiempoAmarillo = TiempoAmarillo;
            this.TiempoVerdeDoblar = TiempoVerdeDoblar;
            this.CarrosPorSegundo = CarrosPorSegundo;
        }


        public void Verde_Amarillo()
        {
            Verde = false;
            Amarillo = true;

        }

        public void Amarillo_Rojo()
        {
            Amarillo = false;
            Rojo = true;

        }

        public void Rojo_Verde()
        {
            Rojo = false;
            Verde = true;

        }

        public void ActivarVerdeDoblar()
        {
            if(TiempoVerdeDoblar != 0)
            {
                VerdeDoblar = true;
            }

        }

        public void DesactivarVerdeDoblar()
        {
            VerdeDoblar = false;
        }



    }


}
