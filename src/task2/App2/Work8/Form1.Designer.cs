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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Orders = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.order_id = new System.Windows.Forms.Label();
            this.customer_id = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ship_name = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.ship_city = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.ship_country = new System.Windows.Forms.Label();
            this.show = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.connect = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Orders.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Orders);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 30);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // Orders
            // 
            this.Orders.Controls.Add(this.connect);
            this.Orders.Controls.Add(this.prev);
            this.Orders.Controls.Add(this.exit);
            this.Orders.Controls.Add(this.next);
            this.Orders.Controls.Add(this.show);
            this.Orders.Controls.Add(this.ship_country);
            this.Orders.Controls.Add(this.ship_city);
            this.Orders.Controls.Add(this.ship_name);
            this.Orders.Controls.Add(this.customer_id);
            this.Orders.Controls.Add(this.order_id);
            this.Orders.Controls.Add(this.textBox5);
            this.Orders.Controls.Add(this.textBox4);
            this.Orders.Controls.Add(this.textBox3);
            this.Orders.Controls.Add(this.textBox2);
            this.Orders.Controls.Add(this.textBox1);
            this.Orders.Location = new System.Drawing.Point(4, 34);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(3);
            this.Orders.Size = new System.Drawing.Size(768, 388);
            this.Orders.TabIndex = 0;
            this.Orders.Text = "Orders";
            this.Orders.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 388);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(327, 111);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 22);
            this.textBox1.TabIndex = 0;
            // 
            // order_id
            // 
            this.order_id.AutoSize = true;
            this.order_id.Location = new System.Drawing.Point(219, 114);
            this.order_id.Name = "order_id";
            this.order_id.Size = new System.Drawing.Size(62, 17);
            this.order_id.TabIndex = 1;
            this.order_id.Text = "Order ID";
            // 
            // customer_id
            // 
            this.customer_id.AutoSize = true;
            this.customer_id.Location = new System.Drawing.Point(219, 143);
            this.customer_id.Name = "customer_id";
            this.customer_id.Size = new System.Drawing.Size(85, 17);
            this.customer_id.TabIndex = 1;
            this.customer_id.Text = "Customer ID";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(327, 140);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 22);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(327, 168);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(217, 22);
            this.textBox3.TabIndex = 0;
            // 
            // ship_name
            // 
            this.ship_name.AutoSize = true;
            this.ship_name.Location = new System.Drawing.Point(219, 171);
            this.ship_name.Name = "ship_name";
            this.ship_name.Size = new System.Drawing.Size(75, 17);
            this.ship_name.TabIndex = 1;
            this.ship_name.Text = "Ship name";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(327, 196);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(217, 22);
            this.textBox4.TabIndex = 0;
            // 
            // ship_city
            // 
            this.ship_city.AutoSize = true;
            this.ship_city.Location = new System.Drawing.Point(219, 199);
            this.ship_city.Name = "ship_city";
            this.ship_city.Size = new System.Drawing.Size(61, 17);
            this.ship_city.TabIndex = 1;
            this.ship_city.Text = "Ship city";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(327, 224);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(217, 22);
            this.textBox5.TabIndex = 0;
            // 
            // ship_country
            // 
            this.ship_country.AutoSize = true;
            this.ship_country.Location = new System.Drawing.Point(219, 227);
            this.ship_country.Name = "ship_country";
            this.ship_country.Size = new System.Drawing.Size(87, 17);
            this.ship_country.TabIndex = 1;
            this.ship_country.Text = "Ship country";
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.Color.Silver;
            this.show.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.show.Location = new System.Drawing.Point(81, 151);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 25);
            this.show.TabIndex = 2;
            this.show.Text = "Show";
            this.show.UseVisualStyleBackColor = false;
            // 
            // prev
            // 
            this.prev.Location = new System.Drawing.Point(41, 180);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(75, 25);
            this.prev.TabIndex = 2;
            this.prev.Text = "Previous";
            this.prev.UseVisualStyleBackColor = true;
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(122, 180);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 25);
            this.next.TabIndex = 2;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(655, 168);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 25);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(574, 168);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(75, 25);
            this.connect.TabIndex = 2;
            this.connect.Text = "Connect";
            this.connect.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.Orders.ResumeLayout(false);
            this.Orders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Orders;
        private System.Windows.Forms.Label order_id;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label customer_id;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button connect;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Label ship_country;
        private System.Windows.Forms.Label ship_city;
        private System.Windows.Forms.Label ship_name;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
    }
}

