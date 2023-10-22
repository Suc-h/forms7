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
            colorDialog1.ShowDialog();
            Form2 form = new Form2();
            form.Size = new Size((int)numericUpDown2.Value, (int)numericUpDown1.Value);
            form.Text = textBox2.Text;
            form.BackColor = colorDialog1.Color;
            Button zpet = new Button();
            Button konec = new Button();
            zpet.Text = "Zpět";
            zpet.DialogResult=DialogResult.OK;
            konec.DialogResult = DialogResult.Cancel;
            konec.Text = "Konec";
            zpet.Size = new Size(106, 34);
            zpet.Location = new Point(13, 13);
            konec.Location = new Point(366, 13);
            konec.Size = new Size(106, 34);

            form.Controls.Add(zpet);
            form.Controls.Add(konec);

            if (form.ShowDialog() == DialogResult.OK)
            {
                form.Close();

            }
            else
            {
                this.Close();
                form.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                numericUpDown1.Enabled = true;
                numericUpDown2.Enabled = true;
            }
            else
            {
                numericUpDown1.Enabled = false;
                numericUpDown2.Enabled = false;
            }
        }
    }
}
