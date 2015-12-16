using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using MySql.Data.MySqlClient;


namespace Course_Db
{
    public partial class ControlPanel : Form
    {
        private MySqlConnection connection;
        private string connStr = "server=localhost; user = root ;database = hotel; port = 3306;password =;";
        Dictionary<string, int> listed = new Dictionary<string, int>();
        public ControlPanel()

        {
            InitializeComponent();
            this.connection = new MySqlConnection(this.connStr);
            this.connection.Open();
            MySqlCommand com = new MySqlCommand("Select Passport_Number, Full_name FROM clients", this.connection);

            MySqlDataReader reader;
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    string result = reader.GetString(1);
                    Delete.Items.Add(result);
                    Delete.Text = result;
                    listed.Add(reader.GetString(1), reader.GetInt32(0));
                }
                catch { }

            }

            this.connection.Close();

            this.connection = new MySqlConnection(this.connStr);
            this.connection.Open();
            MySqlCommand connect_to_pay = new MySqlCommand("Select Passport_Number, Full_name FROM clients WHERE In_hotel = '+'", this.connection);

            MySqlDataReader reader_2;
            reader_2 = connect_to_pay.ExecuteReader();
            while (reader_2.Read())
            {
                try
                {
                    string result = reader_2.GetString(1);
                    Payment_field.Items.Add(result);
                    Payment_field.Text = result;
                    listed.Add(reader.GetString(1), reader.GetInt32(0));
                }
                catch { }

            }

            this.connection.Close();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            MySqlConnection connection;
            string connStr = "server=localhost; user = root ;database = hotel; port = 3306;password =;";
            connection = new MySqlConnection(connStr);
            connection.Open();
            try
            {
                string Query = "select count(*) from hotel where Free ='+';";
                MySqlCommand MyCommand = new MySqlCommand(Query, connection);
                MySqlDataReader MyReader = MyCommand.ExecuteReader();
                while (MyReader.Read())
                     Clients_Info.Text = "На данный момент в отеле проживает "+ (MyReader.GetInt32(0)-1) + " клиентa(ов).";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close(); 
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowInfo_Click(object sender, EventArgs e)
        {
      
                MySqlConnection connection;
                string connStr = "server=localhost; user = root ;database = hotel; port = 3306;password =;Convert Zero Datetime=True; Allow Zero Datetime=True;";
                connection = new MySqlConnection(connStr);
                string sql = "select * from clients"; 
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection); 
                DataSet DS = new DataSet(); 
                dataAdapter.Fill(DS);
                Field_to_show_data.DataSource = DS.Tables[0];
 
        }

        private void Raise_Price_Click(object sender, EventArgs e)
        {
  
                MySqlConnection connection;
                string connStr = "server=localhost; user = root ;database = hotel; port = 3306;password =; Convert Zero Datetime=True; Allow Zero Datetime=True;";
                string tmp = Price_raise.Text;
                double percent = Convert.ToDouble(tmp);
                connection = new MySqlConnection(connStr);
                connection.Open();
                string sql = "update hotel set Price = "+percent+"*Price/100 + Price";
                MySqlCommand MyCommand = new MySqlCommand(sql, connection);
                MyCommand.ExecuteNonQuery();
                string sql2 = "select Room_number, Comfort, Price from hotel";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql2, connection);
                DataSet DS = new DataSet();
                dataAdapter.Fill(DS);
                Field_to_show_data.DataSource = DS.Tables[0];
                connection.Close();

        }

        private void Delete_client_Click(object sender, EventArgs e)
        {
 
                MySqlConnection connection;
                string connStr = "server=localhost; user = root ;database = hotel; port = 3306;password =; Convert Zero Datetime=True; Allow Zero Datetime=True;";
                connection = new MySqlConnection(connStr);
                connection.Open();
                string sql = "START TRANSACTION; update hotel left join clients on hotel.Room_number = clients.Number_ID set hotel.Free= '+' where clients.Full_name = '" + Delete.Text + "'; delete custom, clients from custom inner join clients on custom.Client_ID = clients.Passport_number where clients.Full_name = '" + Delete.Text + "'; COMMIT;";
                MySqlCommand MyCommand = new MySqlCommand(sql, connection);
                MyCommand.ExecuteNonQuery();
                string sql2 = "select * from clients";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql2, connection);
                DataSet DS = new DataSet();
                dataAdapter.Fill(DS);
                Field_to_show_data.DataSource = DS.Tables[0];
                MessageBox.Show("Пользователь успешно удален!");
                connection.Close();

        }

        private void Pay_button_Click(object sender, EventArgs e)
        {
      
                int price = 0;
                int id = 0;
                int b = 0;
                MySqlConnection connection2;
                string connStr = "server=localhost; user = root ;database = hotel; port = 3306;password =;";
                connection2 = new MySqlConnection(connStr);
                connection2.Open();
                try
                {
                    string Query = "select count(*) from bills;";
                    MySqlCommand MyCommand = new MySqlCommand(Query, connection2);
                    MySqlDataReader MyReader = MyCommand.ExecuteReader();
                    while (MyReader.Read())
                    {
                        b = Convert.ToInt32(MyReader.GetString(0)) + 1;
                        MessageBox.Show(MyReader.GetString(0));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection2.Close();
                MySqlConnection connection;
                connection = new MySqlConnection(connStr);
                connection.Open();
                try
                {
                    string Query = "select Price, Number_of_custom from custom left join clients on custom.Client_ID = clients.Passport_number where Full_name = '" + Payment_field.Text + "';";
                    MySqlCommand MyCommand = new MySqlCommand(Query, connection);
                    MySqlDataReader MyReader = MyCommand.ExecuteReader();
                    while (MyReader.Read())
                    {
                        price = MyReader.GetInt32(0);
                        id = MyReader.GetInt32(1);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                connection.Close();

                MySqlConnection connection1;
                connection1 = new MySqlConnection(connStr);
                connection1.Open();
                string sql = "insert into bills (ID, Payment_amount, Bank_name, Date_of_leaving, Custom_ID, Paid) values(" + b + ", " + price + ", 'Приват Банк', '" + Convert.ToString(DateTime.Now) + "', " + id + ", '+')";
                MySqlCommand MyCommand2 = new MySqlCommand(sql, connection1);
                MyCommand2.ExecuteNonQuery();
                connection1.Close();
                MessageBox.Show("Оплата произведена успешно, счет добавлен.");

        }

        private void MonthWork_Click(object sender, EventArgs e)
        {
                MySqlConnection connection;
                string connStr = "server=localhost; user = root ;database = hotel; port = 3306;password =; Convert Zero Datetime=True; Allow Zero Datetime=True;";
                connection = new MySqlConnection(connStr);
                string sql = "select Full_name as Owner, Pledge from clients";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql, connection);
                DataSet DS = new DataSet();
                dataAdapter.Fill(DS);
                Field_to_show_data.DataSource = DS.Tables[0];

        }

        private void MonthBill_Click(object sender, EventArgs e)
        {
                  MySqlConnection connection;
                string connStr = "server=localhost; user = root ;database = hotel; port = 3306;password =; Convert Zero Datetime=True; Allow Zero Datetime=True;";
                connection = new MySqlConnection(connStr);
                string sql2 = "select count(*) as Clients_amount, sum(Payment_amount) as Gains_for_month, min(Payment_amount) as Minimum_bill, max(Payment_amount) as Maximum_bill from bills";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sql2, connection);
                DataSet DS = new DataSet();
                dataAdapter.Fill(DS);
                Field_to_show_data.DataSource = DS.Tables[0];

        }


    }
}
