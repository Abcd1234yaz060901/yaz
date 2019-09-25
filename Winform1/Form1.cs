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
            
           
            foreach (CapNegocios.Persona p in DB.personas)
            {
              
                dataGridView1.Rows.Add(p.Nombre, p.Apellido,p.FechaNacimiento, p.edad, p.Telefono, p.Celular, p.Direccion, p.Provincia, p.Pais);
            }
        }

        CapNegocios.BaseDatos DB = new CapNegocios.BaseDatos();       


        private void CrearBoton_Click(object sender, EventArgs e)
        {

            CapNegocios.Persona x = new CapNegocios.Persona();

            x.Nombre = NombreBox.Text;
            x.Apellido = ApellidoBox.Text;
            x.Celular = CelularBox.Text;
            x.Direccion = DireccionBox.Text;
            x.edad = Convert.ToInt32(EdadBox.Value);
            x.FechaNacimiento = FechaNacimientoBox.Value;
            x.Pais = PaisBox.Text;
            x.Telefono = TelefonoBox.Text ;
            x.Provincia = ProvinciaBox.Text;
            

            DB.personas.Add(x);

            MessageBox.Show("Persona Creada con Exito");
            ActualizarTabla();
        }

        private void EliminarBoton_Click(object sender, EventArgs e)
        {

            DB.personas.Remove(DB.personas[dataGridView1.CurrentRow.Index]);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ActualizarTabla();
        }
    }
}
