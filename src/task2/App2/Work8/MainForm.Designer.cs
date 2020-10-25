namespace Work8
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
            this.tab_control = new System.Windows.Forms.TabControl();
            this.Orders = new System.Windows.Forms.TabPage();
            this.connect = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.ship_country_lable = new System.Windows.Forms.Label();
            this.ship_city_lable = new System.Windows.Forms.Label();
            this.ship_name_lable = new System.Windows.Forms.Label();
            this.customer_id_lable = new System.Windows.Forms.Label();
            this.order_id_lable = new System.Windows.Forms.Label();
            this.ship_country = new System.Windows.Forms.TextBox();
            this.ship_city = new System.Windows.Forms.TextBox();
            this.ship_name = new System.Windows.Forms.TextBox();
            this.customer_id = new System.Windows.Forms.TextBox();
            this.order_id = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.last = new System.Windows.Forms.Button();
            this.first = new System.Windows.Forms.Button();
            this.show_oder_details = new System.Windows.Forms.Button();
            this.dgOrderDetails = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.category_name = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.TextBox();
            this.dgCategories = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.tab_control.SuspendLayout();
            this.Orders.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDetails)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.Orders);
            this.tab_control.Controls.Add(this.tabPage2);
            this.tab_control.Controls.Add(this.tabPage1);
            this.tab_control.ItemSize = new System.Drawing.Size(100, 30);
            this.tab_control.Location = new System.Drawing.Point(12, 12);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(776, 426);
            this.tab_control.TabIndex = 0;
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.connect);
            this.Orders.Controls.Add(this.first);
            this.Orders.Controls.Add(this.prev);
            this.Orders.Controls.Add(this.exit);
            this.Orders.Controls.Add(this.last);
            this.Orders.Controls.Add(this.next);
            this.Orders.Controls.Add(this.show);
            this.Orders.Controls.Add(this.ship_country_lable);
            this.Orders.Controls.Add(this.ship_city_lable);
            this.Orders.Controls.Add(this.ship_name_lable);
            this.Orders.Controls.Add(this.customer_id_lable);
            this.Orders.Controls.Add(this.order_id_lable);
            this.Orders.Controls.Add(this.ship_country);
            this.Orders.Controls.Add(this.ship_city);
            this.Orders.Controls.Add(this.ship_name);
            this.Orders.Controls.Add(this.customer_id);
            this.Orders.Controls.Add(this.order_id);
            this.Orders.Location = new System.Drawing.Point(4, 34);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(3);
            this.Orders.Size = new System.Drawing.Size(768, 388);
            this.Orders.TabIndex = 0;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(6, 6);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 25);
            this.connect.TabIndex = 2;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(116, 162);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(75, 26);
            this.prev.TabIndex = 2;
            this.prev.Text = "Previous";
            this.prev.UseVisualStyleBackColor = true;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(87, 6);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 25);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(197, 162);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 26);
            this.next.TabIndex = 2;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.Silver;
            this.show.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show.Location = new System.Drawing.Point(402, 80);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 25);
            this.show.TabIndex = 2;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = false;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // ship_country_lable
            // 
            this.ship_country_lable.AutoSize = true;
            this.ship_country_lable.Location = new System.Drawing.Point(294, 227);
            this.ship_country_lable.Name = "ship_country_lable";
            this.ship_country_lable.Size = new System.Drawing.Size(87, 17);
            this.ship_country_lable.TabIndex = 1;
            this.ship_country_lable.Text = "Ship country";
            // 
            // ship_city_lable
            // 
            this.ship_city_lable.AutoSize = true;
            this.ship_city_lable.Location = new System.Drawing.Point(294, 199);
            this.ship_city_lable.Name = "ship_city_lable";
            this.ship_city_lable.Size = new System.Drawing.Size(61, 17);
            this.ship_city_lable.TabIndex = 1;
            this.ship_city_lable.Text = "Ship city";
            // 
            // ship_name_lable
            // 
            this.ship_name_lable.AutoSize = true;
            this.ship_name_lable.Location = new System.Drawing.Point(294, 171);
            this.ship_name_lable.Name = "ship_name_lable";
            this.ship_name_lable.Size = new System.Drawing.Size(75, 17);
            this.ship_name_lable.TabIndex = 1;
            this.ship_name_lable.Text = "Ship name";
            // 
            // customer_id_lable
            // 
            this.customer_id_lable.AutoSize = true;
            this.customer_id_lable.Location = new System.Drawing.Point(294, 143);
            this.customer_id_lable.Name = "customer_id_lable";
            this.customer_id_lable.Size = new System.Drawing.Size(85, 17);
            this.customer_id_lable.TabIndex = 1;
            this.customer_id_lable.Text = "Customer ID";
            // 
            // order_id_lable
            // 
            this.order_id_lable.AutoSize = true;
            this.order_id_lable.Location = new System.Drawing.Point(294, 114);
            this.order_id_lable.Name = "order_id_lable";
            this.order_id_lable.Size = new System.Drawing.Size(62, 17);
            this.order_id_lable.TabIndex = 1;
            this.order_id_lable.Text = "Order ID";
            // 
            // ship_country
            // 
            this.ship_country.Location = new System.Drawing.Point(402, 224);
            this.ship_country.Name = "ship_country";
            this.ship_country.Size = new System.Drawing.Size(217, 22);
            this.ship_country.TabIndex = 0;
            // 
            // ship_city
            // 
            this.ship_city.Location = new System.Drawing.Point(402, 196);
            this.ship_city.Name = "ship_city";
            this.ship_city.Size = new System.Drawing.Size(217, 22);
            this.ship_city.TabIndex = 0;
            // 
            // ship_name
            // 
            this.ship_name.Location = new System.Drawing.Point(402, 168);
            this.ship_name.Name = "ship_name";
            this.ship_name.Size = new System.Drawing.Size(217, 22);
            this.ship_name.TabIndex = 0;
            // 
            // customer_id
            // 
            this.customer_id.Location = new System.Drawing.Point(402, 140);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(217, 22);
            this.customer_id.TabIndex = 0;
            // 
            // order_id
            // 
            this.order_id.Location = new System.Drawing.Point(402, 111);
            this.order_id.Name = "order_id";
            this.order_id.Size = new System.Drawing.Size(217, 22);
            this.order_id.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgOrderDetails);
            this.tabPage2.Controls.Add(this.show_oder_details);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Order Details";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // last
            // 
            this.last.Location = new System.Drawing.Point(209, 194);
            this.last.Name = "last";
            this.last.Size = new System.Drawing.Size(49, 26);
            this.last.TabIndex = 2;
            this.last.Text = "Last";
            this.last.UseVisualStyleBackColor = true;
            this.last.Click += new System.EventHandler(this.last_Click);
            // 
            // first
            // 
            this.first.Location = new System.Drawing.Point(132, 194);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(45, 26);
            this.first.TabIndex = 2;
            this.first.Text = "First";
            this.first.UseVisualStyleBackColor = true;
            this.first.Click += new System.EventHandler(this.first_Click);
            // 
            // show_oder_details
            // 
            this.show_oder_details.Location = new System.Drawing.Point(6, 6);
            this.show_oder_details.Name = "show_oder_details";
            this.show_oder_details.Size = new System.Drawing.Size(75, 23);
            this.show_oder_details.TabIndex = 0;
            this.show_oder_details.Text = "Show";
            this.show_oder_details.UseVisualStyleBackColor = true;
            this.show_oder_details.Click += new System.EventHandler(this.show_oder_details_Click);
            // 
            // dgOrderDetails
            // 
            this.dgOrderDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOrderDetails.Location = new System.Drawing.Point(6, 35);
            this.dgOrderDetails.Name = "dgOrderDetails";
            this.dgOrderDetails.RowHeadersWidth = 51;
            this.dgOrderDetails.RowTemplate.Height = 24;
            this.dgOrderDetails.Size = new System.Drawing.Size(756, 347);
            this.dgOrderDetails.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.add);
            this.tabPage1.Controls.Add(this.dgCategories);
            this.tabPage1.Controls.Add(this.description);
            this.tabPage1.Controls.Add(this.category_name);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(768, 388);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Categories";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Description";
            // 
            // category_name
            // 
            this.category_name.Location = new System.Drawing.Point(362, 37);
            this.category_name.Name = "category_name";
            this.category_name.Size = new System.Drawing.Size(175, 22);
            this.category_name.TabIndex = 1;
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(362, 66);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(175, 22);
            this.description.TabIndex = 1;
            // 
            // dgCategories
            // 
            this.dgCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategories.Location = new System.Drawing.Point(3, 107);
            this.dgCategories.Name = "dgCategories";
            this.dgCategories.RowHeadersWidth = 51;
            this.dgCategories.RowTemplate.Height = 24;
            this.dgCategories.Size = new System.Drawing.Size(762, 278);
            this.dgCategories.TabIndex = 2;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(563, 64);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 3;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tab_control);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tab_control.ResumeLayout(false);
            this.Orders.ResumeLayout(false);
            this.Orders.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgOrderDetails)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategories)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage Orders;
        private System.Windows.Forms.Label order_id_lable;
        private System.Windows.Forms.TextBox order_id;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label customer_id_lable;
        private System.Windows.Forms.TextBox customer_id;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Label ship_country_lable;
        private System.Windows.Forms.Label ship_city_lable;
        private System.Windows.Forms.Label ship_name_lable;
        private System.Windows.Forms.TextBox ship_country;
        private System.Windows.Forms.TextBox ship_city;
        private System.Windows.Forms.TextBox ship_name;
        private System.Windows.Forms.Button first;
        private System.Windows.Forms.Button last;
        private System.Windows.Forms.DataGridView dgOrderDetails;
        private System.Windows.Forms.Button show_oder_details;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgCategories;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.TextBox category_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button add;
    }
}

