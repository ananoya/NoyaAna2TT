namespace CrudADO
{
    partial class FrmAgregar
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
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            lblEdad = new Label();
            lblNombre = new Label();
            btnGuardarAgregar = new Button();
            SuspendLayout();
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(112, 85);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(173, 27);
            txtEdad.TabIndex = 12;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(112, 40);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(173, 27);
            txtNombre.TabIndex = 11;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(55, 92);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(46, 20);
            lblEdad.TabIndex = 10;
            lblEdad.Text = "Edad:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(34, 47);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 9;
            lblNombre.Text = "Nombre:";
            // 
            // btnGuardarAgregar
            // 
            btnGuardarAgregar.Location = new Point(301, 172);
            btnGuardarAgregar.Name = "btnGuardarAgregar";
            btnGuardarAgregar.Size = new Size(94, 29);
            btnGuardarAgregar.TabIndex = 13;
            btnGuardarAgregar.Text = "Guardar";
            btnGuardarAgregar.UseVisualStyleBackColor = true;
            btnGuardarAgregar.Click += btnGuardarAgregar_Click;
            // 
            // FrmAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 234);
            Controls.Add(btnGuardarAgregar);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Name = "FrmAgregar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmAgregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEdad;
        private TextBox txtNombre;
        private Label lblEdad;
        private Label lblNombre;
        private Button btnGuardarAgregar;
    }
}