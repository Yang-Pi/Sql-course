namespace App3
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.customer_id_label = new System.Windows.Forms.Label();
            this.contact_name_label = new System.Windows.Forms.Label();
            this.phone_label = new System.Windows.Forms.Label();
            this.company_name_label = new System.Windows.Forms.Label();
            this.customer_id = new System.Windows.Forms.TextBox();
            this.company_name = new System.Windows.Forms.TextBox();
            this.contact_name = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customer_id_combo = new System.Windows.Forms.ComboBox();
            this.employee_id_combo = new System.Windows.Forms.ComboBox();
            this.shipper_combo = new System.Windows.Forms.ComboBox();
            this.add = new System.Windows.Forms.Button();
            this.order_date = new System.Windows.Forms.TextBox();
            this.ship_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgOD = new System.Windows.Forms.DataGridView();
            this.dsOD = new App3.dsOrderDetails();
            this.orderDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.discountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.insert);
            this.tabPage1.Controls.Add(this.phone);
            this.tabPage1.Controls.Add(this.contact_name);
            this.tabPage1.Controls.Add(this.company_name);
            this.tabPage1.Controls.Add(this.customer_id);
            this.tabPage1.Controls.Add(this.phone_label);
            this.tabPage1.Controls.Add(this.company_name_label);
            this.tabPage1.Controls.Add(this.contact_name_label);
            this.tabPage1.Controls.Add(this.customer_id_label);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Customer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgOD);
            this.tabPage2.Controls.Add(this.ship_price);
            this.tabPage2.Controls.Add(this.order_date);
            this.tabPage2.Controls.Add(this.add);
            this.tabPage2.Controls.Add(this.shipper_combo);
            this.tabPage2.Controls.Add(this.employee_id_combo);
            this.tabPage2.Controls.Add(this.customer_id_combo);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add Oder";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // customer_id_label
            // 
            this.customer_id_label.AutoSize = true;
            this.customer_id_label.Location = new System.Drawing.Point(240, 81);
            this.customer_id_label.Name = "customer_id_label";
            this.customer_id_label.Size = new System.Drawing.Size(85, 17);
            this.customer_id_label.TabIndex = 0;
            this.customer_id_label.Text = "Customer ID";
            // 
            // contact_name_label
            // 
            this.contact_name_label.AutoSize = true;
            this.contact_name_label.Location = new System.Drawing.Point(240, 150);
            this.contact_name_label.Name = "contact_name_label";
            this.contact_name_label.Size = new System.Drawing.Size(97, 17);
            this.contact_name_label.TabIndex = 0;
            this.contact_name_label.Text = "Contact Name";
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(240, 187);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(49, 17);
            this.phone_label.TabIndex = 0;
            this.phone_label.Text = "Phone";
            // 
            // company_name_label
            // 
            this.company_name_label.AutoSize = true;
            this.company_name_label.Location = new System.Drawing.Point(240, 114);
            this.company_name_label.Name = "company_name_label";
            this.company_name_label.Size = new System.Drawing.Size(108, 17);
            this.company_name_label.TabIndex = 0;
            this.company_name_label.Text = "Company Name";
            // 
            // customer_id
            // 
            this.customer_id.Location = new System.Drawing.Point(364, 81);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(100, 22);
            this.customer_id.TabIndex = 1;
            // 
            // company_name
            // 
            this.company_name.Location = new System.Drawing.Point(364, 114);
            this.company_name.Name = "company_name";
            this.company_name.Size = new System.Drawing.Size(141, 22);
            this.company_name.TabIndex = 1;
            // 
            // contact_name
            // 
            this.contact_name.Location = new System.Drawing.Point(364, 150);
            this.contact_name.Name = "contact_name";
            this.contact_name.Size = new System.Drawing.Size(141, 22);
            this.contact_name.TabIndex = 1;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(364, 187);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(141, 22);
            this.phone.TabIndex = 1;
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(325, 250);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 2;
            this.insert.Text = "Insert";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ship Via";
            // 
            // customer_id_combo
            // 
            this.customer_id_combo.FormattingEnabled = true;
            this.customer_id_combo.Location = new System.Drawing.Point(246, 26);
            this.customer_id_combo.Name = "customer_id_combo";
            this.customer_id_combo.Size = new System.Drawing.Size(121, 24);
            this.customer_id_combo.TabIndex = 1;
            // 
            // employee_id_combo
            // 
            this.employee_id_combo.FormattingEnabled = true;
            this.employee_id_combo.Location = new System.Drawing.Point(246, 60);
            this.employee_id_combo.Name = "employee_id_combo";
            this.employee_id_combo.Size = new System.Drawing.Size(121, 24);
            this.employee_id_combo.TabIndex = 1;
            // 
            // shipper_combo
            // 
            this.shipper_combo.FormattingEnabled = true;
            this.shipper_combo.Location = new System.Drawing.Point(246, 93);
            this.shipper_combo.Name = "shipper_combo";
            this.shipper_combo.Size = new System.Drawing.Size(121, 24);
            this.shipper_combo.TabIndex = 1;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(469, 96);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 3;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // order_date
            // 
            this.order_date.Location = new System.Drawing.Point(505, 32);
            this.order_date.Name = "order_date";
            this.order_date.Size = new System.Drawing.Size(100, 22);
            this.order_date.TabIndex = 4;
            // 
            // ship_price
            // 
            this.ship_price.Location = new System.Drawing.Point(505, 60);
            this.ship_price.Name = "ship_price";
            this.ship_price.Size = new System.Drawing.Size(100, 22);
            this.ship_price.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(405, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Order Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ship Price";
            // 
            // dgOD
            // 
            this.dgOD.AutoGenerateColumns = false;
            this.dgOD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productidDataGridViewTextBoxColumn,
            this.unitpriceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.discountDataGridViewTextBoxColumn});
            this.dgOD.DataSource = this.orderDetailsBindingSource;
            this.dgOD.Location = new System.Drawing.Point(6, 145);
            this.dgOD.Name = "dgOD";
            this.dgOD.RowHeadersWidth = 51;
            this.dgOD.RowTemplate.Height = 24;
            this.dgOD.Size = new System.Drawing.Size(756, 246);
            this.dgOD.TabIndex = 5;
            // 
            // dsOD
            // 
            this.dsOD.DataSetName = "dsOrderDetails";
            this.dsOD.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderDetailsBindingSource
            // 
            this.orderDetailsBindingSource.DataMember = "OrderDetails";
            this.orderDetailsBindingSource.DataSource = this.dsOD;
            // 
            // productidDataGridViewTextBoxColumn
            // 
            this.productidDataGridViewTextBoxColumn.DataPropertyName = "product_id";
            this.productidDataGridViewTextBoxColumn.HeaderText = "product_id";
            this.productidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productidDataGridViewTextBoxColumn.Name = "productidDataGridViewTextBoxColumn";
            this.productidDataGridViewTextBoxColumn.Width = 125;
            // 
            // unitpriceDataGridViewTextBoxColumn
            // 
            this.unitpriceDataGridViewTextBoxColumn.DataPropertyName = "unit_price";
            this.unitpriceDataGridViewTextBoxColumn.HeaderText = "unit_price";
            this.unitpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unitpriceDataGridViewTextBoxColumn.Name = "unitpriceDataGridViewTextBoxColumn";
            this.unitpriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "quantity";
            this.quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            this.discountDataGridViewTextBoxColumn.DataPropertyName = "discount";
            this.discountDataGridViewTextBoxColumn.HeaderText = "discount";
            this.discountDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            this.discountDataGridViewTextBoxColumn.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsOD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label customer_id_label;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.TextBox contact_name;
        private System.Windows.Forms.TextBox company_name;
        private System.Windows.Forms.TextBox customer_id;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Label company_name_label;
        private System.Windows.Forms.Label contact_name_label;
        private System.Windows.Forms.TextBox ship_price;
        private System.Windows.Forms.TextBox order_date;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ComboBox shipper_combo;
        private System.Windows.Forms.ComboBox employee_id_combo;
        private System.Windows.Forms.ComboBox customer_id_combo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgOD;
        private System.Windows.Forms.Label label5;
        private dsOrderDetails dsOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn productidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource orderDetailsBindingSource;
    }
}

