namespace WindowsFormsApplication1
{
    partial class RegistoUtilizador
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
            System.Windows.Forms.Label lblnome;
            System.Windows.Forms.Label lblE_mail;
            System.Windows.Forms.Label lblData_nasc;
            System.Windows.Forms.Label lblLogin;
            System.Windows.Forms.Label lblPass;
            System.Windows.Forms.Label lblDepartamento;
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtE_mail = new System.Windows.Forms.TextBox();
            this.dtpData_nasc = new System.Windows.Forms.DateTimePicker();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.btnRegistar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            lblnome = new System.Windows.Forms.Label();
            lblE_mail = new System.Windows.Forms.Label();
            lblData_nasc = new System.Windows.Forms.Label();
            lblLogin = new System.Windows.Forms.Label();
            lblPass = new System.Windows.Forms.Label();
            lblDepartamento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblnome
            // 
            lblnome.AutoSize = true;
            lblnome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblnome.Location = new System.Drawing.Point(66, 31);
            lblnome.Name = "lblnome";
            lblnome.Size = new System.Drawing.Size(80, 29);
            lblnome.TabIndex = 18;
            lblnome.Text = "nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(250, 20);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(502, 35);
            this.txtNome.TabIndex = 19;
            // 
            // lblE_mail
            // 
            lblE_mail.AutoSize = true;
            lblE_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblE_mail.Location = new System.Drawing.Point(66, 79);
            lblE_mail.Name = "lblE_mail";
            lblE_mail.Size = new System.Drawing.Size(86, 29);
            lblE_mail.TabIndex = 20;
            lblE_mail.Text = "e-mail:";
            // 
            // txtE_mail
            // 
            this.txtE_mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE_mail.Location = new System.Drawing.Point(250, 68);
            this.txtE_mail.Name = "txtE_mail";
            this.txtE_mail.Size = new System.Drawing.Size(502, 35);
            this.txtE_mail.TabIndex = 21;
            // 
            // lblData_nasc
            // 
            lblData_nasc.AutoSize = true;
            lblData_nasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblData_nasc.Location = new System.Drawing.Point(66, 128);
            lblData_nasc.Name = "lblData_nasc";
            lblData_nasc.Size = new System.Drawing.Size(121, 29);
            lblData_nasc.TabIndex = 22;
            lblData_nasc.Text = "data nasc:";
            // 
            // dtpData_nasc
            // 
            this.dtpData_nasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpData_nasc.Location = new System.Drawing.Point(250, 116);
            this.dtpData_nasc.Name = "dtpData_nasc";
            this.dtpData_nasc.Size = new System.Drawing.Size(502, 35);
            this.dtpData_nasc.TabIndex = 23;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblLogin.Location = new System.Drawing.Point(66, 175);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new System.Drawing.Size(72, 29);
            lblLogin.TabIndex = 24;
            lblLogin.Text = "login:";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(250, 164);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(502, 35);
            this.txtLogin.TabIndex = 25;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblPass.Location = new System.Drawing.Point(66, 223);
            lblPass.Name = "lblPass";
            lblPass.Size = new System.Drawing.Size(70, 29);
            lblPass.TabIndex = 26;
            lblPass.Text = "pass:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(250, 212);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(502, 35);
            this.txtPass.TabIndex = 27;
            // 
            // lblDepartamento
            // 
            lblDepartamento.AutoSize = true;
            lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDepartamento.Location = new System.Drawing.Point(66, 281);
            lblDepartamento.Name = "lblDepartamento";
            lblDepartamento.Size = new System.Drawing.Size(168, 29);
            lblDepartamento.TabIndex = 30;
            lblDepartamento.Text = "departamento:";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(250, 270);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(502, 35);
            this.txtDepartamento.TabIndex = 31;
            // 
            // btnRegistar
            // 
            this.btnRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistar.Location = new System.Drawing.Point(601, 365);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(129, 91);
            this.btnRegistar.TabIndex = 32;
            this.btnRegistar.Text = "Registar";
            this.btnRegistar.UseVisualStyleBackColor = true;
            this.btnRegistar.Click += new System.EventHandler(this.BtnRegistar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(291, 365);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(129, 91);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // RegistoUtilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 506);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(lblnome);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(lblE_mail);
            this.Controls.Add(this.txtE_mail);
            this.Controls.Add(lblData_nasc);
            this.Controls.Add(this.dtpData_nasc);
            this.Controls.Add(lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(lblPass);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(lblDepartamento);
            this.Controls.Add(this.txtDepartamento);
            this.Name = "RegistoUtilizador";
            this.Text = "RegistoUtilizador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtE_mail;
        private System.Windows.Forms.DateTimePicker dtpData_nasc;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Button btnRegistar;
        private System.Windows.Forms.Button btnCancelar;
    }
}