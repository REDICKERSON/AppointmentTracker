using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robert_Dickerson___InventorySystem
{
    public partial class DBTest : Form
    {
        
        public string connectionString;
        public string dbQuery;

        string dbName = "Robert_Dickerson___InventorySystem.Properties.Settings.client_scheduleConnectionString";
        public DBTest()
        {
            InitializeComponent();
            DBDVG1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DBDVG1.DefaultCellStyle.SelectionBackColor = DBDVG1.DefaultCellStyle.BackColor;
            DBDVG1.DefaultCellStyle.SelectionForeColor = DBDVG1.DefaultCellStyle.ForeColor;

            string connectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;

            MySqlConnection conToMySQL = new MySqlConnection(connectionString);
            conToMySQL.Open();
            MySqlCommand cmdToMySQL = new MySqlCommand("SELECT * FROM customer", conToMySQL);
            MySqlDataAdapter adaptToMySQL = new MySqlDataAdapter(selectCommand: cmdToMySQL);

            DataTable dataTable = new DataTable();
            dataTable.Load(cmdToMySQL.ExecuteReader());
            DBDVG1.DataSource = dataTable;

        }

        private void DBTest_Load(object sender, EventArgs e)
        {

        }

        private void DBDVG1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
