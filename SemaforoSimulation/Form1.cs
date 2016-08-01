using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemaforoSimulation
{
    public enum Rutas
    {
        Macoris = 0,
        Tenares = 1,
        Nordestana = 2
    }

    public partial class Form1 : Form
    {
      int TiempoVerdeSem1;
      int TiempoVerdeSem2;
      int TiempoVerdeDoblarSem2;
      int TiempoVerdeSem3;
      int TiempoAmarilloSem1;
      int TiempoAmarilloSem2;
      int TiempoAmarilloSem3;
      int TiempoRojoSem1;
      int TiempoRojoSem2;
      int TiempoRojoSem3;

        //enum que define las rutas
      
        //Totales de carros que van de una ruta a otra
        int carrosR1R2;
        int carrosR1R3;
        int carrosR2R1;
        int carrosR2R3;
        int carrosR3R1;
        int carrosR3R2;

        //Total tiempo de espera de todos los carros
        int tiempoEspera;

        //Cantidad de carros que tuvieron que esperar
        int esperaSemaforo1;
        int esperaSemaforo2;
        int esperaSemaforo3;

        //Tiempo de simulacion en segundos
        int Tiempo;



        public Form1()
        {
            Random rand = new Random();
            Tiempo = 28800;
            Semaforo Semaforo1 = new Semaforo(30,27,3,2);
            Semaforo1.Rojo_Verde();
            List<Carros> carrosFila1 = new List<Carros>();
            Semaforo Semaforo2 = new Semaforo(20, 27, 3,10, 2);
            Semaforo2.Rojo_Verde();
            List<Carros> carrosFila2 = new List<Carros>();
            Semaforo Semaforo3 = new Semaforo(40, 17, 3, 1);
            Semaforo3.Amarillo_Rojo();
            List<Carros> carrosFila3 = new List<Carros>();
            for (int x = 1; x <= Tiempo; x++)
            {
                
                //agregar nuevo carro a lista 
                if(rand.Next(1,101) <= 40)
                {
                    Carros carro = new Carros(0);
                    carro.RutaDestino = (Rutas)rand.Next(0, 3);
                    carrosFila1.Add(carro);
                }
                if (rand.Next(1, 101) <= 35)
                {
                    Carros carro = new Carros(0);
                    carro.RutaDestino = (Rutas)rand.Next(0, 3);
                    carrosFila2.Add(carro);
                }
                if (rand.Next(1, 101) <= 25)
                {
                    Carros carro = new Carros(0);
                    carro.RutaDestino = (Rutas)rand.Next(0, 3);
                    carrosFila3.Add(carro);
                }

                //Proceso de semaforo 1
                if (Semaforo1.Verde)
                {

                }


            }
            InitializeComponent();
           
        }


       
    }
}
