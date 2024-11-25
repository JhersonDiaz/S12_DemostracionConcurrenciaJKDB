using System;
using System.Windows.Forms;

namespace DemoConcu_Jherson_Kelvin_Diaz_Bravo
{
    partial class FrmBloqueos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnIncrementar = new System.Windows.Forms.Button();
            this.LblContador = new System.Windows.Forms.Label();
            this.btnDisminuir = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIncrementar
            // 
            this.btnIncrementar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnIncrementar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(35)))));
            this.btnIncrementar.FlatAppearance.BorderSize = 0;
            this.btnIncrementar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncrementar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncrementar.ForeColor = System.Drawing.Color.Yellow;
            this.btnIncrementar.Location = new System.Drawing.Point(12, 16);
            this.btnIncrementar.Name = "btnIncrementar";
            this.btnIncrementar.Size = new System.Drawing.Size(173, 50);
            this.btnIncrementar.TabIndex = 0;
            this.btnIncrementar.Text = "Incrementar";
            this.btnIncrementar.UseVisualStyleBackColor = false;
            this.btnIncrementar.Click += new System.EventHandler(this.btnIncrementar_Click);
            // 
            // LblContador
            // 
            this.LblContador.AutoSize = true;
            this.LblContador.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContador.ForeColor = System.Drawing.Color.Black;
            this.LblContador.Location = new System.Drawing.Point(91, 330);
            this.LblContador.Name = "LblContador";
            this.LblContador.Size = new System.Drawing.Size(14, 15);
            this.LblContador.TabIndex = 1;
            this.LblContador.Text = "0";
            // 
            // btnDisminuir
            // 
            this.btnDisminuir.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDisminuir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(35)))));
            this.btnDisminuir.FlatAppearance.BorderSize = 0;
            this.btnDisminuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisminuir.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisminuir.ForeColor = System.Drawing.Color.Yellow;
            this.btnDisminuir.Location = new System.Drawing.Point(12, 86);
            this.btnDisminuir.Name = "btnDisminuir";
            this.btnDisminuir.Size = new System.Drawing.Size(173, 50);
            this.btnDisminuir.TabIndex = 2;
            this.btnDisminuir.Text = "Disminuir";
            this.btnDisminuir.UseVisualStyleBackColor = false;
            this.btnDisminuir.Click += new System.EventHandler(this.btnDisminuir_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(99)))));
            this.splitContainer1.Panel1.Controls.Add(this.btnIncrementar);
            this.splitContainer1.Panel1.Controls.Add(this.LblContador);
            this.splitContainer1.Panel1.Controls.Add(this.btnDisminuir);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TxtResultado);
            this.splitContainer1.Size = new System.Drawing.Size(635, 403);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.TabIndex = 3;
            // 
            // TxtResultado
            // 
            this.TxtResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtResultado.Location = new System.Drawing.Point(0, 0);
            this.TxtResultado.Multiline = true;
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(420, 403);
            this.TxtResultado.TabIndex = 0;
            this.TxtResultado.TextChanged += new System.EventHandler(this.TxtResultado_TextChanged);
            // 
            // FrmBloqueos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(635, 403);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmBloqueos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Bloqueos";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void TxtResultado_TextChanged(object sender, EventArgs e)
        {
            
        }
        #endregion

        private System.Windows.Forms.Button btnIncrementar;
        private System.Windows.Forms.Label LblContador;
        private System.Windows.Forms.Button btnDisminuir;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox TxtResultado;
    }
}