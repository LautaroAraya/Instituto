namespace InstitutoDesktop.Views.Commons.Materias
{
    partial class NuevoEditarMateriaView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtMateria = new TextBox();
            label2 = new Label();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtAnioYCarrera = new TextBox();
            label3 = new Label();
            chkEsRecreo = new CheckBox();
            SuspendLayout();
            // 
            // txtMateria
            // 
            txtMateria.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMateria.Location = new Point(136, 175);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(640, 35);
            txtMateria.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 174);
            label2.Name = "label2";
            label2.Size = new Size(103, 34);
            label2.TabIndex = 16;
            label2.Text = "Materia:";
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(192, 64, 0);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancelar.ForeColor = SystemColors.ControlLightLight;
            btnCancelar.Location = new Point(632, 368);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(144, 46);
            btnCancelar.TabIndex = 14;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(0, 192, 0);
            btnGuardar.Cursor = Cursors.Hand;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.ControlLightLight;
            btnGuardar.Location = new Point(25, 368);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(144, 46);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtAnioYCarrera
            // 
            txtAnioYCarrera.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAnioYCarrera.Location = new Point(180, 73);
            txtAnioYCarrera.Name = "txtAnioYCarrera";
            txtAnioYCarrera.ReadOnly = true;
            txtAnioYCarrera.Size = new Size(608, 35);
            txtAnioYCarrera.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1, 74);
            label3.Name = "label3";
            label3.Size = new Size(173, 34);
            label3.TabIndex = 19;
            label3.Text = "Año y Carrera:";
            // 
            // chkEsRecreo
            // 
            chkEsRecreo.AutoSize = true;
            chkEsRecreo.Location = new Point(199, 273);
            chkEsRecreo.Name = "chkEsRecreo";
            chkEsRecreo.Size = new Size(95, 24);
            chkEsRecreo.TabIndex = 21;
            chkEsRecreo.Text = "Es Recreo";
            chkEsRecreo.UseVisualStyleBackColor = true;
            // 
            // NuevoEditarMateriaView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(chkEsRecreo);
            Controls.Add(txtAnioYCarrera);
            Controls.Add(label3);
            Controls.Add(txtMateria);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Name = "NuevoEditarMateriaView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Nuevo Editar Materias";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMateria;
        private Label label2;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtAnioYCarrera;
        private Label label3;
        private CheckBox chkEsRecreo;
    }
}