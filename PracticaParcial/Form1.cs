namespace PracticaParcial
{
    public partial class Form1 : Form
    {
        public Form1() //constructor
        {
            InitializeComponent();
            RepositorioSocios repositorio = new RepositorioSocios();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        public void Refrescar()
        {
            RepositorioSocios repositorio = new RepositorioSocios();
            dtvg1.DataSource = repositorio.Listar(); // mostrar en la lista
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        //Boton nuevo

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            try
            {
                FrmNuevo frmAgregar = new FrmNuevo();
                frmAgregar.ShowDialog();
                Refrescar();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en agregar:" + ex.Message);
            }
        }



        //Boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int? idNuevo = GetId();
                RepositorioSocios repositorio = new RepositorioSocios();
                repositorio.Eliminar((int)idNuevo);
                Refrescar();
            }
            catch (Exception ex)
            {
                throw new Exception("Erorr en el boton eliminar:" + ex.Message);
            }
        }




        //Boton Modificar
        private void btnModificar_Click(object sender, EventArgs e)
        {
            int? idSocio = GetId();
            if (idSocio != null)
            {
                RepositorioSocios repositorio = new RepositorioSocios();
                Socios socios = repositorio.ObtenerPorId((int)idSocio);
                FormModificar frmModificar = new FormModificar(socios);
                frmModificar.ShowDialog();
                Refrescar();
            }
            else
            {
                MessageBox.Show("Seleccione socio");
            }

        }



        //get id
        private int? GetId()
        {
            try
            {
                int idObtenido = int.Parse(dtvg1.CurrentRow.Cells[0].Value.ToString());
                return idObtenido;
            }
            catch
            {
                return null;
            }

        }

        private void btnCantCuotaAlDia_Click(object sender, EventArgs e)
        {
            RepositorioSocios repositorio = new RepositorioSocios();
            int cantidad = repositorio.CantidadSociosCuotaAlDia();
            MessageBox.Show("Cantidad de socios con cuota al dia: " + cantidad);
            Refrescar();
        }

        private void btnListarCuotaAlDia_Click(object sender, EventArgs e)
        {
            RepositorioSocios repositorio = new RepositorioSocios();
            dtvg1.DataSource = repositorio.ListarCuotaAlDia();
        }
    }
}
