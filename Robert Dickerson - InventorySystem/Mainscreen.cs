using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Robert_Dickerson___InventorySystem
{
    public partial class Mainscreen : Form
    {
        public delegate void DataGridViewCellEventHandler();
        public object DataGridView { get; private set; }
        
        public static int currentIndex;
        public static int currentCustomerIndex = -1;
        public static string currentCustomerID;
        public static string currentAppointment;
        public static string currentAppointmentID;

        public static string currentCustomerName;
        public static object currentCustomer;
        public static string currentCustomerAddressID;

        public static string connectionString;
        public static DataGridView dataGridView;
        public static DataGridView dataGridView2;
        
        public DateTime currentDate;

        public static RadioButton allActiveApptViewRB;



        public static MySqlConnection conToMySQL;
        public static MySqlDataReader mySqlDataReader;
        public static MySqlCommand cmdToMySQL;
        public static MySqlDataAdapter adapterToMySQL;

        public static DataTable dataTable;
        public static DataTable dataTable2;    

        public static string dbName = "Robert_Dickerson___InventorySystem.Properties.Settings.client_scheduleConnectionString";

        public Mainscreen()
        {
            InitializeComponent();
            
            allActiveApptViewRB = allActiveAptsRB;                  

            //DBDGV1 setup
            string connectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;

            conToMySQL = new MySqlConnection(connectionString);
            conToMySQL.Open();
            cmdToMySQL = new MySqlCommand("SELECT * FROM customer", conToMySQL);
            adapterToMySQL = new MySqlDataAdapter(selectCommand: cmdToMySQL);

            dataTable = new DataTable();          
            dataTable.Load(cmdToMySQL.ExecuteReader());
            dataGridView = DBDGV1;            
            dataGridView.DataSource = dataTable;            
            adapterToMySQL.Fill(dataTable);

            //this will convert the UTC times in the database back into local times for datagridview2 on save
            for (int i = 0; i < Mainscreen.dataTable.Rows.Count; i++)
            {
                Mainscreen.dataTable.Rows[i]["createDate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable.Rows[i]["createDate"], TimeZoneInfo.Local).ToString();
                Mainscreen.dataTable.Rows[i]["lastUpdate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable.Rows[i]["lastUpdate"], TimeZoneInfo.Local).ToString();
            }

            conToMySQL.Close();

            // DBDGV2 / Calendar setup
            currentDate = DateTime.Now;
            cal.AddBoldedDate(currentDate);         

            //this is for the DBDGV2 datagridview
            string connectionString2 = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;
                      
            MySqlConnection conToMySQL2 = new MySqlConnection(connectionString2);
            conToMySQL2.Open();
            MySqlCommand cmdToMySQL2 = new MySqlCommand("SELECT * FROM appointment", conToMySQL2);
            MySqlDataAdapter adapterToMySQL2 = new MySqlDataAdapter(selectCommand: cmdToMySQL2);

            Mainscreen.dataTable2 = new DataTable();
            Mainscreen.dataTable2.Load(cmdToMySQL2.ExecuteReader());
            
            dataGridView2 = DBDGV2;
            Mainscreen.dataGridView2.DataSource = Mainscreen.dataTable2;

            //this will convert the UTC times in the database back into local times for datagridview2 on save
            for (int i = 0; i < Mainscreen.dataTable2.Rows.Count; i++)
            {
                Mainscreen.dataTable2.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["start"], TimeZoneInfo.Local).ToString();
                Mainscreen.dataTable2.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["end"], TimeZoneInfo.Local).ToString();
                Mainscreen.dataTable2.Rows[i]["lastUpdate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["lastUpdate"], TimeZoneInfo.Local).ToString();
                Mainscreen.dataTable2.Rows[i]["createDate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["createDate"], TimeZoneInfo.Local).ToString();
            }

            conToMySQL2.Close();

            
           
        }
        //this starts the calendar with the current day selected
        private void CleanTheDB() //this will delete any test runs made while testing
        {           

            string connectionString3 = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;

            MySqlConnection conToMySQL3 = new MySqlConnection(connectionString3);

            //this deletes the test customer
            conToMySQL3.Open();
            MySqlCommand cmdToMySQL3 = new MySqlCommand("DELETE FROM client_schedule.customer WHERE customerId > 3", conToMySQL3);
            MySqlDataAdapter adaptToMySQL3 = new MySqlDataAdapter(selectCommand: cmdToMySQL3);

            cmdToMySQL3.ExecuteReader();
            conToMySQL3.Close();

            //this deletes the test address
            conToMySQL3.Open();
            cmdToMySQL3 = new MySqlCommand("DELETE FROM client_schedule.address WHERE addressId > 3", conToMySQL3);
            adaptToMySQL3 = new MySqlDataAdapter(selectCommand: cmdToMySQL3);

            cmdToMySQL3.ExecuteReader();
            conToMySQL3.Close();

            //this deletes the test city
            conToMySQL3.Open();
            cmdToMySQL3 = new MySqlCommand("DELETE FROM client_schedule.city WHERE cityId > 5", conToMySQL3);
            adaptToMySQL3 = new MySqlDataAdapter(selectCommand: cmdToMySQL3);

            cmdToMySQL3.ExecuteReader();
            conToMySQL3.Close();

            //this deletes the test country
            conToMySQL3.Open();
            cmdToMySQL3 = new MySqlCommand("DELETE FROM client_schedule.country WHERE countryId > 3", conToMySQL3);
            adaptToMySQL3 = new MySqlDataAdapter(selectCommand: cmdToMySQL3);

            cmdToMySQL3.ExecuteReader();
            conToMySQL3.Close();

        }

        private void Form1_Load(System.Object sender, System.EventArgs e)
        {
            customerSearchEntry.Text = "";
            
            this.customerTableAdapter.Fill(this.client_scheduleDataSet.customer);
            DBDGV1.Rows[0].Selected = false;
            DBDGV2.Rows[0].Selected = false;

            this.DBDGV1.CellClick += dataGridView1_CellClick;
            this.DBDGV2.CellClick += dataGridView2_CellClick;

            //this is to check if an appointment is within 15 mins for the current user and alerts them if so
            string connectionString2 = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;

            MySqlConnection conForAppt15Check = new MySqlConnection(connectionString2);
            conForAppt15Check.Open();
            MySqlCommand cmdForAppt15Check = new MySqlCommand("SELECT customerId, userId, start, end FROM appointment", conForAppt15Check);
            MySqlDataAdapter adapterCheckForAppt = new MySqlDataAdapter(selectCommand: cmdForAppt15Check);

            DataTable CheckForAppt = new DataTable();
            CheckForAppt.Load(cmdForAppt15Check.ExecuteReader());

            //this will convert the UTC times in the database back into local times for comparison
            DateTime now = DateTime.Now;
            for (int i = 0; i < CheckForAppt.Rows.Count; i++)
            {
                if (CheckForAppt.Rows[i]["userId"].ToString() == LogInScreen.currentUserId)
                {
                    CheckForAppt.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)CheckForAppt.Rows[i]["start"], TimeZoneInfo.Local).ToString();
                    string customerAppt15 = CheckForAppt.Rows[i]["customerId"].ToString();
                    DateTime apptStart15 = Convert.ToDateTime(CheckForAppt.Rows[i]["start"].ToString());
                    if (CheckForAppt15(apptStart15) == true)
                    {
                        MessageBox.Show($"User '{LogInScreen.currentUserName}' you have an appointment with customerID:'{customerAppt15}' at '{apptStart15.ToString("hh:mm tt")}' !");
                    }
                }                
            }
            
            conForAppt15Check.Close();                    

        }

        private const int timeWindowInMinutes = 15;

        //this checks to see if an appt time is within 15 mins of current time
        public static bool CheckForAppt15(DateTime apptStartTime)
        {
            TimeSpan timeDifference = apptStartTime - DateTime.Now;

            return (timeDifference.TotalSeconds > -1 && timeDifference.TotalSeconds < 0) // this gives a time difference tolerance up to one sec before
                   || (timeDifference.TotalSeconds >= 0 && Math.Floor(timeDifference.TotalSeconds) <= timeWindowInMinutes * 60); // this gives a time difference tolerance within 15 minutes
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentIndex = DBDGV1.CurrentCell.RowIndex;
            currentCustomerID = dataTable.Rows[currentIndex]["customerId"].ToString();
            currentCustomerName = dataTable.Rows[currentIndex]["customerName"].ToString();
            currentCustomer = dataTable.Rows[currentIndex];
            currentCustomerAddressID = dataTable.Rows[currentIndex]["addressId"].ToString();

        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {            
            currentCustomerIndex = DBDGV2.CurrentCell.RowIndex;
            currentAppointmentID = dataTable2.Rows[currentCustomerIndex]["appointmentId"].ToString();
        }        

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomer = new AddCustomer();
            addCustomer.Show();
            customerSearchEntry.Text = "";
            refreshDBDGV1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((Mainscreen.dataGridView.SelectedRows.Count != 0) && (currentCustomerID != null))
            {
                ModifyCustomer modifyCustomer = new ModifyCustomer();
                modifyCustomer.Show();

                DBDGV1.Rows[currentIndex].Selected = false;
                currentCustomerID = null;
                customerSearchEntry.Text = "";
                refreshDBDGV1();
            }
            else
            {
                button2.Enabled = false;
                MessageBox.Show("Please select a customer to modify.");
                button2.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DBDGV1.SelectedRows.Count != 0)
            {
                if (Inventory.AllParts.Any())
                {
                    DialogResult deletePartCheck = MessageBox.Show("Do you want to delete this customer from the database?", "Delete?", MessageBoxButtons.YesNo);

                    if (deletePartCheck == DialogResult.Yes)
                    {
                        //this will connect to the DB and begin the Delete statment
                        string dbName = "Robert_Dickerson___InventorySystem.Properties.Settings.client_scheduleConnectionString";

                        string connectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;                                                
                        MySqlConnection conForDelete = new MySqlConnection(connectionString);

                        conForDelete.Open();
                        MySqlCommand cmdForDelete = new MySqlCommand($"DELETE FROM customer WHERE customerId = '{currentCustomerID}'", conForDelete);
                        cmdForDelete.ExecuteNonQuery();
                        conForDelete.Close();

                        //this is to repopulate the datagridview after delete
                        conForDelete.Open();
                        MySqlCommand cmdForRefresh = new MySqlCommand("SELECT * FROM customer", conForDelete);
                        adapterToMySQL = new MySqlDataAdapter(selectCommand: cmdForRefresh);

                        Mainscreen.dataTable = new DataTable();
                        Mainscreen.dataTable.Load(cmdForRefresh.ExecuteReader());
                        Mainscreen.dataGridView.DataSource = Mainscreen.dataTable;
                        Mainscreen.adapterToMySQL.Fill(Mainscreen.dataTable);

                        //this will convert the UTC times in the database back into local times for datagridview2 on save
                        for (int i = 0; i < Mainscreen.dataTable.Rows.Count; i++)
                        {
                            Mainscreen.dataTable.Rows[i]["createDate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable.Rows[i]["createDate"], TimeZoneInfo.Local).ToString();
                            Mainscreen.dataTable.Rows[i]["lastUpdate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable.Rows[i]["lastUpdate"], TimeZoneInfo.Local).ToString();
                        }

                        conForDelete.Close();

                        dataGridView.ClearSelection();
                        customerSearchEntry.Text = "";

                    }
                    else if (deletePartCheck == DialogResult.No)
                    {
                        dataGridView.ClearSelection();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete");
                dataGridView.ClearSelection();
            }

            dataGridView.ClearSelection();
        }        

        private void button9_Click(object sender, EventArgs e)
        {
            apptSearchEntry.Text = "";
            refreshDBDGV2();
            /*Product.TempModList = new BindingList<Part>();*/
            AddAppointment addAppointment = new AddAppointment();
            addAppointment.Show(); 

        }
        
        //this is the modify button
        private void button6_Click(object sender, EventArgs e)
        {
            if ((Mainscreen.dataGridView2.SelectedRows.Count != 0) && (currentCustomerIndex >= 0))
            {
                button6.Enabled = true;
                ModAppt modifyAppointment = new ModAppt();
                modifyAppointment.Show();

                /*DBDGV2.Rows[currentIndex].Selected = false;*/
                currentCustomerIndex  = -1;
                apptSearchEntry.Text = "";

            }
            else
            {
                button6.Enabled = false;
                MessageBox.Show("Please select an appointment to modify.");
                button6.Enabled = true;
                dataGridView2.Refresh();
            }
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            if (DBDGV2.SelectedRows.Count != 0)
            {
                if (Inventory.Products.Any())
                {
                    DialogResult deleteApptCheck = MessageBox.Show("Do you want to delete this appointment from the database?", "Delete?", MessageBoxButtons.YesNo);

                    if (deleteApptCheck == DialogResult.Yes)
                    {
                        //this will connect to the DB and begin the Delete statment
                        string dbName = "Robert_Dickerson___InventorySystem.Properties.Settings.client_scheduleConnectionString";

                        string connectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;
                        MySqlConnection conForDelete = new MySqlConnection(connectionString);

                        conForDelete.Open();
                        MySqlCommand cmdForDelete = new MySqlCommand($"DELETE FROM appointment WHERE appointmentId = '{currentAppointmentID}'", conForDelete);
                        cmdForDelete.ExecuteNonQuery();
                        conForDelete.Close();

                        //this will refresh the DBDGV2 table
                        conForDelete.Open();
                        cmdForDelete = new MySqlCommand("SELECT * FROM appointment", conForDelete);
                        Mainscreen.adapterToMySQL = new MySqlDataAdapter(selectCommand: cmdForDelete);

                        dataTable2 = new DataTable();                       
                        Mainscreen.dataTable2.Load(cmdForDelete.ExecuteReader());
                        Mainscreen.adapterToMySQL.Fill(Mainscreen.dataTable2);
                        Mainscreen.dataGridView2.DataSource = Mainscreen.dataTable2;

                        //this will convert the UTC times in the database back into local times for datagridview2 on save
                        for (int i = 0; i < Mainscreen.dataTable2.Rows.Count; i++)
                        {
                            Mainscreen.dataTable2.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["start"], TimeZoneInfo.Local).ToString();
                            Mainscreen.dataTable2.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["end"], TimeZoneInfo.Local).ToString();
                            Mainscreen.dataTable2.Rows[i]["lastUpdate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["lastUpdate"], TimeZoneInfo.Local).ToString();
                            Mainscreen.dataTable2.Rows[i]["createDate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["createDate"], TimeZoneInfo.Local).ToString();
                        }

                        conForDelete.Close();

                        MessageBox.Show("The appointment was deleted.");

                        dataGridView2.ClearSelection();
                        apptSearchEntry.Text = "";

                    }
                    else if (deleteApptCheck == DialogResult.No)
                    {
                        //this should just do nothing
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to delete");
                dataGridView2.ClearSelection();
            }
            dataGridView2.ClearSelection();

        }
        /// <summary>
        /// Part Search Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click_1(object sender, EventArgs e)
        {                      
            DBDGV1.ClearSelection();           
           
        }
        
        /// <summary>
        /// Product Search Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            DBDGV2.ClearSelection();
        }
        
        public string CreateDATE()
        {
            return DateTime.Now.ToString("yyyy-MM-dd, HH:mm:ss");
        }
        
        private void monthlyApptViewRB_CheckedChanged(object sender, EventArgs e)
        {
            cal.RemoveAllBoldedDates();
            dataTable2.Clear();
            int dayOfTheMonth = (int)currentDate.DayOfWeek;
            string startDate = currentDate.AddDays(dayOfTheMonth - 31).ToString();
            DateTime tempDate = Convert.ToDateTime(startDate);
            for (int i = 0; i < 62; i++)
            {
                cal.AddBoldedDate(tempDate.AddDays(i));
            }
            cal.UpdateBoldedDates();
            string endDate = currentDate.AddDays(31 - dayOfTheMonth).ToString();

            string connectionString2 = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;
            MySqlConnection conToMySQL2 = new MySqlConnection(connectionString2);
            conToMySQL2.Open();
            MySqlCommand cmdToMySQL2 = new MySqlCommand($"SELECT * FROM appointment WHERE start >= '{startDate}' AND end <= '{endDate}';", conToMySQL2);
            MySqlDataAdapter adapterToMySQL2 = new MySqlDataAdapter(selectCommand: cmdToMySQL2);
            adapterToMySQL2.Fill(dataTable2);
            conToMySQL2.Close();

            dataGridView2 = DBDGV2;
            dataGridView2.DataSource = dataTable2;

            //this will convert the UTC times in the database back into local times for datagridview2 on save
            for (int i = 0; i < Mainscreen.dataTable2.Rows.Count; i++)
            {
                Mainscreen.dataTable2.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["start"], TimeZoneInfo.Local).ToString();
                Mainscreen.dataTable2.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["end"], TimeZoneInfo.Local).ToString();
                Mainscreen.dataTable2.Rows[i]["lastUpdate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["lastUpdate"], TimeZoneInfo.Local).ToString();
                Mainscreen.dataTable2.Rows[i]["createDate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["createDate"], TimeZoneInfo.Local).ToString();
            }

            dataGridView2.ClearSelection();
        }

        private void weeklyApptViewRB_CheckedChanged(object sender, EventArgs e)
        {
            cal.RemoveAllBoldedDates();
            dataTable2.Clear();
            int dayOfTheWeek = (int)currentDate.DayOfWeek;
            string startDate = currentDate.AddDays(-dayOfTheWeek).ToString();
            DateTime tempDate = Convert.ToDateTime(startDate);
            for (int i = 0; i < 7; i++)
            {
                cal.AddBoldedDate(tempDate.AddDays(i));
            }
            cal.UpdateBoldedDates();
            string endDate = currentDate.AddDays(7 - dayOfTheWeek).ToString();

            string connectionString2 = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;
            MySqlConnection conToMySQL2 = new MySqlConnection(connectionString2);
            conToMySQL2.Open();
            MySqlCommand cmdToMySQL2 = new MySqlCommand($"SELECT * FROM appointment WHERE start >= '{startDate}' AND end <= '{endDate}';", conToMySQL2);
            MySqlDataAdapter adapterToMySQL2 = new MySqlDataAdapter(selectCommand: cmdToMySQL2);
            adapterToMySQL2.Fill(dataTable2);
            conToMySQL2.Close();
            
            dataGridView2 = DBDGV2;
            dataGridView2.DataSource = dataTable2;

            //this will convert the UTC times in the database back into local times for datagridview2 on save
            for (int i = 0; i < Mainscreen.dataTable2.Rows.Count; i++)
            {
                Mainscreen.dataTable2.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["start"], TimeZoneInfo.Local).ToString();
                Mainscreen.dataTable2.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["end"], TimeZoneInfo.Local).ToString();
                Mainscreen.dataTable2.Rows[i]["lastUpdate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["lastUpdate"], TimeZoneInfo.Local).ToString();
                Mainscreen.dataTable2.Rows[i]["createDate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["createDate"], TimeZoneInfo.Local).ToString();
            }

            dataGridView2.ClearSelection();
            }

        }
        
        public static void refreshDBDGV2()
        {
            string connectionString2 = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;

            MySqlConnection conToMySQL2 = new MySqlConnection(connectionString2);
            conToMySQL2.Open();
            MySqlCommand cmdToMySQL2 = new MySqlCommand("SELECT * FROM appointment", conToMySQL2);
            MySqlDataAdapter adapterToMySQL2 = new MySqlDataAdapter(selectCommand: cmdToMySQL2);

            dataTable2 = new DataTable();
            dataTable2.Load(cmdToMySQL2.ExecuteReader());
            
            dataGridView2.DataSource = dataTable2;


            //this will convert the UTC times in the database back into local times for datagridview2 on save
            for (int i = 0; i < Mainscreen.dataTable2.Rows.Count; i++)
            {
                Mainscreen.dataTable2.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["start"], TimeZoneInfo.Local).ToString();
                Mainscreen.dataTable2.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["end"], TimeZoneInfo.Local).ToString();
                Mainscreen.dataTable2.Rows[i]["lastUpdate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["lastUpdate"], TimeZoneInfo.Local).ToString();
                Mainscreen.dataTable2.Rows[i]["createDate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["createDate"], TimeZoneInfo.Local).ToString();
            }

            conToMySQL2.Close();
            dataGridView2.Refresh();
            dataGridView2.ClearSelection();
        }
        public static void refreshDBDGV1()
        {
            string connectionString2 = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;

            MySqlConnection conToMySQL2 = new MySqlConnection(connectionString2);
            conToMySQL2.Open();
            MySqlCommand cmdToMySQL2 = new MySqlCommand("SELECT * FROM customer", conToMySQL2);
            MySqlDataAdapter adapterToMySQL2 = new MySqlDataAdapter(selectCommand: cmdToMySQL2);

            dataTable = new DataTable();
            dataTable.Load(cmdToMySQL2.ExecuteReader());

            dataGridView.DataSource = dataTable;


            //this will convert the UTC times in the database back into local times for datagridview2 on save
            for (int i = 0; i < Mainscreen.dataTable.Rows.Count; i++)
            {
                /*Mainscreen.dataTable.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable.Rows[i]["start"], TimeZoneInfo.Local).ToString();
                Mainscreen.dataTable.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable.Rows[i]["end"], TimeZoneInfo.Local).ToString();*/
                Mainscreen.dataTable.Rows[i]["lastUpdate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable.Rows[i]["lastUpdate"], TimeZoneInfo.Local).ToString();
                Mainscreen.dataTable.Rows[i]["createDate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable.Rows[i]["createDate"], TimeZoneInfo.Local).ToString();
            }

            conToMySQL2.Close();
            dataGridView.Refresh();
            dataGridView.ClearSelection();
        }
        private void allActiveAptsRB_CheckedChanged(object sender, EventArgs e)
        {
            string connectionString2 = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;

            MySqlConnection conToMySQL2 = new MySqlConnection(connectionString2);
            conToMySQL2.Open();
            MySqlCommand cmdToMySQL2 = new MySqlCommand("SELECT * FROM appointment", conToMySQL2);
            MySqlDataAdapter adapterToMySQL2 = new MySqlDataAdapter(selectCommand: cmdToMySQL2);

            dataTable2 = new DataTable();
            dataTable2.Load(cmdToMySQL2.ExecuteReader());
            dataGridView2 = DBDGV2;
            dataGridView2.DataSource = dataTable2;



            //this will convert the UTC times in the database back into local times for datagridview2 on save
            for (int i = 0; i < Mainscreen.dataTable2.Rows.Count; i++)
            {
                Mainscreen.dataTable2.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["start"], TimeZoneInfo.Local).ToString();
                Mainscreen.dataTable2.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["end"], TimeZoneInfo.Local).ToString();
                Mainscreen.dataTable2.Rows[i]["lastUpdate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["lastUpdate"], TimeZoneInfo.Local).ToString();
                Mainscreen.dataTable2.Rows[i]["createDate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["createDate"], TimeZoneInfo.Local).ToString();
            }

            conToMySQL2.Close();
            dataGridView2.Refresh();
            dataGridView2.ClearSelection();
        }

        private void reportBTN_Click(object sender, EventArgs e)
        {
            Reports reportScreen = new Reports();
            reportScreen.Show();
            dataGridView.ClearSelection();
            dataGridView2.ClearSelection();
        }
        /// <summary>
        /// customerSearchBTN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click_1(object sender, EventArgs e)
        {
            dataGridView.ClearSelection();
            bool found = false;
            var searchEntry = customerSearchEntry.Text.ToString();

            if (!string.IsNullOrWhiteSpace(searchEntry))
            {
                string connectionString2 = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;

                MySqlConnection conToMySQL2 = new MySqlConnection(connectionString2);
                conToMySQL2.Open();
                MySqlCommand customerSearchCMD = new MySqlCommand($"SELECT * FROM customer WHERE customerName LIKE '%{searchEntry}%'", conToMySQL2);
                MySqlDataAdapter customerSearchAdapter = new MySqlDataAdapter(selectCommand: customerSearchCMD);

                dataTable = new DataTable();
                dataTable.Load(customerSearchCMD.ExecuteReader());
                
                if (dataTable.Rows.Count > 0)
                {
                    dataGridView.DataSource = dataTable;
                    dataGridView.ClearSelection();
                    currentIndex = -1;
                    currentCustomerID = null;
                    found = true;
                }
                else
                {
                    MessageBox.Show("Nothing Found!: Please enter a Customer Name and try again.");
                    dataGridView.DataSource = dataTable;
                    dataGridView.ClearSelection();
                    currentIndex = -1;
                    refreshDBDGV1();
                    found = false;
                }
            }
            else
            {                
                MessageBox.Show("Please enter a Customer Name and try again.");
                dataGridView.DataSource = dataTable;
                dataGridView.ClearSelection();
                currentIndex = -1;
                refreshDBDGV1();                
            }
        }

        private void appointmentSearchBTN_Click(object sender, EventArgs e)
        {
            dataGridView2.ClearSelection();
            bool found = false;
            var searchEntry = apptSearchEntry.Text.ToString();

            if (!string.IsNullOrWhiteSpace(searchEntry))
            {
                string connectionString2 = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;

                MySqlConnection conToMySQL2 = new MySqlConnection(connectionString2);
                conToMySQL2.Open();
                MySqlCommand customerSearchCMD = new MySqlCommand($"SELECT * FROM appointment WHERE customerId LIKE '%{searchEntry}%'", conToMySQL2);
                MySqlDataAdapter customerSearchAdapter = new MySqlDataAdapter(selectCommand: customerSearchCMD);

                dataTable2 = new DataTable();
                dataTable2.Load(customerSearchCMD.ExecuteReader());
                
                if (dataTable2.Rows.Count > 0)
                {
                    dataGridView2.DataSource = dataTable2;
                    dataGridView2.ClearSelection();
                    currentCustomerIndex = -1;
                    currentCustomerID = null;
                    found = true;
                }
                else
                {
                    MessageBox.Show("Nothing found!: Please enter a Customer ID and try again.");
                    dataGridView2.DataSource = dataTable2;
                    dataGridView2.ClearSelection();
                    currentIndex = -1;
                    refreshDBDGV2();
                    found = false;
                }
            }
            else
            {
                MessageBox.Show("Please enter a Customer ID and try again.");
                dataGridView2.DataSource = dataTable2;
                dataGridView2.ClearSelection();
                currentIndex = -1;
                refreshDBDGV2();                
            }
        }
    

        public void customerSearchEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void apptSearchEntry_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void customerRefreshBTN_Click(object sender, EventArgs e)
        {
            customerSearchEntry.Text = "";
            refreshDBDGV1();
        }

        private void apptRefreshBTN_Click(object sender, EventArgs e)
        {
            apptSearchEntry.Text = "";
            refreshDBDGV2();
        }
    }

}
