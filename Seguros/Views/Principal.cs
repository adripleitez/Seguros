using MaterialSkin;
using Seguros.Controllers;
using Seguros.models;
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
            List<User> UserList = (from DataRow dr in UserController.GetUserHistorial().Rows
                                   select new User()
                                   {

                                       Id_usuario = Convert.ToInt32(dr["id_usuario"]),
                                       Usuario = dr["usuario"].ToString(),
                                       Password = dr["password"].ToString(),
                                       Nombre = dr["nombre"].ToString()

                                   }).ToList();
            foreach ( User user in UserList)
            {
                ListViewItem item = new ListViewItem();
                item = listView1.Items.Add(user.Id_usuario.ToString());
                item.SubItems.Add(user.Nombre);
                item.SubItems.Add(user.Usuario);
                item.SubItems.Add(DateTime.Now.ToString());
                item.SubItems.Add("10:00 pm");
            }
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
