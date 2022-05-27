namespace Robert_Dickerson___InventorySystem
{
    partial class DBTest
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
            this.DBDVG1 = new System.Windows.Forms.DataGridView();
            this.tableUpdateStatementBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DBDVG1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUpdateStatementBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DBDVG1
            // 
            this.DBDVG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DBDVG1.Location = new System.Drawing.Point(12, 83);
            this.DBDVG1.Name = "DBDVG1";
            this.DBDVG1.Size = new System.Drawing.Size(776, 355);
            this.DBDVG1.TabIndex = 0;
            this.DBDVG1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DBDVG1_CellContentClick);
            // 
            // tableUpdateStatementBindingSource
            // 
            this.tableUpdateStatementBindingSource.DataSource = typeof(MySqlX.XDevAPI.Relational.TableUpdateStatement);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(198, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // DBTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DBDVG1);
            this.Name = "DBTest";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.DBTest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DBDVG1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableUpdateStatementBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DBDVG1;
        private System.Windows.Forms.BindingSource tableUpdateStatementBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}