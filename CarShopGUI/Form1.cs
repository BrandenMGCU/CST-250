/* Branden M.
 * CST-250
 * Grand Canyon University
 * 03/06/22
 */


using CarClassLibraryWorking;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace CarShopGUI
{
    public partial class Form1 : Form
    {
        Store myStore = new Store();
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_create_car_Click(object sender, EventArgs e)
        {
            Car c = new Car(txt_make.Text, txt_model.Text, decimal.Parse(txt_price.Text), cb_box_color.Text, cb_box_condition.Text, cb_box_year.Text); //When we made the default car constructor with only 3 things they were, the make, model and the price.
           // MessageBox.Show(c.ToString());
           myStore.CarList.Add(c); // This will create the car list
            carInventoryBindingSource.ResetBindings(false);

            txt_make.Text = "";
            txt_model.Text = "";
            txt_price.Text = "";
            cb_box_color.Text = cb_box_color.SelectedItem.ToString();
            cb_box_year.Text =  cb_box_year.SelectedItem.ToString();
            cb_box_color.SelectedIndex = -1;
            cb_box_condition.SelectedIndex = -1;
            cb_box_year.SelectedIndex = -1;
            

        }

        private void btn_addtocart_Click(object sender, EventArgs e)
        {
            // Move the selected item from the inventory list box to the checkout box
            Car selected = (Car) lst_inventory.SelectedItem; //(Car) is a casting and says that it will be a car
            myStore.ShoppingList.Add(selected); // This will add the selected item to the checkout cart

            cartBindingSource.ResetBindings(false); // We're not changing anything in this source, that is why it is false

            carInventoryBindingSource.Clear(); // This will clear out the car inventory box when the user clicks add to cart

        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            // This will truly checkout

            //Total Price
            decimal total = myStore.Checkout(); // This will allow us to have a real checkout number with change

            // This will tell us the total underneath checkout and will add a $ to it as well
            lbl_total.Text = "$" + total.ToString();

            cartBindingSource.ResetBindings(false); // This should clear the cart after checkout

            MessageBox.Show("Your total is: " + lbl_total.Text);
            
            lbl_total.Text = txt_price.Text;

           
            cb_box_color.SelectedIndex = -1;
            cb_box_condition.SelectedIndex = -1;
            cb_box_year.SelectedIndex = -1;
            lst_inventory.DataBindings.Clear();
               
        }

        private void lst_inventory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           carInventoryBindingSource.DataSource = myStore.CarList; // This will connect the car inventory to the car list

            cartBindingSource.DataSource = myStore.ShoppingList;

            lst_inventory.DataSource = carInventoryBindingSource;
            lst_inventory.DisplayMember = ToString(); // This will display the data from the inventory to some text

            lst_cart.DataSource = cartBindingSource;
            lst_cart.DisplayMember = ToString(); // This will display the data from the cart to some text
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_make.Text = "";
            txt_model.Text = "";
            txt_price.Text = "";
        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb_box_color_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }
    }
}
