using InstitutoDesktop.ExtensionMethods;
using InstitutoDesktop.Util;
using InstitutoServices.Interfaces;
using InstitutoServices.Models.Horarios;
using InstitutoServices.Services.Commons;
using InstitutoDesktop.ExtensionMethods;

namespace InstitutoDesktop.Views.Horarios
{
    public partial class HorasView : Form
    {
        IGenericService<Hora> horaService = new GenericService<Hora>();
        BindingSource BindingHoras = new BindingSource();
        List<Hora> listaHoras = new List<Hora>();

        public HorasView()
        {
            InitializeComponent();
            dataGridHoras.DataSource = BindingHoras;

            CargarGrilla();
        }
        private async Task CargarGrilla()
        {
            listaHoras.DataSource = await horaService.GetAllAsync();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarHoraView agregarEditarHora = new AgregarEditarHoraView();
            agregarEditarHora.ShowDialog();
            CargarGrilla();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            var hora = (Hora)BindingHoras.Current;
            AgregarEditarHoraView agregarEditarHoraView = new AgregarEditarHoraView(hora);
            agregarEditarHoraView.ShowDialog();
            await CargarGrilla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var hora = (Hora)BindingHoras.Current;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar a la carrera {hora.Nombre}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await horaService.DeleteAsync(hora.Id);
                await CargarGrilla();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BindingHoras.DataSource = listaHoras.Where(h => h.Nombre.Contains(txtFiltro.Text)).OrderBy(h => h.Nombre).ToList();

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            BtnBuscar.PerformClick();
        }
    }
}
