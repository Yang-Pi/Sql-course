using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" Хотите выйти?", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.No) {
                e.Cancel = true;
            }

        }

        private const string Pswd = "QWERTY";
        private void Password_KeyUp(object sender, KeyEventArgs e)
        {
            if (Pswd == this.textBox1.Text)
            {
                Form2 secondform = new Form2(0, this.textBox2.Text);
                secondform.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 secondform = new Form2(1, this.textBox2.Text);
            secondform.ShowDialog();

        }
    }
}
