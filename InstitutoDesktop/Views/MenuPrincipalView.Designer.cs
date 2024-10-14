namespace InstitutoDesktop
{
    partial class MenuPrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem2 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem7 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem6 = new FontAwesome.Sharp.IconMenuItem();
            btnAlumnos = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem5 = new FontAwesome.Sharp.IconMenuItem();
            iconDocente = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItemAniosCarrera = new FontAwesome.Sharp.IconMenuItem();
            turnoExamenesToolStripMenuItem = new ToolStripMenuItem();
            iconMenuItem9 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem3 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem4 = new FontAwesome.Sharp.IconMenuItem();
            iconMenuItem8 = new FontAwesome.Sharp.IconMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { iconMenuItem1, iconMenuItem2, iconMenuItem3 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(1091, 32);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.House;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.IconSize = 40;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(104, 28);
            iconMenuItem1.Text = "Principal";
            // 
            // iconMenuItem2
            // 
            iconMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { iconMenuItem7, iconMenuItem6, btnAlumnos, iconMenuItem5, iconDocente, iconMenuItemAniosCarrera, turnoExamenesToolStripMenuItem, iconMenuItem9, iconMenuItem8 });
            iconMenuItem2.IconChar = FontAwesome.Sharp.IconChar.Database;
            iconMenuItem2.IconColor = Color.Black;
            iconMenuItem2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem2.Name = "iconMenuItem2";
            iconMenuItem2.Size = new Size(84, 28);
            iconMenuItem2.Text = "Bases";
            // 
            // iconMenuItem7
            // 
            iconMenuItem7.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            iconMenuItem7.IconColor = Color.Black;
            iconMenuItem7.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem7.Name = "iconMenuItem7";
            iconMenuItem7.Size = new Size(228, 30);
            iconMenuItem7.Text = "Horas";
            iconMenuItem7.Click += iconMenuItem7_Click;
            // 
            // iconMenuItem6
            // 
            iconMenuItem6.IconChar = FontAwesome.Sharp.IconChar.Hurricane;
            iconMenuItem6.IconColor = Color.Black;
            iconMenuItem6.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem6.Name = "iconMenuItem6";
            iconMenuItem6.Size = new Size(228, 30);
            iconMenuItem6.Text = "Ciclo Lectivo";
            iconMenuItem6.Click += iconMenuItem6_Click;
            // 
            // btnAlumnos
            // 
            btnAlumnos.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            btnAlumnos.IconColor = Color.Black;
            btnAlumnos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(228, 30);
            btnAlumnos.Text = "Alumnos";
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // iconMenuItem5
            // 
            iconMenuItem5.IconChar = FontAwesome.Sharp.IconChar.School;
            iconMenuItem5.IconColor = Color.Black;
            iconMenuItem5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem5.Name = "iconMenuItem5";
            iconMenuItem5.Size = new Size(228, 30);
            iconMenuItem5.Text = "Carreras";
            iconMenuItem5.Click += iconMenuItem5_Click;
            // 
            // iconDocente
            // 
            iconDocente.IconChar = FontAwesome.Sharp.IconChar.User;
            iconDocente.IconColor = Color.Pink;
            iconDocente.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconDocente.Name = "iconDocente";
            iconDocente.Size = new Size(228, 30);
            iconDocente.Text = "Docentes";
            iconDocente.Click += iconDocente_Click;
            // 
            // iconMenuItemAniosCarrera
            // 
            iconMenuItemAniosCarrera.IconChar = FontAwesome.Sharp.IconChar.Neuter;
            iconMenuItemAniosCarrera.IconColor = Color.Black;
            iconMenuItemAniosCarrera.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItemAniosCarrera.Name = "iconMenuItemAniosCarrera";
            iconMenuItemAniosCarrera.Size = new Size(228, 30);
            iconMenuItemAniosCarrera.Text = "Años de las carreras";
            iconMenuItemAniosCarrera.Click += iconMenuItemAniosCarrera_Click;
            // 
            // turnoExamenesToolStripMenuItem
            // 
            turnoExamenesToolStripMenuItem.Name = "turnoExamenesToolStripMenuItem";
            turnoExamenesToolStripMenuItem.Size = new Size(228, 30);
            turnoExamenesToolStripMenuItem.Text = "Turno Examenes";
            turnoExamenesToolStripMenuItem.Click += turnoExamenesToolStripMenuItem_Click;
            // 
            // iconMenuItem9
            // 
            iconMenuItem9.IconChar = FontAwesome.Sharp.IconChar.Receipt;
            iconMenuItem9.IconColor = Color.Black;
            iconMenuItem9.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem9.Name = "iconMenuItem9";
            iconMenuItem9.Size = new Size(228, 30);
            iconMenuItem9.Text = "Materias";
            iconMenuItem9.Click += iconMenuItem9_Click;
            // 
            // iconMenuItem3
            // 
            iconMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { iconMenuItem4 });
            iconMenuItem3.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            iconMenuItem3.IconColor = Color.Black;
            iconMenuItem3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem3.Name = "iconMenuItem3";
            iconMenuItem3.Size = new Size(76, 28);
            iconMenuItem3.Text = "Salir";
            // 
            // iconMenuItem4
            // 
            iconMenuItem4.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconMenuItem4.IconColor = Color.Black;
            iconMenuItem4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem4.Name = "iconMenuItem4";
            iconMenuItem4.Size = new Size(200, 26);
            iconMenuItem4.Text = "Salir del sistema";
            iconMenuItem4.Click += iconMenuItem4_Click;
            // 
            // iconMenuItem8
            // 
            iconMenuItem8.IconChar = FontAwesome.Sharp.IconChar.None;
            iconMenuItem8.IconColor = Color.Black;
            iconMenuItem8.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem8.Name = "iconMenuItem8";
            iconMenuItem8.Size = new Size(228, 30);
            iconMenuItem8.Text = "Horarios";
            iconMenuItem8.Click += iconMenuItem8_Click;
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1091, 662);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuPrincipalView";
            Text = "Instituto Superior de Profesorado Nº20";
            WindowState = FormWindowState.Maximized;
            Activated += MenuPrincipalView_Activated;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem2;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem5;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem3;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem4;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem7;

        private FontAwesome.Sharp.IconMenuItem iconMenuItem6;


        private FontAwesome.Sharp.IconMenuItem btnAlumnos;

        private FontAwesome.Sharp.IconMenuItem iconDocente;

        private ToolStripMenuItem turnoExamenesToolStripMenuItem;

        private FontAwesome.Sharp.IconMenuItem iconMenuItemAniosCarrera;

        private FontAwesome.Sharp.IconMenuItem iconMenuItem9;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem8;
    }
}
