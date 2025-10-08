namespace PracticaParcial
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
            dtvg1 = new DataGridView();
            btnRefrescar = new Button();
            btnEliminar = new Button();
            btnNuevo = new Button();
            btnModificar = new Button();
            btnCantCuotaAlDia = new Button();
            btnListarCuotaAlDia = new Button();
            ((System.ComponentModel.ISupportInitialize)dtvg1).BeginInit();
            SuspendLayout();
            // 
            // dtvg1
            // 
            dtvg1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvg1.Location = new Point(39, 87);
            dtvg1.Name = "dtvg1";
            dtvg1.RowHeadersWidth = 51;
            dtvg1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvg1.Size = new Size(1034, 323);
            dtvg1.TabIndex = 0;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(39, 30);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(94, 29);
            btnRefrescar.TabIndex = 1;
            btnRefrescar.Text = "Refrescar";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(430, 30);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(179, 30);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(305, 30);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 7;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnCantCuotaAlDia
            // 
            btnCantCuotaAlDia.Location = new Point(554, 30);
            btnCantCuotaAlDia.Name = "btnCantCuotaAlDia";
            btnCantCuotaAlDia.Size = new Size(195, 29);
            btnCantCuotaAlDia.TabIndex = 8;
            btnCantCuotaAlDia.Text = "Cantidad Cuota al dia";
            btnCantCuotaAlDia.UseVisualStyleBackColor = true;
            btnCantCuotaAlDia.Click += btnCantCuotaAlDia_Click;
            // 
            // btnListarCuotaAlDia
            // 
            btnListarCuotaAlDia.Location = new Point(783, 30);
            btnListarCuotaAlDia.Name = "btnListarCuotaAlDia";
            btnListarCuotaAlDia.Size = new Size(195, 29);
            btnListarCuotaAlDia.TabIndex = 9;
            btnListarCuotaAlDia.Text = "Listar Cuota al dia";
            btnListarCuotaAlDia.UseVisualStyleBackColor = true;
            btnListarCuotaAlDia.Click += btnListarCuotaAlDia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 450);
            Controls.Add(btnListarCuotaAlDia);
            Controls.Add(btnCantCuotaAlDia);
            Controls.Add(btnModificar);
            Controls.Add(btnNuevo);
            Controls.Add(btnEliminar);
            Controls.Add(btnRefrescar);
            Controls.Add(dtvg1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtvg1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtvg1;
        private Button btnRefrescar;
        private RadioButton radioButton1;
        private Button button1;
        private Button button2;
        private Button btnEliminar;
        private Button btnNuevo;
        private Button btnModificar;
        private Button btnCantCuotaAlDia;
        private Button btnListarCuotaAlDia;
    }
}
