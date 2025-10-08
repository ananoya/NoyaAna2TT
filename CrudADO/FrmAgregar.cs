using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudADO
{
    public partial class FrmAgregar : Form
    {


        public FrmAgregar() //constructor vacio
        {


            InitializeComponent();
        }

         public FrmAgregar(Persona persona) //constructor con parametro persona para editar
         {
             InitializeComponent();
             txtNombre.Text = persona.Nombre;
             txtEdad.Text = persona.Edad.ToString();
         }

        private void btnGuardarAgregar_Click(object sender, EventArgs e)
        {


            try
            {
      
                    // 1. Capturar datos del formulario
                    string nombre = txtNombre.Text;
                    int edad = int.Parse(txtEdad.Text);

                    // 2. Crear objeto Persona
                    Persona persona = new Persona
                    {
                        Nombre = nombre,
                        Edad = edad
                    };

                    // 3. Instanciar repositorio y guardar
                    PersonaDB repositorioPersona = new PersonaDB();
                    repositorioPersona.Agregar(persona);


                    // 4. Indicar que la operación fue exitosa y cierra el forms
                    this.Close();
                
             
                
            }


            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

    }
}
