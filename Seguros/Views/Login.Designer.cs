﻿namespace Seguros
{
    partial class login
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
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtfield1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtfield2 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRegister = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(129, 199);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(79, 24);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Usuario:";
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(129, 294);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(110, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Contraseña:";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // txtfield1
            // 
            this.txtfield1.BackColor = System.Drawing.SystemColors.Control;
            this.txtfield1.Depth = 0;
            this.txtfield1.Hint = "Ingresa tu usuario";
            this.txtfield1.Location = new System.Drawing.Point(133, 241);
            this.txtfield1.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtfield1.Name = "txtfield1";
            this.txtfield1.PasswordChar = '\0';
            this.txtfield1.SelectedText = "";
            this.txtfield1.SelectionLength = 0;
            this.txtfield1.SelectionStart = 0;
            this.txtfield1.Size = new System.Drawing.Size(525, 28);
            this.txtfield1.TabIndex = 2;
            this.txtfield1.UseSystemPasswordChar = false;
            this.txtfield1.Click += new System.EventHandler(this.txtfield1_Click);
            // 
            // txtfield2
            // 
            this.txtfield2.BackColor = System.Drawing.SystemColors.Control;
            this.txtfield2.Depth = 0;
            this.txtfield2.Hint = "Ingresar contraseña";
            this.txtfield2.Location = new System.Drawing.Point(133, 342);
            this.txtfield2.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtfield2.Name = "txtfield2";
            this.txtfield2.PasswordChar = '*';
            this.txtfield2.SelectedText = "";
            this.txtfield2.SelectionLength = 0;
            this.txtfield2.SelectionStart = 0;
            this.txtfield2.Size = new System.Drawing.Size(525, 28);
            this.txtfield2.TabIndex = 3;
            this.txtfield2.UseSystemPasswordChar = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Depth = 0;
            this.btnLogin.Location = new System.Drawing.Point(258, 443);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(244, 46);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Iniciar Sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Depth = 0;
            this.btnRegister.Location = new System.Drawing.Point(258, 502);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Primary = true;
            this.btnRegister.Size = new System.Drawing.Size(244, 46);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Registrarse";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 671);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtfield2);
            this.Controls.Add(this.txtfield1);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtfield1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtfield2;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegister;
    }
}

