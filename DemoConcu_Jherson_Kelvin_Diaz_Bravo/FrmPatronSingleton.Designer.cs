namespace DemoConcu_Jherson_Kelvin_Diaz_Bravo
{
    partial class FrmPatronSingleton
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
            this.btnAsignar = new System.Windows.Forms.Button();
            this.btnRecuperar = new System.Windows.Forms.Button();
            this.LblCadena_Conexion = new System.Windows.Forms.Label();
            this.TxtCadenaConexion = new System.Windows.Forms.TextBox();
            this.LblCadena_ConexRecuperada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAsignar
            // 
            this.btnAsignar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(99)))));
            this.btnAsignar.FlatAppearance.BorderSize = 0;
            this.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.ForeColor = System.Drawing.Color.Black;
            this.btnAsignar.Location = new System.Drawing.Point(21, 72);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(139, 59);
            this.btnAsignar.TabIndex = 0;
            this.btnAsignar.Text = "Asignar Cadena de Conexión";
            this.btnAsignar.UseVisualStyleBackColor = false;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // btnRecuperar
            // 
            this.btnRecuperar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(180)))), ((int)(((byte)(99)))));
            this.btnRecuperar.FlatAppearance.BorderSize = 0;
            this.btnRecuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperar.ForeColor = System.Drawing.Color.Black;
            this.btnRecuperar.Location = new System.Drawing.Point(21, 154);
            this.btnRecuperar.Name = "btnRecuperar";
            this.btnRecuperar.Size = new System.Drawing.Size(139, 59);
            this.btnRecuperar.TabIndex = 1;
            this.btnRecuperar.Text = "Obtener Cadena de Conexión";
            this.btnRecuperar.UseVisualStyleBackColor = false;
            this.btnRecuperar.Click += new System.EventHandler(this.btnRecuperar_Click);
            // 
            // LblCadena_Conexion
            // 
            this.LblCadena_Conexion.AutoSize = true;
            this.LblCadena_Conexion.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCadena_Conexion.ForeColor = System.Drawing.Color.Yellow;
            this.LblCadena_Conexion.Location = new System.Drawing.Point(17, 9);
            this.LblCadena_Conexion.Name = "LblCadena_Conexion";
            this.LblCadena_Conexion.Size = new System.Drawing.Size(148, 19);
            this.LblCadena_Conexion.TabIndex = 2;
            this.LblCadena_Conexion.Text = "Cadena de Conexión";
            // 
            // TxtCadenaConexion
            // 
            this.TxtCadenaConexion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCadenaConexion.Location = new System.Drawing.Point(21, 34);
            this.TxtCadenaConexion.Name = "TxtCadenaConexion";
            this.TxtCadenaConexion.Size = new System.Drawing.Size(552, 26);
            this.TxtCadenaConexion.TabIndex = 3;
            // 
            // LblCadena_ConexRecuperada
            // 
            this.LblCadena_ConexRecuperada.AutoSize = true;
            this.LblCadena_ConexRecuperada.ForeColor = System.Drawing.Color.Yellow;
            this.LblCadena_ConexRecuperada.Location = new System.Drawing.Point(12, 266);
            this.LblCadena_ConexRecuperada.Name = "LblCadena_ConexRecuperada";
            this.LblCadena_ConexRecuperada.Size = new System.Drawing.Size(16, 13);
            this.LblCadena_ConexRecuperada.TabIndex = 4;
            this.LblCadena_ConexRecuperada.Text = "...";
            // 
            // FrmPatronSingleton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(22)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(594, 354);
            this.Controls.Add(this.LblCadena_ConexRecuperada);
            this.Controls.Add(this.TxtCadenaConexion);
            this.Controls.Add(this.LblCadena_Conexion);
            this.Controls.Add(this.btnRecuperar);
            this.Controls.Add(this.btnAsignar);
            this.Name = "FrmPatronSingleton";
            this.Text = "Demostracion del Patron Singleton";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.Button btnRecuperar;
        private System.Windows.Forms.Label LblCadena_Conexion;
        private System.Windows.Forms.TextBox TxtCadenaConexion;
        private System.Windows.Forms.Label LblCadena_ConexRecuperada;
    }
}