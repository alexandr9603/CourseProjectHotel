using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Course_Db
{
    public partial class UserPanel : Form
    {
        private MySqlConnection connection;
        private string connStr = "server=localhost; user = root ;database = hotel; port = 3306;password =;";
        Dictionary<string, int> listed = new Dictionary<string, int>();

        public UserPanel()
        {
            InitializeComponent();
            this.connection = new MySqlConnection(this.connStr);
            this.connection.Open();
            MySqlCommand com = new MySqlCommand("Select distinct comfort FROM hotel", this.connection);
            MySqlDataReader reader;            reader = com.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    string result = reader.GetString(0);
                    Choose_Comfort.Items.Add(result);
                    Choose_Comfort.Text = result;
                    listed.Add(reader.GetString(1), reader.GetInt32(0));
                }
                catch { }

            }

            this.connection.Close();

            this.connection = new MySqlConnection(this.connStr);
            this.connection.Open();
            MySqlCommand connect_to_pay = new MySqlCommand("Select distinct roominess from hotel",  this.connection);

            MySqlDataReader reader_2;
            reader_2 = connect_to_pay.ExecuteReader();
            while (reader_2.Read())
            {
                try
                {
                    string result = reader_2.GetString(0);
                    Choose_roominess.Items.Add(result);
                    Choose_roominess.Text = result;
                    listed.Add(reader.GetString(1), reader.GetInt32(0));
                }
                catch { }

            }

            this.connection.Close();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserPanel_Load(object sender, EventArgs e)
        {

        }

        private void Send_Click(object sender, EventArgs e)
        {
            CustomPanel f = new CustomPanel();
            f.Owner = this;
            f.Show();
        }

        public string[] Data_func()
        {
            string[] text = new string[2];
            text[0] = Choose_Comfort.Text;
            text[1] = Choose_roominess.Text;
            return text;
        }
    }
}
