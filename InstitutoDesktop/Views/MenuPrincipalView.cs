using InstitutoDesktop.Views;
using InstitutoDesktop.Views.Inscripciones;
using InstitutoDesktop.Views.Horarios;
using InstitutoDesktop.Views.MesasExamenes;

using InstitutoDesktop.Views.Commons.Alumnos;

using InstitutoDesktop.Views.Commons;
using InstitutoDesktop.Views.Commons.AnioCarreras;
using InstitutoDesktop.Views.Commons.Materias;




namespace InstitutoDesktop
{
    public partial class MenuPrincipalView : Form
    {
        bool logueado = false;

        public MenuPrincipalView()
        {
            InitializeComponent();

        }



        private void iconMenuItem5_Click(object sender, EventArgs e)
        {
            CarrerasView carrerasView = new CarrerasView();
            carrerasView.ShowDialog();
        }

        private void iconMenuItem4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void iconMenuItem6_Click(object sender, EventArgs e)
        {
            CiclosLectivosView ciclosLectivosView = new CiclosLectivosView();
            ciclosLectivosView.ShowDialog();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            AlumnosView alumnosView = new AlumnosView();
            alumnosView.ShowDialog();
        }
        private void iconDocente_Click(object sender, EventArgs e)
        {
            DocentesView docentesView = new DocentesView();
            docentesView.ShowDialog();

        }

        private void iconMenuItem7_Click(object sender, EventArgs e)
        {
            HorasView horariosView = new HorasView();
            horariosView.ShowDialog();
        }


        private void turnoExamenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TurnoExamenesView turnoexamenesview = new TurnoExamenesView();
            turnoexamenesview.ShowDialog();
        }



        private void iconMenuItem9_Click(object sender, EventArgs e)
        {
            MateriaView materiaView = new MateriaView();
            materiaView.ShowDialog();
        }

        private void iconMenuItemAniosCarrera_Click(object sender, EventArgs e)
        {
            AnioCarrerasView aniosCarreraView = new AnioCarrerasView();
            aniosCarreraView.ShowDialog();


        }

        private void MenuPrincipalView_Activated(object sender, EventArgs e)
        {
            if (!logueado)
            {
                IniciarSesionView iniciarSesionView = new IniciarSesionView();
                iniciarSesionView.ShowDialog();
                if (!iniciarSesionView.loginSuccessfull)
                {
                    Application.Exit();
                }
                else
                {
                    logueado = true;
                }
            }

        }

        private void iconMenuItem8_Click(object sender, EventArgs e)
        {
            HorariosView horariosView = new HorariosView();
            horariosView.ShowDialog();
        }
    }
}
