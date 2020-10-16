using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Class1 class1 = new Class1();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Put_forward(object sender, EventArgs e)
        {
            class1.PutForward();
            class1.Uranus();
            label1.Text = class1.Neutrons().ToString();
            label2.Text = class1.Kernel().ToString();
        }

        private void Push_in(object sender, EventArgs e)
        {
            class1.PushIn();
            class1.Uranus();
            label1.Text = class1.Neutrons().ToString();
            label2.Text = class1.Kernel().ToString();
        }

        private void Nothing(object sender, EventArgs e)
        {
            class1.Nothing();
            class1.Uranus();
            label1.Text = class1.Neutrons().ToString();
            label2.Text = class1.Kernel().ToString();
        }

        private void Shank_position(object sender, EventArgs e)
        {

        }

        private void Quantity_neutrons(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
