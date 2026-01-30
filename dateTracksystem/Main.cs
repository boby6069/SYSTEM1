using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlconnector = MySql.Data.MySqlClient;
namespace dateTracksystem
{



    public partial class Main : Form
    {



        public Main()
        {
            InitializeComponent();
        }

        private void databaseConnection()
        {
            string connStr = "Server=localhost;Database=librarymanagement;Uid=root;Pwd=;";

            try
            {
                using (MySqlConnection con = new MySqlConnection(connStr))
                {
                    con.Open();
                    MessageBox.Show("Connected to MySQL!");
                    con.Close();
                    string query = "SELECT Title FROM books";
                    using (MySqlCommand cmd = new MySqlCommand(query, con))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Example: read column values
                                string title = reader["title"].ToString();

                                // Show or store results
                                // Console.WriteLine($"{title} by {author}");
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in flowLayoutPanel1.Controls)
            {
                if (ctrl is UCbook1)
                {
                    flowLayoutPanel1.Controls.Remove(ctrl);
                    ctrl.Dispose();
                }
            }
                    UCbook1 uc = new UCbook1();
                    flowLayoutPanel1.Controls.Add(uc);
                
            }
        }
    }

