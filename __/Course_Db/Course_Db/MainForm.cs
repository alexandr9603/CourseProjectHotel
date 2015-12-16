using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using MySql.Data.MySqlClient;


namespace Course_Db
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void GoToAdminPanel_Click(object sender, EventArgs e)
        {
            AdminPanel f = new AdminPanel();
            f.Show();
        }

        private void MakeCustom_Click(object sender, EventArgs e)
        {
            UserPanel f = new UserPanel();
            f.Show();
        }

        private void Exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

    }
}
