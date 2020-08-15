namespace Seguros.Views
{
    partial class PruebaDataGrid
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
            this.lbl_usuario = new MaterialSkin.Controls.MaterialLabel();
            this.lbl_bienvenido = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_usuario
            // 
            this.lbl_usuario.AutoSize = true;
            this.lbl_usuario.Depth = 0;
            this.lbl_usuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_usuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_usuario.Location = new System.Drawing.Point(222, 81);
            this.lbl_usuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_usuario.Name = "lbl_usuario";
            this.lbl_usuario.Size = new System.Drawing.Size(74, 24);
            this.lbl_usuario.TabIndex = 4;
            this.lbl_usuario.Text = "Usuario";
            // 
            // lbl_bienvenido
            // 
            this.lbl_bienvenido.AutoSize = true;
            this.lbl_bienvenido.Depth = 0;
            this.lbl_bienvenido.Font = new System.Drawing.Font("Roboto", 11F);
            this.lbl_bienvenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_bienvenido.Location = new System.Drawing.Point(76, 81);
            this.lbl_bienvenido.MouseState = MaterialSkin.MouseState.HOVER;
            this.lbl_bienvenido.Name = "lbl_bienvenido";
            this.lbl_bienvenido.Size = new System.Drawing.Size(103, 24);
            this.lbl_bienvenido.TabIndex = 3;
            this.lbl_bienvenido.Text = "Bienvenido";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Location = new System.Drawing.Point(70, 123);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(632, 304);
            this.dataGridView1.TabIndex = 5;
            // 
            // PruebaDataGrid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_usuario);
            this.Controls.Add(this.lbl_bienvenido);
            this.Name = "PruebaDataGrid";
            this.Text = "PruebaDataGrid";
            this.Load += new System.EventHandler(this.PruebaDataGrid_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel lbl_usuario;
        private MaterialSkin.Controls.MaterialLabel lbl_bienvenido;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}