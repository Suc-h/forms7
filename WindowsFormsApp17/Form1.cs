using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Size = new Size((int)numericUpDown2.Value, (int)numericUpDown1.Value);
            form.Name=textBox1.Text;
            form.BackColor = Color.AliceBlue;
            form.ShowDialog();
        }
    }
}
