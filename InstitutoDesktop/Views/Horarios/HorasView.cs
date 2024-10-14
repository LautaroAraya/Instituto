using InstitutoServices.Interfaces;
using InstitutoServices.Services;
using InstitutoDesktop.Views.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstitutoServices.Services.Commons;
using InstitutoServices.Models.Horarios;
using InstitutoDesktop.ExtensionMethods;

namespace InstitutoDesktop.Views.Horarios
{
    public partial class HorasView : Form
    {
        IGenericService<Hora> horaService = new GenericService<Hora>();
        BindingSource listaHoras = new BindingSource();
        public HorasView()
        {
            InitializeComponent();
            dataGridHoras.DataSource = listaHoras;
            CargarGrilla();
        }
        private async Task CargarGrilla()
        {
            listaHoras.DataSource = await horaService.GetAllAsync();
            dataGridHoras.OcultarColumnas(new string[] { "Desde", "Hasta", "Eliminado" });
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarHoraView agregarEditarHora = new AgregarEditarHoraView();
            agregarEditarHora.ShowDialog();
            CargarGrilla();
        }

        private async void btnEditar_Click(object sender, EventArgs e)
        {
            var hora = (Hora)listaHoras.Current;
            AgregarEditarHoraView agregarEditarHoraView = new AgregarEditarHoraView(hora);
            agregarEditarHoraView.ShowDialog();
            await CargarGrilla();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var hora = (Hora)listaHoras.Current;
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
    }
}
