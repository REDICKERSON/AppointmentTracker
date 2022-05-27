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
    public partial class ModAppt : Form
    {
        public delegate void DataGridViewCellEventHandler();

        public static string[] typeString = { "Meeting", "Presentation", "Scrum" };
        public static int customerIndex;
        public static string customerSelectID;
        public static Part currentAssociatedPart;
        DataTable dataTable2 = new DataTable();
        /*public static int index = 0;*/
        public static string dbName = "Robert_Dickerson___InventorySystem.Properties.Settings.client_scheduleConnectionString";
        private bool invalid = false;
        private bool textIsRED;
        private bool textISGREEN;
        private bool outsideBusHours;

        //variables for delete/reload textboxes on modify
        public static string tempTitle;
        public static string userID;
        public static string tempCustomerID;
        public static string tempCustomerSelectedID;
        public static string tempDescription;
        public static string tempLocation;
        public static string tempContact;
        public static string tempType;
        public static string tempUrl;
        public static DateTime tempStart;
        public static DateTime tempEnd;


        public ModAppt()
        {
            InitializeComponent();

            customerIndex = -1;

            this.button2.MouseEnter += button2_MouseEnter_1;
            this.button2.MouseLeave += button2_MouseLeave_1;

            //this will set the values in the typeComboBox
            string[] typeString = { "Meeting", "Presentation", "Scrum" };
            typeComboBox.DataSource = typeString;

            //this will set the datetime pickers to current time
            startTimePicker.Format = DateTimePickerFormat.Custom;
            startTimePicker.CustomFormat = "yyyy/MM/dd HH:mm:ss hh:mm tt"; //"dddd, MMMM dd, yyyy hh:mm tt"

            endTimePicker.Format = DateTimePickerFormat.Custom;
            endTimePicker.CustomFormat = "yyyy/MM/dd HH:mm:ss hh:mm tt";

            startTimePicker.Value = DateTime.Now.AddMinutes(15);
            endTimePicker.Value = DateTime.Now.AddMinutes(45);

            //this will populate datagridview1 with customer table for selection
            string connectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;

            MySqlConnection conToMySQL = new MySqlConnection(connectionString);
            conToMySQL.Open();
            MySqlCommand cmdToMySQL = new MySqlCommand("SELECT * FROM customer", conToMySQL);
            MySqlDataAdapter adapterToMySQL = new MySqlDataAdapter(selectCommand: cmdToMySQL);

            DataTable dataTable = new DataTable();
            /*adapterToMySQL.Fill(dataTable); */

            dataTable.Load(cmdToMySQL.ExecuteReader());
            dataGridView1.DataSource = dataTable;

            conToMySQL.Close();

           /* //this will populate datagridview2 with appointment table for validation           
            conToMySQL.Open();
            MySqlCommand cmdToMySQL2 = new MySqlCommand("SELECT customerId, start, end FROM appointment", conToMySQL);
            MySqlDataAdapter adapterToMySQL2 = new MySqlDataAdapter(selectCommand: cmdToMySQL2);

            dataTable2.Load(cmdToMySQL2.ExecuteReader());
            dataGridView2.DataSource = dataTable2;

            for (int i = 0; i < dataTable2.Rows.Count; i++)
            {
                dataTable2.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dataTable2.Rows[i]["start"], TimeZoneInfo.Local).ToString();
                dataTable2.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dataTable2.Rows[i]["end"], TimeZoneInfo.Local).ToString();
            }

            checkForTimeConflict();

            conToMySQL.Close();*/

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            customerIndex = dataGridView1.CurrentCell.RowIndex;


        }
        /*public void ValidateTextBox()
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text) ||
                string.IsNullOrWhiteSpace(descriptionTextBox.Text) ||
                string.IsNullOrWhiteSpace(locationTextBox.Text) ||
                string.IsNullOrWhiteSpace(contactTextBox.Text) ||
                string.IsNullOrWhiteSpace(typeTextBox.Text) ||
                string.IsNullOrWhiteSpace(urlTextBox.Text))
            {
                return;
            }
*//*
            bool b_inv = Int32.TryParse(locationTextBox.Text, out int inv);
            bool b_min = Int32.TryParse(typeTextBox.Text, out int min) && inv >= min;
            bool b_max = Int32.TryParse(urlTextBox.Text, out int max) && inv <= max;

            locationTextBox.BackColor = b_inv ? Color.White : Color.Salmon;
            typeTextBox.BackColor = b_min ? Color.White : Color.Salmon;
            urlTextBox.BackColor = b_max ? Color.White : Color.Salmon;

            button2.Enabled = true;*//*
        }*/

        /// <summary>
        /// Cancel Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;

                MySqlConnection conToMySQL = new MySqlConnection(connectionString);
                conToMySQL.Open();
                MySqlCommand cmdToMySQL = new MySqlCommand("SELECT * FROM customer", conToMySQL);
                MySqlDataAdapter adapterToMySQL = new MySqlDataAdapter(selectCommand: cmdToMySQL);

                DataTable dataTable = new DataTable();
                /*adapterToMySQL.Fill(dataTable); */
                dataTable.Load(cmdToMySQL.ExecuteReader());

                /* //this will set customerSelectID to the currently selected customer in the datagridview
                 for (int i = 0; i < dataTable.Rows.Count; i++)
                 {
                     customerSelectID = dataTable.Rows[customerIndex]["customerId"].ToString();
                 }*/
                conToMySQL.Close();

                //this will create the appointment with a series of instert statements                  
                conToMySQL.Open();
                string query = $"INSERT INTO appointment(customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                    $" VALUES('{tempCustomerID}','{LogInScreen.currentUserId}','{tempTitle}','{tempDescription}','{tempLocation}','{tempContact}','{tempType}','{tempUrl}','{tempStart}','{tempEnd}','{CreateUtcDATE()}','{CreatedBY()}','{LastUtcUPDATE()}','{LastUpdateBY()}');";

                MySqlCommand cmdToCreateAppt = new MySqlCommand(query, conToMySQL);
                cmdToCreateAppt.ExecuteReader();
                conToMySQL.Close();

               /* //this will refresh the DBDGV2 table

                conToMySQL.Open();
                MySqlCommand cmdToRefresh = new MySqlCommand("SELECT * FROM appointment", conToMySQL);
                MySqlDataAdapter adapterToRefresh = new MySqlDataAdapter(selectCommand: cmdToRefresh);
                dataTable2 = new DataTable();
                *//*adapterToMySQL.Fill(dataTable); *//*
                dataTable2.Load(cmdToRefresh.ExecuteReader());
                adapterToRefresh.Fill(Mainscreen.dataTable2);
                Mainscreen.dataGridView2.DataSource = dataTable2;

                //this will convert the UTC times in the database back into local times for datagridview2 on save
                for (int i = 0; i < Mainscreen.dataTable2.Rows.Count; i++)
                {
                    dataTable2.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dataTable2.Rows[i]["start"], TimeZoneInfo.Local).ToString();
                    dataTable2.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dataTable2.Rows[i]["end"], TimeZoneInfo.Local).ToString();
                }

                conToMySQL.Close();*/
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex}");
            }
            Mainscreen.refreshDBDGV2();
            Close();
                      

            /*Mainscreen.allActiveApptViewRB.Enabled = true;*/
            Mainscreen.dataGridView.ClearSelection();            
        }
        public string CreateUtcDATE()
        {
            return DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd, HH:mm:ss");
        }

        public string CreatedBY()
        {
            return LogInScreen.currentUserName;
        }

        public string LastUtcUPDATE()
        {
            return DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd, HH:mm:ss");
        }

        public string LastUpdateBY()
        {
            return LogInScreen.currentUserName;
        }

        private void button2_MouseEnter_1(object sender, EventArgs e)
        {
            try
            {
                //this checks to see if any text boxes are null or salmon colored
                invalid = this.Controls.OfType<TextBox>()
                  .Any(t => t.BackColor == Color.Salmon || string.IsNullOrWhiteSpace(t.Text));
                // I used the LAMBDA expression here to save me many, many lines of code that would list out each one
                // and check to see if it had the backcolor equal to Salmon. This LAMBDA also does the same for all the textboxes
                // and checks to see if they are null or whitespace only characters. 

                //this checks to see if there is a time conflict for appt and thus given a red error message
                if (apptERRORLabel.ForeColor == Color.Firebrick)
                {
                    textIsRED = true;
                }
                if (apptERRORLabel.ForeColor == Color.Green)
                {
                    textISGREEN = true;
                }

                if ((invalid) || (textIsRED) || (outsideBusHours))
                {
                    button2.Enabled = false;

                    button2.UseVisualStyleBackColor = false;
                    button2.BackColor = Color.DarkGray;
                }
                if ((!invalid) && (textISGREEN) && (!outsideBusHours))
                {
                    button2.Enabled = true;
                    button2.UseVisualStyleBackColor = true;
                    button2.BackColor = Color.White;
                }
            }
            catch (InvalidCastException error)
            {
                MessageBox.Show($"The following error has occurred: '{error}'.");
            }
        }
        private void button2_MouseLeave_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {

            if (customerIndex == -1)
            {
                MessageBox.Show("Please select a customer from the Customer List.");
            }
            else
            {
                try
                {
                    //this checks to see if any text boxes are null or salmon colored
                    invalid = this.Controls.OfType<TextBox>()
                      .Any(t => t.BackColor == Color.Salmon || string.IsNullOrWhiteSpace(t.Text));
                    // I used the LAMBDA expression here to save me many, many lines of code that would list out each one
                    // and check to see if it had the backcolor equal to Salmon. This LAMBDA also does the same for all the textboxes
                    // and checks to see if they are null or whitespace only characters. 

                    //this checks to see if there is a time conflict for appt and thus given a red error message
                    if (apptERRORLabel.ForeColor == Color.Firebrick)
                    {
                        textIsRED = true;
                    }
                    if (apptERRORLabel.ForeColor == Color.Green)
                    {
                        textISGREEN = true;
                    }

                    if ((invalid) || (textIsRED) || (outsideBusHours))
                    {
                        button2.Enabled = false;

                        button2.UseVisualStyleBackColor = false;
                        button2.BackColor = Color.DarkGray;
                    }
                    if ((!invalid) && (textISGREEN) && (!outsideBusHours))
                    {
                        //
                        string connectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;

                        MySqlConnection conToMySQL = new MySqlConnection(connectionString);
                        conToMySQL.Open();
                        MySqlCommand cmdToMySQL = new MySqlCommand("SELECT * FROM customer", conToMySQL);
                        MySqlDataAdapter adapterToMySQL = new MySqlDataAdapter(selectCommand: cmdToMySQL);

                        DataTable dataTable = new DataTable();
                        /*adapterToMySQL.Fill(dataTable); */
                        dataTable.Load(cmdToMySQL.ExecuteReader());

                        //this will set customerSelectID to the currently selected customer in the datagridview
                        for (int i = 0; i < dataTable.Rows.Count; i++)
                        {
                            customerSelectID = dataTable.Rows[customerIndex]["customerId"].ToString();
                        }
                        conToMySQL.Close();

                        //this will create the appointment with a series of instert statements                  
                        conToMySQL.Open();
                        string query = $"INSERT INTO appointment(customerId, userId, title, description, location, contact, type, url, start, end, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                            $" VALUES('{customerSelectID}','{LogInScreen.currentUserId}','{contact.Text}','{descriptionTextBox.Text}','{locationTextBox.Text}','{contactTextBox.Text}','{typeComboBox.SelectedValue}','{urlTextBox.Text}','{startTimePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd, HH:mm:ss")}','{endTimePicker.Value.ToUniversalTime().ToString("yyyy-MM-dd, HH:mm:ss")}','{CreateUtcDATE()}','{CreatedBY()}','{LastUtcUPDATE()}','{LastUpdateBY()}');";

                        MySqlCommand cmdToCreateAppt = new MySqlCommand(query, conToMySQL);
                        cmdToCreateAppt.ExecuteReader();
                        conToMySQL.Close();

                        //this will refresh the DBDGV2 table

                        conToMySQL.Open();
                        MySqlCommand cmdToRefresh = new MySqlCommand("SELECT * FROM appointment", conToMySQL);
                        MySqlDataAdapter adapterToRefresh = new MySqlDataAdapter(selectCommand: cmdToRefresh);
                        DataTable dataTableRefresh = new DataTable();
                        adapterToMySQL.Fill(dataTable);
                        dataTableRefresh.Load(cmdToRefresh.ExecuteReader());
                        adapterToRefresh.Fill(Mainscreen.dataTable2);
                        Mainscreen.dataGridView2.DataSource = dataTableRefresh;

                        //this will convert the UTC times in the database back into local times for datagridview2 on save
                        for (int i = 0; i < Mainscreen.dataTable2.Rows.Count; i++)
                        {
                            Mainscreen.dataTable2.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["start"], TimeZoneInfo.Local).ToString();
                            Mainscreen.dataTable2.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable2.Rows[i]["end"], TimeZoneInfo.Local).ToString();
                        }

                        conToMySQL.Close();

                        Mainscreen.dataGridView2.ClearSelection();
                        /*Mainscreen.currentAppointmentID = null;*/

                        
                        //
                        button2.Enabled = true;
                        button2.UseVisualStyleBackColor = true;
                        button2.BackColor = Color.White;

                        Mainscreen.refreshDBDGV2();
                        Close();
                    }
                }
                catch (InvalidCastException error)
                {
                    MessageBox.Show($"The following error has occurred: '{error}'.");
                }
                
            }
            
        }

        private void ModAppt_Load(object sender, EventArgs e)
        {
            
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            /*this.dataGridView2.Sort(this.dataGridView2.Columns["start"], ListSortDirection.Ascending);*/

            this.dataGridView1.CellClick += dataGridView1_CellClick;
            this.dataGridView2.CellClick += dataGridView2_CellClick_1;

            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();

            if(Mainscreen.currentAppointmentID != null)
            {
                try
                {
                    //this sets the textbox text to that of the selected appt to modify
                    string dbName = "Robert_Dickerson___InventorySystem.Properties.Settings.client_scheduleConnectionString";

                    //this connection and table is made to set variables for populating appointment text boxes to modify
                    string connectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;

                    MySqlConnection conForAppts = new MySqlConnection(connectionString);
                    conForAppts.Open();
                    MySqlCommand cmdForAppts = new MySqlCommand($"SELECT * FROM appointment WHERE appointmentId ='{Mainscreen.currentAppointmentID}'", conForAppts);
                    MySqlDataAdapter apptAdapter = new MySqlDataAdapter(selectCommand: cmdForAppts);

                    DataTable apptTable = new DataTable();
                    apptTable.Load(cmdForAppts.ExecuteReader());

                    tempTitle = apptTable.Rows[0]["title"].ToString();
                    userID = apptTable.Rows[0]["userId"].ToString();
                    tempCustomerID = apptTable.Rows[0]["customerId"].ToString();
                    tempDescription = apptTable.Rows[0]["description"].ToString();
                    tempLocation = apptTable.Rows[0]["location"].ToString();
                    tempContact = apptTable.Rows[0]["contact"].ToString();
                    tempType = apptTable.Rows[0]["type"].ToString();
                    tempUrl = apptTable.Rows[0]["url"].ToString();
                    /*tempCustomerSelectedID = apptTable.Rows[0]["customerId"].ToString();*/

                    conForAppts.Close();

                    //this populates the text boxes accordingly
                    contact.Text = tempTitle;
                    descriptionTextBox.Text = tempDescription;
                    locationTextBox.Text = tempLocation;
                    contactTextBox.Text = tempContact;
                    typeComboBox.Text = tempType;
                    urlTextBox.Text = tempUrl;

                    for (int i = 0; i < dataTable2.Rows.Count; i++)
                    {
                        apptTable.Rows[0]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)apptTable.Rows[0]["start"], TimeZoneInfo.Local).ToString();
                        apptTable.Rows[0]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)apptTable.Rows[0]["end"], TimeZoneInfo.Local).ToString();
                    }
                    tempEnd = (DateTime)apptTable.Rows[0]["end"];
                    tempStart = (DateTime)apptTable.Rows[0]["start"];

                    /*startTimePicker.Value = tempStart;
                    endTimePicker.Value = tempEnd;*/

                    //this will connect to the DB and begin the Delete statment          
                    MySqlConnection conForDelete = new MySqlConnection(connectionString);

                    conForDelete.Open();
                    MySqlCommand cmdForDelete = new MySqlCommand($"DELETE FROM appointment WHERE appointmentId = '{Mainscreen.currentAppointmentID}'", conForDelete);
                    cmdForDelete.ExecuteNonQuery();
                    conForDelete.Close();

                    //this will refresh the appt table after the modify temp delete

                    conForAppts.Open();
                    MySqlCommand cmdToRefresh = new MySqlCommand("SELECT * FROM appointment", conForAppts);
                    MySqlDataAdapter adapterToRefresh = new MySqlDataAdapter(selectCommand: cmdToRefresh);
                    dataTable2 = new DataTable();
                    /*adapterToMySQL.Fill(dataTable); */
                    dataTable2.Load(cmdToRefresh.ExecuteReader());
                    adapterToRefresh.Fill(dataTable2);
                    /*dataGridView2.DataSource = dataTable2;*/

                    //this will convert the UTC times in the database back into local times for datagridview2 on save
                    for (int i = 0; i < dataTable2.Rows.Count; i++)
                    {
                        dataTable2.Rows[i]["start"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dataTable2.Rows[i]["start"], TimeZoneInfo.Local).ToString();
                        dataTable2.Rows[i]["end"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)dataTable2.Rows[i]["end"], TimeZoneInfo.Local).ToString();
                    }
                    dataGridView2.DataSource = dataTable2;

                    conForAppts.Close();

                    /*this.dataGridView2.Sort(this.dataGridView2.Columns["start"], ListSortDirection.Ascending);*/

                    dataGridView2.Refresh();
                    dataGridView2.ClearSelection();

                    /*checkForTimeConflict();*/
                    /*dataGridView2.Refresh();*/

                    //run the delete function for this apptID

                    //on cancel, re-isert that information.


                }
                catch(Exception ex)
                {
                    MessageBox.Show("Please select an appointment to modify.");
                    Close();
                }
            }
            else
            {
                return;
            }
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView2_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            /*currentIndex = dataGridView2.CurrentCell.RowIndex;*/
            /*currentAssociatedPart = Product.TempModList[currentIndex];*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Product.TempModList.Add(currentPart);*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /* if (dataGridView2.SelectedRows.Count != 0)
             {
                 if (Product.TempModList.Any())
                 {
                     DialogResult deleteAssociatedPartCheck = MessageBox.Show("Do you want to delete this associated part?", "Delete?", MessageBoxButtons.YesNo);

                     if (deleteAssociatedPartCheck == DialogResult.Yes)
                     {
                         if (Product.TempModList.Contains(currentPart))
                         {
                             Product.TempModList.Remove(currentPart);

                         }
                     }
                     else if (deleteAssociatedPartCheck == DialogResult.No)
                     {
                         //this should just do nothing
                     }

                 }

             }
             else
             {
                 MessageBox.Show("Please select a part from the list to delete");
             }

             dataGridView2.ClearSelection();*/

        }
        /// <summary>
        /// AddProducts Part Search Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();

            /*bool found = false;

            if (textBox7.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.ToUpper().Contains(textBox7.Text.ToUpper()) || Inventory.AllParts[i].PartID.ToString().Contains(textBox7.Text))
                    {
                        dataGridView1.Rows[i].Selected = true;
                        found = true;
                    }

                }
            }
            if (!found)
            {
                MessageBox.Show("Nothing found!");
            }*/
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void titleTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contact.Text))
            {
                contact.BackColor = Color.Salmon;
                invalid = true;
            }
            else
            {
                contact.BackColor = Color.White;
            }
            button2.Enabled = true;

        }

        private void startLabel_Click(object sender, EventArgs e)
        {

        }

        private void startTimeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private bool isTimeConflict(DateTime start, DateTime end, DateTime apptStart, DateTime apptEnd)
        {

            if (start < apptStart)
            {
                if (end < apptStart)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                if (start > apptEnd)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void checkForTimeConflict()
        {

            for (int index = 0; index < dataTable2.Rows.Count; index++)
            {

                hiddenStartTP.Value = (DateTime)dataTable2.Rows[index]["start"];
                hiddenEndTP.Value = (DateTime)dataTable2.Rows[index]["end"];

                if (isTimeConflict(startTimePicker.Value, endTimePicker.Value, hiddenStartTP.Value, hiddenEndTP.Value))
                {
                    apptERRORLabel.ForeColor = Color.Firebrick;
                    apptERRORLabel.Text = "There is a time conflict! Please adjust the appointment time.";
                    dataGridView2.ClearSelection();
                    dataGridView2.Rows[index].Selected = true;
                    break;
                }
                else
                {
                    apptERRORLabel.ForeColor = Color.Green;
                    apptERRORLabel.Text = "This time slot is available. You can save this appointment now.";

                }

            }
        }
        private void checkForOutsideBusHours()
        {
            DateTime eightAM = new DateTime(2021, 8, 1, 8, 0, 0);
            DateTime fivePM = new DateTime(2021, 8, 1, 17, 0, 0);
            DateTime start = startTimePicker.Value;
            DateTime end = endTimePicker.Value;

            int result1 = DateTime.Compare(start, eightAM);
            int result2 = DateTime.Compare(start, fivePM);
            int result3 = DateTime.Compare(end, eightAM);
            int result4 = DateTime.Compare(end, fivePM);

            if ((start.TimeOfDay < eightAM.TimeOfDay) || (start.TimeOfDay > fivePM.TimeOfDay))
            {
                apptTimes85Label.ForeColor = Color.Firebrick;
                apptTimes85Label.Visible = true;
                outsideBusHours = true;
                apptERRORLabel.Visible = false;

            }
            else if ((end.TimeOfDay < eightAM.TimeOfDay) || (end.TimeOfDay > fivePM.TimeOfDay))
            {
                apptTimes85Label.ForeColor = Color.Firebrick;
                apptTimes85Label.Visible = true;
                outsideBusHours = true;
                apptERRORLabel.Visible = false;
            }
            else
            {
                apptTimes85Label.ForeColor = Color.Green;
                apptTimes85Label.Visible = false;
                outsideBusHours = false;
                apptERRORLabel.Visible = true;
            }

        }
        private bool isOutsideBusHours(DateTime eightAM, DateTime fivePM, DateTime start, DateTime end)
        {

            if ((eightAM < start) && (start < fivePM) && (eightAM < end) && (end < fivePM))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void checkApptBTN_Click_1(object sender, EventArgs e)
        {
            /*//this will connect to the DB and begin the Delete statment
            string dbName = "Robert_Dickerson___InventorySystem.Properties.Settings.client_scheduleConnectionString";

            string connectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;
            MySqlConnection conForDelete = new MySqlConnection(connectionString);

            conForDelete.Open();
            MySqlCommand cmdForDelete = new MySqlCommand($"DELETE FROM appointment WHERE appointmentId = '{Mainscreen.currentAppointmentID}'", conForDelete);
            cmdForDelete.ExecuteNonQuery();
            conForDelete.Close();*/

            //then, this will run the normal checks, but won't error from the previous appt's overlap
            checkForOutsideBusHours();
            checkForTimeConflict();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void descriptionTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                descriptionTextBox.BackColor = Color.Salmon;
            }
            else
            {
                descriptionTextBox.BackColor = Color.White;
            }
            button2.Enabled = true;
        }

        private void locationTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(locationTextBox.Text))
            {
                locationTextBox.BackColor = Color.Salmon;
            }
            else
            {
                locationTextBox.BackColor = Color.White;
            }
            button2.Enabled = true;
        }

        private void contactTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contactTextBox.Text))
            {
                contactTextBox.BackColor = Color.Salmon;
            }
            else
            {
                contactTextBox.BackColor = Color.White;
            }
            button2.Enabled = true;
        }

        /*private void typeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(typeTextBox.Text))
            {
                typeTextBox.BackColor = Color.Salmon;
            }
            else
            {
                typeTextBox.BackColor = Color.White;
            }
            button2.Enabled = true;
        }*/

        private void urlTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(urlTextBox.Text))
            {
                urlTextBox.BackColor = Color.Salmon;
            }
            else
            {
                urlTextBox.BackColor = Color.White;
            }
            button2.Enabled = true;
        }

        private void apptTimes85Label_Click(object sender, EventArgs e)
        {

        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                descriptionTextBox.BackColor = Color.Salmon;
                invalid = true;
            }
            else
            {
                descriptionTextBox.BackColor = Color.White;
            }
            button2.Enabled = true;
        }

        private void locationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(locationTextBox.Text))
            {
                locationTextBox.BackColor = Color.Salmon;
                invalid = true;
            }
            else
            {
                locationTextBox.BackColor = Color.White;
            }
            button2.Enabled = true;
        }

        private void contactTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contactTextBox.Text))
            {
                contactTextBox.BackColor = Color.Salmon;
                invalid = true;
            }
            else
            {
                contactTextBox.BackColor = Color.White;
            }
            button2.Enabled = true;
        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(urlTextBox.Text))
            {
                urlTextBox.BackColor = Color.Salmon;
                invalid = true;
            }
            else
            {
                urlTextBox.BackColor = Color.White;
            }
            button2.Enabled = true;
        }
    }

}
