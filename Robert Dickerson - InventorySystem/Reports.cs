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
    public partial class Reports : Form
    {
        public static string dbName = "Robert_Dickerson___InventorySystem.Properties.Settings.client_scheduleConnectionString";
        public static int totalNumAppts;


        public Reports()
        {
            InitializeComponent();
            string connectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;

            MySqlConnection conToMySQL = new MySqlConnection(connectionString);
            conToMySQL.Open();
            MySqlCommand cmdForApptReport = new MySqlCommand($"Select * FROM appointment WHERE userId = '{LogInScreen.currentUserId}'", conToMySQL);
            MySqlDataAdapter adapterForApptReport = new MySqlDataAdapter(cmdForApptReport);
            DataTable dataTable = new DataTable();
            adapterForApptReport.Fill(dataTable);
            consultantScheduleDGV.DataSource = dataTable;

            totalNumAppts = dataTable.Rows.Count;
            totalNumApptsTextBox.Text = $"Report: Total number of appointments for:\r\n\r\n"+
                $"UserID: {LogInScreen.currentUserId} \r\n\r\n" +
                $"Username: {LogInScreen.currentUserName}\r\n\r\n"+
                $"Total Appointments: {totalNumAppts}";

            monthlyApptTypesReportTextBox.Text = "Report: Number of appointments by Month and Type\r\n\r\n";
            string[] stringOfMonths = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            
            foreach (string month in stringOfMonths)
            {
                monthlyApptTypesReportTextBox.Text = monthlyApptTypesReportTextBox.Text + month + "\r\n";
                int numOfScrum = 0;
                int numOfPresentation = 0;
                int numOfMeeting = 0;

                foreach (DataRow dataRow in dataTable.Rows)
                {
                    if(month != null)
                    {
                        if (month == stringOfMonths[((DateTime)dataRow["start"]).Month - 1])
                        {
                            if (dataRow["type"].ToString() == "Scrum")
                            {
                                numOfScrum++;
                            }
                            if (dataRow["type"].ToString() == "Presentation")
                            {
                                numOfPresentation++;
                            }
                            if (dataRow["type"].ToString() == "Meeting")
                            {
                                numOfMeeting++;
                            }
                        }
                    }
                }
                monthlyApptTypesReportTextBox.Text = monthlyApptTypesReportTextBox.Text +
                    "\tScrum\t\t" + numOfScrum + "\r\n" +
                    "\tPresentation\t" + numOfPresentation + "\r\n" +
                    "\tMeeting\t\t" + numOfMeeting + "\r\n";
                monthlyApptTypesReportTextBox.Select(0, 0);
            }

        }

        private void Reports_Load(object sender, EventArgs e)
        {

        }

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Close();
            Mainscreen.dataGridView.ClearSelection();
            Mainscreen.dataGridView2.ClearSelection();

        }
    }
}
