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

namespace Work8
{
    public partial class MainForm : Form
    {
        private String connectionString;
        private OleDbConnection dbConnection;

        private System.Data.OleDb.OleDbDataAdapter dataAdapter;
        private System.Data.DataSet dataSet;

        private System.Data.DataTable dataTable;
        private System.Data.DataRow dataRow;
        private int iRowId;

        public MainForm()
        {
            InitializeComponent();
            connectionString = 
                    "Provider=SQLOLEDB;Data Source=LAPTOP-6L6A4F3S;" +
                    "Initial Catalog=Ship-shop;Integrated Security=SSPI";
            dbConnection = new OleDbConnection(connectionString);

            if (dbConnection.State.ToString().Equals("Closed")) {
                setNavigationButtonsState(false);
            }

            iRowId = 0;
            dataSet = new DataSet();

            ordersDetails();
            categories();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show(" Хотите выйти?", " Внимание!", MessageBoxButtons.YesNo) == DialogResult.No) {
                e.Cancel = true;
            }
            else {
                dbConnection.Close();
            }
        }

        private void ordersDetails()
        {
            DataTable dtTmp; //model

            dtTmp = dataSet.Tables.Add("Order Details");
            dtTmp.Columns.Add("order_id", typeof(int));
            dtTmp.Columns.Add("product_id", typeof(int));
            dtTmp.Columns.Add("unit_price", typeof(Decimal));
            dtTmp.Columns.Add("quantity", typeof(int));
            dtTmp.Columns.Add("discount", typeof(Decimal));
            dtTmp.Columns.Add("item_total", typeof(Decimal),
                    "unit_price * quantity * (100 - discount) / 100");
            
            dgOrderDetails.DataSource = new BindingSource(dataSet, "Order Details");
        }

        private void categories()
        {
            String query = "SELECT * FROM Categories";

            dataAdapter = new OleDbDataAdapter(query, dbConnection);
            dataAdapter.Fill(dataSet, "Categories");

            dgCategories.DataSource = new BindingSource(dataSet, "Categories");
        }

        private void show_Click(object sender, EventArgs e)
        {
            String query = "SELECT order_id, customer_id, ship_name, " +
                    "ship_city, ship_country FROM Orders";
            dataAdapter = new OleDbDataAdapter(query, dbConnection);

            if (!dataSet.Tables.Contains("Orders")) {
                dataAdapter.Fill(dataSet, "Orders");
            }

            dataTable = dataSet.Tables["Orders"];
            showRow(iRowId);
        }

        private void showRow(int iRowId)
        {
            dataRow = dataTable.Rows[iRowId];

            order_id.Text = dataRow["order_id"].ToString();
            customer_id.Text = dataRow["customer_id"].ToString();
            ship_name.Text = dataRow["ship_name"].ToString();
            ship_city.Text = dataRow["ship_city"].ToString();
            ship_country.Text = dataRow["ship_country"].ToString();
        }

        private void connect_Click(object sender, EventArgs e)
        {
            try {
                dbConnection.Open();
                if (dbConnection.State.ToString().Equals("Open")) {
                    setNavigationButtonsState(true);
                }
                MessageBox.Show("Conneted", "Connection", MessageBoxButtons.OK);
            } catch (Exception) {
                MessageBox.Show("Connection failed!", "Connection", MessageBoxButtons.OK);
            }
        }

        private void setNavigationButtonsState(bool state)
        {
            show.Enabled = state;
            next.Enabled = state;
            prev.Enabled = state;
            first.Enabled = state;
            last.Enabled = state;
            show_oder_details.Enabled = state;
            add.Enabled = state;
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (iRowId < dataSet.Tables["Orders"].Rows.Count - 1) {
                showRow(++iRowId);
            }
        }

        private void prev_Click(object sender, EventArgs e)
        {
            if (iRowId > 0) {
                showRow(--iRowId);
            }
        }

        private void first_Click(object sender, EventArgs e)
        {
            iRowId = 0;
            showRow(iRowId);
        }

        private void last_Click(object sender, EventArgs e)
        {
            iRowId = dataSet.Tables["Orders"].Rows.Count - 1;
            showRow(iRowId);
        }

        private void show_oder_details_Click(object sender, EventArgs e)
        {
            String query = "SELECT * FROM [Order Details]";
            dataSet.Clear();
            dataAdapter = new OleDbDataAdapter(query, dbConnection);
            dataAdapter.Fill(dataSet, "Order Details");
        }

        private void add_Click(object sender, EventArgs e)
        {
            dataRow = dataSet.Tables["Categories"].NewRow();

            dataRow["category_id"] = DateTime.Now.Second;
            dataRow["category_name"] = category_name.Text;
            dataRow["description"] = description.Text;
            dataSet.Tables["Categories"].Rows.Add(dataRow);

            category_name.Clear();
            description.Clear();

            MessageBox.Show("New record created in DataTable!");
        }

        private void exit_Click(object sender, EventArgs e)
        {
            dbConnection.Close();
            setNavigationButtonsState(false);
        }
    }
}
