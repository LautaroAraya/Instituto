using InstitutoDesktop.ExtensionMethods;
using InstitutoDesktop.Util;
using InstitutoServices.Interfaces;
using InstitutoServices.Models.Inscripciones;
using InstitutoServices.Services.Commons;

namespace InstitutoDesktop.Views.Inscripciones
{


    public partial class CiclosLectivosView : Form
    {
        IGenericService<CicloLectivo> ciclolectivoService = new GenericService<CicloLectivo>();
        BindingSource listaCicloLectivos = new BindingSource();
        public CiclosLectivosView()
        {
            InitializeComponent();
            dataGridCiclosLectivos.DataSource = listaCicloLectivos;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            ShowInActivity.Show("Descargando/actualizando la lista de ciclos lectívos");
            listaCicloLectivos.DataSource = await ciclolectivoService.GetAllAsync();
            dataGridCiclosLectivos.OcultarColumnas(new string[] { "Eliminado" });
            ShowInActivity.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarCicloLectivoView agregarEditarCicloLectivoView = new AgregarEditarCicloLectivoView();
            agregarEditarCicloLectivoView.ShowDialog();
            await CargarGrilla();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            var ciclolectivo = (CicloLectivo)listaCicloLectivos.Current;
            AgregarEditarCicloLectivoView agregarEditarCicloLectivoView = new AgregarEditarCicloLectivoView(ciclolectivo);
            agregarEditarCicloLectivoView.ShowDialog();
            await CargarGrilla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var ciclolectivo = (CicloLectivo)listaCicloLectivos.Current;
          
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar el Ciclo Lectivo {ciclolectivo.Nombre}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await ciclolectivoService.DeleteAsync(ciclolectivo.Id);
                await CargarGrilla();
            }
        }
    }
}
