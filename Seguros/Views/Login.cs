using MaterialSkin;
using MaterialSkin.Controls;
using Seguros.Views;
using System;
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

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void txtfield1_Click(object sender, EventArgs e)
        {

        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Close();
            th = new Thread(OpenFormRegister);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenFormRegister(object obj)
        {
            Application.Run(new Register());
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Close();
            th = new Thread(OpenFormMenuPrincipal);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenFormMenuPrincipal(object obj)
        {
            Application.Run(new MenuPrincipal());
        }
    }
}
