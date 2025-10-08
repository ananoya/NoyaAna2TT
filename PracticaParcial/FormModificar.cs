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
    public partial class FormModificar : Form
    {
        private int idSocio;
        public FormModificar(Socios socios)
        {
            InitializeComponent();
            idSocio = socios.Id; //almaceno el id en una variable global para usarla despues
            txtNombre.Text= socios.Nombre;
           txtApellido.Text= socios.Apellido;
           txtDNI.Text =socios.Dni ;
            txtNroDeSocio.Text = socios.NumeroSocio.ToString();
            dateTime.Value = socios.FechaNacimiento;
            comboBox1.SelectedItem = socios.CuotaSAlDia ? "Si" : "No";


        }

        private void btnGuardarModificar_Click(object sender, EventArgs e)
        {   
            //asignar valores segun txt
             
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDNI.Text;
            int numeroSocio = int.Parse(txtNroDeSocio.Text);
            DateTime fechaNacimiento = dateTime.Value;
            bool cuotaAlDia = comboBox1.SelectedItem.ToString() == "Si" ? true : false;

            //ARMO EL NUEVO OBJETO asigno a cada uno respetando la query
            Socios socioModificado = new Socios
            {
                Nombre = nombre,
                Apellido = apellido,
                Dni = dni,
                NumeroSocio = numeroSocio,
                FechaNacimiento = fechaNacimiento,
                CuotaSAlDia = cuotaAlDia,
                Id = idSocio
            };
        

            //insatcio el repo para usar modificar
             
            RepositorioSocios repositorio = new RepositorioSocios();
            repositorio.Modificar(socioModificado);
            this.Close();
        }
    }
}
