namespace InstitutoDesktop.Views.Commons.Materias
{
    partial class MateriaView
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
            btnSalir = new Button();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            dataGridMaterias = new DataGridView();
            cboCarreras = new ComboBox();
            label1 = new Label();
            cboAniosCarreras = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridMaterias).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(192, 64, 0);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ControlLightLight;
            btnSalir.Location = new Point(826, 619);
            btnSalir.Margin = new Padding(3, 5, 3, 5);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(162, 53);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = SystemColors.ControlLightLight;
            btnEliminar.Location = new Point(541, 619);
            btnEliminar.Margin = new Padding(3, 5, 3, 5);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(162, 53);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(128, 128, 255);
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditar.ForeColor = SystemColors.ControlLightLight;
            btnEditar.Location = new Point(296, 619);
            btnEditar.Margin = new Padding(3, 5, 3, 5);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(162, 53);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregar.ForeColor = SystemColors.ControlLightLight;
            btnAgregar.Location = new Point(43, 619);
            btnAgregar.Margin = new Padding(3, 5, 3, 5);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(162, 53);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridMaterias
            // 
            dataGridMaterias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridMaterias.BackgroundColor = Color.White;
            dataGridMaterias.BorderStyle = BorderStyle.None;
            dataGridMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMaterias.Location = new Point(115, 163);
            dataGridMaterias.Margin = new Padding(3, 5, 3, 5);
            dataGridMaterias.Name = "dataGridMaterias";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridMaterias.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridMaterias.RowHeadersWidth = 51;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridMaterias.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridMaterias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridMaterias.Size = new Size(814, 422);
            dataGridMaterias.TabIndex = 9;
            // 
            // cboCarreras
            // 
            cboCarreras.FormattingEnabled = true;
            cboCarreras.Location = new Point(198, 16);
            cboCarreras.Margin = new Padding(3, 5, 3, 5);
            cboCarreras.Name = "cboCarreras";
            cboCarreras.Size = new Size(731, 32);
            cboCarreras.TabIndex = 8;
            cboCarreras.SelectedIndexChanged += cboCarreras_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AllowDrop = true;
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 11);
            label1.Name = "label1";
            label1.Size = new Size(105, 34);
            label1.TabIndex = 7;
            label1.Text = "Carrera:";
            // 
            // cboAniosCarreras
            // 
            cboAniosCarreras.FormattingEnabled = true;
            cboAniosCarreras.Location = new Point(198, 97);
            cboAniosCarreras.Margin = new Padding(3, 5, 3, 5);
            cboAniosCarreras.Name = "cboAniosCarreras";
            cboAniosCarreras.Size = new Size(731, 32);
            cboAniosCarreras.TabIndex = 15;
            cboAniosCarreras.SelectedIndexChanged += cboAniosCarreras_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AllowDrop = true;
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(32, 90);
            label2.Name = "label2";
            label2.Size = new Size(173, 34);
            label2.TabIndex = 14;
            label2.Text = "Año Y Carrera:";
            // 
            // MateriaView
            // 
            AutoScaleDimensions = new SizeF(9F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1050, 700);
            Controls.Add(cboAniosCarreras);
            Controls.Add(label2);
            Controls.Add(btnSalir);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridMaterias);
            Controls.Add(cboCarreras);
            Controls.Add(label1);
            Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MateriaView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Materia";
            ((System.ComponentModel.ISupportInitialize)dataGridMaterias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalir;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnAgregar;
        private DataGridView dataGridMaterias;
        private ComboBox cboCarreras;
        private Label label1;
        private ComboBox cboAniosCarreras;
        private Label label2;
    }
}