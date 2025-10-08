namespace CrudADO
{
    partial class Form1
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
            dtgvPersonas = new DataGridView();
            btnAgregar = new Button();
            btnRefrescar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // dtgvPersonas
            // 
            dtgvPersonas.BackgroundColor = SystemColors.ActiveCaption;
            dtgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvPersonas.Location = new Point(29, 28);
            dtgvPersonas.Name = "dtgvPersonas";
            dtgvPersonas.RowHeadersWidth = 51;
            dtgvPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtgvPersonas.Size = new Size(626, 410);
            dtgvPersonas.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(678, 27);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(678, 396);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(94, 29);
            btnRefrescar.TabIndex = 2;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(678, 62);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 3;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(678, 97);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnRefrescar);
            Controls.Add(btnAgregar);
            Controls.Add(dtgvPersonas);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgvPersonas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgvPersonas;
        private Button btnAgregar;
        private Button btnRefrescar;
        private Button btnModificar;
        private Button btnEliminar;
    }
}
