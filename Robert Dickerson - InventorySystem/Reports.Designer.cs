
namespace Robert_Dickerson___InventorySystem
{
    partial class Reports
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
            this.monthlyApptTypesReportTextBox = new System.Windows.Forms.TextBox();
            this.consultantScheduleDGV = new System.Windows.Forms.DataGridView();
            this.totalNumApptsTextBox = new System.Windows.Forms.TextBox();
            this.exitBTN = new System.Windows.Forms.Button();
            this.scheduleLabel = new System.Windows.Forms.Label();
            this.apptMonthlyTypeLabel = new System.Windows.Forms.Label();
            this.totalNumApptsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.consultantScheduleDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // monthlyApptTypesReportTextBox
            // 
            this.monthlyApptTypesReportTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthlyApptTypesReportTextBox.Location = new System.Drawing.Point(21, 337);
            this.monthlyApptTypesReportTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.monthlyApptTypesReportTextBox.Multiline = true;
            this.monthlyApptTypesReportTextBox.Name = "monthlyApptTypesReportTextBox";
            this.monthlyApptTypesReportTextBox.ReadOnly = true;
            this.monthlyApptTypesReportTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.monthlyApptTypesReportTextBox.Size = new System.Drawing.Size(369, 262);
            this.monthlyApptTypesReportTextBox.TabIndex = 3;
            // 
            // consultantScheduleDGV
            // 
            this.consultantScheduleDGV.AllowUserToAddRows = false;
            this.consultantScheduleDGV.AllowUserToDeleteRows = false;
            this.consultantScheduleDGV.AllowUserToResizeRows = false;
            this.consultantScheduleDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultantScheduleDGV.Location = new System.Drawing.Point(21, 42);
            this.consultantScheduleDGV.Margin = new System.Windows.Forms.Padding(2);
            this.consultantScheduleDGV.Name = "consultantScheduleDGV";
            this.consultantScheduleDGV.ReadOnly = true;
            this.consultantScheduleDGV.RowHeadersVisible = false;
            this.consultantScheduleDGV.RowHeadersWidth = 51;
            this.consultantScheduleDGV.RowTemplate.Height = 24;
            this.consultantScheduleDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.consultantScheduleDGV.Size = new System.Drawing.Size(686, 262);
            this.consultantScheduleDGV.TabIndex = 2;
            // 
            // totalNumApptsTextBox
            // 
            this.totalNumApptsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNumApptsTextBox.Location = new System.Drawing.Point(410, 337);
            this.totalNumApptsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.totalNumApptsTextBox.Multiline = true;
            this.totalNumApptsTextBox.Name = "totalNumApptsTextBox";
            this.totalNumApptsTextBox.ReadOnly = true;
            this.totalNumApptsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.totalNumApptsTextBox.Size = new System.Drawing.Size(297, 185);
            this.totalNumApptsTextBox.TabIndex = 4;
            // 
            // exitBTN
            // 
            this.exitBTN.Location = new System.Drawing.Point(610, 565);
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.Size = new System.Drawing.Size(97, 34);
            this.exitBTN.TabIndex = 5;
            this.exitBTN.Text = "Close";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // scheduleLabel
            // 
            this.scheduleLabel.AutoSize = true;
            this.scheduleLabel.Location = new System.Drawing.Point(18, 27);
            this.scheduleLabel.Name = "scheduleLabel";
            this.scheduleLabel.Size = new System.Drawing.Size(105, 13);
            this.scheduleLabel.TabIndex = 6;
            this.scheduleLabel.Text = "Consultant Schedule";
            // 
            // apptMonthlyTypeLabel
            // 
            this.apptMonthlyTypeLabel.AutoSize = true;
            this.apptMonthlyTypeLabel.Location = new System.Drawing.Point(18, 322);
            this.apptMonthlyTypeLabel.Name = "apptMonthlyTypeLabel";
            this.apptMonthlyTypeLabel.Size = new System.Drawing.Size(138, 13);
            this.apptMonthlyTypeLabel.TabIndex = 7;
            this.apptMonthlyTypeLabel.Text = "Monthly Appointment Types";
            // 
            // totalNumApptsLabel
            // 
            this.totalNumApptsLabel.AutoSize = true;
            this.totalNumApptsLabel.Location = new System.Drawing.Point(407, 322);
            this.totalNumApptsLabel.Name = "totalNumApptsLabel";
            this.totalNumApptsLabel.Size = new System.Drawing.Size(150, 13);
            this.totalNumApptsLabel.TabIndex = 8;
            this.totalNumApptsLabel.Text = "Total Number of Appointments";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 624);
            this.Controls.Add(this.totalNumApptsLabel);
            this.Controls.Add(this.apptMonthlyTypeLabel);
            this.Controls.Add(this.scheduleLabel);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.totalNumApptsTextBox);
            this.Controls.Add(this.monthlyApptTypesReportTextBox);
            this.Controls.Add(this.consultantScheduleDGV);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultantScheduleDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox monthlyApptTypesReportTextBox;
        private System.Windows.Forms.DataGridView consultantScheduleDGV;
        private System.Windows.Forms.TextBox totalNumApptsTextBox;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Label scheduleLabel;
        private System.Windows.Forms.Label apptMonthlyTypeLabel;
        private System.Windows.Forms.Label totalNumApptsLabel;
    }
}