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
    public partial class ModifyCustomer : Form
    {
        public bool isInhouse;
        private bool invalid = false;
        public Part currentPart;
        public string insertCityID;
        public string insertCountryID;
        public string currentCustomerID = Mainscreen.currentCustomerID;
        public string currentCustomerAddressID = Mainscreen.currentCustomerAddressID;
        
        
       
       

        public delegate void EventHandler();
        public ModifyCustomer()
        {
            

            InitializeComponent();
            /*currentPart = Mainscreen.currentPart;*/
            this.saveBTN.MouseEnter += button2_MouseEnter;
            this.saveBTN.MouseLeave += button2_MouseLeave;            

            //this populates the customer name in the text box
            customerNameTextBox.Text = Mainscreen.currentCustomerName.ToString();

            string dbName = "Robert_Dickerson___InventorySystem.Properties.Settings.client_scheduleConnectionString";

            //this populates the customer address1 in the text box
            string connectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;

            MySqlConnection conForAddress = new MySqlConnection(connectionString);
            conForAddress.Open();
            MySqlCommand cmdForAddress = new MySqlCommand($"SELECT * FROM address WHERE addressId ='{currentCustomerAddressID}'", conForAddress);
            MySqlDataAdapter addressAdapter = new MySqlDataAdapter(selectCommand: cmdForAddress);

            DataTable addressTable = new DataTable();
            addressTable.Load(cmdForAddress.ExecuteReader());            

            string tempAddress = addressTable.Rows[0]["address"].ToString();
            string cityID = addressTable.Rows[0]["cityId"].ToString();
            string tempPostalCode = addressTable.Rows[0]["postalCode"].ToString();
            string tempPhone = addressTable.Rows[0]["phone"].ToString();

            addressTextBox.Text = tempAddress.ToString();
            
            insertCityID = cityID.ToString();

            conForAddress.Close();

            //this populates the customer address2 in the text box
            string tempAddress2 = addressTable.Rows[0]["address2"].ToString();

            address2TextBox.Text = tempAddress2.ToString();
            

            //this populates the customer city in the text box
            MySqlConnection conForCity = new MySqlConnection(connectionString);
            conForCity.Open();
            MySqlCommand cmdForCity = new MySqlCommand($"SELECT * FROM city WHERE cityId ='{cityID}'", conForCity);
            MySqlDataAdapter cityAdapter = new MySqlDataAdapter(selectCommand: cmdForCity);

            DataTable cityTable = new DataTable();
            cityTable.Load(cmdForCity.ExecuteReader());
            
            string tempCity = cityTable.Rows[0]["city"].ToString();
            string countryID = cityTable.Rows[0]["countryId"].ToString();

            cityTextBox.Text = tempCity.ToString();

            insertCountryID = countryID.ToString();

            conForCity.Close();

            //this populates the customer country in the text box
            MySqlConnection conForCountry = new MySqlConnection(connectionString);
            conForCountry.Open();
            MySqlCommand cmdForCountry = new MySqlCommand($"SELECT * FROM country WHERE countryId ='{countryID}'", conForCountry);
            MySqlDataAdapter countryAdapter = new MySqlDataAdapter(selectCommand: cmdForCountry);

            DataTable countryTable = new DataTable();
            countryTable.Load(cmdForCountry.ExecuteReader());            

            string tempCountry = countryTable.Rows[0]["country"].ToString();
            
            countryTextBox.Text = tempCountry.ToString();

            conForCountry.Close();

            //this populates the customer postal code in the text box
            postalCodeTextBox.Text = tempPostalCode.ToString();

            //this populates the customer phone number in the text box
            phoneTextBox.Text = tempPhone.ToString();

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

            saveBTN.Enabled = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            
        }
        /// <summary>
        /// Modify Part Save Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            /*if (invalid) { return; }
            bool b_inv = (Int32.TryParse(textBox4.Text, out int num1));
            bool b_min = (Int32.TryParse(textBox5.Text, out int num2));
            bool b_max = (Int32.TryParse(textBox6.Text, out int num3));
            if ((b_inv && b_min) && (num1 < num2) || (b_max && b_min) && (num2 > num3))
            {
                textBox5.BackColor = Color.Salmon;
            }
            else
            {
                textBox5.BackColor = Color.White;
             
            }
            if (radioButton1.Checked == true)
            {
                Inventory.AllParts[Mainscreen.currentIndex] = new Inhouse(int.Parse(textBox1.Text), textBox2.Text, Double.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text), int.Parse(textBox7.Text));
            }
            else
            {
                Inventory.AllParts[Mainscreen.currentIndex] = new Outsourced(int.Parse(textBox1.Text), textBox2.Text, Double.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text), int.Parse(textBox6.Text), textBox7.Text);
            }*/

            Close();

        }
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            invalid = this.Controls.OfType<TextBox>().Any(t => t.BackColor == Color.Salmon);
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
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            saveBTN.BackColor = Color.White;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            /*if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                textBox2.BackColor = Color.Salmon;
            }
            else
            {
                textBox2.BackColor = Color.White;
            }
            saveBTN.Enabled = true;*/


        }
        /// <summary>
        /// Inventory textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

            ValidateTextBox();
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            /*Double num;
            if (string.IsNullOrWhiteSpace(textBox3.Text) || !Double.TryParse(textBox3.Text, out num))
            {
                textBox3.BackColor = Color.Salmon;
            }
            else
            {
                textBox3.BackColor = Color.White;
            }
            saveBTN.Enabled = true;*/
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            ValidateTextBox();

        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            ValidateTextBox();
        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            /*if (radioButton1.Checked)
            {
                int num;
                if (string.IsNullOrWhiteSpace(textBox7.Text) || !Int32.TryParse(textBox7.Text, out num))
                {
                    textBox7.BackColor = Color.Salmon;
                }
                else
                {
                    textBox7.BackColor = Color.White;
                }
                saveBTN.Enabled = true;
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
                saveBTN.Enabled = true;

            }*/
        }

        private void Modifypart_Load(object sender, EventArgs e)
        {
            
            /*int num;
            if (string.IsNullOrWhiteSpace(textBox4.Text) || !Int32.TryParse(textBox4.Text, out num))
            {
                textBox4.BackColor = Color.Salmon;
            }
            else
            {
                textBox4.BackColor = Color.White;
            }

            int inv;
            Int32.TryParse(textBox4.Text, out inv);
            int min;
            Int32.TryParse(textBox5.Text, out min);
            int max;
            Int32.TryParse(textBox6.Text, out max);
            if ((inv < min) || (inv > max))
            {
                textBox4.BackColor = Color.Salmon;
            }
            else
            {
                textBox4.BackColor = Color.White;
            }

            int num2;
            if (string.IsNullOrWhiteSpace(textBox5.Text) || !Int32.TryParse(textBox5.Text, out num2))
            {
                textBox5.BackColor = Color.Salmon;
            }
            else
            {
                textBox5.BackColor = Color.White;
            }
            int inv2;
            Int32.TryParse(textBox4.Text, out inv2);
            int min2;
            Int32.TryParse(textBox5.Text, out min2);
            int max2;
            Int32.TryParse(textBox6.Text, out max2);
            if ((max2 < min2) || (min2 > max2))
            {
                textBox5.BackColor = Color.Salmon;
            }
            else
            {
                textBox5.BackColor = Color.White;
            }*/
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            
            Close();
            Mainscreen.dataGridView.ClearSelection();
            
        }
        public string LastUtcUPDATE()
        {
            return DateTime.Now.ToUniversalTime().ToString("yyyy-MM-dd, HH:mm:ss");
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
            else
            {
                //this sets the text boxes to local variables for use in insert statements
                string name = customerNameTextBox.Text;
                string address = addressTextBox.Text;
                string address2 = address2TextBox.Text;
                string city = cityTextBox.Text;
                string country = countryTextBox.Text;
                string postalCode = postalCodeTextBox.Text;
                string phone = phoneTextBox.Text;

                //this will connect to the DB and begin the insert statments
                string dbName = "Robert_Dickerson___InventorySystem.Properties.Settings.client_scheduleConnectionString";

                string connectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;

                //this inserts the modified data from the name text box
                MySqlConnection conForInsert = new MySqlConnection(connectionString);

                conForInsert.Open();
                MySqlCommand cmdForName = new MySqlCommand($"UPDATE customer SET customerName ='{name}' WHERE customerId = '{currentCustomerID}'", conForInsert);
                cmdForName.ExecuteNonQuery();
                conForInsert.Close();

                //this inserts the modified data from the address, address2, postal code, and phone text boxes
                conForInsert.Open();
                MySqlCommand cmdForAddress = new MySqlCommand($"UPDATE address SET address = '{address}', address2 = '{address2}', postalCode = '{postalCode}', phone = '{phone}' WHERE addressId = '{currentCustomerAddressID}'", conForInsert);
                cmdForAddress.ExecuteNonQuery();
                conForInsert.Close();

                //this inserts the modified data from the city text box
                conForInsert.Open();
                MySqlCommand cmdForCity = new MySqlCommand($"UPDATE city SET city = '{city}' WHERE cityId = '{insertCityID}'", conForInsert);
                cmdForCity.ExecuteNonQuery();
                conForInsert.Close();

                //this inserts the modified data from the country text box
                conForInsert.Open();
                MySqlCommand cmdForCountry = new MySqlCommand($"UPDATE country SET country = '{country}' WHERE countryId = '{insertCountryID}'", conForInsert);
                cmdForCountry.ExecuteNonQuery();
                conForInsert.Close();

                //this sets when this record was last updated
                conForInsert.Open();
                MySqlCommand cmdForLastUpdate = new MySqlCommand($"UPDATE customer SET lastUpdate = '{LastUtcUPDATE()}' WHERE customerId = '{currentCustomerID}'", conForInsert);
                cmdForCountry.ExecuteNonQuery();
                conForInsert.Close();


                //this will run a new select statement and populate the DBDGV1
                conForInsert.Open();
                cmdForName = new MySqlCommand("SELECT * FROM customer", conForInsert);
                Mainscreen.adapterToMySQL = new MySqlDataAdapter(selectCommand: cmdForName);

                Mainscreen.dataTable = new DataTable();

                Mainscreen.dataTable.Load(cmdForName.ExecuteReader());
                Mainscreen.dataGridView.DataSource = Mainscreen.dataTable;

                //this will convert the UTC times in the database back into local times for datagridview2 on save
                for (int i = 0; i < Mainscreen.dataTable.Rows.Count; i++)
                {
                    Mainscreen.dataTable.Rows[i]["createDate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable.Rows[i]["createDate"], TimeZoneInfo.Local).ToString();
                    /*Mainscreen.dataTable.Rows[i]["lastUpdate"] = TimeZoneInfo.ConvertTimeFromUtc((DateTime)Mainscreen.dataTable.Rows[i]["lastUpdate"], TimeZoneInfo.Local).ToString();*/
                }

                conForInsert.Close();

                Mainscreen.dataGridView.ClearSelection();

                Close();

                MessageBox.Show("The customer was modified.");
            }
        }

        private void phoneTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(phoneTextBox.Text) || !long.TryParse(phoneTextBox.Text, out long num))
            {
                phoneTextBox.BackColor = Color.Salmon;
            }
            else
            {
                phoneTextBox.BackColor = Color.White;
            }
            saveBTN.Enabled = true;
        }

        private void postalCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(postalCodeTextBox.Text) || !long.TryParse(postalCodeTextBox.Text, out long num))
            {
                postalCodeTextBox.BackColor = Color.Salmon;
            }
            else
            {
                postalCodeTextBox.BackColor = Color.White;
            }
            saveBTN.Enabled = true;
        }

        private void customerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(customerNameTextBox.Text))
            {
                customerNameTextBox.BackColor = Color.Salmon;
            }
            else
            {
                customerNameTextBox.BackColor = Color.White;
            }
            saveBTN.Enabled = true;
        }

        private void addressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                addressTextBox.BackColor = Color.Salmon;
            }
            else
            {
                addressTextBox.BackColor = Color.White;
            }
            saveBTN.Enabled = true;
        }

        private void address2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(address2TextBox.Text))
            {
                address2TextBox.BackColor = Color.Salmon;
            }
            else
            {
                address2TextBox.BackColor = Color.White;
            }
            saveBTN.Enabled = true;
        }

        private void cityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                cityTextBox.BackColor = Color.Salmon;
            }
            else
            {
                cityTextBox.BackColor = Color.White;
            }
            saveBTN.Enabled = true;
        }

        private void countryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(countryTextBox.Text))
            {
                countryTextBox.BackColor = Color.Salmon;
            }
            else
            {
                countryTextBox.BackColor = Color.White;
            }
            saveBTN.Enabled = true;
        }
    }
}
