using InstitutoDesktop.ExtensionMethods;
using InstitutoDesktop.Util;
using InstitutoServices.Interfaces;
using InstitutoServices.Models.MesasExamenes;
using InstitutoServices.Services.Commons;

namespace InstitutoDesktop.Views.MesasExamenes
{
    public partial class TurnoExamenesView : Form
    {
        IGenericService<TurnoExamen> turnoexamenesService = new GenericService<TurnoExamen>();
        BindingSource listaTurnos = new BindingSource();
        public TurnoExamenesView()
        {
            InitializeComponent();
            dataGridTurnoExamenes.DataSource = listaTurnos;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            ShowInActivity.Show("Descargando/actualizando la lista de turnos de exámenes");
            listaTurnos.DataSource = await turnoexamenesService.GetAllAsync();
            dataGridTurnoExamenes.OcultarColumnas(new string[] { "Eliminado" });
            ShowInActivity.Hide();
        }
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var turnoexamenes = (TurnoExamen)listaTurnos.Current;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar el Ciclo Lectivo {turnoexamenes.Nombre}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await turnoexamenesService.DeleteAsync(turnoexamenes.Id);
                await CargarGrilla();
            }
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarTurnoExamenesView agregarEditarTurnoExamenesView = new AgregarEditarTurnoExamenesView();
            agregarEditarTurnoExamenesView.ShowDialog();
            await CargarGrilla();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {

            var turnoexamen = (TurnoExamen)listaTurnos.Current;
            if (turnoexamen == null)
            {
                MessageBox.Show("Debe seleccionar un valor de la grilla");
                return;
            }
            AgregarEditarTurnoExamenesView agregarEditarTurnoExamenesView = new AgregarEditarTurnoExamenesView(turnoexamen);
            agregarEditarTurnoExamenesView.ShowDialog();
            await CargarGrilla();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
