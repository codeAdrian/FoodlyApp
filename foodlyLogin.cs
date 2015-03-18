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
    public partial class foodlyLogin : Form
    {
        public foodlyLogin()
        {
            InitializeComponent();
        }

        private void b_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Application.ExitThread();
        }

        private void b_login_Click(object sender, EventArgs e)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                pbx_loginLoading.Image = foodlyImages.intro_animation;
            }).Start();

            new Thread(() =>
            {
                tbx_username.Enabled = false;
                tbx_password.Enabled = false;
                if (System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
                {
                    MySqlCommand command = new MySqlCommand();
                    string mySqlConnection = "SERVER=localhost;DATABASE=users_login_data;UID=root;PASSWORD=;";
                    try
                    {
                        using (MySqlConnection connection = new MySqlConnection(mySqlConnection))
                        {
                            connection.Open();
                            command = connection.CreateCommand();
                            command.CommandText = "SELECT* FROM restaurants WHERE foodly_username='" + tbx_username.Text.ToString() + "'AND foodly_password='" + tbx_password.Text.ToString() + "';";
                            command.ExecuteNonQuery();
                            MySqlDataReader reader = command.ExecuteReader();
                            int users = 0;
                            string restaurantSQL="";
                            while (reader.Read()){users++;
                            restaurantSQL = reader.GetString(3);
                            }
                            connection.Close();
                            Thread.Sleep(500);
                            if (users == 1)
                            {
                                rtbx_address foodly_main = new rtbx_address(this,restaurantSQL);
                                tbx_username.Enabled = true;
                                tbx_password.Enabled = true;
                                pbx_loginLoading.Image = null;
                                this.Hide();
                                foodly_main.ShowDialog();
                                this.Show();
                            }

                            else
                            {
                                tbx_username.Enabled = true;
                                tbx_password.Enabled = true;
                                pbx_loginLoading.Image = null;
                                lbl_instructions.Text = "Wrong username or \npassword. Try again.";
                            }
                        }
                    }
                    catch (Exception)
                    {
                       lbl_instructions.Text = "Unable to connect to\nthe Foodly database.";
                       tbx_username.Enabled = true;
                        tbx_password.Enabled = true;
                        pbx_loginLoading.Image=null;
                    }
                }

                else
                {
                    lbl_instructions.Text = "No internet connection\n available.";
                }

            }).Start();

        }
    }
}
