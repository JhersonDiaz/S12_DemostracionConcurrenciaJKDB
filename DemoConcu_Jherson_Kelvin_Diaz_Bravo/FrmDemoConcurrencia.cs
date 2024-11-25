using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoConcu_Jherson_Kelvin_Diaz_Bravo
{
    public partial class FrmDemoConcurrencia : Form
    {
        private CancellationTokenSource _cts;
        public FrmDemoConcurrencia()
        {
            InitializeComponent();
        }

        private void btnSecuencial_Click(object sender, EventArgs e)
        {
            ActualizarResultado("Iniciando proceso secuencial...");
            for (int i = 0; i < 5; i++)
            {//Sleep: Detiene el procesamiento o dormir
                Thread.Sleep(2000); //Carga la segunda linea después de cada 2 segundos
                ActualizarResultado($"Actividad - paso {i + 1}");
            }

            ActualizarResultado("Fin del proceso secuencial.");
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
            txtResultado.AppendText($"{DateTime.Now:HH:mm:ss}:{mensaje}{Environment.NewLine}");
        }

        //thread: Es hilo
        //Thread: Permite crear hilos
        private void btnIniciarHilos_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            Thread hilo1 = new Thread(() =>
            {
                try
                {
                    ActualizarResultado($"Iniciar nuevo Thread {Thread.CurrentThread.ManagedThreadId}...");
                    for (int i = 0; i < 5; i++)
                    {
                        token.ThrowIfCancellationRequested();
                        Thread.Sleep(2000);
                        ActualizarResultado($"Actividad en hilo  {Thread.CurrentThread.ManagedThreadId}- paso {i + 1}");
                    }
                    ActualizarResultado($"Thread {Thread.CurrentThread.ManagedThreadId} terminado.");
                }
                catch (OperationCanceledException)
                {

                    ActualizarResultado("Hilo Cancelado");
                }
        });
        hilo1.Start();
        }

        //await espera hasta que la tarea se ejecute
        //Task: Permite ejecutar una tarea.
        //Run: Definir la tarea que deseamos que se ejecute.
        private async void btnIniciarTarea_Click(object sender, EventArgs e)
        {
            _cts = new CancellationTokenSource();
            var token = _cts.Token;

            await Task.Run(() =>
            {
                try
                {
                    ActualizarResultado($"Iniciando Task {Task.CurrentId}...");
                    for (int i = 0; i < 5; i++)
                    {
                        token.ThrowIfCancellationRequested();

                        Thread.Sleep(2000);
                        ActualizarResultado($"Actividad en tarea {Task.CurrentId} - paso {i + 1}");
                    }
                }
                catch (OperationCanceledException)
                {

                    ActualizarResultado("Tarea Cancelada");
                }
                
            });
            ActualizarResultado($"Task {Task.CurrentId} terminada");
        }

        private void btnCancelarHilos_Click(object sender, EventArgs e)
        {
            _cts.Cancel();
        }

    }
}

