using InstitutoDesktop.ExtensionMethods;
using InstitutoDesktop.Util;
using InstitutoServices.Models.Commons;
using InstitutoServices.Services.Commons;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;

namespace InstitutoDesktop.Views.Commons.AnioCarreras
{
    public partial class AnioCarrerasView : Form
    {
        GenericService<Carrera> carreraService = new GenericService<Carrera>();
        AnioCarreraService anioCarreraService = new AnioCarreraService();
        BindingSource BindingAniosCarrera = new BindingSource();
        List<AnioCarrera> ListAniosCarreraFiltrada = new List<AnioCarrera>();
        BindingSource BindingCarreras = new BindingSource();

        public AnioCarrerasView()
        {
            InitializeComponent();
            ObtenerListas();
        }

        private async void ObtenerListas()
        {
            ShowInActivity.Show("Descargando carreras y años de las carreras");
            var tareas = new List<Task>()
            {
                Task.Run(async () => BindingCarreras.DataSource = await carreraService.GetAllAsync()),
                Task.Run(async () => ListAniosCarreraFiltrada = await anioCarreraService.GetAllAsync())
            };
            await Task.WhenAll(tareas);
            ShowInActivity.Hide();
            BindingAniosCarrera.DataSource = ListAniosCarreraFiltrada;
            CargarCboCarreras();
        }
        private async void ActualizarLista()
        {
            ShowInActivity.Show("Actualizando lista de años de carrera");
            var tareas = new List<Task>()
            {
                Task.Run(async () => ListAniosCarreraFiltrada = await anioCarreraService.GetAllAsync())
            };
            await Task.WhenAll(tareas);
            ShowInActivity.Hide();
            BindingAniosCarrera.DataSource = ListAniosCarreraFiltrada;
            CargarDatosGrilla();
        }

        private async void CargarDatosGrilla()
        {
            dataGridAniosCarrera.DataSource = BindingAniosCarrera;

            if (cboCarreras.SelectedValue != null && cboCarreras.SelectedValue.GetType() == typeof(int))
            {
                var idCarrera = (int)cboCarreras.SelectedValue;
                BindingAniosCarrera.DataSource = ListAniosCarreraFiltrada.Where(x => x.CarreraId == idCarrera).ToList();
                dataGridAniosCarrera.OcultarColumnas(new string[] { "Carrera", "CarreraId", "AñoYCarrera", "Eliminado" });
                dataGridAniosCarrera.EstablecerAnchoDeColumnas(new int[] { 100, 300 });
            }
        }

        private void CargarCboCarreras()
        {
            cboCarreras.DataSource = BindingCarreras;
            cboCarreras.DisplayMember = "Nombre";
            cboCarreras.ValueMember = "Id";
            CargarDatosGrilla();
        }

        private void cboCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCarreras.SelectedValue != null && cboCarreras.SelectedValue.GetType() == typeof(int))
            {
                CargarDatosGrilla();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var carrera = (Carrera)BindingCarreras.Current;
            NuevoEditarAnioCarreraView nuevoEditarAnioCarreraView = new NuevoEditarAnioCarreraView(carrera);
            nuevoEditarAnioCarreraView.ShowDialog();
            ActualizarLista();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var anioCarrera = (AnioCarrera)BindingAniosCarrera.Current;
            NuevoEditarAnioCarreraView nuevoEditarAnioCarreraView = new NuevoEditarAnioCarreraView(anioCarrera);
            nuevoEditarAnioCarreraView.ShowDialog();
            ActualizarLista();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var anioCarrera = (AnioCarrera)BindingAniosCarrera.Current;
            var respuesta = MessageBox.Show($"¿Está seguro/a que quiere borrar el Año {anioCarrera.Nombre}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await anioCarreraService.DeleteAsync(anioCarrera.Id);
                ActualizarLista();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }

}
