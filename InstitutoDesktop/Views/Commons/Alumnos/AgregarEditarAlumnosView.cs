﻿using InstitutoServices.Models;
using InstitutoServices.Interfaces;
using InstitutoServices.Models.Commons;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InstitutoDesktop.Views.Commons.Alumnos
{
    public partial class AgregarEditarAlumnosView : Form
    {
        IGenericService<Alumno> alumnoService = new GenericService<Alumno>();
        Alumno alumno;

        //nuevo
        public AgregarEditarAlumnosView()
        {
            InitializeComponent();
            alumno=new Alumno();
        }

        //editar
        public AgregarEditarAlumnosView(Alumno alumno)
        {
            InitializeComponent();
            this.alumno=alumno;
            CargarDatosAlumnosAEditar();
        }

        private async void CargarDatosAlumnosAEditar()
        {
            txtNombre.Text = alumno.ApellidoNombre;
            txtTelefono.Text = alumno.Telefono;
            txtDireccion.Text = alumno.Direccion;
            txtEmail.Text = alumno.Email;
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            alumno.ApellidoNombre = txtNombre.Text;
            alumno.Telefono = txtTelefono.Text;
            alumno.Direccion = txtDireccion.Text;
            alumno.Email = txtEmail.Text;

            if (alumno.Id == 0)
            {
                await alumnoService.AddAsync(alumno);
            }
            else
            {
                await alumnoService.UpdateAsync(alumno);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
