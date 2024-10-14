namespace InstitutoDesktop.Views.Commons
{
    partial class DocentesView
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
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnAgregar = new FontAwesome.Sharp.IconButton();
            dataGridDocentes = new DataGridView();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            txtFiltro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridDocentes).BeginInit();
            SuspendLayout();
            // 
            // iconButton3
            // 
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.File;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconButton3.IconSize = 24;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(771, 524);
            iconButton3.Margin = new Padding(3, 4, 3, 4);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(127, 40);
            iconButton3.TabIndex = 9;
            iconButton3.Text = "Salir";
            iconButton3.UseVisualStyleBackColor = true;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton2
            // 
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.File;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconButton2.IconSize = 24;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(410, 524);
            iconButton2.Margin = new Padding(3, 4, 3, 4);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(127, 40);
            iconButton2.TabIndex = 8;
            iconButton2.Text = "Eliminar";
            iconButton2.UseVisualStyleBackColor = true;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.File;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconButton1.IconSize = 24;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(228, 524);
            iconButton1.Margin = new Padding(3, 4, 3, 4);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(127, 40);
            iconButton1.TabIndex = 7;
            iconButton1.Text = "Editar";
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += iconButton1_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.IconChar = FontAwesome.Sharp.IconChar.File;
            btnAgregar.IconColor = Color.Black;
            btnAgregar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnAgregar.IconSize = 24;
            btnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregar.Location = new Point(55, 524);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(127, 40);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridDocentes
            // 
            dataGridDocentes.AllowUserToAddRows = false;
            dataGridDocentes.AllowUserToDeleteRows = false;
            dataGridDocentes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDocentes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridDocentes.Location = new Point(94, 93);
            dataGridDocentes.Margin = new Padding(3, 4, 3, 4);
            dataGridDocentes.Name = "dataGridDocentes";
            dataGridDocentes.ReadOnly = true;
            dataGridDocentes.RowHeadersWidth = 62;
            dataGridDocentes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDocentes.Size = new Size(784, 414);
            dataGridDocentes.TabIndex = 5;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.BackColor = Color.OrangeRed;
            BtnBuscar.ForeColor = Color.White;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.White;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(755, 32);
            BtnBuscar.Margin = new Padding(3, 4, 3, 4);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(123, 51);
            BtnBuscar.TabIndex = 16;
            BtnBuscar.Text = "&Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = false;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 47);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 15;
            label3.Text = "Buscar docente:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(244, 44);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(483, 27);
            txtFiltro.TabIndex = 14;
            txtFiltro.TextChanged += txtFiltro_TextChanged;
            // 
            // DocentesView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 592);
            Controls.Add(BtnBuscar);
            Controls.Add(label3);
            Controls.Add(txtFiltro);
            Controls.Add(iconButton3);
            Controls.Add(iconButton2);
            Controls.Add(iconButton1);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridDocentes);
            Name = "DocentesView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Docentes";
            ((System.ComponentModel.ISupportInitialize)dataGridDocentes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton btnAgregar;
        private DataGridView dataGridDocentes;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private Label label3;
        private TextBox txtFiltro;
    }
}