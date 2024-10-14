using InstitutoDesktop.ExtensionMethods;
using InstitutoDesktop.Util;
using InstitutoDesktop.Views.Commons;
using InstitutoServices.Interfaces;
using InstitutoServices.Models.Commons;
using InstitutoServices.Services.Commons;

namespace InstitutoDesktop.Views
{
    public partial class CarrerasView : Form
    {
        IGenericService<Carrera> carreraService = new GenericService<Carrera>();
        BindingSource listaCarreras = new BindingSource();

        public CarrerasView()
        {
            InitializeComponent();
            dataGridCarreras.DataSource=listaCarreras;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            ShowInActivity.Show("Descargando/actualizando la lista de carreras");
            listaCarreras.DataSource = await carreraService.GetAllAsync();
            dataGridCarreras.OcultarColumnas(new string[] { "Eliminado" });
            ShowInActivity.Hide();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarCarreraView agregarEditarCarreraView = new AgregarEditarCarreraView();
            agregarEditarCarreraView.ShowDialog();
            CargarGrilla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var carrera = (Carrera)listaCarreras.Current;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar a la carrera {carrera.Nombre}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await carreraService.DeleteAsync(carrera.Id);
                await CargarGrilla();
            }
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            var carrera = (Carrera)listaCarreras.Current;
            AgregarEditarCarreraView agregarEditarCarreraView = new AgregarEditarCarreraView(carrera);
            agregarEditarCarreraView.ShowDialog();
            await CargarGrilla();
        }
    }
}
