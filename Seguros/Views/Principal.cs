using MaterialSkin;
using Seguros.Controllers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Seguros.Views
{
    public partial class Principal : MaterialSkin.Controls.MaterialForm
    {
        Thread th;
        public Principal()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
           
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            Close();
            th = new Thread(OpenFormDataGrid);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenFormDataGrid(object obj)
        {
            Application.Run(new PruebaDataGrid());
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            Close();
            th = new Thread(OpenFormNuevoPais);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OpenFormNuevoPais(object obj)
        {
            Application.Run(new NuevoPais());
        }
    }
}
