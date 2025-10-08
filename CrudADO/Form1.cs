namespace CrudADO
{
    public partial class Form1 : Form
    {
        PersonaDB repositorioPersona; //global
        public Form1()
        {
            InitializeComponent();
            repositorioPersona = new PersonaDB(); //inicializa en el constructor
        }

        //Metodo load del forms--------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            //cada vez que se cargue el forms se van a mostrar los datos de la bdd refrescandolo, asi se ven los datos actualizados
            Refrescar();

        }


        //Metodo refrescar muestra los datos de la bdd--------------------------------------------------------------
        private void Refrescar()
        {
            //Instacio al repositorio de personas cada vez que se refresca para actualizar los datos (agregados,eliminados o modificado)
            PersonaDB repositorioPersona = new PersonaDB();//ESTO ME HABIA FALTADO ANTES!!
            //muestro los datos en el data gried view con el metodo listar 
            dtgvPersonas.DataSource = repositorioPersona.Listar();
        }


        //Metodo refrescar muestra los datos de la bdd refrescandolo-----------------------------------------------
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        //Metodo boton AGREGAR-----------------------------------------------------------
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try { 
            FrmAgregar formsAgregar = new FrmAgregar(); //crea un objeto del otro forms de agregar
            formsAgregar.ShowDialog(); //Lo muestra y no se puede ir al de atras hasta que lo cierre
            Refrescar();// refresca data gried view
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar: " + ex.Message);
            }
        }


        //Metodo boton Modificar-----------------------------------------------------------
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtgvPersonas.CurrentRow != null)
                {
                    Persona personaSeleccionada = new Persona();
                    personaSeleccionada = (Persona)dtgvPersonas.CurrentRow.DataBoundItem; //creo un objeto persona


                    FrmModificar fromsModificar = new FrmModificar(personaSeleccionada); //le paso el id al constructor del forms agregar
                    fromsModificar.ShowDialog(); //Lo muestra y no se puede ir al de atras hasta que lo cierre
                    Refrescar();
                }
                else
                {
                    MessageBox.Show("No hay fila seleccionada");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar: " + ex.Message);
            }
        }



       
        //Metodo boton Eliminar-----------------------------------------------------------
        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {
                int? id = GetId(); //aca ya tengo el id

                if (id != null) //si no es nulo   
                {//entro al repo y elimino esa fila donde esta ese id
                    //tengo persona y le paso el id 
                    Persona personaGetbyId = repositorioPersona.GetById((int)id);
                        repositorioPersona.Eliminar(personaGetbyId);
                    Refrescar(); //refresco el data gried view

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar " + ex.Message);
            }
            
        }
      
        //HELPER para que me devuelva el id del row seleccionado
        #region HELPER
        private int? GetId() //ese  signo indica q puede ser null
        {

            try
            {
                int idObtenido = int.Parse(dtgvPersonas.Rows[dtgvPersonas.CurrentRow.Index].Cells[0].Value.ToString());
                //obtengo el id de la fila seleccionada
                return idObtenido;
            }
            catch
            {
                return null; //devuelve -1 si no hay fila seleccionada
            }
        }
        #endregion
    }
}
