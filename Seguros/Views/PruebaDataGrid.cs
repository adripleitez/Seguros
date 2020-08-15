using MaterialSkin;
using Seguros.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seguros.Views
{
    public partial class PruebaDataGrid : MaterialSkin.Controls.MaterialForm
    {
        public PruebaDataGrid()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void PruebaDataGrid_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = UserController.GetUserHistorial();
        }
    }
}
