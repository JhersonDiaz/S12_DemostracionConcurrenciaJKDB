using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoConcu_Jherson_Kelvin_Diaz_Bravo
{
    public partial class FrmRestaurante : Form
    {
        private int MesasDisponibles = 0; // Total de mesas en el restaurante
        private object Bloqueo = new object(); // Objeto para bloquear recursos compartidos
        private SemaphoreSlim semaforo = new SemaphoreSlim(2); // Límite de operaciones concurrentes
        public FrmRestaurante()
        {
            InitializeComponent();
        }

        private void btnOcuparMesa_Click(object sender, EventArgs e)
        {
                Task.Run(() =>
                {
                    semaforo.Wait();
                    lock (Bloqueo)
                    {
                        if (MesasDisponibles >= 1)
                        {
                            MesasDisponibles--;
                            ActualizarR($"Mesa ocupada. Mesa disponible: {MesasDisponibles}");
                        }
                        else
                        {
                            ActualizarR("No hay mesas disponibles. Esperando...");
                        }

                        MesasDisponibles++;
                        Thread.Sleep(100);
                        this.Invoke((MethodInvoker)delegate
                        {
                            LblMesasDisponibles.Text = MesasDisponibles.ToString();
                            
                        });
                        Monitor.Pulse(Bloqueo);//Notifica que se está realizando un bloqueó
                    }
                    semaforo.Release();
                });

        }


        private void btnLiberarMesa_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                lock (Bloqueo)//comando lock es para bloquear
                {
                    {
                        MesasDisponibles++;
                        ActualizarR($"Mesa liberada. Mesa disponible: {MesasDisponibles}");
                        Monitor.Pulse(Bloqueo); // Notificar que una mesa fue liberada
                    }
                    if (MesasDisponibles > 0)
                    {
                        MesasDisponibles--;
                        Thread.Sleep(100);
                        this.Invoke((MethodInvoker)delegate
                        {
                            LblMesasDisponibles.Text = MesasDisponibles.ToString();
                        });
                    }
                   
                }
            });
        }

        private void ActualizarR(string mensaje)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => ActualizarR(mensaje)));
            }
            else
            {
                TxtResultadoR.AppendText($"{DateTime.Now:HH:mm:ss} - {mensaje}{Environment.NewLine}");
                LblMesasDisponibles.Text = MesasDisponibles.ToString();
            }
        }

    }
}
