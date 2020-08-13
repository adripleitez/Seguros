using MaterialSkin;
using MaterialSkin.Controls;
using Seguros.Controllers;
using Seguros.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguros
{
    public partial class Register : MaterialSkin.Controls.MaterialForm

    {

        public Register()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

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
            using (login frmLogin = new login())
            {
                frmLogin.ShowDialog();
            }
        }
    }
}
