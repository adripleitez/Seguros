using MaterialSkin;
using System;
using System.Windows.Forms;

namespace Seguros.Views
{
    public partial class NuevaPoliza : MaterialSkin.Controls.MaterialForm
    {
        public NuevaPoliza()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        private void NuevaPoliza_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
