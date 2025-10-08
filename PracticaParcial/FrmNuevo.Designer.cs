namespace PracticaParcial
{
    partial class FrmNuevo
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
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDNI = new TextBox();
            txtNroDeSocio = new TextBox();
            dateTime = new DateTimePicker();
            lblNombre = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            comboBox1 = new ComboBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(240, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(248, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(238, 103);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(250, 27);
            txtApellido.TabIndex = 1;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(240, 156);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(248, 27);
            txtDNI.TabIndex = 2;
            // 
            // txtNroDeSocio
            // 
            txtNroDeSocio.Location = new Point(240, 212);
            txtNroDeSocio.Name = "txtNroDeSocio";
            txtNroDeSocio.Size = new Size(248, 27);
            txtNroDeSocio.TabIndex = 3;
            // 
            // dateTime
            // 
            dateTime.Location = new Point(238, 319);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(250, 27);
            dateTime.TabIndex = 5;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(144, 53);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            lblNombre.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(158, 106);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 7;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(158, 156);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 8;
            label3.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 215);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 9;
            label4.Text = "Nro de socio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(140, 271);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 10;
            label5.Text = "Cuota al día";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(83, 326);
            label6.Name = "label6";
            label6.Size = new Size(146, 20);
            label6.TabIndex = 11;
            label6.Text = "Fecha de nacimiento";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Si", "No" });
            comboBox1.Location = new Point(240, 263);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 28);
            comboBox1.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(484, 386);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // FrmNuevo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 458);
            Controls.Add(btnGuardar);
            Controls.Add(comboBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblNombre);
            Controls.Add(dateTime);
            Controls.Add(txtNroDeSocio);
            Controls.Add(txtDNI);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "FrmNuevo";
            Text = "FrmNuevo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDNI;
        private TextBox txtNroDeSocio;
        private DateTimePicker dateTime;
        private Label lblNombre;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox comboBox1;
        private Button btnGuardar;
    }
}