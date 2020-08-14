using MaterialSkin;
using Seguros.Controllers;
using Seguros.models;
using System;
using System.Windows.Forms;
using System.Threading;

namespace Seguros
{
    public partial class Register : MaterialSkin.Controls.MaterialForm

    {
        Thread th;

        public Register()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
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
            try
            {
                if(String.IsNullOrEmpty(txtfieldUser.Text.ToString()) || String.IsNullOrEmpty(txtfieldPassw.Text.ToString()) 
                    || String.IsNullOrEmpty(txtfieldName.Text.ToString()))
                {
                    MessageBox.Show("No puede dejar ningun campo vacío");
                }
                else
                {
                    User newUser = new User(txtfieldUser.Text.ToString(), txtfieldPassw.Text.ToString(), txtfieldName.Text.ToString());
                    UserController.RegisterUser(newUser);
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Close();
            th = new Thread(OpenFormLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenFormLogin(object obj)
        {
            Application.Run(new login());
        }
    }
}
