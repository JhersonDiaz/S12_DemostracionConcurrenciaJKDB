using System;

namespace DemoConcu_Jherson_Kelvin_Diaz_Bravo
{
    partial class FrmDemoConcurrencia
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelarHilos = new System.Windows.Forms.Button();
            this.btnIniciarTarea = new System.Windows.Forms.Button();
            this.btnIniciarHilos = new System.Windows.Forms.Button();
            this.btnSecuencial = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnCancelarHilos);
            this.panel1.Controls.Add(this.btnIniciarTarea);
            this.panel1.Controls.Add(this.btnIniciarHilos);
            this.panel1.Controls.Add(this.btnSecuencial);
            this.panel1.Location = new System.Drawing.Point(1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 446);
            this.panel1.TabIndex = 0;
            // 
            // btnCancelarHilos
            // 
            this.btnCancelarHilos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelarHilos.BackColor = System.Drawing.Color.Black;
            this.btnCancelarHilos.FlatAppearance.BorderSize = 0;
            this.btnCancelarHilos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarHilos.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarHilos.ForeColor = System.Drawing.Color.Cyan;
            this.btnCancelarHilos.Location = new System.Drawing.Point(2, 197);
            this.btnCancelarHilos.Name = "btnCancelarHilos";
            this.btnCancelarHilos.Size = new System.Drawing.Size(160, 53);
            this.btnCancelarHilos.TabIndex = 3;
            this.btnCancelarHilos.Text = "Cancelar Hilo";
            this.btnCancelarHilos.UseVisualStyleBackColor = false;
            this.btnCancelarHilos.Click += new System.EventHandler(this.btnCancelarHilos_Click);
            // 
            // btnIniciarTarea
            // 
            this.btnIniciarTarea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciarTarea.BackColor = System.Drawing.Color.Black;
            this.btnIniciarTarea.FlatAppearance.BorderSize = 0;
            this.btnIniciarTarea.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarTarea.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarTarea.ForeColor = System.Drawing.Color.Cyan;
            this.btnIniciarTarea.Location = new System.Drawing.Point(2, 129);
            this.btnIniciarTarea.Name = "btnIniciarTarea";
            this.btnIniciarTarea.Size = new System.Drawing.Size(160, 53);
            this.btnIniciarTarea.TabIndex = 2;
            this.btnIniciarTarea.Text = "Iniciar Tarea";
            this.btnIniciarTarea.UseVisualStyleBackColor = false;
            this.btnIniciarTarea.Click += new System.EventHandler(this.btnIniciarTarea_Click);
            // 
            // btnIniciarHilos
            // 
            this.btnIniciarHilos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIniciarHilos.BackColor = System.Drawing.Color.Black;
            this.btnIniciarHilos.FlatAppearance.BorderSize = 0;
            this.btnIniciarHilos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarHilos.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarHilos.ForeColor = System.Drawing.Color.Cyan;
            this.btnIniciarHilos.Location = new System.Drawing.Point(3, 72);
            this.btnIniciarHilos.Name = "btnIniciarHilos";
            this.btnIniciarHilos.Size = new System.Drawing.Size(159, 51);
            this.btnIniciarHilos.TabIndex = 1;
            this.btnIniciarHilos.Text = "Iniciar Hilos";
            this.btnIniciarHilos.UseVisualStyleBackColor = false;
            this.btnIniciarHilos.Click += new System.EventHandler(this.btnIniciarHilos_Click);
            // 
            // btnSecuencial
            // 
            this.btnSecuencial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSecuencial.BackColor = System.Drawing.Color.Black;
            this.btnSecuencial.FlatAppearance.BorderSize = 0;
            this.btnSecuencial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSecuencial.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSecuencial.ForeColor = System.Drawing.Color.Cyan;
            this.btnSecuencial.Location = new System.Drawing.Point(3, 15);
            this.btnSecuencial.Name = "btnSecuencial";
            this.btnSecuencial.Size = new System.Drawing.Size(159, 51);
            this.btnSecuencial.TabIndex = 0;
            this.btnSecuencial.Text = "Inicial Secuencial";
            this.btnSecuencial.UseVisualStyleBackColor = false;
            this.btnSecuencial.Click += new System.EventHandler(this.btnSecuencial_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.txtResultado);
            this.panel2.Location = new System.Drawing.Point(177, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(629, 439);
            this.panel2.TabIndex = 1;
            // 
            // txtResultado
            // 
            this.txtResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResultado.Location = new System.Drawing.Point(0, 0);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(629, 439);
            this.txtResultado.TabIndex = 0;
            // 
            // FrmDemoConcurrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 442);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmDemoConcurrencia";
            this.Text = "Demostracion de Concurrencia";
            this.Load += new System.EventHandler(this.FrmDemoConcurrencia_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        private void FrmDemoConcurrencia_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIniciarTarea;
        private System.Windows.Forms.Button btnIniciarHilos;
        private System.Windows.Forms.Button btnSecuencial;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnCancelarHilos;
    }
}

