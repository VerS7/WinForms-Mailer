namespace WFMailer
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.EmailEntry = new System.Windows.Forms.TextBox();
            this.PasswordEntry = new System.Windows.Forms.TextBox();
            this.IntroLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.EmailStatus = new System.Windows.Forms.Label();
            this.LoginStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmailEntry
            // 
            this.EmailEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailEntry.Location = new System.Drawing.Point(86, 85);
            this.EmailEntry.Name = "EmailEntry";
            this.EmailEntry.Size = new System.Drawing.Size(221, 26);
            this.EmailEntry.TabIndex = 0;
            // 
            // PasswordEntry
            // 
            this.PasswordEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordEntry.Location = new System.Drawing.Point(86, 159);
            this.PasswordEntry.Name = "PasswordEntry";
            this.PasswordEntry.Size = new System.Drawing.Size(221, 26);
            this.PasswordEntry.TabIndex = 1;
            // 
            // IntroLabel
            // 
            this.IntroLabel.AutoSize = true;
            this.IntroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IntroLabel.Location = new System.Drawing.Point(79, 9);
            this.IntroLabel.Name = "IntroLabel";
            this.IntroLabel.Size = new System.Drawing.Size(238, 39);
            this.IntroLabel.TabIndex = 2;
            this.IntroLabel.Text = "Вход в Mailer";
            this.IntroLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLabel.Location = new System.Drawing.Point(83, 65);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(47, 17);
            this.EmailLabel.TabIndex = 3;
            this.EmailLabel.Text = "Email";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordLabel.Location = new System.Drawing.Point(83, 139);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(63, 17);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Пароль";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.AliceBlue;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.Location = new System.Drawing.Point(135, 217);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(113, 32);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // EmailStatus
            // 
            this.EmailStatus.AutoSize = true;
            this.EmailStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailStatus.ForeColor = System.Drawing.Color.Red;
            this.EmailStatus.Location = new System.Drawing.Point(88, 111);
            this.EmailStatus.Name = "EmailStatus";
            this.EmailStatus.Size = new System.Drawing.Size(100, 13);
            this.EmailStatus.TabIndex = 6;
            this.EmailStatus.Text = "EmailErrorStatus";
            // 
            // LoginStatus
            // 
            this.LoginStatus.AutoSize = true;
            this.LoginStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginStatus.Location = new System.Drawing.Point(97, 196);
            this.LoginStatus.MinimumSize = new System.Drawing.Size(200, 0);
            this.LoginStatus.Name = "LoginStatus";
            this.LoginStatus.Size = new System.Drawing.Size(200, 15);
            this.LoginStatus.TabIndex = 7;
            this.LoginStatus.Text = "Status...";
            this.LoginStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.LoginStatus);
            this.Controls.Add(this.EmailStatus);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.IntroLabel);
            this.Controls.Add(this.PasswordEntry);
            this.Controls.Add(this.EmailEntry);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 300);
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mailer | Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailEntry;
        private System.Windows.Forms.TextBox PasswordEntry;
        private System.Windows.Forms.Label IntroLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label EmailStatus;
        private System.Windows.Forms.Label LoginStatus;
    }
}