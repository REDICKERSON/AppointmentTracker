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
    public partial class AddCustomer : Form
    {
        private string connectionString;
        private MySqlConnection conToMySQL;
        private MySqlDataReader mySqlDataReader;
        private MySqlCommand cmdToMySQL;
        private int id;
        

        public string dbName = "Robert_Dickerson___InventorySystem.Properties.Settings.client_scheduleConnectionString";
        private bool invalid = false;

        public delegate void EventHandler();

        public AddCustomer()
        {
            InitializeComponent();

            this.SaveButton.MouseEnter += button2_MouseEnter;
            this.SaveButton.MouseLeave += button2_MouseLeave;
            connectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;
            conToMySQL = new MySqlConnection(connectionString);
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
        public void ValidateTextBox()
        {
            if (string.IsNullOrWhiteSpace(addCustomerNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(addCustomerAddressTextBox.Text) ||
                string.IsNullOrWhiteSpace(addCustomerAddress2TextBox.Text) ||
                string.IsNullOrWhiteSpace(addCustomerCityTextBox.Text) ||
                string.IsNullOrWhiteSpace(addCustomerCountryTextBox.Text) ||
                !long.TryParse(addCustomerPostalCodeTextBox.Text, out long num) ||
                !long.TryParse(addCustomerPhoneTextBox.Text, out long num2))
            {
                return;
            }

            /*bool b_inv = Int32.TryParse(addCustomerAddressTextBox.Text, out int inv);
            bool b_min = Int32.TryParse(textBox5.Text, out int min) && inv >= min;
            bool b_max = Int32.TryParse(textBox6.Text, out int max) && inv <= max;

            addCustomerAddressTextBox.BackColor = b_inv ? Color.White : Color.Salmon;
            textBox5.BackColor = b_min ? Color.White : Color.Salmon;
            textBox6.BackColor = b_max ? Color.White : Color.Salmon;*/

            SaveButton.Enabled = true;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            invalid = this.Controls.OfType<TextBox>()
              .Any(t => t.BackColor == Color.Salmon || string.IsNullOrWhiteSpace(t.Text));
            // I also used the LAMBDA expression here to save me many, many lines of code that would list out each one
            // and check to see if it had the backcolor equal to Salmon. This LAMBDA also does the same for all the textboxes
            // and checks to see if they are null or whitespace only characters. 

            if (invalid)
            {
                SaveButton.Enabled = false;

                SaveButton.UseVisualStyleBackColor = false;
                SaveButton.BackColor = Color.DarkGray;
            }
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            SaveButton.BackColor = Color.White;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            /*if (radioButton1.Checked)
            {
                int num;
                if (string.IsNullOrWhiteSpace(textBox7.Text) || !Int32.TryParse(textBox7.Text, out int num))
                {
                    textBox7.BackColor = Color.Salmon;
                }
                else
                {
                    textBox7.BackColor = Color.White;
                }
                button2.Enabled = true;
            }
            else
            {

                if (string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    textBox7.BackColor = Color.Salmon;
                    invalid = true;
                }
                else
                {
                    textBox7.BackColor = Color.White;
                }
                button2.Enabled = true;
            }*/
        }
       
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            /*//label 8 needs to read "Company Name" when radio button 2 is pressed, and textbox 7 needs to accept a string.
            if (radioButton2.Enabled)
            {
                label8.Text = "Company Name";
                isInhouse = false;

                if (string.IsNullOrWhiteSpace(textBox7.Text))
                {
                    textBox7.BackColor = Color.Salmon;
                }
                else
                {
                    textBox7.BackColor = Color.White;
                }
            }*/

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            /*//label 8 needs to read "Machine ID" and textbox 7 needs to accept only integers when radio button 1 is pressed.
            if (radioButton1.Enabled)
            {
                isInhouse = true;

                label8.Text = "Machine ID";
                Double num1;
                if (string.IsNullOrWhiteSpace(textBox7.Text) || !Double.TryParse(textBox7.Text, out num1))
                {
                    textBox7.BackColor = Color.Salmon;
                }
                else
                {
                    textBox7.BackColor = Color.White;
                }
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*Console.WriteLine(CreatedBY());
            Console.WriteLine(CreateDATE());*/
            Close();
        }

        private void CreateCountry()
        {
            
            
            conToMySQL.Open();
            cmdToMySQL = new MySqlCommand($"INSERT INTO country(country, createDate, createdBy, lastUpdate, lastUpdateBy)" +
            $" VALUES ('{addCustomerCountryTextBox.Text}','{CreateUtcDATE()}','{CreatedBY()}','{LastUtcUPDATE()}','{LastUpdateBY()}')", conToMySQL);
            cmdToMySQL.ExecuteReader();
            conToMySQL.Close();

            conToMySQL.Open();
            cmdToMySQL = new MySqlCommand($"SELECT countryId FROM country WHERE country = '{addCustomerCountryTextBox.Text}' ", conToMySQL);

            id = (int)GetReaderVALUE(cmdToMySQL);
            conToMySQL.Close();
            
        }

        private void CreateCity()
        {
            try
            {
                conToMySQL.Open();
                cmdToMySQL = new MySqlCommand($"INSERT INTO city(city, countryId, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                $" VALUES ('{addCustomerCityTextBox.Text}','{id}','{CreateUtcDATE()}','{CreatedBY()}','{LastUtcUPDATE()}','{LastUpdateBY()}')", conToMySQL);
                cmdToMySQL.ExecuteReader();
                conToMySQL.Close();

                conToMySQL.Open();
                cmdToMySQL = new MySqlCommand($"SELECT cityId FROM city WHERE city = '{addCustomerCityTextBox.Text}' ", conToMySQL);


                id = (int)GetReaderVALUE(cmdToMySQL);
                conToMySQL.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void CreateAddress()
        {
            if (id != -1)
            {
                try
                {
                    conToMySQL.Open();
                    cmdToMySQL = new MySqlCommand($"INSERT INTO address(address, address2, cityId, postalCode, phone, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                        $" VALUES ('{addCustomerAddressTextBox.Text}','{addCustomerAddress2TextBox.Text}','{id}','{addCustomerPostalCodeTextBox.Text}','{addCustomerPhoneTextBox.Text}','{CreateUtcDATE()}','{CreatedBY()}','{LastUtcUPDATE()}','{LastUpdateBY()}')", conToMySQL);

                    cmdToMySQL.ExecuteReader();
                    conToMySQL.Close();

                    conToMySQL.Open();
                    cmdToMySQL = new MySqlCommand($"SELECT addressId FROM address WHERE address = '{addCustomerAddressTextBox.Text}' ", conToMySQL);

                    id = (int)GetReaderVALUE(cmdToMySQL);
                    conToMySQL.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            
        }
        private void CreateCustomer()
        {
            if (id != -1)
            {
                try
                {
                    conToMySQL.Open();
                    cmdToMySQL = new MySqlCommand($"INSERT INTO customer(customerName, addressId, active, createDate, createdBy, lastUpdate, lastUpdateBy)" +
                        $" VALUES ('{addCustomerNameTextBox.Text}','{id}','1','{CreateUtcDATE()}','{CreatedBY()}','{LastUtcUPDATE()}','{LastUpdateBY()}')", conToMySQL);
                    cmdToMySQL.ExecuteReader();
                    conToMySQL.Close();

                    conToMySQL.Open();
                    cmdToMySQL = new MySqlCommand($"SELECT customerId FROM customer WHERE customerName = '{addCustomerNameTextBox.Text}' ", conToMySQL);

                    id = (int)GetReaderVALUE(cmdToMySQL);
                    conToMySQL.Close();

                    //this will refresh the DBDGV1 table
                    conToMySQL = new MySqlConnection(connectionString);
                    conToMySQL.Open();
                    cmdToMySQL = new MySqlCommand("SELECT * FROM customer", conToMySQL);
                    Mainscreen.adapterToMySQL = new MySqlDataAdapter(selectCommand: cmdToMySQL);

                    Mainscreen.dataTable = new DataTable();
                    Mainscreen.dataTable.Load(cmdToMySQL.ExecuteReader());
                    Mainscreen.dataGridView.DataSource = Mainscreen.dataTable;
                    Mainscreen.adapterToMySQL.Fill(Mainscreen.dataTable);

                    //this will convert the UTC times in the database back into local times for datagridview2 on save
                    for (int i = 0; i < Mainscreen.dataTable.Rows.Count; i++)
                    {
                        Mainscreen.dataTable.Rows[i]["createDate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable.Rows[i]["createDate"], TimeZoneInfo.Local).ToString();
                        Mainscreen.dataTable.Rows[i]["lastUpdate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable.Rows[i]["lastUpdate"], TimeZoneInfo.Local).ToString();
                    }


                    conToMySQL.Close();

                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }        


        }
        public object GetReaderVALUE(MySqlCommand cmdToMySQL)
        {

            mySqlDataReader = cmdToMySQL.ExecuteReader();
            if (mySqlDataReader.Read()) 
            {
                return mySqlDataReader[0];
            }
            return -1;
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            invalid = this.Controls.OfType<TextBox>()
              .Any(t => t.BackColor == Color.Salmon || string.IsNullOrWhiteSpace(t.Text));
            // I also used the LAMBDA expression here to save me many, many lines of code that would list out each one
            // and check to see if it had the backcolor equal to Salmon. This LAMBDA also does the same for all the textboxes
            // and checks to see if they are null or whitespace only characters. 

            if (invalid)
            {
                SaveButton.Enabled = false;

                SaveButton.UseVisualStyleBackColor = false;
                SaveButton.BackColor = Color.DarkGray;
            }
            else
            {
                string connectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;

                conToMySQL.Open();

                // this select statement checks to see if the countryID exists, if not, it will then insert that info into DB.
                cmdToMySQL = new MySqlCommand($"SELECT countryId FROM country WHERE country = '{addCustomerCountryTextBox.Text}' ", conToMySQL);

                id = (int)GetReaderVALUE(cmdToMySQL);
                conToMySQL.Close();

                if (id == -1)
                {
                    CreateCountry();
                    CreateCity();
                    CreateAddress();
                    CreateCustomer();
                    return;
                }

                //this is for cityId
                conToMySQL.Open();
                cmdToMySQL = new MySqlCommand($"SELECT cityId FROM city WHERE city = '{addCustomerCityTextBox.Text}' ", conToMySQL);
                id = (int)GetReaderVALUE(cmdToMySQL);
                conToMySQL.Close();

                if (id == -1)
                {

                    CreateCity();
                    CreateAddress();
                    CreateCustomer();
                    return;
                }


                // this is for addressId
                conToMySQL.Open();
                cmdToMySQL = new MySqlCommand($"SELECT addressId FROM address WHERE address = '{addCustomerAddressTextBox.Text}' ", conToMySQL);

                id = (int)GetReaderVALUE(cmdToMySQL);
                conToMySQL.Close();


                if (id == -1)
                {

                    CreateAddress();
                    CreateCustomer();
                    return;
                }

                // this is for customerId
                conToMySQL.Open();
                cmdToMySQL = new MySqlCommand($"SELECT customerId FROM customer WHERE customerName = '{addCustomerNameTextBox.Text}' ", conToMySQL);

                id = (int)GetReaderVALUE(cmdToMySQL);
                conToMySQL.Close();

                if (id == -1)
                {

                    CreateCustomer();
                    return;
                }


                Close();
            }
        }

    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addCustomerNameTextBox.Text))
            {
                addCustomerNameTextBox.BackColor = Color.Salmon;
            }
            else
            {
                addCustomerNameTextBox.BackColor = Color.White;
            }
            SaveButton.Enabled = true;
        }
        /// <summary>
        /// Inventory text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addCustomerAddressTextBox.Text))
            {
                addCustomerAddressTextBox.BackColor = Color.Salmon;
            }
            else
            {
                addCustomerAddressTextBox.BackColor = Color.White;
            }
            SaveButton.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(addCustomerPhoneTextBox.Text) || !long.TryParse(addCustomerPhoneTextBox.Text, out long num))
            {
                addCustomerPhoneTextBox.BackColor = Color.Salmon;
            }
            else
            {
                addCustomerPhoneTextBox.BackColor = Color.White;
            }
            SaveButton.Enabled = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {


            ValidateTextBox();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Addpart_Load(object sender, EventArgs e)
        {

        }

        private void addCustomerAddress2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addCustomerAddress2TextBox.Text))
            {
                addCustomerAddress2TextBox.BackColor = Color.Salmon;
            }
            else
            {
                addCustomerAddress2TextBox.BackColor = Color.White;
            }
            SaveButton.Enabled = true;
        }

        private void addCustomerCityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addCustomerCityTextBox.Text))
            {
                addCustomerCityTextBox.BackColor = Color.Salmon;
            }
            else
            {
                addCustomerCityTextBox.BackColor = Color.White;
            }
            SaveButton.Enabled = true;
        }

        private void addCustomerCountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addCustomerCountryTextBox.Text))
            {
                addCustomerCountryTextBox.BackColor = Color.Salmon;
            }
            else
            {
                addCustomerCountryTextBox.BackColor = Color.White;
            }
            SaveButton.Enabled = true;
        }

        private void addCustomerPostalCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addCustomerPostalCodeTextBox.Text) || !long.TryParse(addCustomerPostalCodeTextBox.Text, out long num))
            {
                addCustomerPostalCodeTextBox.BackColor = Color.Salmon;
            }
            else
            {
                addCustomerPostalCodeTextBox.BackColor = Color.White;
            }
            SaveButton.Enabled = true;
        }
    }
}

