namespace Robert_Dickerson___InventorySystem
{
    partial class AddCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.addCustomerLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.addCustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.addCustomerPhoneNumberLabel = new System.Windows.Forms.Label();
            this.addCustomerPhoneTextBox = new System.Windows.Forms.TextBox();
            this.addCustomerAddressLabel = new System.Windows.Forms.Label();
            this.addCustomerAddressTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.addCustomerAddress2Label = new System.Windows.Forms.Label();
            this.addCustomerAddress2TextBox = new System.Windows.Forms.TextBox();
            this.addCustomerCityLabel = new System.Windows.Forms.Label();
            this.addCustomerCityTextBox = new System.Windows.Forms.TextBox();
            this.addCustomerPostalCodeLabel = new System.Windows.Forms.Label();
            this.addCustomerPostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.addCustomerCountryLabel = new System.Windows.Forms.Label();
            this.addCustomerCountryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(433, 387);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(71, 38);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(344, 387);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(71, 38);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // addCustomerLabel
            // 
            this.addCustomerLabel.AutoSize = true;
            this.addCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerLabel.Location = new System.Drawing.Point(12, 9);
            this.addCustomerLabel.Name = "addCustomerLabel";
            this.addCustomerLabel.Size = new System.Drawing.Size(111, 20);
            this.addCustomerLabel.TabIndex = 22;
            this.addCustomerLabel.Text = "Add Customer";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(73, 86);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(51, 20);
            this.customerNameLabel.TabIndex = 32;
            this.customerNameLabel.Text = "Name";
            // 
            // addCustomerNameTextBox
            // 
            this.addCustomerNameTextBox.Location = new System.Drawing.Point(196, 88);
            this.addCustomerNameTextBox.Name = "addCustomerNameTextBox";
            this.addCustomerNameTextBox.Size = new System.Drawing.Size(236, 20);
            this.addCustomerNameTextBox.TabIndex = 0;
            this.addCustomerNameTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // addCustomerPhoneNumberLabel
            // 
            this.addCustomerPhoneNumberLabel.AutoSize = true;
            this.addCustomerPhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerPhoneNumberLabel.Location = new System.Drawing.Point(73, 338);
            this.addCustomerPhoneNumberLabel.Name = "addCustomerPhoneNumberLabel";
            this.addCustomerPhoneNumberLabel.Size = new System.Drawing.Size(115, 20);
            this.addCustomerPhoneNumberLabel.TabIndex = 36;
            this.addCustomerPhoneNumberLabel.Text = "Phone Number";
            // 
            // addCustomerPhoneTextBox
            // 
            this.addCustomerPhoneTextBox.Location = new System.Drawing.Point(196, 340);
            this.addCustomerPhoneTextBox.Name = "addCustomerPhoneTextBox";
            this.addCustomerPhoneTextBox.Size = new System.Drawing.Size(236, 20);
            this.addCustomerPhoneTextBox.TabIndex = 6;
            this.addCustomerPhoneTextBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // addCustomerAddressLabel
            // 
            this.addCustomerAddressLabel.AutoSize = true;
            this.addCustomerAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerAddressLabel.Location = new System.Drawing.Point(73, 131);
            this.addCustomerAddressLabel.Name = "addCustomerAddressLabel";
            this.addCustomerAddressLabel.Size = new System.Drawing.Size(68, 20);
            this.addCustomerAddressLabel.TabIndex = 34;
            this.addCustomerAddressLabel.Text = "Address";
            // 
            // addCustomerAddressTextBox
            // 
            this.addCustomerAddressTextBox.Location = new System.Drawing.Point(196, 133);
            this.addCustomerAddressTextBox.Name = "addCustomerAddressTextBox";
            this.addCustomerAddressTextBox.Size = new System.Drawing.Size(236, 20);
            this.addCustomerAddressTextBox.TabIndex = 1;
            this.addCustomerAddressTextBox.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // addCustomerAddress2Label
            // 
            this.addCustomerAddress2Label.AutoSize = true;
            this.addCustomerAddress2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerAddress2Label.Location = new System.Drawing.Point(73, 174);
            this.addCustomerAddress2Label.Name = "addCustomerAddress2Label";
            this.addCustomerAddress2Label.Size = new System.Drawing.Size(81, 20);
            this.addCustomerAddress2Label.TabIndex = 38;
            this.addCustomerAddress2Label.Text = "Address 2";
            // 
            // addCustomerAddress2TextBox
            // 
            this.addCustomerAddress2TextBox.Location = new System.Drawing.Point(196, 174);
            this.addCustomerAddress2TextBox.Name = "addCustomerAddress2TextBox";
            this.addCustomerAddress2TextBox.Size = new System.Drawing.Size(236, 20);
            this.addCustomerAddress2TextBox.TabIndex = 2;
            this.addCustomerAddress2TextBox.TextChanged += new System.EventHandler(this.addCustomerAddress2TextBox_TextChanged);
            // 
            // addCustomerCityLabel
            // 
            this.addCustomerCityLabel.AutoSize = true;
            this.addCustomerCityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerCityLabel.Location = new System.Drawing.Point(73, 212);
            this.addCustomerCityLabel.Name = "addCustomerCityLabel";
            this.addCustomerCityLabel.Size = new System.Drawing.Size(35, 20);
            this.addCustomerCityLabel.TabIndex = 40;
            this.addCustomerCityLabel.Text = "City";
            // 
            // addCustomerCityTextBox
            // 
            this.addCustomerCityTextBox.Location = new System.Drawing.Point(196, 214);
            this.addCustomerCityTextBox.Name = "addCustomerCityTextBox";
            this.addCustomerCityTextBox.Size = new System.Drawing.Size(236, 20);
            this.addCustomerCityTextBox.TabIndex = 3;
            this.addCustomerCityTextBox.TextChanged += new System.EventHandler(this.addCustomerCityTextBox_TextChanged);
            // 
            // addCustomerPostalCodeLabel
            // 
            this.addCustomerPostalCodeLabel.AutoSize = true;
            this.addCustomerPostalCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerPostalCodeLabel.Location = new System.Drawing.Point(73, 295);
            this.addCustomerPostalCodeLabel.Name = "addCustomerPostalCodeLabel";
            this.addCustomerPostalCodeLabel.Size = new System.Drawing.Size(95, 20);
            this.addCustomerPostalCodeLabel.TabIndex = 42;
            this.addCustomerPostalCodeLabel.Text = "Postal Code";
            // 
            // addCustomerPostalCodeTextBox
            // 
            this.addCustomerPostalCodeTextBox.Location = new System.Drawing.Point(196, 297);
            this.addCustomerPostalCodeTextBox.Name = "addCustomerPostalCodeTextBox";
            this.addCustomerPostalCodeTextBox.Size = new System.Drawing.Size(236, 20);
            this.addCustomerPostalCodeTextBox.TabIndex = 5;
            this.addCustomerPostalCodeTextBox.TextChanged += new System.EventHandler(this.addCustomerPostalCodeTextBox_TextChanged);
            // 
            // addCustomerCountryLabel
            // 
            this.addCustomerCountryLabel.AutoSize = true;
            this.addCustomerCountryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustomerCountryLabel.Location = new System.Drawing.Point(73, 252);
            this.addCustomerCountryLabel.Name = "addCustomerCountryLabel";
            this.addCustomerCountryLabel.Size = new System.Drawing.Size(64, 20);
            this.addCustomerCountryLabel.TabIndex = 44;
            this.addCustomerCountryLabel.Text = "Country";
            // 
            // addCustomerCountryTextBox
            // 
            this.addCustomerCountryTextBox.Location = new System.Drawing.Point(196, 254);
            this.addCustomerCountryTextBox.Name = "addCustomerCountryTextBox";
            this.addCustomerCountryTextBox.Size = new System.Drawing.Size(236, 20);
            this.addCustomerCountryTextBox.TabIndex = 4;
            this.addCustomerCountryTextBox.TextChanged += new System.EventHandler(this.addCustomerCountryTextBox_TextChanged);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 447);
            this.Controls.Add(this.addCustomerCountryLabel);
            this.Controls.Add(this.addCustomerCountryTextBox);
            this.Controls.Add(this.addCustomerPostalCodeLabel);
            this.Controls.Add(this.addCustomerPostalCodeTextBox);
            this.Controls.Add(this.addCustomerCityLabel);
            this.Controls.Add(this.addCustomerCityTextBox);
            this.Controls.Add(this.addCustomerAddress2Label);
            this.Controls.Add(this.addCustomerAddress2TextBox);
            this.Controls.Add(this.addCustomerPhoneNumberLabel);
            this.Controls.Add(this.addCustomerPhoneTextBox);
            this.Controls.Add(this.addCustomerAddressLabel);
            this.Controls.Add(this.addCustomerAddressTextBox);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.addCustomerNameTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.addCustomerLabel);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.Load += new System.EventHandler(this.Addpart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        /*public string getTextbox1()
       { return textBox1.Text; }*/

        public string getTextbox2()
        { return addCustomerNameTextBox.Text; }
        public string getTextbox3()
        { return addCustomerPhoneTextBox.Text; }
        public string getTextbox4()
        { return addCustomerAddressTextBox.Text; }
       /* public string getTextbox5()
        { return textBox5.Text; }
        public string getTextbox6()
        { return textBox6.Text; }
        public string getTextbox7()
        { return textBox7.Text; }*/

        #endregion
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label addCustomerLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox addCustomerNameTextBox;
        private System.Windows.Forms.Label addCustomerPhoneNumberLabel;
        private System.Windows.Forms.TextBox addCustomerPhoneTextBox;
        private System.Windows.Forms.Label addCustomerAddressLabel;
        private System.Windows.Forms.TextBox addCustomerAddressTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label addCustomerAddress2Label;
        private System.Windows.Forms.TextBox addCustomerAddress2TextBox;
        private System.Windows.Forms.Label addCustomerCityLabel;
        private System.Windows.Forms.TextBox addCustomerCityTextBox;
        private System.Windows.Forms.Label addCustomerPostalCodeLabel;
        private System.Windows.Forms.TextBox addCustomerPostalCodeTextBox;
        private System.Windows.Forms.Label addCustomerCountryLabel;
        private System.Windows.Forms.TextBox addCustomerCountryTextBox;
    }
}