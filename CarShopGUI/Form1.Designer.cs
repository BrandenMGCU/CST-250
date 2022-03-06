namespace CarShopGUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_create_car = new System.Windows.Forms.Button();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.txt_model = new System.Windows.Forms.TextBox();
            this.txt_make = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lst_inventory = new System.Windows.Forms.ListBox();
            this.btn_addtocart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lst_cart = new System.Windows.Forms.ListBox();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.cb_box_color = new System.Windows.Forms.ComboBox();
            this.cb_box = new System.Windows.Forms.Label();
            this.cb_box_condition = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.cb_box_year = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_box_year);
            this.groupBox1.Controls.Add(this.lbl_year);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cb_box_condition);
            this.groupBox1.Controls.Add(this.cb_box);
            this.groupBox1.Controls.Add(this.cb_box_color);
            this.groupBox1.Controls.Add(this.btn_reset);
            this.groupBox1.Controls.Add(this.btn_create_car);
            this.groupBox1.Controls.Add(this.txt_price);
            this.groupBox1.Controls.Add(this.txt_model);
            this.groupBox1.Controls.Add(this.txt_make);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 264);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create a Car:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btn_create_car
            // 
            this.btn_create_car.Location = new System.Drawing.Point(13, 235);
            this.btn_create_car.Name = "btn_create_car";
            this.btn_create_car.Size = new System.Drawing.Size(75, 23);
            this.btn_create_car.TabIndex = 6;
            this.btn_create_car.Text = "Create a Car";
            this.btn_create_car.UseVisualStyleBackColor = true;
            this.btn_create_car.Click += new System.EventHandler(this.btn_create_car_Click);
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(79, 82);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(100, 20);
            this.txt_price.TabIndex = 5;
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            // 
            // txt_model
            // 
            this.txt_model.Location = new System.Drawing.Point(79, 50);
            this.txt_model.Name = "txt_model";
            this.txt_model.Size = new System.Drawing.Size(100, 20);
            this.txt_model.TabIndex = 4;
            // 
            // txt_make
            // 
            this.txt_make.Location = new System.Drawing.Point(79, 20);
            this.txt_make.Name = "txt_make";
            this.txt_make.Size = new System.Drawing.Size(100, 20);
            this.txt_make.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Model";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lst_inventory);
            this.groupBox2.Location = new System.Drawing.Point(252, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 392);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Car Inventory:";
            // 
            // lst_inventory
            // 
            this.lst_inventory.FormattingEnabled = true;
            this.lst_inventory.Location = new System.Drawing.Point(0, 19);
            this.lst_inventory.Name = "lst_inventory";
            this.lst_inventory.Size = new System.Drawing.Size(246, 368);
            this.lst_inventory.TabIndex = 0;
            this.lst_inventory.SelectedIndexChanged += new System.EventHandler(this.lst_inventory_SelectedIndexChanged);
            // 
            // btn_addtocart
            // 
            this.btn_addtocart.Location = new System.Drawing.Point(510, 164);
            this.btn_addtocart.Name = "btn_addtocart";
            this.btn_addtocart.Size = new System.Drawing.Size(84, 23);
            this.btn_addtocart.TabIndex = 2;
            this.btn_addtocart.Text = "Add to Cart -->";
            this.btn_addtocart.UseVisualStyleBackColor = true;
            this.btn_addtocart.Click += new System.EventHandler(this.btn_addtocart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lst_cart);
            this.groupBox3.Location = new System.Drawing.Point(600, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(188, 323);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shopping Cart:";
            // 
            // lst_cart
            // 
            this.lst_cart.FormattingEnabled = true;
            this.lst_cart.Location = new System.Drawing.Point(6, 24);
            this.lst_cart.Name = "lst_cart";
            this.lst_cart.Size = new System.Drawing.Size(165, 290);
            this.lst_cart.TabIndex = 0;
            // 
            // btn_checkout
            // 
            this.btn_checkout.Location = new System.Drawing.Point(606, 359);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(75, 23);
            this.btn_checkout.TabIndex = 4;
            this.btn_checkout.Text = "Checkout";
            this.btn_checkout.UseVisualStyleBackColor = true;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(573, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total Cost:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Location = new System.Drawing.Point(631, 408);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(34, 13);
            this.lbl_total.TabIndex = 6;
            this.lbl_total.Text = "$0.00";
            this.lbl_total.Click += new System.EventHandler(this.lbl_total_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(104, 235);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // cb_box_color
            // 
            this.cb_box_color.FormattingEnabled = true;
            this.cb_box_color.Items.AddRange(new object[] {
            "Black",
            "White",
            "Red",
            "Blue",
            "Green",
            "Yellow",
            "Orange",
            "Purple",
            "Gray"});
            this.cb_box_color.Location = new System.Drawing.Point(79, 114);
            this.cb_box_color.Name = "cb_box_color";
            this.cb_box_color.Size = new System.Drawing.Size(100, 21);
            this.cb_box_color.TabIndex = 8;
            this.cb_box_color.SelectedIndexChanged += new System.EventHandler(this.cb_box_color_SelectedIndexChanged);
            // 
            // cb_box
            // 
            this.cb_box.AutoSize = true;
            this.cb_box.Location = new System.Drawing.Point(13, 114);
            this.cb_box.Name = "cb_box";
            this.cb_box.Size = new System.Drawing.Size(31, 13);
            this.cb_box.TabIndex = 9;
            this.cb_box.Text = "Color";
            // 
            // cb_box_condition
            // 
            this.cb_box_condition.FormattingEnabled = true;
            this.cb_box_condition.Items.AddRange(new object[] {
            "New",
            "Used"});
            this.cb_box_condition.Location = new System.Drawing.Point(79, 154);
            this.cb_box_condition.Name = "cb_box_condition";
            this.cb_box_condition.Size = new System.Drawing.Size(100, 21);
            this.cb_box_condition.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Condition";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(16, 194);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(29, 13);
            this.lbl_year.TabIndex = 12;
            this.lbl_year.Text = "Year";
            // 
            // cb_box_year
            // 
            this.cb_box_year.FormattingEnabled = true;
            this.cb_box_year.Items.AddRange(new object[] {
            "2022",
            "2021",
            "2020",
            "2019",
            "2018"});
            this.cb_box_year.Location = new System.Drawing.Point(79, 194);
            this.cb_box_year.Name = "cb_box_year";
            this.cb_box_year.Size = new System.Drawing.Size(100, 21);
            this.cb_box_year.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_checkout);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_addtocart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Activity 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_create_car;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.TextBox txt_model;
        private System.Windows.Forms.TextBox txt_make;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lst_inventory;
        private System.Windows.Forms.Button btn_addtocart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lst_cart;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_box_condition;
        private System.Windows.Forms.Label cb_box;
        private System.Windows.Forms.ComboBox cb_box_color;
        private System.Windows.Forms.ComboBox cb_box_year;
        private System.Windows.Forms.Label lbl_year;
    }
}

