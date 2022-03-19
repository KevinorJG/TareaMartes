using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsUIActivo.Forms
{
    public partial class FrmActivo : Form
    {
        public FrmActivo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxName.TextLength == 0 || textBoxTime.TextLength == 0 || textBoxValue.TextLength == 0 || textBoxValueR.TextLength == 0 || textBoxID.TextLength == 0)
            {
                MessageBox.Show("Debe de llenar todos datos","Error de registro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {

            }
        }

        private void FrmActivo_Load(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmBuscar windws = new FrmBuscar();
            windws.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDepreciacion window = new FrmDepreciacion();
            window.Show();
        }
    }
}
