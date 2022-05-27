namespace Robert_Dickerson___InventorySystem
{
    partial class ModifyCustomer
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
            this.cancelBTN = new System.Windows.Forms.Button();
            this.saveBTN = new System.Windows.Forms.Button();
            this.modifyCustomerLabel = new System.Windows.Forms.Label();
            this.countryLabel = new System.Windows.Forms.Label();
            this.countryTextBox = new System.Windows.Forms.TextBox();
            this.postalCodeLabel = new System.Windows.Forms.Label();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.address2Label = new System.Windows.Forms.Label();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.customerAddressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelBTN
            // 
            this.cancelBTN.Location = new System.Drawing.Point(428, 405);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(71, 38);
            this.cancelBTN.TabIndex = 8;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(339, 405);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(71, 38);
            this.saveBTN.TabIndex = 7;
            this.saveBTN.Text = "Save";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // modifyCustomerLabel
            // 
            this.modifyCustomerLabel.AutoSize = true;
            this.modifyCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyCustomerLabel.Location = new System.Drawing.Point(12, 9);
            this.modifyCustomerLabel.Name = "modifyCustomerLabel";
            this.modifyCustomerLabel.Size = new System.Drawing.Size(128, 20);
            this.modifyCustomerLabel.TabIndex = 45;
            this.modifyCustomerLabel.Text = "Modify Customer";
            // 
            // countryLabel
            // 
            this.countryLabel.AutoSize = true;
            this.countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel.Location = new System.Drawing.Point(92, 266);
            this.countryLabel.Name = "countryLabel";
            this.countryLabel.Size = new System.Drawing.Size(64, 20);
            this.countryLabel.TabIndex = 61;
            this.countryLabel.Text = "Country";
            // 
            // countryTextBox
            // 
            this.countryTextBox.Location = new System.Drawing.Point(215, 268);
            this.countryTextBox.Name = "countryTextBox";
            this.countryTextBox.Size = new System.Drawing.Size(236, 20);
            this.countryTextBox.TabIndex = 4;
            this.countryTextBox.TextChanged += new System.EventHandler(this.countryTextBox_TextChanged);
            // 
            // postalCodeLabel
            // 
            this.postalCodeLabel.AutoSize = true;
            this.postalCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postalCodeLabel.Location = new System.Drawing.Point(92, 309);
            this.postalCodeLabel.Name = "postalCodeLabel";
            this.postalCodeLabel.Size = new System.Drawing.Size(95, 20);
            this.postalCodeLabel.TabIndex = 59;
            this.postalCodeLabel.Text = "Postal Code";
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(215, 311);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(236, 20);
            this.postalCodeTextBox.TabIndex = 5;
            this.postalCodeTextBox.TextChanged += new System.EventHandler(this.postalCodeTextBox_TextChanged);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel.Location = new System.Drawing.Point(92, 226);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(35, 20);
            this.cityLabel.TabIndex = 57;
            this.cityLabel.Text = "City";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(215, 228);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(236, 20);
            this.cityTextBox.TabIndex = 3;
            this.cityTextBox.TextChanged += new System.EventHandler(this.cityTextBox_TextChanged);
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address2Label.Location = new System.Drawing.Point(92, 188);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(81, 20);
            this.address2Label.TabIndex = 55;
            this.address2Label.Text = "Address 2";
            // 
            // address2TextBox
            // 
            this.address2TextBox.Location = new System.Drawing.Point(215, 188);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(236, 20);
            this.address2TextBox.TabIndex = 2;
            this.address2TextBox.TextChanged += new System.EventHandler(this.address2TextBox_TextChanged);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.AutoSize = true;
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLabel.Location = new System.Drawing.Point(92, 352);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(115, 20);
            this.phoneNumberLabel.TabIndex = 53;
            this.phoneNumberLabel.Text = "Phone Number";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(215, 354);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(236, 20);
            this.phoneTextBox.TabIndex = 6;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.phoneTextBox_TextChanged);
            // 
            // customerAddressLabel
            // 
            this.customerAddressLabel.AutoSize = true;
            this.customerAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddressLabel.Location = new System.Drawing.Point(92, 145);
            this.customerAddressLabel.Name = "customerAddressLabel";
            this.customerAddressLabel.Size = new System.Drawing.Size(68, 20);
            this.customerAddressLabel.TabIndex = 51;
            this.customerAddressLabel.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(215, 147);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(236, 20);
            this.addressTextBox.TabIndex = 1;
            this.addressTextBox.TextChanged += new System.EventHandler(this.addressTextBox_TextChanged);
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(92, 100);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(51, 20);
            this.customerNameLabel.TabIndex = 49;
            this.customerNameLabel.Text = "Name";
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Location = new System.Drawing.Point(215, 102);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(236, 20);
            this.customerNameTextBox.TabIndex = 0;
            this.customerNameTextBox.TextChanged += new System.EventHandler(this.customerNameTextBox_TextChanged);
            // 
            // ModifyCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 474);
            this.Controls.Add(this.countryLabel);
            this.Controls.Add(this.countryTextBox);
            this.Controls.Add(this.postalCodeLabel);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.address2Label);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.customerAddressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.modifyCustomerLabel);
            this.Name = "ModifyCustomer";
            this.Text = "Modify Customer";
            this.Load += new System.EventHandler(this.Modifypart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Label modifyCustomerLabel;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox countryTextBox;
        private System.Windows.Forms.Label postalCodeLabel;
        private System.Windows.Forms.TextBox postalCodeTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label customerAddressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameTextBox;
    }
}