using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaParcial
{
    public partial class FrmNuevo : Form
    {
        public FrmNuevo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
         
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Socios nuevoSocio = new Socios();

            //asigno valores segun txt 
            nuevoSocio.Nombre = txtNombre.Text;
            nuevoSocio.Apellido= txtApellido.Text;
            nuevoSocio.Dni = txtDNI.Text;
            nuevoSocio.NumeroSocio = int.Parse(txtNroDeSocio.Text);
            nuevoSocio.FechaNacimiento = dateTime.Value;
            nuevoSocio.CuotaSAlDia = comboBox1.SelectedItem.ToString() == "Si" ? true : false;
            
            RepositorioSocios repositorio = new RepositorioSocios();
            repositorio.Agregar(nuevoSocio);
            this.Close();
        }
    }
}
