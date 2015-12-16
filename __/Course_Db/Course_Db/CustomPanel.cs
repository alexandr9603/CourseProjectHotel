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
using System.Globalization;

namespace Course_Db
{
    public partial class CustomPanel : Form
    {

        private MySqlConnection connection;
        private string connStr = "server=localhost; user = root ;database = hotel; port = 3306;password =;";
        Dictionary<string, int> listed = new Dictionary<string, int>();

        public CustomPanel()
        {
            InitializeComponent();
            Send.Hide();
            FreeInfo.Hide();
            ComfortInfo.Hide();
            Pass.Hide();
            Pass_field.Hide();
            Pledge.Hide();
            Pledge_field.Hide();
            Phone.Hide();
            Phone_field.Hide();
            Name.Hide();
            Name_Field.Hide();
            this.connection = new MySqlConnection(this.connStr);
            this.connection.Open();
            MySqlCommand com = new MySqlCommand("Select distinct Roominess FROM hotel where Free='+'", this.connection);
            MySqlDataReader reader; 
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                try
                {
                    string result = reader.GetString(0);
                    FreeInfo.Items.Add(result);
                    FreeInfo.Text = result;
                    listed.Add(reader.GetString(0), reader.GetInt32(1));
                }
                catch { }

            }

            this.connection.Close();

            this.connection.Open();

            MySqlCommand com2 = new MySqlCommand("Select distinct Comfort FROM hotel where Free='+'", this.connection);
            MySqlDataReader reader2;
            reader2 = com2.ExecuteReader();
            while (reader2.Read())
            {
                try
                {
                    string result = reader2.GetString(0);
                    ComfortInfo.Items.Add(result);
                    ComfortInfo.Text = result;
                    listed.Add(reader.GetString(0), reader.GetInt32(1));
                }
                catch { }

            }

            this.connection.Close();

        }

        private void CustomPanel_Load(object sender, EventArgs e)
        {
            UserPanel frm = (UserPanel)this.Owner;
            string [] test = frm.Data_func();
            string connStr = "server=localhost; user = root ;database = hotel; port = 3306;password =;";
            MySqlConnection connection;
            connection = new MySqlConnection(connStr);
            connection.Open();
            string check = "select * from hotel where Comfort = '"+ test[0] +"' and Roominess = '"+ test[1] +"' and Free='+';";
            MySqlCommand com = new MySqlCommand(check, connection);
            MySqlDataReader reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                    try
                    {
                        if (reader.HasRows)
                        {
                            connection.Close();
                            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(check, connection);
                            DataSet DS = new DataSet();
                            dataAdapter.Fill(DS);
                            Data_Field.DataSource = DS.Tables[0];
                        }
                        else
                        {
                            MySqlConnection connection1 = new MySqlConnection(connStr);
                            MessageBox.Show("Свободного номера с выбраными вами предпочтениями, к сожалению, сейчас нет. Попробуйте выбрать другой из свободных.");
                            FreeInfo.Show();
                            ComfortInfo.Show();
                            Data_Field.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
            }
            else
            {
                MessageBox.Show("Свободного номера с выбраными вами предпочтениями, к сожалению, сейчас нет. Попробуйте выбрать другой из свободных.");
                FreeInfo.Show();
                ComfortInfo.Show();
                Data_Field.Hide();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            FreeInfo.Hide();
            ComfortInfo.Hide();
            Data_Field.Hide();
            Pass.Show();
            Pass_field.Show();
            Pledge.Show();
            Pledge_field.Show();
            Phone.Show();
            Phone_field.Show();
            Name.Show();
            Name_Field.Show();
            Send.Show();
            OkButton.Hide();
        }

        private void Send_Click(object sender, EventArgs e)
        {
            string number1 = null;
            string number2 = null;
            int num = 0;
            int num2 = 0;
            int b = 0;
            MySqlConnection connection;
            string connStr = "server=localhost; user = root ;database = hotel; port = 3306;password =;";
            connection = new MySqlConnection(connStr);
            string read = "select Room_number, Price from hotel where Comfort = '" + ComfortInfo.Text + "' or Roominess = '" + FreeInfo.Text + "' and Free = '+'";
            connection.Open();
            MySqlCommand MyCommand1 = new MySqlCommand(read, connection);
            MySqlDataReader MyReader1 = MyCommand1.ExecuteReader();
            try
            {
                while (MyReader1.Read())
                {
                       number1 = MyReader1.GetString(0);
                       number2 = MyReader1.GetString(1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            num = Convert.ToInt32(number1);
            num2 = Convert.ToInt32(number2);

            connection.Close();

            MySqlConnection connection1 = new MySqlConnection(connStr);
            connection1.Open();
            string sql = "START TRANSACTION;";
            string sql2 = "insert into clients (Passport_number, Full_name, Phone_number, Date_of_settlement, Pledge, In_Hotel, Number_ID) values(" + Convert.ToInt32(Pass_field.Text) + ", '" + Name_Field.Text + "', " + Convert.ToInt32(Phone_field.Text) + " ,'"+ Convert.ToString(DateTime.Now) +"', '" + Pledge_field.Text + "', '+', " + num + ");";
            string sql3 = "update hotel set Free = '-' where Room_number = " + num + " ;";
            string sql7 = "select count(*) from custom";
            MySqlCommand MyCommand2 = new MySqlCommand(sql7, connection1);
            MySqlDataReader r = MyCommand2.ExecuteReader();
            while (r.Read())
            {
                b = r.GetInt32(0);
            }
            connection1.Close();
            MySqlConnection connection5 = new MySqlConnection(connStr);
            connection5.Open();
            string sql4 = "insert into custom (Number_of_custom, Comfort, Roominess, Price, Additional_services, Client_ID) values (" + (b+1) + ", '" + ComfortInfo.Text + "', '" + FreeInfo.Text + "', " + num2 + ", '-',  " + Convert.ToInt32(Pass_field.Text) + ");";
            string sql5 = "COMMIT;";
            string sql_all = sql + sql2 + sql3 + sql4 + sql5;
            MySqlCommand MyCommand = new MySqlCommand(sql_all, connection5);
            MyCommand.ExecuteNonQuery();
            MessageBox.Show("Ваш заказ успешно оформлен!");
            connection5.Close();
            this.Close();
        }

        private bool Validate_fields()
        {
            try
            {
                int i = Int32.Parse(Pass_field.Text);
                int a = Int32.Parse(Name_Field.Text);
                int b = Int32.Parse(Pledge_field.Text);
                int c = Int32.Parse(Phone_field.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            return true;
        }
    }
}
