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

namespace App3
{
	public partial class MainForm : Form
	{
		private String connectionString;
		private OleDbConnection dbConnection;

		public MainForm()
		{
			InitializeComponent();

			connectionString =
					"Provider=SQLOLEDB;Data Source=LAPTOP-6L6A4F3S;" +
					"Initial Catalog=Ship-shop;Integrated Security=SSPI";
			dbConnection = new OleDbConnection(connectionString);
			try {
				dbConnection.Open();
			} catch (Exception e) {
				Console.WriteLine(e.Message);
			}

			initComboBoxes();
		}

		private void initComboBoxes()
		{
			OleDbCommand query = new OleDbCommand("SELECT customer_id FROM Customers", dbConnection);
			OleDbDataReader rdr = query.ExecuteReader();

			while (rdr.Read())
				customer_id_combo.Items.Add(rdr["customer_id"]);
			rdr.Close();

			query.CommandText = "SELECT employee_id, last_name FROM Employees";
			rdr = query.ExecuteReader();

			while (rdr.Read())
				employee_id_combo.Items.Add(rdr["employee_id"] + " - " + rdr["last_name"]);
			rdr.Close();

			query.CommandText = "SELECT shipper_id, company_name FROM Shippers";
			rdr = query.ExecuteReader();

			while (rdr.Read())
				shipper_combo.Items.Add(rdr["shipper_id"] + " - " + rdr["company_name"]);
			rdr.Close();
		}

		private void insert_Click(object sender, EventArgs e)
        {
			String query = "INSERT INTO Customers (customer_id, company_name, " +
					"contact_name, phone, country, city) VALUES (?, ?, ?, ?, ?, ?)";
			OleDbCommand cmdIC = new OleDbCommand(query, dbConnection);

			cmdIC.Parameters.Add("@p1", OleDbType.Integer);
			cmdIC.Parameters.Add("@p2", OleDbType.VarChar, 50);
			cmdIC.Parameters.Add("@p3", OleDbType.VarChar, 50);
			cmdIC.Parameters.Add("@p4", OleDbType.VarChar, 50);
			cmdIC.Parameters.Add("@p5", OleDbType.VarChar, 50);
			cmdIC.Parameters.Add("@p6", OleDbType.VarChar, 50);

			cmdIC.Parameters[0].Value = customer_id.Text;
			cmdIC.Parameters[1].Value = company_name.Text;
			cmdIC.Parameters[2].Value = contact_name.Text;
			cmdIC.Parameters[3].Value = phone.Text;

			if (phone.Text.Substring(1,2).Equals("79")) {
				cmdIC.Parameters[4].Value = "Russia";
				cmdIC.Parameters[5].Value = "Moscow";
            }

			try {
				cmdIC.ExecuteNonQuery();

				MessageBox.Show("Record successfully inserted!");
				customer_id.Clear();
				company_name.Clear();
				contact_name.Clear();
				phone.Clear();
			} catch (OleDbException exc) {
				MessageBox.Show("Something went wrong...\n" + exc.ToString());
			}
		}

		private void add_Click(object sender, EventArgs e)
		{
			String query = "INSERT INTO Orders (customer_id, employee_id, " +
					"shipper_id, order_date) VALUES (?, ?, ?, ?)";
			OleDbCommand cmdIC = new OleDbCommand(query, dbConnection);

			cmdIC.Parameters.Add("@p1", OleDbType.Integer);
			cmdIC.Parameters.Add("@p2", OleDbType.Integer);
			cmdIC.Parameters.Add("@p3", OleDbType.Integer);
			cmdIC.Parameters.Add("@p4", OleDbType.Date);

			cmdIC.Parameters[0].Value = customer_id_combo.SelectedItem.ToString();

			String s = employee_id_combo.SelectedItem.ToString();
			cmdIC.Parameters[1].Value = s.Remove(s.IndexOf("-") - 1, s.Length - s.IndexOf("-") + 1);

			s = shipper_combo.SelectedItem.ToString();
			cmdIC.Parameters[2].Value = s.Remove(s.IndexOf("-") - 1, s.Length - s.IndexOf("-") + 1);
			cmdIC.Parameters[3].Value = order_date.Text;

			try
			{
				int iRowAff = cmdIC.ExecuteNonQuery();
				MessageBox.Show("Orders: rows affected - " + iRowAff.ToString());

				customer_id_combo.Text = "";
				employee_id_combo.Text= "";
				shipper_combo.Text = "";
				order_date.Text = "";

				cmdIC.Dispose();
				iRowAff = 0;

				query = "SELECT max(order_id) id FROM Orders";
				OleDbCommand dbCommand = new OleDbCommand(query, dbConnection);
				OleDbDataReader rdr = dbCommand.ExecuteReader();
				rdr.Read();
				String order_id = rdr["id"].ToString();

				query = "INSERT INTO [Order Details] (order_id, product_id, unit_price, quantity, discount) VALUES (?, ?, ?, ?, ?)";
				cmdIC = new OleDbCommand(query, dbConnection);

				cmdIC.Parameters.Add("@p1", OleDbType.Integer);
				cmdIC.Parameters.Add("@p2", OleDbType.Integer);
				cmdIC.Parameters.Add("@p3", OleDbType.Decimal);
				cmdIC.Parameters.Add("@p4", OleDbType.Integer);
				cmdIC.Parameters.Add("@p5", OleDbType.Decimal);

				int iRowID = 0;

				for (iRowID = 0; iRowID < dsOD.Tables["OrderDetails"].Rows.Count; iRowID++)
				{
					DataRow dRow = dsOD.Tables["OrderDetails"].Rows[iRowID];
					
					cmdIC.Parameters[0].Value = order_id;
					cmdIC.Parameters[1].Value = dRow["product_id"].ToString();
					cmdIC.Parameters[2].Value = dRow["unit_price"].ToString();
					cmdIC.Parameters[3].Value = dRow["quantity"].ToString();
					cmdIC.Parameters[4].Value = dRow["discount"].ToString();

					iRowAff += cmdIC.ExecuteNonQuery();
				}

				MessageBox.Show("Order Details: rows affected - " + iRowAff.ToString());
				dsOD.Clear();
			}
			catch (OleDbException exc)
			{
				MessageBox.Show(exc.ToString());
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
	}
}
