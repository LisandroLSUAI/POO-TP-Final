namespace VISTA
{
	partial class RegistroForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBoxTipo = new System.Windows.Forms.GroupBox();
            this.clienteRbtn = new System.Windows.Forms.RadioButton();
            this.empleadoRbtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSuperAdminPass = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownDNI = new System.Windows.Forms.NumericUpDown();
            this.groupBoxTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDNI)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 800;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 800;
            this.label1.Text = "Nombre";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(174, 111);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(134, 20);
            this.txtPass.TabIndex = 9;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(174, 68);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(134, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(236, 391);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 36);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(84, 391);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(94, 36);
            this.btnRegistrar.TabIndex = 17;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBoxTipo
            // 
            this.groupBoxTipo.Controls.Add(this.clienteRbtn);
            this.groupBoxTipo.Controls.Add(this.empleadoRbtn);
            this.groupBoxTipo.Controls.Add(this.label3);
            this.groupBoxTipo.Controls.Add(this.textBoxSuperAdminPass);
            this.groupBoxTipo.Location = new System.Drawing.Point(108, 246);
            this.groupBoxTipo.Name = "groupBoxTipo";
            this.groupBoxTipo.Size = new System.Drawing.Size(200, 127);
            this.groupBoxTipo.TabIndex = 140;
            this.groupBoxTipo.TabStop = false;
            this.groupBoxTipo.Text = "Tipo de Perfil";
            // 
            // clienteRbtn
            // 
            this.clienteRbtn.AutoSize = true;
            this.clienteRbtn.Checked = true;
            this.clienteRbtn.Location = new System.Drawing.Point(24, 29);
            this.clienteRbtn.Name = "clienteRbtn";
            this.clienteRbtn.Size = new System.Drawing.Size(57, 17);
            this.clienteRbtn.TabIndex = 14;
            this.clienteRbtn.TabStop = true;
            this.clienteRbtn.Text = "Cliente";
            this.clienteRbtn.UseVisualStyleBackColor = true;
            // 
            // empleadoRbtn
            // 
            this.empleadoRbtn.AutoSize = true;
            this.empleadoRbtn.Location = new System.Drawing.Point(24, 52);
            this.empleadoRbtn.Name = "empleadoRbtn";
            this.empleadoRbtn.Size = new System.Drawing.Size(88, 17);
            this.empleadoRbtn.TabIndex = 15;
            this.empleadoRbtn.Text = "Administrador";
            this.empleadoRbtn.UseVisualStyleBackColor = true;
            this.empleadoRbtn.CheckedChanged += new System.EventHandler(this.empleadoRbtn_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 800;
            this.label3.Text = "Contraseña de SuperAdmin:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxSuperAdminPass
            // 
            this.textBoxSuperAdminPass.Location = new System.Drawing.Point(41, 88);
            this.textBoxSuperAdminPass.Name = "textBoxSuperAdminPass";
            this.textBoxSuperAdminPass.PasswordChar = '*';
            this.textBoxSuperAdminPass.ReadOnly = true;
            this.textBoxSuperAdminPass.Size = new System.Drawing.Size(133, 20);
            this.textBoxSuperAdminPass.TabIndex = 16;
            this.textBoxSuperAdminPass.UseSystemPasswordChar = true;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(174, 149);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(134, 20);
            this.textBoxEmail.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 100;
            this.label4.Text = "E-mail";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 100;
            this.label5.Text = "DNI";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // numericUpDownDNI
            // 
            this.numericUpDownDNI.Location = new System.Drawing.Point(174, 191);
            this.numericUpDownDNI.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownDNI.Name = "numericUpDownDNI";
            this.numericUpDownDNI.Size = new System.Drawing.Size(134, 20);
            this.numericUpDownDNI.TabIndex = 11;
            // 
            // RegistroForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.numericUpDownDNI);
            this.Controls.Add(this.groupBoxTipo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "RegistroForm";
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.RegistroForm_Load);
            this.groupBoxTipo.ResumeLayout(false);
            this.groupBoxTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDNI)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnRegistrar;
		private System.Windows.Forms.GroupBox groupBoxTipo;
		private System.Windows.Forms.RadioButton clienteRbtn;
		private System.Windows.Forms.RadioButton empleadoRbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSuperAdminPass;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownDNI;
    }
}