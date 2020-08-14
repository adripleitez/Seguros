using MaterialSkin;
using System;

namespace Seguros.Views
{
    public partial class Principal : MaterialSkin.Controls.MaterialForm
    {
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
    }
}
