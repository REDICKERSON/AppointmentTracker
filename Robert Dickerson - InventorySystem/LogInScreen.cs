using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robert_Dickerson___InventorySystem
{
    public partial class LogInScreen : Form
        
    {
        string dbName = "Robert_Dickerson___InventorySystem.Properties.Settings.client_scheduleConnectionString";
        public static string currentUserId;
        public static string currentUserName;
        private bool invalid = false;
        private StreamWriter logInWriter;
        /*public static RegionInfo CurrentRegion { get; }*/
        private string attempts = Path.Combine(Directory.GetCurrentDirectory(), "logInAttemptsLog.txt");
        public static int counter = 1;
        public static string currentRegion;


        public LogInScreen()
        {
            InitializeComponent();
            
            
            CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
            RegionInfo.CurrentRegion.ToString();

            // This will check to see what the computer's current language setting is. My two Log-In display languages are ENGLISH and SPANISH.
            if (currentCulture.ToString() == "es-MX" )
            {
                /*Thread.CurrentThread.CurrentCulture =
                CultureInfo.GetCultureInfo("es_MX");

                Thread.CurrentThread.CurrentUICulture =
                CultureInfo.GetCultureInfo("es-MX");*/

                /*ResourceManager rm = new ResourceManager("LogInScreen.es", Assembly.GetExecutingAssembly());*/

                welcomeMessageLabel.Text = "¡Bienvenidos! Inicie sesión con su nombre de usuario y contraseña a continuación:";
                usernameLabel.Text = "Nombre de usuario";
                passwordLabel.Text = "Contraseña";
                submitBTN.Text = "Entregar";
                exitBTN.Text = "Salida";
                loginErrorLabel.Text = "¡El nombre de usuario y la contraseña no coinciden! Inténtalo de nuevo.";

            };
            

            this.submitBTN.MouseEnter += submitBTN_MouseEnter;
            this.submitBTN.MouseLeave += submitBTN_MouseLeave;

        }


        

        private void exitBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LogInScreen_Load(object sender, EventArgs e)
        {
            //this will be used to save login attempts to a file
            /*FileStream fileStream = new FileStream(attempts, FileMode.Append, FileAccess.Write);
            logInWriter = new StreamWriter(fileStream);*/

            loginErrorLabel.Hide();
            passwordTextbox.UseSystemPasswordChar = true;
        }
        private void submitBTN_MouseEnter(object sender, EventArgs e)
        {
            invalid = this.Controls.OfType<TextBox>()
              .Any(t => t.BackColor == Color.Salmon || string.IsNullOrWhiteSpace(t.Text));
            // I used the LAMBDA expression here to save me many, many lines of code that would list out each one
            // and check to see if it had the backcolor equal to Salmon. This LAMBDA also does the same for all the textboxes
            // and checks to see if they are null or whitespace only characters. 

            if (invalid)
            {
                submitBTN.Enabled = false;

                submitBTN.UseVisualStyleBackColor = false;
                submitBTN.BackColor = Color.DarkGray;
            }
        }
        private void submitBTN_MouseLeave(object sender, EventArgs e)
        {
            submitBTN.BackColor = Color.White;
        }
        private void submitBTN_Click(object sender, EventArgs e)
        {
            loginErrorLabel.Hide();

            string connectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString;

            MySqlConnection conToMySQL = new MySqlConnection(connectionString);
            conToMySQL.Open();
            MySqlCommand cmdToMySQL = new MySqlCommand("SELECT * FROM user", conToMySQL);
            MySqlDataAdapter adapterMySQL = new MySqlDataAdapter(cmdToMySQL);

            DataTable dataTable = new DataTable();
            adapterMySQL.Fill(dataTable);

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if ((dataTable.Rows[i]["userName"].Equals(usernameTextbox.Text)) &&
                    (dataTable.Rows[i]["password"].Equals(passwordTextbox.Text)))
                {
                    currentUserId = dataTable.Rows[i]["userId"].ToString();
                    currentUserName = dataTable.Rows[i]["userName"].ToString();

                    Mainscreen mainScreen = new Mainscreen();
                    mainScreen.Show();

                    this.Hide();

                    try
                    {
                        using (FileStream fileStream = new FileStream(attempts, FileMode.Append, FileAccess.Write))
                        {
                            /*FileStream fileStream = new FileStream(attempts, FileMode.Append, FileAccess.Write);*/
                            logInWriter = new StreamWriter(fileStream);
                            string success = $"{DateTime.Now} - UserID: {currentUserId}, UserName: {currentUserName}, has successfully logged in.";
                            logInWriter.WriteLine(success);
                            logInWriter.Close();
                        }
                            /*FileStream fileStream = new FileStream(attempts, FileMode.Append, FileAccess.Write);*//*
                            logInWriter = new StreamWriter(fileStream);
                        string success = $"{DateTime.Now} - UserID: {currentUserId}, UserName: {currentUserName}, has successfully logged in.";
                        logInWriter.WriteLine(success);
                        logInWriter.Close();*/
                         
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    
                    /*Console.WriteLine("YOU DID IT");*/
                }
                else
                {
                    loginErrorLabel.Show();

                    try
                    {
                        using(FileStream fileStream = new FileStream(attempts, FileMode.Append, FileAccess.Write))
                        {
                            logInWriter = new StreamWriter(fileStream);
                            string failed = $"{DateTime.Now} - There was a failed attempt to login for the UserName: '{usernameTextbox.Text.ToString()}' !";
                            logInWriter.WriteLine(failed);
                            logInWriter.Close();
                        }
                        /*logInWriter = new StreamWriter(fileStream2);
                        string failed = $"{DateTime.Now} - There was a failed attempt to login for the UserName: '{usernameTextbox.Text.ToString()}' !";
                        logInWriter.WriteLine(failed);*/                    
                            
                       
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                    /*MessageBox.Show("YOU ARE WRONG!");*/
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(usernameTextbox.Text))
            {
                usernameTextbox.BackColor = Color.Salmon;
            }
            else
            {
                usernameTextbox.BackColor = Color.White;
            }
            submitBTN.Enabled = true;
        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTextbox.Text))
            {
                passwordTextbox.BackColor = Color.Salmon;
            }
            else
            {
                passwordTextbox.BackColor = Color.White;
            }
            submitBTN.Enabled = true;
        }

        private void welcomeMessageLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
