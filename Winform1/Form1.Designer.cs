namespace Winform1
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EliminarBoton = new System.Windows.Forms.Button();
            this.CrearBoton = new System.Windows.Forms.Button();
            this.PaisBox = new System.Windows.Forms.TextBox();
            this.ProvinciaBox = new System.Windows.Forms.TextBox();
            this.DireccionBox = new System.Windows.Forms.TextBox();
            this.CelularBox = new System.Windows.Forms.TextBox();
            this.TelefonoBox = new System.Windows.Forms.TextBox();
            this.EdadBox = new System.Windows.Forms.NumericUpDown();
            this.FechaNacimientoBox = new System.Windows.Forms.DateTimePicker();
            this.ApellidoBox = new System.Windows.Forms.TextBox();
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdadBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-2, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1579, 777);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EliminarBoton);
            this.tabPage1.Controls.Add(this.CrearBoton);
            this.tabPage1.Controls.Add(this.PaisBox);
            this.tabPage1.Controls.Add(this.ProvinciaBox);
            this.tabPage1.Controls.Add(this.DireccionBox);
            this.tabPage1.Controls.Add(this.CelularBox);
            this.tabPage1.Controls.Add(this.TelefonoBox);
            this.tabPage1.Controls.Add(this.EdadBox);
            this.tabPage1.Controls.Add(this.FechaNacimientoBox);
            this.tabPage1.Controls.Add(this.ApellidoBox);
            this.tabPage1.Controls.Add(this.NombreBox);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(10, 48);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1559, 719);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contacto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // EliminarBoton
            // 
            this.EliminarBoton.Location = new System.Drawing.Point(1206, 466);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(302, 86);
            this.EliminarBoton.TabIndex = 31;
            this.EliminarBoton.Text = "Eliminar";
            this.EliminarBoton.UseVisualStyleBackColor = true;
            // 
            // CrearBoton
            // 
            this.CrearBoton.Location = new System.Drawing.Point(855, 466);
            this.CrearBoton.Name = "CrearBoton";
            this.CrearBoton.Size = new System.Drawing.Size(302, 86);
            this.CrearBoton.TabIndex = 30;
            this.CrearBoton.Text = "Crear";
            this.CrearBoton.UseVisualStyleBackColor = true;
            // 
            // PaisBox
            // 
            this.PaisBox.Location = new System.Drawing.Point(1064, 286);
            this.PaisBox.Name = "PaisBox";
            this.PaisBox.Size = new System.Drawing.Size(429, 38);
            this.PaisBox.TabIndex = 28;
            // 
            // ProvinciaBox
            // 
            this.ProvinciaBox.Location = new System.Drawing.Point(1064, 204);
            this.ProvinciaBox.Name = "ProvinciaBox";
            this.ProvinciaBox.Size = new System.Drawing.Size(429, 38);
            this.ProvinciaBox.TabIndex = 27;
            // 
            // DireccionBox
            // 
            this.DireccionBox.Location = new System.Drawing.Point(1064, 113);
            this.DireccionBox.Name = "DireccionBox";
            this.DireccionBox.Size = new System.Drawing.Size(429, 38);
            this.DireccionBox.TabIndex = 26;
            // 
            // CelularBox
            // 
            this.CelularBox.Location = new System.Drawing.Point(382, 647);
            this.CelularBox.Name = "CelularBox";
            this.CelularBox.Size = new System.Drawing.Size(382, 38);
            this.CelularBox.TabIndex = 25;
            // 
            // TelefonoBox
            // 
            this.TelefonoBox.Location = new System.Drawing.Point(382, 551);
            this.TelefonoBox.Name = "TelefonoBox";
            this.TelefonoBox.Size = new System.Drawing.Size(382, 38);
            this.TelefonoBox.TabIndex = 24;
            // 
            // EdadBox
            // 
            this.EdadBox.Location = new System.Drawing.Point(382, 440);
            this.EdadBox.Name = "EdadBox";
            this.EdadBox.Size = new System.Drawing.Size(382, 38);
            this.EdadBox.TabIndex = 23;
            // 
            // FechaNacimientoBox
            // 
            this.FechaNacimientoBox.Location = new System.Drawing.Point(382, 329);
            this.FechaNacimientoBox.Name = "FechaNacimientoBox";
            this.FechaNacimientoBox.Size = new System.Drawing.Size(382, 38);
            this.FechaNacimientoBox.TabIndex = 22;
            // 
            // ApellidoBox
            // 
            this.ApellidoBox.Location = new System.Drawing.Point(382, 224);
            this.ApellidoBox.Name = "ApellidoBox";
            this.ApellidoBox.Size = new System.Drawing.Size(382, 38);
            this.ApellidoBox.TabIndex = 21;
            // 
            // NombreBox
            // 
            this.NombreBox.Location = new System.Drawing.Point(382, 113);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(382, 38);
            this.NombreBox.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(853, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 32);
            this.label10.TabIndex = 19;
            this.label10.Text = "Pais ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(853, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(133, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "Provincia";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(852, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 654);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 551);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Edad\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 32);
            this.label3.TabIndex = 12;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos de Contacto";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(10, 48);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1559, 719);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tabla";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1500, 583);
            this.dataGridView1.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(490, 46);
            this.label11.TabIndex = 2;
            this.label11.Text = "Informacion del Contacto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1577, 777);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EdadBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.Button CrearBoton;
        private System.Windows.Forms.TextBox PaisBox;
        private System.Windows.Forms.TextBox ProvinciaBox;
        private System.Windows.Forms.TextBox DireccionBox;
        private System.Windows.Forms.TextBox CelularBox;
        private System.Windows.Forms.TextBox TelefonoBox;
        private System.Windows.Forms.NumericUpDown EdadBox;
        private System.Windows.Forms.DateTimePicker FechaNacimientoBox;
        private System.Windows.Forms.TextBox ApellidoBox;
        private System.Windows.Forms.TextBox NombreBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

