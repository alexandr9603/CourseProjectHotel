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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Try_Click(object sender, EventArgs e)
        {
            MySqlConnection connection;
            string connStr = "server=localhost; user = root ;database = hotel; port = 3306;password =;";
            connection = new MySqlConnection(connStr);
            connection.Open();
            try
            {
                string text = Password.Text;
                string Query = "select id from authorize where PASS = '" + text +"';";
                MySqlCommand MyCommand = new MySqlCommand(Query, connection);
                MySqlDataReader MyReader = MyCommand.ExecuteReader();
                if (MyReader.HasRows)
                {
                    while (MyReader.Read())
                        MessageBox.Show("Привет! Ваш ID в системе работников нашего отеля =" + MyReader.GetInt32(0) + "!");
                    this.Close();
                    ControlPanel ControlForm = new ControlPanel();
                    ControlForm.Show();
                }
                else
                    MessageBox.Show("Извините, по указанному уникальному паролю не был найден ни один сотрудник! Попробуйте еще раз или покиньте данную страницу.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close(); 
        }
    }
}
