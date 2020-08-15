namespace Seguros.Views
{
    partial class Principal
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
            this.lbl_bienvenido = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_usuario = new MaterialSkin.Controls.MaterialLabel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ID_Usuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Usuario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Hora = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // lbl_bienvenido
            // 
            this.lbl_bienvenido.AutoSize = true;
            this.lbl_bienvenido.Depth = 0;
            this.lbl_bienvenido.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_bienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_bienvenido.Location = new System.Drawing.Point(78, 123);
            this.lbl_bienvenido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_bienvenido.Name = "lbl_bienvenido";
            this.lbl_bienvenido.Size = new System.Drawing.Size(103, 24);
            this.lbl_bienvenido.TabIndex = 0;
            this.lbl_bienvenido.Text = "Bienvenido";
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Depth = 0;
            this.lbl_usuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_usuario.Location = new System.Drawing.Point(244, 123);
            this.lbl_usuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(74, 24);
            this.lbl_usuario.TabIndex = 1;
            this.lbl_usuario.Text = "Usuario";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.Control;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID_Usuario,
            this.Nombre,
            this.Usuario,
            this.Fecha,
            this.Hora});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(51, 195);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(697, 336);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ID_Usuario
            // 
            this.ID_Usuario.Text = "ID_Usuario";
            this.ID_Usuario.Width = 130;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nombre.Width = 160;
            // 
            // Usuario
            // 
            this.Usuario.Text = "Usuario";
            this.Usuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Usuario.Width = 130;
            // 
            // Fecha
            // 
            this.Fecha.Text = "Fecha";
            this.Fecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Fecha.Width = 130;
            // 
            // Hora
            // 
            this.Hora.Text = "Hora";
            this.Hora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hora.Width = 130;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(545, 115);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(176, 43);
            this.materialRaisedButton1.TabIndex = 3;
            this.materialRaisedButton1.Text = "PruebaDataGrid";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 617);
            this.Controls.Add(this.materialRaisedButton1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_bienvenido);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lbl_bienvenido;
        private MaterialSkin.Controls.MaterialLabel lbl_usuario;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Usuario;
        private System.Windows.Forms.ColumnHeader Fecha;
        private System.Windows.Forms.ColumnHeader Hora;
        private System.Windows.Forms.ColumnHeader ID_Usuario;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
    }
}