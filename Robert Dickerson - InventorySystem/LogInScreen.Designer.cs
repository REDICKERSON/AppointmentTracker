
namespace Robert_Dickerson___InventorySystem
{
    partial class LogInScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInScreen));
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.welcomeMessageLabel = new System.Windows.Forms.Label();
            this.submitBTN = new System.Windows.Forms.Button();
            this.exitBTN = new System.Windows.Forms.Button();
            this.loginErrorLabel = new System.Windows.Forms.Label();
            this.LanguageStatementLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTextbox
            // 
            resources.ApplyResources(this.usernameTextbox, "usernameTextbox");
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.TextChanged += new System.EventHandler(this.usernameTextbox_TextChanged);
            // 
            // passwordTextbox
            // 
            resources.ApplyResources(this.passwordTextbox, "passwordTextbox");
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.TextChanged += new System.EventHandler(this.passwordTextbox_TextChanged);
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.Name = "usernameLabel";
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.Name = "passwordLabel";
            // 
            // welcomeMessageLabel
            // 
            resources.ApplyResources(this.welcomeMessageLabel, "welcomeMessageLabel");
            this.welcomeMessageLabel.Name = "welcomeMessageLabel";
            this.welcomeMessageLabel.Click += new System.EventHandler(this.welcomeMessageLabel_Click);
            // 
            // submitBTN
            // 
            resources.ApplyResources(this.submitBTN, "submitBTN");
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.UseVisualStyleBackColor = true;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click);
            // 
            // exitBTN
            // 
            resources.ApplyResources(this.exitBTN, "exitBTN");
            this.exitBTN.Name = "exitBTN";
            this.exitBTN.UseVisualStyleBackColor = true;
            this.exitBTN.Click += new System.EventHandler(this.exitBTN_Click);
            // 
            // loginErrorLabel
            // 
            resources.ApplyResources(this.loginErrorLabel, "loginErrorLabel");
            this.loginErrorLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.loginErrorLabel.Name = "loginErrorLabel";
            this.loginErrorLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LanguageStatementLabel
            // 
            resources.ApplyResources(this.LanguageStatementLabel, "LanguageStatementLabel");
            this.LanguageStatementLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.LanguageStatementLabel.Name = "LanguageStatementLabel";
            // 
            // LogInScreen
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LanguageStatementLabel);
            this.Controls.Add(this.loginErrorLabel);
            this.Controls.Add(this.exitBTN);
            this.Controls.Add(this.submitBTN);
            this.Controls.Add(this.welcomeMessageLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.usernameTextbox);
            this.Name = "LogInScreen";
            this.Load += new System.EventHandler(this.LogInScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label welcomeMessageLabel;
        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Button exitBTN;
        private System.Windows.Forms.Label loginErrorLabel;
        private System.Windows.Forms.Label LanguageStatementLabel;
    }
}