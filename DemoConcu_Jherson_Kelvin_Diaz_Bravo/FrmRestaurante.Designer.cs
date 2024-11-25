namespace DemoConcu_Jherson_Kelvin_Diaz_Bravo
{
    partial class FrmRestaurante
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnOcuparMesa = new System.Windows.Forms.Button();
            this.btnLiberarMesa = new System.Windows.Forms.Button();
            this.LblMesasDisponibles = new System.Windows.Forms.Label();
            this.TxtResultadoR = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.LblMesasDisponibles);
            this.splitContainer1.Panel1.Controls.Add(this.btnOcuparMesa);
            this.splitContainer1.Panel1.Controls.Add(this.btnLiberarMesa);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.TxtResultadoR);
            this.splitContainer1.Size = new System.Drawing.Size(654, 372);
            this.splitContainer1.SplitterDistance = 218;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnOcuparMesa
            // 
            this.btnOcuparMesa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnOcuparMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(35)))));
            this.btnOcuparMesa.FlatAppearance.BorderSize = 0;
            this.btnOcuparMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOcuparMesa.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOcuparMesa.ForeColor = System.Drawing.Color.Yellow;
            this.btnOcuparMesa.Location = new System.Drawing.Point(24, 29);
            this.btnOcuparMesa.Name = "btnOcuparMesa";
            this.btnOcuparMesa.Size = new System.Drawing.Size(173, 50);
            this.btnOcuparMesa.TabIndex = 3;
            this.btnOcuparMesa.Text = "Mesas";
            this.btnOcuparMesa.UseVisualStyleBackColor = false;
            this.btnOcuparMesa.Click += new System.EventHandler(this.btnOcuparMesa_Click);
            // 
            // btnLiberarMesa
            // 
            this.btnLiberarMesa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLiberarMesa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(35)))));
            this.btnLiberarMesa.FlatAppearance.BorderSize = 0;
            this.btnLiberarMesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLiberarMesa.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLiberarMesa.ForeColor = System.Drawing.Color.Yellow;
            this.btnLiberarMesa.Location = new System.Drawing.Point(24, 99);
            this.btnLiberarMesa.Name = "btnLiberarMesa";
            this.btnLiberarMesa.Size = new System.Drawing.Size(173, 50);
            this.btnLiberarMesa.TabIndex = 4;
            this.btnLiberarMesa.Text = "Liberar Mesa";
            this.btnLiberarMesa.UseVisualStyleBackColor = false;
            this.btnLiberarMesa.Click += new System.EventHandler(this.btnLiberarMesa_Click);
            // 
            // LblMesasDisponibles
            // 
            this.LblMesasDisponibles.AutoSize = true;
            this.LblMesasDisponibles.Location = new System.Drawing.Point(86, 328);
            this.LblMesasDisponibles.Name = "LblMesasDisponibles";
            this.LblMesasDisponibles.Size = new System.Drawing.Size(13, 13);
            this.LblMesasDisponibles.TabIndex = 5;
            this.LblMesasDisponibles.Text = "0";
            // 
            // TxtResultadoR
            // 
            this.TxtResultadoR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TxtResultadoR.Location = new System.Drawing.Point(0, 0);
            this.TxtResultadoR.Multiline = true;
            this.TxtResultadoR.Name = "TxtResultadoR";
            this.TxtResultadoR.Size = new System.Drawing.Size(432, 372);
            this.TxtResultadoR.TabIndex = 0;
            // 
            // FrmRestaurante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 372);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FrmRestaurante";
            this.Text = "FrmRestaurante";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label LblMesasDisponibles;
        private System.Windows.Forms.Button btnOcuparMesa;
        private System.Windows.Forms.Button btnLiberarMesa;
        private System.Windows.Forms.TextBox TxtResultadoR;
    }
}