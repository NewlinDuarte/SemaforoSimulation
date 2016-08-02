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
        int tiempoVerdeSem1;
        int tiempoVerdeSem2;
        int tiempoVerdeDoblarSem2;
        int tiempoVerdeSem3;
        int tiempoAmarilloSem1;
        int tiempoAmarilloSem2;
        int tiempoAmarilloSem3;
        int tiempoRojoSem1;
        int tiempoRojoSem2;
        int tiempoRojoSem3;

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
        int tiempo;

        //Guarda los carros en espera en cada semaforo (numerado respectivamente)
        List<Carros> carrosFila1 = new List<Carros>();
        List<Carros> carrosFila2 = new List<Carros>();
        List<Carros> carrosFila3 = new List<Carros>();

        public Form1()
        {
            
            InitializeComponent();
            


        }

        private void avanzarFila1()
        {
            if(carrosFila1[0].TiempoDeEspera > 0)
            {
                tiempoEspera += carrosFila1[0].TiempoDeEspera;
                esperaSemaforo1++;
            }
            
           
            switch ((int)carrosFila1[0].RutaDestino)
            {
                case 1:
                    carrosR1R2++;
                    break;

                case 2:
                    carrosR1R3++;
                    break;

                default:
                    break;
            }
            carrosFila1.RemoveAt(0);
        }

        private void avanzarFila2()
        {
            if (carrosFila2[0].TiempoDeEspera > 0)
            {
                tiempoEspera += carrosFila2[0].TiempoDeEspera;
                esperaSemaforo2++;
            }
            switch ((int)carrosFila2[0].RutaDestino)
            {
                case 0:
                    carrosR2R1++;
                    break;

                case 2:
                    carrosR2R3++;
                    break;

                default:
                    break;
            }
            carrosFila2.RemoveAt(0);            
        }

        private void avanzarFila3()
        {
            if (carrosFila3[0].TiempoDeEspera > 0)
            {
                tiempoEspera += carrosFila3[0].TiempoDeEspera;
                esperaSemaforo3++;
            }
            switch ((int)carrosFila3[0].RutaDestino)
            {
                case 0:
                    carrosR3R1++;
                    break;

                case 1:
                    carrosR3R2++;
                    break;

                default:
                    break;
            }
            carrosFila3.RemoveAt(0);
        }

        private void SimularButton_Click(object sender, EventArgs e)
        {
            //Inicializando valores por defecto
            Random rand = new Random();
            tiempo = 28800;
            tiempoEspera = 0;
            //Inicializando Semaforos (Semaforo 1 y 2 inician en verde)
            Semaforo Semaforo1 = new Semaforo(30, 27, 3, 2);
            Semaforo1.Rojo_Verde();

            Semaforo Semaforo2 = new Semaforo(20, 27, 3, 10, 2);
            Semaforo2.Rojo_Verde();

            Semaforo Semaforo3 = new Semaforo(40, 17, 3, 1);
            Semaforo3.Amarillo_Rojo();

            //inicializando valores de resultado;
            carrosR1R2 =0;
            carrosR1R3 =0;
            carrosR2R1 =0;
            carrosR2R3 =0;
            carrosR3R1 =0;
            carrosR3R2 =0;

            // Inicializando los Tiempos de semaforos
            tiempoVerdeSem1 = 0;
            tiempoVerdeSem2 = 0;
            tiempoVerdeDoblarSem2 = 0;
            tiempoVerdeSem3 = 0;
            tiempoAmarilloSem1 = 0;
            tiempoAmarilloSem2 = 0;
            tiempoAmarilloSem3 = 0;
            tiempoRojoSem1 = 0;
            tiempoRojoSem2 = 0;
            tiempoRojoSem3 = 0;

            for (int x = 1; x <= tiempo; x++)
            {

                //agregar nuevo carro a lista 
                if (rand.Next(1, 101) <= 40)
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

                //Rojo de Semaforo 3 tiene que verificar existencia de carros en R1
                if (Semaforo3.Rojo && carrosFila3.Count > 0 && carrosFila3[0].RutaDestino == (Rutas)1 && carrosFila1.Count == 0)
                {
                    avanzarFila3();
                }

                //Proceso de semaforo 1
                //Verder/ Amarillo
                if ((Semaforo1.Verde || Semaforo1.Amarillo) && carrosFila1.Count > 0)
                {
                    avanzarFila1();
                    if (carrosFila1.Count > 0)
                        avanzarFila1();
                }
                //Rojo
                if (Semaforo1.Rojo && carrosFila1.Count > 0 && carrosFila1[0].RutaDestino == (Rutas)2)
                {
                    avanzarFila1();
                    if (carrosFila1.Count > 0)
                        avanzarFila1();
                }

                //Proceso de semaforo 2
                //Verder/ Amarillo
                if ((Semaforo2.Verde || Semaforo2.Amarillo) && carrosFila2.Count > 0 && carrosFila2.Any(carro => carro.RutaDestino == 0))
                {
                    avanzarFila2();
                    if (carrosFila2.Count > 0)
                        avanzarFila2();
                }
                //Verde Doblar
                if (Semaforo2.VerdeDoblar && carrosFila2.Count > 0 && carrosFila2.Any(carro => carro.RutaDestino == (Rutas)2))
                {
                    avanzarFila2();
                    if (carrosFila1.Count > 0 && carrosFila2.Any(carro => carro.RutaDestino == (Rutas)3))
                        avanzarFila2();
                }



                //Proceso de semaforo 3
                //Verder/ Amarillo
                if ((Semaforo3.Verde || Semaforo3.Amarillo) && carrosFila3.Count > 0)
                {
                    avanzarFila3();
                }


                //Tiempos de Semaforos

                //Semaforo1
                if (Semaforo1.Verde)
                {
                    if (tiempoVerdeSem1 == Semaforo1.TiempoVerde)
                    {
                        tiempoVerdeSem1 = 0;
                        Semaforo1.Verde_Amarillo();
                    }
                    tiempoVerdeSem1++;
                }
                else
                {
                    if (Semaforo1.Amarillo)
                    {
                        if (tiempoAmarilloSem1 == Semaforo1.TiempoAmarillo)
                        {
                            tiempoAmarilloSem1 = 0;
                            Semaforo1.Amarillo_Rojo();
                        }
                        tiempoAmarilloSem1++;
                    }
                    else
                    {
                        if (tiempoRojoSem1 == Semaforo1.TiempoRojo)
                        {
                            tiempoRojoSem1 = 0;
                            Semaforo1.Rojo_Verde();
                        }
                        tiempoRojoSem1++;
                        foreach (Carros carro in carrosFila1)
                        {
                            carro.TiempoDeEspera++;
                        }
                    }
                }

                //Semaforo2
                if (Semaforo2.Verde)
                {
                    if (tiempoVerdeSem2 == Semaforo2.TiempoVerde)
                    {
                        tiempoVerdeSem2 = 0;
                        Semaforo2.Verde_Amarillo();
                    }
                    tiempoVerdeSem2++;
                }
                else
                {
                    if (Semaforo2.Amarillo)
                    {
                        if (tiempoAmarilloSem2 == Semaforo2.TiempoAmarillo)
                        {
                            tiempoAmarilloSem2 = 0;
                            Semaforo2.Amarillo_Rojo();
                            Semaforo2.ActivarVerdeDoblar();
                        }
                        tiempoAmarilloSem2++;
                    }
                    else
                    {
                        if (tiempoRojoSem2 == Semaforo2.TiempoRojo)
                        {
                            tiempoRojoSem2 = 0;
                            Semaforo2.Rojo_Verde();
                        }
                        if (tiempoVerdeDoblarSem2 == Semaforo2.TiempoVerdeDoblar)
                            Semaforo2.DesactivarVerdeDoblar();
                        tiempoRojoSem2++;
                        tiempoVerdeDoblarSem2++;
                        foreach (Carros carro in carrosFila2)
                        {
                            carro.TiempoDeEspera++;
                        }
                    }
                }

                //Semaforo3
                if (Semaforo3.Verde)
                {
                    if (tiempoVerdeSem3 == Semaforo3.TiempoVerde)
                    {
                        tiempoVerdeSem3 = 0;
                        Semaforo3.Verde_Amarillo();
                    }
                    tiempoVerdeSem3++;
                }
                else
                {
                    if (Semaforo3.Amarillo)
                    {
                        if (tiempoAmarilloSem3 == Semaforo3.TiempoAmarillo)
                        {
                            tiempoAmarilloSem3 = 0;
                            Semaforo3.Amarillo_Rojo();
                        }
                        tiempoAmarilloSem3++;
                    }
                    else
                    {
                        if (tiempoRojoSem3 == Semaforo3.TiempoRojo)
                        {
                            tiempoRojoSem3 = 0;
                            Semaforo3.Rojo_Verde();
                        }
                        tiempoRojoSem3++;
                        foreach (Carros carro in carrosFila3)
                        {
                            carro.TiempoDeEspera++;
                        }
                    }
                }
            }
            TiempoEsperaTb.Text = (tiempoEspera / 60).ToString();
            R1R2Tb.Text = carrosR1R2.ToString();
            R1R3Tb.Text = carrosR1R3.ToString();
            R2R1Tb.Text = carrosR2R1.ToString();
            R2R3Tb.Text = carrosR2R3.ToString();
            R3R1Tb.Text = carrosR3R1.ToString();
            R3R2Tb.Text = carrosR3R2.ToString();
        }
    }
}
