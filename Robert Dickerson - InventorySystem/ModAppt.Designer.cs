
namespace Robert_Dickerson___InventorySystem
{
    partial class ModAppt
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
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.apptTimes85Label = new System.Windows.Forms.Label();
            this.hiddenEndTP = new System.Windows.Forms.DateTimePicker();
            this.hiddenStartTP = new System.Windows.Forms.DateTimePicker();
            this.apptERRORLabel = new System.Windows.Forms.Label();
            this.checkApptBTN = new System.Windows.Forms.Button();
            this.existingApptGridLabel = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.allCustomerLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.typeLabel = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.urlLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.contact = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.modApptLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(159, 228);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(243, 21);
            this.typeComboBox.TabIndex = 113;
            // 
            // apptTimes85Label
            // 
            this.apptTimes85Label.AutoSize = true;
            this.apptTimes85Label.Location = new System.Drawing.Point(168, 428);
            this.apptTimes85Label.Name = "apptTimes85Label";
            this.apptTimes85Label.Size = new System.Drawing.Size(216, 13);
            this.apptTimes85Label.TabIndex = 112;
            this.apptTimes85Label.Text = "*Business hours are from 8:00 AM - 5:00PM*";
            // 
            // hiddenEndTP
            // 
            this.hiddenEndTP.Location = new System.Drawing.Point(548, 538);
            this.hiddenEndTP.Name = "hiddenEndTP";
            this.hiddenEndTP.Size = new System.Drawing.Size(243, 20);
            this.hiddenEndTP.TabIndex = 111;
            this.hiddenEndTP.Visible = false;
            // 
            // hiddenStartTP
            // 
            this.hiddenStartTP.Location = new System.Drawing.Point(548, 499);
            this.hiddenStartTP.Name = "hiddenStartTP";
            this.hiddenStartTP.Size = new System.Drawing.Size(243, 20);
            this.hiddenStartTP.TabIndex = 110;
            this.hiddenStartTP.Visible = false;
            // 
            // apptERRORLabel
            // 
            this.apptERRORLabel.AutoSize = true;
            this.apptERRORLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.apptERRORLabel.Location = new System.Drawing.Point(136, 406);
            this.apptERRORLabel.Name = "apptERRORLabel";
            this.apptERRORLabel.Size = new System.Drawing.Size(286, 13);
            this.apptERRORLabel.TabIndex = 109;
            this.apptERRORLabel.Text = "There is a time conflict! Please adjust the appointment time.";
            // 
            // checkApptBTN
            // 
            this.checkApptBTN.Location = new System.Drawing.Point(419, 338);
            this.checkApptBTN.Name = "checkApptBTN";
            this.checkApptBTN.Size = new System.Drawing.Size(113, 59);
            this.checkApptBTN.TabIndex = 108;
            this.checkApptBTN.Text = "Check Appointment Time Availability";
            this.checkApptBTN.UseVisualStyleBackColor = true;
            this.checkApptBTN.Click += new System.EventHandler(this.checkApptBTN_Click_1);
            // 
            // existingApptGridLabel
            // 
            this.existingApptGridLabel.AutoSize = true;
            this.existingApptGridLabel.Location = new System.Drawing.Point(545, 270);
            this.existingApptGridLabel.Name = "existingApptGridLabel";
            this.existingApptGridLabel.Size = new System.Drawing.Size(136, 13);
            this.existingApptGridLabel.TabIndex = 107;
            this.existingApptGridLabel.Text = "Existing Appointment Times";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dataGridView2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dataGridView2.Location = new System.Drawing.Point(548, 287);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(438, 211);
            this.dataGridView2.TabIndex = 106;
            // 
            // endTimePicker
            // 
            this.endTimePicker.Location = new System.Drawing.Point(159, 374);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(243, 20);
            this.endTimePicker.TabIndex = 105;
            // 
            // startTimePicker
            // 
            this.startTimePicker.Location = new System.Drawing.Point(159, 335);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(243, 20);
            this.startTimePicker.TabIndex = 104;
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(66, 374);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(76, 20);
            this.endLabel.TabIndex = 103;
            this.endLabel.Text = "End Time";
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(65, 335);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(82, 20);
            this.startLabel.TabIndex = 102;
            this.startLabel.Text = "Start Time";
            // 
            // allCustomerLabel
            // 
            this.allCustomerLabel.AutoSize = true;
            this.allCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allCustomerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.allCustomerLabel.Location = new System.Drawing.Point(545, 31);
            this.allCustomerLabel.Name = "allCustomerLabel";
            this.allCustomerLabel.Size = new System.Drawing.Size(398, 13);
            this.allCustomerLabel.TabIndex = 101;
            this.allCustomerLabel.Text = "Please select a customer from the list and then fill out details about the appoin" +
    "tment";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(548, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(438, 218);
            this.dataGridView1.TabIndex = 100;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(64, 226);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(43, 20);
            this.typeLabel.TabIndex = 99;
            this.typeLabel.Text = "Type";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(159, 273);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(243, 20);
            this.urlTextBox.TabIndex = 98;
            this.urlTextBox.TextChanged += new System.EventHandler(this.urlTextBox_TextChanged);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(64, 271);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(42, 20);
            this.urlLabel.TabIndex = 97;
            this.urlLabel.Text = "URL";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(60, 187);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(65, 20);
            this.contactLabel.TabIndex = 96;
            this.contactLabel.Text = "Contact";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(159, 189);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(243, 20);
            this.contactTextBox.TabIndex = 95;
            this.contactTextBox.TextChanged += new System.EventHandler(this.contactTextBox_TextChanged);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(60, 144);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(70, 20);
            this.locationLabel.TabIndex = 94;
            this.locationLabel.Text = "Location";
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(159, 146);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(243, 20);
            this.locationTextBox.TabIndex = 93;
            this.locationTextBox.TextChanged += new System.EventHandler(this.locationTextBox_TextChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(60, 99);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.descriptionLabel.TabIndex = 92;
            this.descriptionLabel.Text = "Description";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(159, 101);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(243, 20);
            this.descriptionTextBox.TabIndex = 91;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(60, 56);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(98, 20);
            this.titleLabel.TabIndex = 90;
            this.titleLabel.Text = "Title of Appt.";
            // 
            // titleTextBox
            // 
            this.contact.Location = new System.Drawing.Point(159, 58);
            this.contact.Name = "titleTextBox";
            this.contact.Size = new System.Drawing.Size(243, 20);
            this.contact.TabIndex = 89;
            this.contact.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(275, 504);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 38);
            this.button3.TabIndex = 88;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 38);
            this.button2.TabIndex = 87;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // modApptLabel
            // 
            this.modApptLabel.AutoSize = true;
            this.modApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modApptLabel.Location = new System.Drawing.Point(12, 9);
            this.modApptLabel.Name = "modApptLabel";
            this.modApptLabel.Size = new System.Drawing.Size(150, 20);
            this.modApptLabel.TabIndex = 86;
            this.modApptLabel.Text = "Modify Appointment";
            // 
            // ModAppt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 575);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.apptTimes85Label);
            this.Controls.Add(this.hiddenEndTP);
            this.Controls.Add(this.hiddenStartTP);
            this.Controls.Add(this.apptERRORLabel);
            this.Controls.Add(this.checkApptBTN);
            this.Controls.Add(this.existingApptGridLabel);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.endTimePicker);
            this.Controls.Add(this.startTimePicker);
            this.Controls.Add(this.endLabel);
            this.Controls.Add(this.startLabel);
            this.Controls.Add(this.allCustomerLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.urlLabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.locationTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.contact);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.modApptLabel);
            this.Name = "ModAppt";
            this.Text = "ModAppt";
            this.Load += new System.EventHandler(this.ModAppt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label apptTimes85Label;
        private System.Windows.Forms.DateTimePicker hiddenEndTP;
        private System.Windows.Forms.DateTimePicker hiddenStartTP;
        private System.Windows.Forms.Label apptERRORLabel;
        private System.Windows.Forms.Button checkApptBTN;
        private System.Windows.Forms.Label existingApptGridLabel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label allCustomerLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label urlLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label modApptLabel;
    }
}