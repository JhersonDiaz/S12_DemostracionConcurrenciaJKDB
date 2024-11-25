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
    public partial class FrmBloqueos : Form
    {
        private int Contador = 0;//Declarar variable Contador privado
        private object Bloqueo = new object();//Objeto que permite bloquear la parte que deseo
        private SemaphoreSlim semaforo = new SemaphoreSlim(2);
        public FrmBloqueos()
        {
            InitializeComponent();
        }

        private void btnIncrementar_Click(object sender, EventArgs e)
        {//Task.Run se esta ejecutando la tarea
            Task.Run(() =>
            {
                semaforo.Wait();

                lock(Bloqueo)
                {
                    Contador++;
                    Thread.Sleep(100);
                    this.Invoke((MethodInvoker)delegate
                    {
                        LblContador.Text = Contador.ToString();
                    });
                    Monitor.Pulse(Bloqueo);//Notifica que se está realizando un bloqueó
                }
                //semaforo.Release();
            });     
            
        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                lock (Bloqueo)//comando lock es para bloquear
                {

                    while (Contador <= 0)
                    {
                        ActualizarResultado("Esperando...");
                        Monitor.Wait(Bloqueo);//Wait: espera el proceso a capturar
                    }
                    if (Contador > 0)
                    {
                        Contador--;
                        Thread.Sleep(100);
                        this.Invoke((MethodInvoker)delegate
                        {
                            LblContador.Text = Contador.ToString();
                        });
                    }

                }
            });
        }
        private void ActualizarResultado(String mensaje)
        //Environment.NewLine: Salto de linea
        //AppendText: Sirve para añadir texto
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => ActualizarResultado(mensaje)));
                return;
            }
            TxtResultado.AppendText($"{DateTime.Now:HH:mm:ss}:{mensaje}{Environment.NewLine}");
        }

    }
}
