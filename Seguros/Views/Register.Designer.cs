namespace Seguros
{
    partial class Register
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
            this.txtfieldUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtfieldPassw = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRegister = new MaterialSkin.Controls.MaterialRaisedButton();
            this.txtfieldName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(129, 243);
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
            this.materialLabel2.Location = new System.Drawing.Point(129, 338);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(110, 24);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Contraseña:";
            this.materialLabel2.Click += new System.EventHandler(this.materialLabel2_Click);
            // 
            // txtfieldUser
            // 
            this.txtfieldUser.BackColor = System.Drawing.SystemColors.Control;
            this.txtfieldUser.Depth = 0;
            this.txtfieldUser.Hint = "Ingresa tu usuario";
            this.txtfieldUser.Location = new System.Drawing.Point(133, 285);
            this.txtfieldUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtfieldUser.Name = "txtfieldUser";
            this.txtfieldUser.PasswordChar = '\0';
            this.txtfieldUser.SelectedText = "";
            this.txtfieldUser.SelectionLength = 0;
            this.txtfieldUser.SelectionStart = 0;
            this.txtfieldUser.Size = new System.Drawing.Size(525, 28);
            this.txtfieldUser.TabIndex = 2;
            this.txtfieldUser.UseSystemPasswordChar = false;
            this.txtfieldUser.Click += new System.EventHandler(this.txtfield1_Click);
            // 
            // txtfieldPassw
            // 
            this.txtfieldPassw.BackColor = System.Drawing.SystemColors.Control;
            this.txtfieldPassw.Depth = 0;
            this.txtfieldPassw.Hint = "Ingresar contraseña";
            this.txtfieldPassw.Location = new System.Drawing.Point(133, 386);
            this.txtfieldPassw.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtfieldPassw.Name = "txtfieldPassw";
            this.txtfieldPassw.PasswordChar = '*';
            this.txtfieldPassw.SelectedText = "";
            this.txtfieldPassw.SelectionLength = 0;
            this.txtfieldPassw.SelectionStart = 0;
            this.txtfieldPassw.Size = new System.Drawing.Size(525, 28);
            this.txtfieldPassw.TabIndex = 3;
            this.txtfieldPassw.UseSystemPasswordChar = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Depth = 0;
            this.btnLogin.Location = new System.Drawing.Point(258, 537);
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
            this.btnRegister.Location = new System.Drawing.Point(258, 469);
            this.btnRegister.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Primary = true;
            this.btnRegister.Size = new System.Drawing.Size(244, 46);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Registrarse";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.materialRaisedButton2_Click);
            // 
            // txtfieldName
            // 
            this.txtfieldName.BackColor = System.Drawing.SystemColors.Control;
            this.txtfieldName.Depth = 0;
            this.txtfieldName.Hint = "Ingresa tu primer nombre y apellido";
            this.txtfieldName.Location = new System.Drawing.Point(133, 189);
            this.txtfieldName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtfieldName.Name = "txtfieldName";
            this.txtfieldName.PasswordChar = '\0';
            this.txtfieldName.SelectedText = "";
            this.txtfieldName.SelectionLength = 0;
            this.txtfieldName.SelectionStart = 0;
            this.txtfieldName.Size = new System.Drawing.Size(525, 28);
            this.txtfieldName.TabIndex = 9;
            this.txtfieldName.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.SystemColors.Window;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(129, 147);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(84, 24);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Nombre:";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 671);
            this.Controls.Add(this.txtfieldName);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtfieldPassw);
            this.Controls.Add(this.txtfieldUser);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.MaximizeBox = false;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrarse";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtfieldUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtfieldPassw;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
        private MaterialSkin.Controls.MaterialRaisedButton btnRegister;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtfieldName;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
    }
}

