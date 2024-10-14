namespace InstitutoDesktop.Views.Commons.AnioCarreras
{
    partial class AnioCarrerasView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            cboCarreras = new ComboBox();
            dataGridAniosCarrera = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridAniosCarrera).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(66, 30);
            label1.Name = "label1";
            label1.Size = new Size(105, 34);
            label1.TabIndex = 0;
            label1.Text = "Carrera:";
            // 
            // cboCarreras
            // 
            cboCarreras.FormattingEnabled = true;
            cboCarreras.Location = new Point(165, 30);
            cboCarreras.Margin = new Padding(3, 4, 3, 4);
            cboCarreras.Name = "cboCarreras";
            cboCarreras.Size = new Size(650, 32);
            cboCarreras.TabIndex = 1;
            cboCarreras.SelectedIndexChanged += cboCarreras_SelectedIndexChanged;
            // 
            // dataGridAniosCarrera
            // 
            dataGridAniosCarrera.AllowUserToAddRows = false;
            dataGridAniosCarrera.AllowUserToDeleteRows = false;
            dataGridAniosCarrera.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridAniosCarrera.BackgroundColor = Color.White;
            dataGridAniosCarrera.BorderStyle = BorderStyle.None;
            dataGridAniosCarrera.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridAniosCarrera.Location = new Point(91, 84);
            dataGridAniosCarrera.Margin = new Padding(3, 4, 3, 4);
            dataGridAniosCarrera.Name = "dataGridAniosCarrera";
            dataGridAniosCarrera.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridAniosCarrera.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridAniosCarrera.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridAniosCarrera.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridAniosCarrera.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridAniosCarrera.Size = new Size(724, 352);
            dataGridAniosCarrera.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(27, 464);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(144, 44);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(128, 128, 255);
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.ControlLightLight;
            btnEditar.Location = new Point(252, 464);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(144, 44);
            btnEditar.TabIndex = 4;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(470, 464);
            btnEliminar.Margin = new Padding(3, 4, 3, 4);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(144, 44);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(192, 64, 0);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.Location = new Point(723, 464);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(144, 44);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // AnioCarrerasView
            // 
            AutoScaleDimensions = new SizeF(9F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(900, 540);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridAniosCarrera);
            Controls.Add(cboCarreras);
            Controls.Add(label1);
            Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AnioCarrerasView";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Años Carrera";
            ((System.ComponentModel.ISupportInitialize)dataGridAniosCarrera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboCarreras;
        private DataGridView dataGridAniosCarrera;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnSalir;
    }
}