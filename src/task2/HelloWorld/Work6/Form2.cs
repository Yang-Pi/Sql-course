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
    public partial class Form2 : Form
    {
        private int numpage;

        public Form2(int numpage, string strParam)
        {
            InitializeComponent();
            this.numpage = numpage;
            this.txtGetText.Text = strParam;

            comboBox1.Items.Add(new Spr(1, "Ваня"));
            comboBox1.Items.Add(new Spr(2, "Ваcя"));
            comboBox1.Items.Add(new Spr(3, "Петя"));
            comboBox1.Items.Add(new Spr(4, "Гоша"));
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (numpage == 0) {
                this.tabControl1.SelectedTab = this.tabPage1;
            } else {
                this.tabControl1.SelectedTab = this.tabPage2;
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            textBox1.Text = listBox1.SelectedItem.ToString();
            textBox2.Text = listBox1.SelectedIndex.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (object item in listBox1.SelectedItems) {
                richTextBox1.Text = richTextBox1.Text + item.ToString() + "\r\n";
            }
            foreach (object item in listBox1.SelectedIndices) {
                richTextBox2.Text = richTextBox2.Text + item.ToString() + "\r\n";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                MessageBox.Show(((Spr)comboBox1.SelectedItem).id.ToString());
            } else
            {
                MessageBox.Show("Please select someone");
            }
            
        }
    }

    public class Spr
    {
        int _id;
        string _name;

        public Spr(int id, string name)
        {
            this._id = id;
            this._name = name;
        }
        public string Name
        {
            get {
                return this._name;
            }
        }
        public int id
        {
            get {
                return this._id;
            }
        }

        public override string ToString()
        {
            return this._name;
        }
    }

}
