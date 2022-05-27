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
    public partial class ModifyAppointment : Form
    {
        public delegate void DataGridViewCellEventHandler();
        public static int customerIndex;
        public static string customerSelectID;
        public static Part currentAssociatedPart;
        DataTable dataTable2 = new DataTable();
        public static int index = 0;
        public static string dbName = "Robert_Dickerson___InventorySystem.Properties.Settings.client_scheduleConnectionString";
        private bool invalid = false;

        public ModifyAppointment()
        {
            InitializeComponent();

            typeComboBox.DataSource = AddAppointment.typeString;

            this.saveBTN.MouseEnter += saveBTN_MouseEnter;
            this.saveBTN.MouseLeave += saveBTN_MouseLeave;


            string dbName = "Robert_Dickerson___InventorySystem.Properties.Settings.client_scheduleConnectionString";

            //this connection and table is made to set variables for populating appointment text boxes to modify
            string connectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;

            MySqlConnection conForAppts = new MySqlConnection(connectionString);
            conForAppts.Open();
            MySqlCommand cmdForAppts = new MySqlCommand($"SELECT * FROM appointment WHERE appointmentId ='{Mainscreen.currentAppointmentID}'", conForAppts);
            MySqlDataAdapter apptAdapter = new MySqlDataAdapter(selectCommand: cmdForAppts);

            DataTable apptTable = new DataTable();
            apptTable.Load(cmdForAppts.ExecuteReader());

            string tempTitle = apptTable.Rows[0]["title"].ToString();
            string userID = apptTable.Rows[0]["userId"].ToString();
            string tempCustomerID = apptTable.Rows[0]["customerId"].ToString();
            string tempDescription = apptTable.Rows[0]["description"].ToString();
            string tempLocation = apptTable.Rows[0]["location"].ToString();
            string tempContact = apptTable.Rows[0]["contact"].ToString();
            string tempType = apptTable.Rows[0]["type"].ToString();
            string tempUrl = apptTable.Rows[0]["url"].ToString();

            conForAppts.Close();

            //this populates the text boxes accordingly
            titleTextBox.Text = tempTitle;
            descriptionTextBox.Text = tempDescription;
            locationTextBox.Text = tempLocation;
            contactTextBox.Text = tempContact;
            /*typeTextBox.Text = tempType;*/
            urlTextBox.Text = tempUrl;

        }
        public string LastUtcUPDATE()
        {
            return DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd, HH:mm:ss");
        }
        public string LastUpdateBY()
        {
            return LogInScreen.currentUserName;
        }
        public void ValidateTextBox()
        {
            /*if (string.IsNullOrWhiteSpace(textBox5.Text) ||
                string.IsNullOrWhiteSpace(textBox6.Text) ||
                string.IsNullOrWhiteSpace(textBox4.Text))
            {
                return;
            }

            bool b_inv = Int32.TryParse(textBox4.Text, out int inv);
            bool b_min = Int32.TryParse(textBox5.Text, out int min) && inv >= min;
            bool b_max = Int32.TryParse(textBox6.Text, out int max) && inv <= max;

            textBox4.BackColor = b_inv ? Color.White : Color.Salmon;
            textBox5.BackColor = b_min ? Color.White : Color.Salmon;
            textBox6.BackColor = b_max ? Color.White : Color.Salmon;

            button2.Enabled = true;*/
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //I only need these if I am using datagridviews

            /*currentIndex = dataGridView1.CurrentCell.RowIndex;
            currentPart = Inventory.AllParts[currentIndex];*/

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //I only need these if I am using datagridviews

            /*currentIndex = dataGridView2.CurrentCell.RowIndex;
            currentPart = Product.TempModList[currentIndex];*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Close();  
        }
        /// <summary>
        /// Save Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            

            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Product.TempModList.Add(currentPart);*/
        }

        private void Modifyproduct_Load(object sender, EventArgs e)
        {
            //I only need these if I am using datagridviews

            /*dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();

            this.dataGridView1.CellClick += dataGridView1_CellClick;
            this.dataGridView2.CellClick += dataGridView2_CellClick;*/
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*if (dataGridView2.SelectedRows.Count != 0)
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

        private void button4_Click(object sender, EventArgs e)
        {
            /*dataGridView1.ClearSelection();*/

            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           /* if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.BackColor = Color.Salmon;
            }
            else
            {
                textBox2.BackColor = Color.White;
            }
            button2.Enabled = true;*/
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           /* Double num;
            if (string.IsNullOrWhiteSpace(textBox3.Text) || !Double.TryParse(textBox3.Text, out num))
            {
                textBox3.BackColor = Color.Salmon;
            }
            else
            {
                textBox3.BackColor = Color.White;
            }
            button2.Enabled = true;*/
        }
        private void saveBTN_MouseLeave(object sender, EventArgs e)
        {
            saveBTN.BackColor = Color.White;
        }
        private void saveBTN_MouseEnter(object sender, EventArgs e)
        {
            invalid = this.Controls.OfType<TextBox>()
              .Any(t => t.BackColor == Color.Salmon || string.IsNullOrWhiteSpace(t.Text));
            // I used the LAMBDA expression here to save me many, many lines of code that would list out each one
            // and check to see if it had the backcolor equal to Salmon. This LAMBDA also does the same for all the textboxes
            // and checks to see if they are null or whitespace only characters. 

            if (invalid)
            {
                saveBTN.Enabled = false;

                saveBTN.UseVisualStyleBackColor = false;
                saveBTN.BackColor = Color.DarkGray;
            }
        }

        private void saveBTN_Click(object sender, EventArgs e)
        {
            //this sets the text boxes to local variables for use in insert statements
            string title = titleTextBox.Text;
            string description = descriptionTextBox.Text;
            string location = locationTextBox.Text;
            string contact = contactTextBox.Text;
            string type = typeComboBox.SelectedValue.ToString();
            string url = urlTextBox.Text;           

            //this will connect to the DB and begin the insert statments
            string dbName = "Robert_Dickerson___InventorySystem.Properties.Settings.client_scheduleConnectionString";

            string connectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;

            //this inserts the modified data from the name text box
            MySqlConnection conForInsert = new MySqlConnection(connectionString);

            conForInsert.Open();
            MySqlCommand cmdForApptUpdate = new MySqlCommand($"UPDATE appointment SET title ='{title}', description = '{description}', location = '{location}', contact = '{contact}', type = '{type}', url = '{url}', lastUpdate = '{LastUtcUPDATE()}', lastUpdateBy = '{LastUpdateBY()}' WHERE appointmentId = '{Mainscreen.currentAppointmentID}'", conForInsert);
            cmdForApptUpdate.ExecuteNonQuery();
            conForInsert.Close();

            //this will refresh the DBDGV2 table
            conForInsert.Open();
            cmdForApptUpdate = new MySqlCommand("SELECT * FROM appointment", conForInsert);
            Mainscreen.adapterToMySQL = new MySqlDataAdapter(selectCommand: cmdForApptUpdate);

            Mainscreen.dataTable2 = new DataTable();
            Mainscreen.dataTable2.Load(cmdForApptUpdate.ExecuteReader());
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
            
            conForInsert.Close();

            Close();

            MessageBox.Show("The appointment was modified.");
            Mainscreen.dataGridView2.ClearSelection();

        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            Close();
            Mainscreen.dataGridView2.ClearSelection();
        }

        private void titleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(titleTextBox.Text))
            {
                titleTextBox.BackColor = Color.Salmon;
            }
            else
            {
                titleTextBox.BackColor = Color.White;
            }
            saveBTN.Enabled = true;
        }

        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                descriptionTextBox.BackColor = Color.Salmon;
            }
            else
            {
                descriptionTextBox.BackColor = Color.White;
            }
            saveBTN.Enabled = true;
        }

        private void locationTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(locationTextBox.Text))
            {
                locationTextBox.BackColor = Color.Salmon;
            }
            else
            {
                locationTextBox.BackColor = Color.White;
            }
            saveBTN.Enabled = true;
        }

        private void contactTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(contactTextBox.Text))
            {
                contactTextBox.BackColor = Color.Salmon;
            }
            else
            {
                contactTextBox.BackColor = Color.White;
            }
            saveBTN.Enabled = true;
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
            saveBTN.Enabled = true;
        }*/

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(urlTextBox.Text))
            {
                urlTextBox.BackColor = Color.Salmon;
            }
            else
            {
                urlTextBox.BackColor = Color.White;
            }
            saveBTN.Enabled = true;
        }
    }
}
