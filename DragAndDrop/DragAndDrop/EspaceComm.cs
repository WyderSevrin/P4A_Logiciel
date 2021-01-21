using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop
{
    public partial class EspaceComm : UserControl
    {
        public EspaceComm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBDesComm.Checked == true)
            {
                MessageBox.Show("Espace commentaire désactivé");
            }
        }
    }
}
