using InstitutoServices.Interfaces;
using InstitutoServices.Models.Horarios;
using InstitutoServices.Services;
using InstitutoServices.Services.Commons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoDesktop.Views.Horarios
{
    public partial class AgregarEditarHoraView : Form
    {
        IGenericService<Hora> horarioService = new GenericService<Hora>();
        private Hora hora;

        public AgregarEditarHoraView()
        {
            InitializeComponent();
            hora = new Hora();
        }

        public AgregarEditarHoraView(Hora hora)
        {
            InitializeComponent();
            this.hora = hora;
            CargarDatosEnPantalla();
        }

        private async void CargarDatosEnPantalla()
        {
            txtNombre.Text = hora.Nombre;
            dateTimeDesde.Value = hora.Desde;
            dateTimeHasta.Value = hora.Hasta;
            chkRecreo.Checked = hora.EsRecreo;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            hora.Nombre = txtNombre.Text;
            hora.Desde = dateTimeDesde.Value;
            hora.Hasta = dateTimeHasta.Value;
            hora.EsRecreo = chkRecreo.Checked;

            if (hora.Id == 0)
            {
                await horarioService.AddAsync(hora);

            }
            else
            {
                await horarioService.UpdateAsync(hora);
            }
           
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
