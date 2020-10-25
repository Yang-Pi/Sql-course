using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work7
{
    public partial class MainForm : Form
    {
        private OleDbConnection dbConnection;
        public MainForm()
        {
            InitializeComponent();

            string connectionString =
                    "Provider=SQLOLEDB;Data Source=LAPTOP-6L6A4F3S;Initial Catalog=Ship-shop;Integrated Security=SSPI";
            dbConnection = new OleDbConnection(connectionString);
            
            if (dbConnection.State.ToString().Equals("Closed")) {
                tablesToolStripMenuItem.Enabled = false;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" Хотите выйти?", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.No) {
                e.Cancel = true;
            } else {
                dbConnection.Close();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                dbConnection.Open();
                if (dbConnection.State.ToString().Equals("Open")) {
                    tablesToolStripMenuItem.Enabled = true;
                } else {
                    tablesToolStripMenuItem.Enabled = false;
                }
                MessageBox.Show("Conneted", "Connection", MessageBoxButtons.OK);
            } catch (Exception) {
                MessageBox.Show("Connection failed!", "Connection", MessageBoxButtons.OK);
            }
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Table.customers == false) {
                Table Customers = new Table(dbConnection, "Customers");
                Customers.MdiParent = this;
                Customers.Show();
            } else
                foreach (Form tbl in this.MdiChildren)
                    if (tbl.Text == "Customers") {
                        tbl.Activate();
                        break;
                    }
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Table.orders == false)
            {
                Table Orders = new Table(dbConnection, "Orders");
                Orders.MdiParent = this;
                Orders.Show();
            }
            else
                foreach (Form tbl in this.MdiChildren)
                    if (tbl.Text == "Orders")
                    {
                        tbl.Activate();
                        break;
                    }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dbConnection.Close();
            tablesToolStripMenuItem.Enabled = false;
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Создание многооконного приложения и подключение к базе данных.", "Info", MessageBoxButtons.OK);
        }
    }
}
