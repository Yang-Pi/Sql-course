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
    public partial class Table : Form
    {
        private OleDbDataAdapter dataAdapter;
        public static bool customers, orders;

        public Table()
        {
            InitializeComponent();
        }

        public Table(OleDbConnection connection, String str)
        {
            InitializeComponent();

            dataAdapter = new OleDbDataAdapter("SELECT * FROM " + str, connection);
            DataTable tableCustomers = new DataTable(str);
            dataSet.Tables.Add(tableCustomers);
            dgTable.DataSource = new BindingSource(dataSet, str);
            dataAdapter.Fill(dataSet, str);
            //dgTable.DataMember = str;
            Text = str;
            
            if (Text == "Orders") orders = true;
            if (Text == "Customers") customers = true;
        }

        public void Table_ClosingForm()
        {
            if (Text == "Orders") orders = false;
            if (Text == "Customers") customers = false;
        }

        private void Table_Load(object sender, EventArgs e)
        {

        }
    }
}
