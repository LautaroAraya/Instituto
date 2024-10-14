using InstitutoDesktop.ExtensionMethods;
using InstitutoDesktop.Util;
using InstitutoServices.Interfaces;
using InstitutoServices.Models.Commons;
using InstitutoServices.Services.Commons;

namespace InstitutoDesktop.Views.Commons
{
    public partial class DocentesView : Form
    {
        IGenericService<Docente> docenteService = new GenericService<Docente>();
        BindingSource BindingDocente = new BindingSource();
        List<Docente> listDocente = new List<Docente>();

        public DocentesView()
        {
            InitializeComponent();
            dataGridDocentes.DataSource = BindingDocente;
            CargarGrilla();

        }

        private async Task CargarGrilla()
        {
            ShowInActivity.Show("Descargando/actualizando la lista de docentes");
            listDocente = await docenteService.GetAllAsync();
            dataGridDocentes.OcultarColumnas(new string[] { "Eliminado" });
            ShowInActivity.Hide();
            BindingDocente.DataSource = listDocente;

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarDocenteView agregarEditarDocenteView = new AgregarEditarDocenteView();
            agregarEditarDocenteView.ShowDialog();
            CargarGrilla();
        }

        private async void iconButton1_Click(object sender, EventArgs e)
        {
            var docente = (Docente)BindingDocente.Current;
            AgregarEditarDocenteView agregarEditarDocenteView = new AgregarEditarDocenteView(docente);
            agregarEditarDocenteView.ShowDialog();
            await CargarGrilla();
        }

        private async void iconButton2_Click(object sender, EventArgs e)
        {
            var docente = (Docente)BindingDocente.Current;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere borrar el docente{docente.Nombre}", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await docenteService.DeleteAsync(docente.Id);
                await CargarGrilla();
                dataGridDocentes.SeleccionarFilaNuevaOEditada(docente.Id);
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            BindingDocente.DataSource = listDocente.Where(x => x.Nombre.ToUpper().Contains(txtFiltro.Text.ToUpper())).ToList();

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            BtnBuscar.PerformClick();
        }
    }
}
