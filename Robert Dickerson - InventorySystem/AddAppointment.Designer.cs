namespace Robert_Dickerson___InventorySystem
{
    partial class AddAppointment
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
            this.components = new System.ComponentModel.Container();
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
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addApptLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.allCustomerLabel = new System.Windows.Forms.Label();
            this.startLabel = new System.Windows.Forms.Label();
            this.endLabel = new System.Windows.Forms.Label();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.existingApptGridLabel = new System.Windows.Forms.Label();
            this.checkApptBTN = new System.Windows.Forms.Button();
            this.apptERRORLabel = new System.Windows.Forms.Label();
            this.hiddenEndTP = new System.Windows.Forms.DateTimePicker();
            this.hiddenStartTP = new System.Windows.Forms.DateTimePicker();
            this.apptTimes85Label = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.partBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.Location = new System.Drawing.Point(64, 226);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(43, 20);
            this.typeLabel.TabIndex = 61;
            this.typeLabel.Text = "Type";
            this.typeLabel.Click += new System.EventHandler(this.typeLabel_Click);
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(159, 273);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(243, 20);
            this.urlTextBox.TabIndex = 60;
            this.urlTextBox.TextChanged += new System.EventHandler(this.urlTextBox_TextChanged);
            // 
            // urlLabel
            // 
            this.urlLabel.AutoSize = true;
            this.urlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlLabel.Location = new System.Drawing.Point(64, 271);
            this.urlLabel.Name = "urlLabel";
            this.urlLabel.Size = new System.Drawing.Size(42, 20);
            this.urlLabel.TabIndex = 59;
            this.urlLabel.Text = "URL";
            this.urlLabel.Click += new System.EventHandler(this.urlLabel_Click);
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.Location = new System.Drawing.Point(60, 187);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(65, 20);
            this.contactLabel.TabIndex = 57;
            this.contactLabel.Text = "Contact";
            this.contactLabel.Click += new System.EventHandler(this.contactLabel_Click);
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(159, 189);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(243, 20);
            this.contactTextBox.TabIndex = 56;
            this.contactTextBox.TextChanged += new System.EventHandler(this.contactTextBox_TextChanged);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(60, 144);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(70, 20);
            this.locationLabel.TabIndex = 55;
            this.locationLabel.Text = "Location";
            this.locationLabel.Click += new System.EventHandler(this.locationLabel_Click);
            // 
            // locationTextBox
            // 
            this.locationTextBox.Location = new System.Drawing.Point(159, 146);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(243, 20);
            this.locationTextBox.TabIndex = 54;
            this.locationTextBox.TextChanged += new System.EventHandler(this.locationTextBox_TextChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(60, 99);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(89, 20);
            this.descriptionLabel.TabIndex = 53;
            this.descriptionLabel.Text = "Description";
            this.descriptionLabel.Click += new System.EventHandler(this.descriptionLabel_Click);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(159, 101);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(243, 20);
            this.descriptionTextBox.TabIndex = 52;
            this.descriptionTextBox.TextChanged += new System.EventHandler(this.descriptionTextBox_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(60, 56);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(98, 20);
            this.titleLabel.TabIndex = 51;
            this.titleLabel.Text = "Title of Appt.";
            this.titleLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(159, 58);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(243, 20);
            this.titleTextBox.TabIndex = 50;
            this.titleTextBox.TextChanged += new System.EventHandler(this.titleTextBox_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(275, 504);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 38);
            this.button3.TabIndex = 47;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(183, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 38);
            this.button2.TabIndex = 46;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addApptLabel
            // 
            this.addApptLabel.AutoSize = true;
            this.addApptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addApptLabel.Location = new System.Drawing.Point(12, 9);
            this.addApptLabel.Name = "addApptLabel";
            this.addApptLabel.Size = new System.Drawing.Size(133, 20);
            this.addApptLabel.TabIndex = 45;
            this.addApptLabel.Text = "Add Appointment";
            this.addApptLabel.Click += new System.EventHandler(this.addApptLabel_Click);
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
            this.dataGridView1.TabIndex = 64;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // allCustomerLabel
            // 
            this.allCustomerLabel.AutoSize = true;
            this.allCustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allCustomerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.allCustomerLabel.Location = new System.Drawing.Point(545, 31);
            this.allCustomerLabel.Name = "allCustomerLabel";
            this.allCustomerLabel.Size = new System.Drawing.Size(398, 13);
            this.allCustomerLabel.TabIndex = 69;
            this.allCustomerLabel.Text = "Please select a customer from the list and then fill out details about the appoin" +
    "tment";
            this.allCustomerLabel.Click += new System.EventHandler(this.allCustomerLabel_Click);
            // 
            // startLabel
            // 
            this.startLabel.AutoSize = true;
            this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startLabel.Location = new System.Drawing.Point(65, 335);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(82, 20);
            this.startLabel.TabIndex = 72;
            this.startLabel.Text = "Start Time";
            this.startLabel.Click += new System.EventHandler(this.startLabel_Click);
            // 
            // endLabel
            // 
            this.endLabel.AutoSize = true;
            this.endLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endLabel.Location = new System.Drawing.Point(66, 374);
            this.endLabel.Name = "endLabel";
            this.endLabel.Size = new System.Drawing.Size(76, 20);
            this.endLabel.TabIndex = 74;
            this.endLabel.Text = "End Time";
            this.endLabel.Click += new System.EventHandler(this.endLabel_Click);
            // 
            // startTimePicker
            // 
            this.startTimePicker.Location = new System.Drawing.Point(159, 335);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(243, 20);
            this.startTimePicker.TabIndex = 76;
            this.startTimePicker.ValueChanged += new System.EventHandler(this.startTimePicker_ValueChanged);
            // 
            // endTimePicker
            // 
            this.endTimePicker.Location = new System.Drawing.Point(159, 374);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(243, 20);
            this.endTimePicker.TabIndex = 77;
            this.endTimePicker.ValueChanged += new System.EventHandler(this.endTimePicker_ValueChanged);
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
            this.dataGridView2.TabIndex = 78;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_1);
            // 
            // existingApptGridLabel
            // 
            this.existingApptGridLabel.AutoSize = true;
            this.existingApptGridLabel.Location = new System.Drawing.Point(545, 270);
            this.existingApptGridLabel.Name = "existingApptGridLabel";
            this.existingApptGridLabel.Size = new System.Drawing.Size(136, 13);
            this.existingApptGridLabel.TabIndex = 79;
            this.existingApptGridLabel.Text = "Existing Appointment Times";
            this.existingApptGridLabel.Click += new System.EventHandler(this.existingApptGridLabel_Click);
            // 
            // checkApptBTN
            // 
            this.checkApptBTN.Location = new System.Drawing.Point(419, 338);
            this.checkApptBTN.Name = "checkApptBTN";
            this.checkApptBTN.Size = new System.Drawing.Size(113, 59);
            this.checkApptBTN.TabIndex = 80;
            this.checkApptBTN.Text = "Check Appointment Time Availability";
            this.checkApptBTN.UseVisualStyleBackColor = true;
            this.checkApptBTN.Click += new System.EventHandler(this.checkApptBTN_Click);
            // 
            // apptERRORLabel
            // 
            this.apptERRORLabel.AutoSize = true;
            this.apptERRORLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.apptERRORLabel.Location = new System.Drawing.Point(136, 406);
            this.apptERRORLabel.Name = "apptERRORLabel";
            this.apptERRORLabel.Size = new System.Drawing.Size(286, 13);
            this.apptERRORLabel.TabIndex = 81;
            this.apptERRORLabel.Text = "There is a time conflict! Please adjust the appointment time.";
            this.apptERRORLabel.Click += new System.EventHandler(this.apptERRORLabel_Click);
            // 
            // hiddenEndTP
            // 
            this.hiddenEndTP.Location = new System.Drawing.Point(548, 538);
            this.hiddenEndTP.Name = "hiddenEndTP";
            this.hiddenEndTP.Size = new System.Drawing.Size(243, 20);
            this.hiddenEndTP.TabIndex = 83;
            this.hiddenEndTP.Visible = false;
            this.hiddenEndTP.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // hiddenStartTP
            // 
            this.hiddenStartTP.Location = new System.Drawing.Point(548, 499);
            this.hiddenStartTP.Name = "hiddenStartTP";
            this.hiddenStartTP.Size = new System.Drawing.Size(243, 20);
            this.hiddenStartTP.TabIndex = 82;
            this.hiddenStartTP.Visible = false;
            this.hiddenStartTP.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // apptTimes85Label
            // 
            this.apptTimes85Label.AutoSize = true;
            this.apptTimes85Label.Location = new System.Drawing.Point(168, 428);
            this.apptTimes85Label.Name = "apptTimes85Label";
            this.apptTimes85Label.Size = new System.Drawing.Size(216, 13);
            this.apptTimes85Label.TabIndex = 84;
            this.apptTimes85Label.Text = "*Business hours are from 8:00 AM - 5:00PM*";
            this.apptTimes85Label.Click += new System.EventHandler(this.apptTimes85Label_Click);
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(159, 228);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(243, 21);
            this.typeComboBox.TabIndex = 85;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // partBindingSource1
            // 
            this.partBindingSource1.DataSource = typeof(Robert_Dickerson___InventorySystem.Part);
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(Robert_Dickerson___InventorySystem.Part);
            // 
            // AddAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 570);
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
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addApptLabel);
            this.Name = "AddAppointment";
            this.Text = "Add Appointment";
            this.Load += new System.EventHandler(this.Addproduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label addApptLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label allCustomerLabel;
        private System.Windows.Forms.BindingSource partBindingSource;
        private System.Windows.Forms.BindingSource partBindingSource1;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label endLabel;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label existingApptGridLabel;
        private System.Windows.Forms.Button checkApptBTN;
        private System.Windows.Forms.Label apptERRORLabel;
        private System.Windows.Forms.DateTimePicker hiddenEndTP;
        private System.Windows.Forms.DateTimePicker hiddenStartTP;
        private System.Windows.Forms.Label apptTimes85Label;
        private System.Windows.Forms.ComboBox typeComboBox;
    }
}