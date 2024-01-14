using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void потребителToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vchoddd_potrebitel2.Show();
            vchod_potrebitel1.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //vchod_potrebitelm1.Show();
            vchoddd_potrebitel2.Hide();

        }
        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vchoddd_potrebitel2.Hide();
        }

        
    }
}
