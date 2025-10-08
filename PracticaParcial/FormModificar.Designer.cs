namespace PracticaParcial
{
    partial class FormModificar
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
            comboBox1 = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblNombre = new Label();
            dateTime = new DateTimePicker();
            txtNroDeSocio = new TextBox();
            txtDNI = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // btnGuardarModificar
            // 
            btnGuardarModificar.Location = new Point(554, 377);
            btnGuardarModificar.Name = "btnGuardarModificar";
            btnGuardarModificar.Size = new Size(94, 29);
            btnGuardarModificar.TabIndex = 26;
            btnGuardarModificar.Text = "Guardar";
            btnGuardarModificar.UseVisualStyleBackColor = true;
            btnGuardarModificar.Click += btnGuardarModificar_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Si", "No" });
            comboBox1.Location = new Point(310, 254);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(248, 28);
            comboBox1.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(153, 317);
            label6.Name = "label6";
            label6.Size = new Size(146, 20);
            label6.TabIndex = 24;
            label6.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(210, 262);
            label5.Name = "label5";
            label5.Size = new Size(89, 20);
            label5.TabIndex = 23;
            label5.Text = "Cuota al día";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(210, 206);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 22;
            label4.Text = "Nro de socio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(228, 147);
            label3.Name = "label3";
            label3.Size = new Size(35, 20);
            label3.TabIndex = 21;
            label3.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 97);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 20;
            label2.Text = "Apellido";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(214, 44);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 19;
            lblNombre.Text = "Nombre";
            // 
            // dateTime
            // 
            dateTime.Location = new Point(308, 310);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(250, 27);
            dateTime.TabIndex = 18;
            // 
            // txtNroDeSocio
            // 
            txtNroDeSocio.Location = new Point(310, 203);
            txtNroDeSocio.Name = "txtNroDeSocio";
            txtNroDeSocio.Size = new Size(248, 27);
            txtNroDeSocio.TabIndex = 17;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(310, 147);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(248, 27);
            txtDNI.TabIndex = 16;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(308, 94);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(250, 27);
            txtApellido.TabIndex = 15;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(310, 44);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(248, 27);
            txtNombre.TabIndex = 14;
            // 
            // FormModificar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 423);
            Controls.Add(btnGuardarModificar);
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
            Name = "FormModificar";
            Text = "FormModificar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGuardarModificar;
        private ComboBox comboBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblNombre;
        private DateTimePicker dateTime;
        private TextBox txtNroDeSocio;
        private TextBox txtDNI;
        private TextBox txtApellido;
        private TextBox txtNombre;
    }
}