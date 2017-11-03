using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DP_Sample01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            string connStr = "Server=localhost;UID=root;Password=;database=products;Port=3306";

            MySqlConnection conn = new MySqlConnection(connStr);
            MySqlCommand command = new MySqlCommand("select CategoryId, CategoryName, Description from Categories", conn);
            try
            {
                conn.Open();
                MySqlDataReader reader = command.ExecuteReader();
                this.DisplayCategories(reader);
                conn.Close();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void DisplayCategories(MySqlDataReader reader) {
            lvwCategory.Items.Clear();

            while (reader.Read())
            {
                string[] row = { reader.GetString("CategoryId"), reader.GetString("CategoryName"), reader.GetString("Description") };
                var item = new ListViewItem(row);
                lvwCategory.Items.Add(item);
            }
        }
    }
}
