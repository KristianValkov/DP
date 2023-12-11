using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ДП_Кристиан_Вълков.Presenter
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void пилешкиХапкиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void рататуйToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void пърженаРибаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            //var n = menuStrip1.Text;
            //n.Color = "";
            заНасToolStripMenuItem.BackColor = Color.Peru;
            видовеЯстияToolStripMenuItem.BackColor = Color.White;
            контактиToolStripMenuItem.BackColor = Color.White;
            абонаментToolStripMenuItem.BackColor = Color.White;

        }

        private void заНасToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //private void зАДУШЕНИМАНАТАРКИToolStripMenuItem_Click(object sender, EventArgs e)
        //{

        //}
    }
}
