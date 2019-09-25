using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Winform1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void ActualizarTabla()
        {


            dataGridView1.Rows.Clear();


            foreach (CapNegocios.Productos p in DB.Productos)
            {

                dataGridView1.Rows.Add(p.Codigo,p.Nombre, p.detalle, p.Costo,p.Precio, p.FechaCreacion,p.FechaCreacion,p.Categoria,p.Estado);
            }
        }

        CapNegocios.BaseDatos DB = new CapNegocios.BaseDatos();


        private void CrearBoton_Click(object sender, EventArgs e)
        {

            CapNegocios.Productos x = new CapNegocios.Productos();

            x.Codigo = CodigoBox.Text;
            x.Nombre = NombreBox.Text;
            x.detalle = DetalleBox.Text;
            x.Costo = CostoBox.Text;
            x.Precio = PrecioBox.Text;
            x.FechaCreacion = FechaCreacionBox.Value;
            x.FechaVencimiento = FechaVencimientoBox.Value;
            x.Categoria = CategoriaBox.Text;
            x.Estado = EstadoBox.Text;

            DB.Productos.Add(x);

            MessageBox.Show("Producto Creado con Exito");
            ActualizarTabla();
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {

            DB.Productos.Remove(DB.Productos[dataGridView1.CurrentRow.Index]);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void EliminarBoton_Click_1(object sender, EventArgs e)
        {
            DB.Productos.Remove(DB.Productos[dataGridView1.CurrentRow.Index]);
        }
    }
}

