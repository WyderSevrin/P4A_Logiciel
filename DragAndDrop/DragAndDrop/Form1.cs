using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragAndDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ajoutOE1.BringToFront();
        }
        private void ButtonAjoutOE_Click(object sender, EventArgs e)
        {
            ajoutOE1.BringToFront();
        }
        private void ButtonBiblio_Click(object sender, EventArgs e)
        {
            gererBiblio1.BringToFront();
        }

        private void ButtonEspComm_Click(object sender, EventArgs e)
        {
            espaceComm1.BringToFront();
        }

        private void ButtonSugg_Click(object sender, EventArgs e)
        {
            suggestions1.BringToFront();
        }

        private void ButtonPower_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
