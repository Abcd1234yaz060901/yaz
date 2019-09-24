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
            this.NombreBox = new System.Windows.Forms.TextBox();
            this.CodigoBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Nombrelabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CategoriaBox = new System.Windows.Forms.ComboBox();
            this.EstadoBox = new System.Windows.Forms.ComboBox();
            this.DetalleBox = new System.Windows.Forms.TextBox();
            this.CostoBox = new System.Windows.Forms.TextBox();
            this.PrecioBox = new System.Windows.Forms.TextBox();
            this.FechaCreacionBox = new System.Windows.Forms.DateTimePicker();
            this.FechaVencimientoBox = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            this.tabPage1.Controls.Add(this.FechaVencimientoBox);
            this.tabPage1.Controls.Add(this.FechaCreacionBox);
            this.tabPage1.Controls.Add(this.PrecioBox);
            this.tabPage1.Controls.Add(this.CostoBox);
            this.tabPage1.Controls.Add(this.DetalleBox);
            this.tabPage1.Controls.Add(this.EstadoBox);
            this.tabPage1.Controls.Add(this.CategoriaBox);
            this.tabPage1.Controls.Add(this.EliminarBoton);
            this.tabPage1.Controls.Add(this.CrearBoton);
            this.tabPage1.Controls.Add(this.NombreBox);
            this.tabPage1.Controls.Add(this.CodigoBox);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.Nombrelabel);
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
            this.EliminarBoton.Location = new System.Drawing.Point(1210, 538);
            this.EliminarBoton.Name = "EliminarBoton";
            this.EliminarBoton.Size = new System.Drawing.Size(302, 86);
            this.EliminarBoton.TabIndex = 31;
            this.EliminarBoton.Text = "Eliminar";
            this.EliminarBoton.UseVisualStyleBackColor = true;
            // 
            // CrearBoton
            // 
            this.CrearBoton.Location = new System.Drawing.Point(858, 538);
            this.CrearBoton.Name = "CrearBoton";
            this.CrearBoton.Size = new System.Drawing.Size(302, 86);
            this.CrearBoton.TabIndex = 30;
            this.CrearBoton.Text = "Crear";
            this.CrearBoton.UseVisualStyleBackColor = true;
            // 
            // NombreBox
            // 
            this.NombreBox.Location = new System.Drawing.Point(382, 224);
            this.NombreBox.Name = "NombreBox";
            this.NombreBox.Size = new System.Drawing.Size(382, 38);
            this.NombreBox.TabIndex = 21;
            // 
            // CodigoBox
            // 
            this.CodigoBox.Location = new System.Drawing.Point(382, 113);
            this.CodigoBox.Name = "CodigoBox";
            this.CodigoBox.Size = new System.Drawing.Size(382, 38);
            this.CodigoBox.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(853, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 32);
            this.label10.TabIndex = 19;
            this.label10.Text = "Categoria";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(853, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(259, 32);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fecha Vencimiento";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(852, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 32);
            this.label8.TabIndex = 17;
            this.label8.Text = "Fecha Creacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(853, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 32);
            this.label7.TabIndex = 16;
            this.label7.Text = "Estado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 551);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 32);
            this.label5.TabIndex = 14;
            this.label5.Text = "Detalle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 32);
            this.label4.TabIndex = 13;
            this.label4.Text = "Costo";
            // 
            // Nombrelabel
            // 
            this.Nombrelabel.AutoSize = true;
            this.Nombrelabel.Location = new System.Drawing.Point(30, 224);
            this.Nombrelabel.Name = "Nombrelabel";
            this.Nombrelabel.Size = new System.Drawing.Size(115, 32);
            this.Nombrelabel.TabIndex = 12;
            this.Nombrelabel.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 11;
            this.label2.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos del Producto";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(20, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(203, 46);
            this.label11.TabIndex = 2;
            this.label11.Text = "Inventario";
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
            // CategoriaBox
            // 
            this.CategoriaBox.FormattingEnabled = true;
            this.CategoriaBox.Items.AddRange(new object[] {
            "Laptops",
            "Celular"});
            this.CategoriaBox.Location = new System.Drawing.Point(1189, 286);
            this.CategoriaBox.Name = "CategoriaBox";
            this.CategoriaBox.Size = new System.Drawing.Size(323, 39);
            this.CategoriaBox.TabIndex = 32;
            // 
            // EstadoBox
            // 
            this.EstadoBox.FormattingEnabled = true;
            this.EstadoBox.Items.AddRange(new object[] {
            "Nuevo",
            "Usado"});
            this.EstadoBox.Location = new System.Drawing.Point(1189, 378);
            this.EstadoBox.Name = "EstadoBox";
            this.EstadoBox.Size = new System.Drawing.Size(323, 39);
            this.EstadoBox.TabIndex = 33;
            // 
            // DetalleBox
            // 
            this.DetalleBox.Location = new System.Drawing.Point(382, 329);
            this.DetalleBox.Name = "DetalleBox";
            this.DetalleBox.Size = new System.Drawing.Size(382, 38);
            this.DetalleBox.TabIndex = 34;
            // 
            // CostoBox
            // 
            this.CostoBox.Location = new System.Drawing.Point(382, 440);
            this.CostoBox.Name = "CostoBox";
            this.CostoBox.Size = new System.Drawing.Size(382, 38);
            this.CostoBox.TabIndex = 35;
            // 
            // PrecioBox
            // 
            this.PrecioBox.Location = new System.Drawing.Point(382, 551);
            this.PrecioBox.Name = "PrecioBox";
            this.PrecioBox.Size = new System.Drawing.Size(382, 38);
            this.PrecioBox.TabIndex = 36;
            // 
            // FechaCreacionBox
            // 
            this.FechaCreacionBox.Location = new System.Drawing.Point(1189, 113);
            this.FechaCreacionBox.Name = "FechaCreacionBox";
            this.FechaCreacionBox.Size = new System.Drawing.Size(323, 38);
            this.FechaCreacionBox.TabIndex = 37;
            // 
            // FechaVencimientoBox
            // 
            this.FechaVencimientoBox.Location = new System.Drawing.Point(1189, 204);
            this.FechaVencimientoBox.Name = "FechaVencimientoBox";
            this.FechaVencimientoBox.Size = new System.Drawing.Size(323, 38);
            this.FechaVencimientoBox.TabIndex = 38;
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
        private System.Windows.Forms.Label Nombrelabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button EliminarBoton;
        private System.Windows.Forms.Button CrearBoton;
        private System.Windows.Forms.TextBox NombreBox;
        private System.Windows.Forms.TextBox CodigoBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker FechaVencimientoBox;
        private System.Windows.Forms.DateTimePicker FechaCreacionBox;
        private System.Windows.Forms.TextBox PrecioBox;
        private System.Windows.Forms.TextBox CostoBox;
        private System.Windows.Forms.TextBox DetalleBox;
        private System.Windows.Forms.ComboBox EstadoBox;
        private System.Windows.Forms.ComboBox CategoriaBox;
    }
}

