namespace Robert_Dickerson___InventorySystem
{
    partial class Mainscreen
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
            this.appointmentSchedulerLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.customerLabel = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.appointmentCalendarLabel = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.DBDGV1 = new System.Windows.Forms.DataGridView();
            this.DBDGV2 = new System.Windows.Forms.DataGridView();
            this.monthlyApptViewRB = new System.Windows.Forms.RadioButton();
            this.weeklyApptViewRB = new System.Windows.Forms.RadioButton();
            this.client_scheduleDataSet = new Robert_Dickerson___InventorySystem.client_scheduleDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Robert_Dickerson___InventorySystem.client_scheduleDataSetTableAdapters.customerTableAdapter();
            this.cal = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.allActiveAptsRB = new System.Windows.Forms.RadioButton();
            this.reportBTN = new System.Windows.Forms.Button();
            this.customerSearchBTN = new System.Windows.Forms.Button();
            this.appointmentSearchBTN = new System.Windows.Forms.Button();
            this.customerSearchEntry = new System.Windows.Forms.TextBox();
            this.apptSearchEntry = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerRefreshBTN = new System.Windows.Forms.Button();
            this.apptRefreshBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DBDGV1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBDGV2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // appointmentSchedulerLabel
            // 
            this.appointmentSchedulerLabel.AutoSize = true;
            this.appointmentSchedulerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentSchedulerLabel.Location = new System.Drawing.Point(13, 9);
            this.appointmentSchedulerLabel.Name = "appointmentSchedulerLabel";
            this.appointmentSchedulerLabel.Size = new System.Drawing.Size(176, 20);
            this.appointmentSchedulerLabel.TabIndex = 0;
            this.appointmentSchedulerLabel.Text = "Appointment Scheduler";
            this.appointmentSchedulerLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(232, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Modify";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(386, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(23, 55);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(72, 16);
            this.customerLabel.TabIndex = 5;
            this.customerLabel.Text = "Customers";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1162, 415);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 38);
            this.button7.TabIndex = 11;
            this.button7.Text = "Exit";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // appointmentCalendarLabel
            // 
            this.appointmentCalendarLabel.AutoSize = true;
            this.appointmentCalendarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appointmentCalendarLabel.Location = new System.Drawing.Point(718, 55);
            this.appointmentCalendarLabel.Name = "appointmentCalendarLabel";
            this.appointmentCalendarLabel.Size = new System.Drawing.Size(141, 16);
            this.appointmentCalendarLabel.TabIndex = 21;
            this.appointmentCalendarLabel.Text = "Appointment Calendar";
            this.appointmentCalendarLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1162, 358);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 38);
            this.button5.TabIndex = 20;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1085, 358);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 38);
            this.button6.TabIndex = 19;
            this.button6.Text = "Modify";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(1008, 358);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 38);
            this.button9.TabIndex = 18;
            this.button9.Text = "Add";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // DBDGV1
            // 
            this.DBDGV1.AllowUserToAddRows = false;
            this.DBDGV1.AllowUserToResizeRows = false;
            this.DBDGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBDGV1.Location = new System.Drawing.Point(26, 77);
            this.DBDGV1.Name = "DBDGV1";
            this.DBDGV1.ReadOnly = true;
            this.DBDGV1.RowHeadersVisible = false;
            this.DBDGV1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DBDGV1.Size = new System.Drawing.Size(430, 267);
            this.DBDGV1.TabIndex = 24;
            this.DBDGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_3);
            // 
            // DBDGV2
            // 
            this.DBDGV2.AllowUserToAddRows = false;
            this.DBDGV2.AllowUserToResizeRows = false;
            this.DBDGV2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBDGV2.Location = new System.Drawing.Point(240, 8);
            this.DBDGV2.Name = "DBDGV2";
            this.DBDGV2.ReadOnly = true;
            this.DBDGV2.RowHeadersVisible = false;
            this.DBDGV2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DBDGV2.Size = new System.Drawing.Size(508, 267);
            this.DBDGV2.TabIndex = 25;
            this.DBDGV2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick_2);
            // 
            // monthlyApptViewRB
            // 
            this.monthlyApptViewRB.AutoSize = true;
            this.monthlyApptViewRB.Location = new System.Drawing.Point(51, 36);
            this.monthlyApptViewRB.Name = "monthlyApptViewRB";
            this.monthlyApptViewRB.Size = new System.Drawing.Size(150, 17);
            this.monthlyApptViewRB.TabIndex = 27;
            this.monthlyApptViewRB.TabStop = true;
            this.monthlyApptViewRB.Text = "Monthly Appointment View";
            this.monthlyApptViewRB.UseVisualStyleBackColor = true;
            this.monthlyApptViewRB.CheckedChanged += new System.EventHandler(this.monthlyApptViewRB_CheckedChanged);
            // 
            // weeklyApptViewRB
            // 
            this.weeklyApptViewRB.AutoSize = true;
            this.weeklyApptViewRB.Location = new System.Drawing.Point(51, 59);
            this.weeklyApptViewRB.Name = "weeklyApptViewRB";
            this.weeklyApptViewRB.Size = new System.Drawing.Size(149, 17);
            this.weeklyApptViewRB.TabIndex = 28;
            this.weeklyApptViewRB.TabStop = true;
            this.weeklyApptViewRB.Text = "Weekly Appointment View";
            this.weeklyApptViewRB.UseVisualStyleBackColor = true;
            this.weeklyApptViewRB.CheckedChanged += new System.EventHandler(this.weeklyApptViewRB_CheckedChanged);
            // 
            // client_scheduleDataSet
            // 
            this.client_scheduleDataSet.DataSetName = "client_scheduleDataSet";
            this.client_scheduleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "customer";
            this.customerBindingSource.DataSource = this.client_scheduleDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // cal
            // 
            this.cal.Location = new System.Drawing.Point(6, 82);
            this.cal.Name = "cal";
            this.cal.TabIndex = 29;
            this.cal.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.cal_DateChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DBDGV2);
            this.groupBox1.Controls.Add(this.allActiveAptsRB);
            this.groupBox1.Controls.Add(this.cal);
            this.groupBox1.Controls.Add(this.monthlyApptViewRB);
            this.groupBox1.Controls.Add(this.weeklyApptViewRB);
            this.groupBox1.Location = new System.Drawing.Point(479, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(754, 277);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // allActiveAptsRB
            // 
            this.allActiveAptsRB.AutoSize = true;
            this.allActiveAptsRB.Location = new System.Drawing.Point(51, 13);
            this.allActiveAptsRB.Name = "allActiveAptsRB";
            this.allActiveAptsRB.Size = new System.Drawing.Size(162, 17);
            this.allActiveAptsRB.TabIndex = 30;
            this.allActiveAptsRB.TabStop = true;
            this.allActiveAptsRB.Text = "All Active Appointments View";
            this.allActiveAptsRB.UseVisualStyleBackColor = true;
            this.allActiveAptsRB.CheckedChanged += new System.EventHandler(this.allActiveAptsRB_CheckedChanged);
            // 
            // reportBTN
            // 
            this.reportBTN.Location = new System.Drawing.Point(530, 358);
            this.reportBTN.Name = "reportBTN";
            this.reportBTN.Size = new System.Drawing.Size(127, 46);
            this.reportBTN.TabIndex = 31;
            this.reportBTN.Text = "Click here for your \r\nConsultant Report";
            this.reportBTN.UseVisualStyleBackColor = true;
            this.reportBTN.Click += new System.EventHandler(this.reportBTN_Click);
            // 
            // customerSearchBTN
            // 
            this.customerSearchBTN.Location = new System.Drawing.Point(98, 46);
            this.customerSearchBTN.Name = "customerSearchBTN";
            this.customerSearchBTN.Size = new System.Drawing.Size(75, 23);
            this.customerSearchBTN.TabIndex = 32;
            this.customerSearchBTN.Text = "Search";
            this.customerSearchBTN.UseVisualStyleBackColor = true;
            this.customerSearchBTN.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // appointmentSearchBTN
            // 
            this.appointmentSearchBTN.Location = new System.Drawing.Point(869, 46);
            this.appointmentSearchBTN.Name = "appointmentSearchBTN";
            this.appointmentSearchBTN.Size = new System.Drawing.Size(75, 23);
            this.appointmentSearchBTN.TabIndex = 33;
            this.appointmentSearchBTN.Text = "Search";
            this.appointmentSearchBTN.UseVisualStyleBackColor = true;
            this.appointmentSearchBTN.Click += new System.EventHandler(this.appointmentSearchBTN_Click);
            // 
            // customerSearchEntry
            // 
            this.customerSearchEntry.Location = new System.Drawing.Point(179, 48);
            this.customerSearchEntry.Name = "customerSearchEntry";
            this.customerSearchEntry.Size = new System.Drawing.Size(184, 20);
            this.customerSearchEntry.TabIndex = 34;
            this.customerSearchEntry.TextChanged += new System.EventHandler(this.customerSearchEntry_TextChanged);
            // 
            // apptSearchEntry
            // 
            this.apptSearchEntry.Location = new System.Drawing.Point(950, 48);
            this.apptSearchEntry.Name = "apptSearchEntry";
            this.apptSearchEntry.Size = new System.Drawing.Size(184, 20);
            this.apptSearchEntry.TabIndex = 35;
            this.apptSearchEntry.TextChanged += new System.EventHandler(this.apptSearchEntry_TextChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Robert_Dickerson___InventorySystem.Product);
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataSource = typeof(Robert_Dickerson___InventorySystem.Part);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(Robert_Dickerson___InventorySystem.Inventory);
            // 
            // customerRefreshBTN
            // 
            this.customerRefreshBTN.Location = new System.Drawing.Point(369, 47);
            this.customerRefreshBTN.Name = "customerRefreshBTN";
            this.customerRefreshBTN.Size = new System.Drawing.Size(87, 23);
            this.customerRefreshBTN.TabIndex = 36;
            this.customerRefreshBTN.Text = "Refresh View";
            this.customerRefreshBTN.UseVisualStyleBackColor = true;
            this.customerRefreshBTN.Click += new System.EventHandler(this.customerRefreshBTN_Click);
            // 
            // apptRefreshBTN
            // 
            this.apptRefreshBTN.Location = new System.Drawing.Point(1140, 47);
            this.apptRefreshBTN.Name = "apptRefreshBTN";
            this.apptRefreshBTN.Size = new System.Drawing.Size(87, 23);
            this.apptRefreshBTN.TabIndex = 37;
            this.apptRefreshBTN.Text = "Refresh View";
            this.apptRefreshBTN.UseVisualStyleBackColor = true;
            this.apptRefreshBTN.Click += new System.EventHandler(this.apptRefreshBTN_Click);
            // 
            // Mainscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 472);
            this.Controls.Add(this.apptRefreshBTN);
            this.Controls.Add(this.customerRefreshBTN);
            this.Controls.Add(this.apptSearchEntry);
            this.Controls.Add(this.customerSearchEntry);
            this.Controls.Add(this.appointmentSearchBTN);
            this.Controls.Add(this.customerSearchBTN);
            this.Controls.Add(this.reportBTN);
            this.Controls.Add(this.DBDGV1);
            this.Controls.Add(this.appointmentCalendarLabel);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.appointmentSchedulerLabel);
            this.Controls.Add(this.groupBox1);
            this.Name = "Mainscreen";
            this.Text = "Mainscreen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBDGV1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBDGV2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.client_scheduleDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label appointmentSchedulerLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label appointmentCalendarLabel;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.BindingSource Allparts = new System.Windows.Forms.BindingSource(Inventory.AllParts, null);
        private System.Windows.Forms.BindingSource Products = new System.Windows.Forms.BindingSource(Inventory.Products, null);
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource partBindingSource = new System.Windows.Forms.BindingSource(Inventory.AllParts, null);
        /*private System.Windows.Forms.BindingSource partBindingSource1;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.BindingSource inventoryBindingSource1;*/
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.DataGridView DBDGV1;
        private System.Windows.Forms.DataGridView DBDGV2;
        private System.Windows.Forms.RadioButton monthlyApptViewRB;
        private System.Windows.Forms.RadioButton weeklyApptViewRB;
        private client_scheduleDataSet client_scheduleDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private client_scheduleDataSetTableAdapters.customerTableAdapter customerTableAdapter;
        private System.Windows.Forms.MonthCalendar cal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton allActiveAptsRB;
        private System.Windows.Forms.Button reportBTN;
        private System.Windows.Forms.Button customerSearchBTN;
        private System.Windows.Forms.Button appointmentSearchBTN;
        private System.Windows.Forms.TextBox customerSearchEntry;
        private System.Windows.Forms.TextBox apptSearchEntry;
        private System.Windows.Forms.Button customerRefreshBTN;
        private System.Windows.Forms.Button apptRefreshBTN;
    }
}

