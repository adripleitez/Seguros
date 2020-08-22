using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Seguros.Views
{
    public partial class MenuPrincipal : MaterialSkin.Controls.MaterialForm
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static new void ReleaseCapture();
        
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static new void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {

            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                axAcroPDF1.src = fd.FileName;
            }
            else
            {
                MessageBox.Show("select the file");
            }


            


        }
    }
}
