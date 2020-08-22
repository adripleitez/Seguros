using MaterialSkin;
using MaterialSkin.Controls;
using System;
using Spire.PdfViewer;
using System.Threading;
using System.Windows.Forms;

namespace Seguros
{
    public partial class login : MaterialForm

    {
        Thread th;
        public login()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            /* materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Cyan600, Primary.Cyan500,
                Primary.Cyan500, Accent.LightBlue700,
                TextShade.WHITE
            );
            */

        }

        /*private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Close();
            th = new Thread(OpenFormRegister);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenFormRegister(object obj)
        {
            Application.Run(new Register());
        }*/

        private void login_Load(object sender, EventArgs e)
        {

        }


        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                pdfDocumentViewer1.LoadFromFile(fd.FileName);
            }
            else
            {
                MessageBox.Show("seleccionar archivo");
            }
        }
    }
}
