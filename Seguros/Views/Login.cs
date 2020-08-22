using MaterialSkin;
using MaterialSkin.Controls;
using System;
using PdfiumViewer;
using System.Threading;
using System.Windows.Forms;
using System.IO;

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
                openfile(fd.FileName);
            }
            else
            {
                MessageBox.Show("seleccionar archivo");
            }
        }


        private void openfile(string filepath)
        {

            byte[] bytes = System.IO.File.ReadAllBytes(filepath);
            var stream = new MemoryStream(bytes);
            PdfDocument pdfDocument = PdfDocument.Load(stream);
            pdfViewer1.Document = pdfDocument;

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
