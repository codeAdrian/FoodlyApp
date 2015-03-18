using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using MySql.Data.MySqlClient;
using MySql.Data;

namespace FoodlyApp
{
    public partial class rtbx_address : Form
    {
        Form loginStr = new Form();
        string restaurant_name;
        PictureBox[] array = new PictureBox[20];
        public rtbx_address(Form login, string restaurantName)
        {
            restaurant_name = restaurantName;
            InitializeComponent();
            loginStr = login;
            this.Text = "Foodly - restaurant: " + restaurantName;
            lv_orders.View = View.Details;
            lv_orders.CheckBoxes = true;
            lv_orders.GridLines = true;
            lv_orders.FullRowSelect = true;
            lv_orders.Scrollable = true;
            lv_orders.SuspendLayout();
            lv_orders.Columns.Add("ID", 40, HorizontalAlignment.Center); //0
            lv_orders.Columns.Add("Date", 70, HorizontalAlignment.Center);//1
            lv_orders.Columns.Add("Time", 50, HorizontalAlignment.Center);//2
            lv_orders.Columns.Add("Customer", 80, HorizontalAlignment.Center);//3
            lv_orders.Columns.Add("Item", 80, HorizontalAlignment.Center);//4
            lv_orders.Columns.Add("ID code", 80, HorizontalAlignment.Center);//5
            lv_orders.Columns.Add("Quantity", 80, HorizontalAlignment.Center);//6
            lv_orders.Columns.Add("Price", 80, HorizontalAlignment.Center);//7
            lv_orders.Columns.Add("Size", 80, HorizontalAlignment.Center);//8
            lv_orders.Columns.Add("Address", 100, HorizontalAlignment.Center);//09
            lv_orders.Columns.Add("Phone Number", 80, HorizontalAlignment.Center);//10
            lv_orders.Columns.Add("Processed", 80, HorizontalAlignment.Center);//11
            
            lv_receipt.View = View.Details;
            lv_receipt.GridLines = true;
            lv_receipt.FullRowSelect = true;
            lv_receipt.Scrollable = true;
            lv_receipt.SuspendLayout();
            lv_receipt.Columns.Add("#", 30, HorizontalAlignment.Center);//4
            lv_receipt.Columns.Add("Item", 110, HorizontalAlignment.Center);//4
            lv_receipt.Columns.Add("ID code", 110, HorizontalAlignment.Center);//5
            lv_receipt.Columns.Add("Quantity", 80, HorizontalAlignment.Center);//6
            lv_receipt.Columns.Add("Size", 70, HorizontalAlignment.Center);//8
            lv_receipt.Columns.Add("Price", 70, HorizontalAlignment.Center);//7
        }

        private void b_mainLoad_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                //pbx_loading.Image = Images.intro_animation;
            }).Start();

            //btn_ucitajNarudzbe.Enabled = false;
            new Thread(() =>
            {
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    //Thread.Sleep(2000); //Pauza radi efekta
                    int rows = 0;
                    MySqlCommand command = new MySqlCommand();
                    string mySqlConnection = "SERVER=localhost;DATABASE=foodly;UID=root;PASSWORD=;";
                    try
                    {
                        using (MySqlConnection connect = new MySqlConnection(mySqlConnection))
                        {
                            connect.Open();
                            command = connect.CreateCommand();
                            command.CommandText = "SELECT* FROM narudzbe WHERE restaurant='" + restaurant_name + "';";
                            command.ExecuteNonQuery();
                            lv_orders.Items.Clear();
                            MySqlDataReader dr = command.ExecuteReader();
                            while (dr.Read())
                            {
                                rows++;
                                ListViewItem Item = new ListViewItem();
                                string[] row = { dr["date"].ToString(), dr["time"].ToString(), dr["firstName"].ToString()+ " " + dr["lastName"].ToString(), dr["item"].ToString(), dr["IDcode"].ToString(), dr["quantity"].ToString(), dr["price"].ToString(), dr["size"].ToString(), dr["address"].ToString(), dr["phoneNumber"].ToString(), dr["processed"].ToString()};
                                lv_orders.Items.Add(rows.ToString()).SubItems.AddRange(row);
                            }
                            string customer_temp=lv_orders.Items[0].SubItems[3].Text.ToString();
                            Color[] colorSet = new Color[2];
                            colorSet[0] = Color.Yellow; colorSet[1] = Color.Gold;
                            int colorIndex = 0;
                            foreach (ListViewItem item in lv_orders.Items)
                            {
                                if (item.SubItems[3].Text == customer_temp)
                                {
                                    item.BackColor = colorSet[colorIndex];
                                }

                                else
                                {
                                    if (colorIndex < colorSet.Length-1) colorIndex++;
                                    else colorIndex=0;
                                    item.BackColor = colorSet[colorIndex];
                                    customer_temp = item.SubItems[3].Text.ToString();
                                }
                                if (item.SubItems[11].Text == "True") { item.Checked = true; item.BackColor = Color.Orange; }
                            }
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error while connecting to the database", "Error");
                        loginStr.Show();
                        this.Close();
                    }
                }
            }).Start();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            loginStr.Show();
            this.Close();
        }

        private void lv_orders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_orders.SelectedItems.Count == 0)return;
            ListViewItem item = lv_orders.SelectedItems[0];
            tbx_nameSurename.Text = item.SubItems[3].Text.ToString();
            rtb_address.Text = item.SubItems[9].Text.ToString();
            tbx_phone.Text = item.SubItems[10].Text.ToString();

            string t_customer=item.SubItems[3].Text.ToString();
            string t_date = item.SubItems[1].Text.ToString();
            string t_time = item.SubItems[2].Text.ToString();
            int rows = 0;
            lv_receipt.Items.Clear();
            float totalPrice = 0;
            foreach (ListViewItem customer in lv_orders.Items)
            {
                if(customer.SubItems[1].Text==t_date && customer.SubItems[2].Text==t_time && customer.SubItems[3].Text==t_customer)
                {
                    rows++;
                    string[] row = { customer.SubItems[4].Text, customer.SubItems[5].Text, customer.SubItems[6].Text, customer.SubItems[8].Text, customer.SubItems[7].Text };
                    lv_receipt.Items.Add(rows.ToString()).SubItems.AddRange(row);
                    totalPrice += float.Parse(customer.SubItems[7].Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat) * float.Parse(customer.SubItems[6].Text, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
                }
            }
            lbl_totalPrice.Text = totalPrice.ToString("F")+" kn";
        }
    }
}
