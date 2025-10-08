using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CrudADO
{
    public partial class FrmModificar : Form
    {
        public FrmModificar(Persona persona) //constructor con parametro persona para editar
        {
            InitializeComponent();
            txtId.Text = persona.Id.ToString();
            txtNombre.Text = persona.Nombre;
            txtEdad.Text = persona.Edad.ToString();
        }
        private void FrmModificar_Load_1(object sender, EventArgs e)
        {
            txtId.Enabled = false;

        }

        private void btnGuardarModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txtNombre.Text;
                int edad = int.Parse(txtEdad.Text);
                int id = int.Parse(txtId.Text);

                Persona persona = new Persona //respetar la query
                {
                    
                    Nombre = nombre,
                    Edad = edad,
                    Id = id
                };

                PersonaDB repositorio = new PersonaDB();
                repositorio.Modificar(persona);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }

        }


    }
}
