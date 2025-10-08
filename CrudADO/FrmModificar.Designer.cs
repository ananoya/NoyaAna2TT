namespace CrudADO
{
    partial class FrmModificar
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
            btnGuardarModificar = new Button();
            txtEdad = new TextBox();
            txtNombre = new TextBox();
            lblEdad = new Label();
            lblNombre = new Label();
            txtId = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGuardarModificar
            // 
            btnGuardarModificar.Location = new Point(287, 161);
            btnGuardarModificar.Name = "btnGuardarModificar";
            btnGuardarModificar.Size = new Size(94, 29);
            btnGuardarModificar.TabIndex = 18;
            btnGuardarModificar.Text = "Guardar";
            btnGuardarModificar.UseVisualStyleBackColor = true;
            btnGuardarModificar.Click += btnGuardarModificar_Click;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(104, 112);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(173, 27);
            txtEdad.TabIndex = 17;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(104, 67);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(173, 27);
            txtNombre.TabIndex = 16;
            txtNombre.TextAlign = HorizontalAlignment.Right;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(47, 119);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(46, 20);
            lblEdad.TabIndex = 15;
            lblEdad.Text = "Edad:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(26, 74);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 14;
            lblNombre.Text = "Nombre:";
            // 
            // txtId
            // 
            txtId.Location = new Point(104, 34);
            txtId.Name = "txtId";
            txtId.Size = new Size(173, 27);
            txtId.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 34);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 19;
            label1.Text = "Id:";
            // 
            // FrmModificar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 224);
            Controls.Add(txtId);
            Controls.Add(label1);
            Controls.Add(btnGuardarModificar);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(lblEdad);
            Controls.Add(lblNombre);
            Name = "FrmModificar";
            Text = "FrmModificar";
            Load += FrmModificar_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarModificar;
        private TextBox txtEdad;
        private TextBox txtNombre;
        private Label lblEdad;
        private Label lblNombre;
        private TextBox txtId;
        private Label label1;
    }
}