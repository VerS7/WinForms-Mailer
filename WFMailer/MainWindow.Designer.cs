namespace WFMailer
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.MainTab = new System.Windows.Forms.TabControl();
            this.InboxPage = new System.Windows.Forms.TabPage();
            this.InboxPanel = new System.Windows.Forms.Panel();
            this.InboxFrom = new System.Windows.Forms.Label();
            this.InboxDateTime = new System.Windows.Forms.Label();
            this.InboxSubject = new System.Windows.Forms.Label();
            this.InboxMessage = new System.Windows.Forms.TextBox();
            this.InboxListView = new System.Windows.Forms.ListView();
            this.InboxStatus = new System.Windows.Forms.Label();
            this.SentPage = new System.Windows.Forms.TabPage();
            this.SentPanel = new System.Windows.Forms.Panel();
            this.SentTo = new System.Windows.Forms.Label();
            this.SentDateTime = new System.Windows.Forms.Label();
            this.SentSubject = new System.Windows.Forms.Label();
            this.SentMessage = new System.Windows.Forms.TextBox();
            this.SentListView = new System.Windows.Forms.ListView();
            this.SentStatus = new System.Windows.Forms.Label();
            this.MessageTab = new System.Windows.Forms.TabPage();
            this.NewMessageSendingStatus = new System.Windows.Forms.Label();
            this.NewMessageSendButton = new System.Windows.Forms.Button();
            this.NewMessageBody = new System.Windows.Forms.TextBox();
            this.NewMessageEmailTextBox = new System.Windows.Forms.TextBox();
            this.NewMessageReceiverLabel = new System.Windows.Forms.Label();
            this.NewMessageSubjectTextBox = new System.Windows.Forms.TextBox();
            this.NewMessageThemeLabel = new System.Windows.Forms.Label();
            this.UserImageLabel = new System.Windows.Forms.Label();
            this.UserLabel = new System.Windows.Forms.Label();
            this.UserEmail = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SMTPConnInfo = new System.Windows.Forms.Label();
            this.SMTPConnStatus = new System.Windows.Forms.Label();
            this.IMAPConnInfo = new System.Windows.Forms.Label();
            this.IMAPConnStatus = new System.Windows.Forms.Label();
            this.MainTab.SuspendLayout();
            this.InboxPage.SuspendLayout();
            this.InboxPanel.SuspendLayout();
            this.SentPage.SuspendLayout();
            this.SentPanel.SuspendLayout();
            this.MessageTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.InboxPage);
            this.MainTab.Controls.Add(this.SentPage);
            this.MainTab.Controls.Add(this.MessageTab);
            this.MainTab.Location = new System.Drawing.Point(0, 0);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(835, 555);
            this.MainTab.TabIndex = 0;
            this.MainTab.SelectedIndexChanged += new System.EventHandler(this.MainTab_SelectedIndexChanged);
            // 
            // InboxPage
            // 
            this.InboxPage.Controls.Add(this.InboxPanel);
            this.InboxPage.Controls.Add(this.InboxListView);
            this.InboxPage.Controls.Add(this.InboxStatus);
            this.InboxPage.Location = new System.Drawing.Point(4, 22);
            this.InboxPage.Name = "InboxPage";
            this.InboxPage.Padding = new System.Windows.Forms.Padding(3);
            this.InboxPage.Size = new System.Drawing.Size(827, 529);
            this.InboxPage.TabIndex = 0;
            this.InboxPage.Text = "Входящие";
            this.InboxPage.UseVisualStyleBackColor = true;
            // 
            // InboxPanel
            // 
            this.InboxPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.InboxPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InboxPanel.Controls.Add(this.InboxFrom);
            this.InboxPanel.Controls.Add(this.InboxDateTime);
            this.InboxPanel.Controls.Add(this.InboxSubject);
            this.InboxPanel.Controls.Add(this.InboxMessage);
            this.InboxPanel.Location = new System.Drawing.Point(382, 25);
            this.InboxPanel.Name = "InboxPanel";
            this.InboxPanel.Size = new System.Drawing.Size(435, 489);
            this.InboxPanel.TabIndex = 6;
            // 
            // InboxFrom
            // 
            this.InboxFrom.AutoSize = true;
            this.InboxFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InboxFrom.ForeColor = System.Drawing.SystemColors.InfoText;
            this.InboxFrom.Location = new System.Drawing.Point(3, 50);
            this.InboxFrom.Name = "InboxFrom";
            this.InboxFrom.Size = new System.Drawing.Size(128, 15);
            this.InboxFrom.TabIndex = 3;
            this.InboxFrom.Text = "from@domain.com";
            this.InboxFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InboxDateTime
            // 
            this.InboxDateTime.AutoSize = true;
            this.InboxDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InboxDateTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.InboxDateTime.Location = new System.Drawing.Point(3, 71);
            this.InboxDateTime.Name = "InboxDateTime";
            this.InboxDateTime.Size = new System.Drawing.Size(139, 15);
            this.InboxDateTime.TabIndex = 2;
            this.InboxDateTime.Text = "00:00:0000 00:00:00";
            this.InboxDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InboxSubject
            // 
            this.InboxSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InboxSubject.Location = new System.Drawing.Point(2, 4);
            this.InboxSubject.MinimumSize = new System.Drawing.Size(420, 35);
            this.InboxSubject.Name = "InboxSubject";
            this.InboxSubject.Size = new System.Drawing.Size(420, 40);
            this.InboxSubject.TabIndex = 1;
            this.InboxSubject.Text = "Тема сообщения";
            // 
            // InboxMessage
            // 
            this.InboxMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InboxMessage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.InboxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InboxMessage.HideSelection = false;
            this.InboxMessage.Location = new System.Drawing.Point(6, 89);
            this.InboxMessage.Multiline = true;
            this.InboxMessage.Name = "InboxMessage";
            this.InboxMessage.ReadOnly = true;
            this.InboxMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InboxMessage.Size = new System.Drawing.Size(424, 392);
            this.InboxMessage.TabIndex = 0;
            this.InboxMessage.Text = "Сообщение";
            // 
            // InboxListView
            // 
            this.InboxListView.AutoArrange = false;
            this.InboxListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InboxListView.FullRowSelect = true;
            this.InboxListView.HideSelection = false;
            this.InboxListView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.InboxListView.Location = new System.Drawing.Point(7, 25);
            this.InboxListView.Name = "InboxListView";
            this.InboxListView.Size = new System.Drawing.Size(370, 489);
            this.InboxListView.TabIndex = 3;
            this.InboxListView.UseCompatibleStateImageBehavior = false;
            this.InboxListView.View = System.Windows.Forms.View.Details;
            this.InboxListView.SelectedIndexChanged += new System.EventHandler(this.InboxListView_SelectedIndexChanged);
            // 
            // InboxStatus
            // 
            this.InboxStatus.AutoSize = true;
            this.InboxStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InboxStatus.Location = new System.Drawing.Point(3, 5);
            this.InboxStatus.Name = "InboxStatus";
            this.InboxStatus.Size = new System.Drawing.Size(69, 17);
            this.InboxStatus.TabIndex = 1;
            this.InboxStatus.Text = "Status...";
            // 
            // SentPage
            // 
            this.SentPage.Controls.Add(this.SentPanel);
            this.SentPage.Controls.Add(this.SentListView);
            this.SentPage.Controls.Add(this.SentStatus);
            this.SentPage.Location = new System.Drawing.Point(4, 22);
            this.SentPage.Name = "SentPage";
            this.SentPage.Padding = new System.Windows.Forms.Padding(3);
            this.SentPage.Size = new System.Drawing.Size(827, 529);
            this.SentPage.TabIndex = 1;
            this.SentPage.Text = "Отправленные";
            this.SentPage.UseVisualStyleBackColor = true;
            // 
            // SentPanel
            // 
            this.SentPanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.SentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SentPanel.Controls.Add(this.SentTo);
            this.SentPanel.Controls.Add(this.SentDateTime);
            this.SentPanel.Controls.Add(this.SentSubject);
            this.SentPanel.Controls.Add(this.SentMessage);
            this.SentPanel.Location = new System.Drawing.Point(382, 25);
            this.SentPanel.Name = "SentPanel";
            this.SentPanel.Size = new System.Drawing.Size(435, 489);
            this.SentPanel.TabIndex = 6;
            // 
            // SentTo
            // 
            this.SentTo.AutoSize = true;
            this.SentTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SentTo.ForeColor = System.Drawing.SystemColors.InfoText;
            this.SentTo.Location = new System.Drawing.Point(3, 50);
            this.SentTo.Name = "SentTo";
            this.SentTo.Size = new System.Drawing.Size(128, 15);
            this.SentTo.TabIndex = 3;
            this.SentTo.Text = "from@domain.com";
            this.SentTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SentDateTime
            // 
            this.SentDateTime.AutoSize = true;
            this.SentDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SentDateTime.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SentDateTime.Location = new System.Drawing.Point(3, 71);
            this.SentDateTime.Name = "SentDateTime";
            this.SentDateTime.Size = new System.Drawing.Size(139, 15);
            this.SentDateTime.TabIndex = 2;
            this.SentDateTime.Text = "00:00:0000 00:00:00";
            this.SentDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SentSubject
            // 
            this.SentSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SentSubject.Location = new System.Drawing.Point(2, 4);
            this.SentSubject.MinimumSize = new System.Drawing.Size(420, 35);
            this.SentSubject.Name = "SentSubject";
            this.SentSubject.Size = new System.Drawing.Size(420, 40);
            this.SentSubject.TabIndex = 1;
            this.SentSubject.Text = "Тема сообщения";
            // 
            // SentMessage
            // 
            this.SentMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SentMessage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SentMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SentMessage.HideSelection = false;
            this.SentMessage.Location = new System.Drawing.Point(6, 89);
            this.SentMessage.Multiline = true;
            this.SentMessage.Name = "SentMessage";
            this.SentMessage.ReadOnly = true;
            this.SentMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.SentMessage.Size = new System.Drawing.Size(424, 392);
            this.SentMessage.TabIndex = 0;
            this.SentMessage.Text = "Сообщение";
            // 
            // SentListView
            // 
            this.SentListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SentListView.HideSelection = false;
            this.SentListView.Location = new System.Drawing.Point(7, 25);
            this.SentListView.Name = "SentListView";
            this.SentListView.Size = new System.Drawing.Size(370, 489);
            this.SentListView.TabIndex = 4;
            this.SentListView.UseCompatibleStateImageBehavior = false;
            this.SentListView.View = System.Windows.Forms.View.Details;
            this.SentListView.SelectedIndexChanged += new System.EventHandler(this.SentListView_SelectedIndexChanged);
            // 
            // SentStatus
            // 
            this.SentStatus.AutoSize = true;
            this.SentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SentStatus.Location = new System.Drawing.Point(3, 5);
            this.SentStatus.Name = "SentStatus";
            this.SentStatus.Size = new System.Drawing.Size(69, 17);
            this.SentStatus.TabIndex = 4;
            this.SentStatus.Text = "Status...";
            // 
            // MessageTab
            // 
            this.MessageTab.Controls.Add(this.NewMessageSendingStatus);
            this.MessageTab.Controls.Add(this.NewMessageSendButton);
            this.MessageTab.Controls.Add(this.NewMessageBody);
            this.MessageTab.Controls.Add(this.NewMessageEmailTextBox);
            this.MessageTab.Controls.Add(this.NewMessageReceiverLabel);
            this.MessageTab.Controls.Add(this.NewMessageSubjectTextBox);
            this.MessageTab.Controls.Add(this.NewMessageThemeLabel);
            this.MessageTab.Location = new System.Drawing.Point(4, 22);
            this.MessageTab.Name = "MessageTab";
            this.MessageTab.Padding = new System.Windows.Forms.Padding(3);
            this.MessageTab.Size = new System.Drawing.Size(827, 529);
            this.MessageTab.TabIndex = 2;
            this.MessageTab.Text = "Отправить";
            this.MessageTab.UseVisualStyleBackColor = true;
            // 
            // NewMessageSendingStatus
            // 
            this.NewMessageSendingStatus.AutoSize = true;
            this.NewMessageSendingStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewMessageSendingStatus.Location = new System.Drawing.Point(162, 497);
            this.NewMessageSendingStatus.Name = "NewMessageSendingStatus";
            this.NewMessageSendingStatus.Size = new System.Drawing.Size(71, 18);
            this.NewMessageSendingStatus.TabIndex = 7;
            this.NewMessageSendingStatus.Text = "Status...";
            // 
            // NewMessageSendButton
            // 
            this.NewMessageSendButton.BackColor = System.Drawing.Color.AliceBlue;
            this.NewMessageSendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewMessageSendButton.Location = new System.Drawing.Point(10, 490);
            this.NewMessageSendButton.Name = "NewMessageSendButton";
            this.NewMessageSendButton.Size = new System.Drawing.Size(129, 33);
            this.NewMessageSendButton.TabIndex = 6;
            this.NewMessageSendButton.Text = "Отправить";
            this.NewMessageSendButton.UseVisualStyleBackColor = false;
            this.NewMessageSendButton.Click += new System.EventHandler(this.NewMessageSendButton_Click);
            // 
            // NewMessageBody
            // 
            this.NewMessageBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewMessageBody.Location = new System.Drawing.Point(10, 119);
            this.NewMessageBody.Multiline = true;
            this.NewMessageBody.Name = "NewMessageBody";
            this.NewMessageBody.Size = new System.Drawing.Size(561, 365);
            this.NewMessageBody.TabIndex = 5;
            // 
            // NewMessageEmailTextBox
            // 
            this.NewMessageEmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewMessageEmailTextBox.Location = new System.Drawing.Point(10, 77);
            this.NewMessageEmailTextBox.Name = "NewMessageEmailTextBox";
            this.NewMessageEmailTextBox.Size = new System.Drawing.Size(561, 26);
            this.NewMessageEmailTextBox.TabIndex = 3;
            // 
            // NewMessageReceiverLabel
            // 
            this.NewMessageReceiverLabel.AutoSize = true;
            this.NewMessageReceiverLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewMessageReceiverLabel.Location = new System.Drawing.Point(3, 57);
            this.NewMessageReceiverLabel.Name = "NewMessageReceiverLabel";
            this.NewMessageReceiverLabel.Size = new System.Drawing.Size(140, 17);
            this.NewMessageReceiverLabel.TabIndex = 2;
            this.NewMessageReceiverLabel.Text = "Email получателя";
            // 
            // NewMessageSubjectTextBox
            // 
            this.NewMessageSubjectTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewMessageSubjectTextBox.Location = new System.Drawing.Point(10, 23);
            this.NewMessageSubjectTextBox.Name = "NewMessageSubjectTextBox";
            this.NewMessageSubjectTextBox.Size = new System.Drawing.Size(561, 26);
            this.NewMessageSubjectTextBox.TabIndex = 1;
            // 
            // NewMessageThemeLabel
            // 
            this.NewMessageThemeLabel.AutoSize = true;
            this.NewMessageThemeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewMessageThemeLabel.Location = new System.Drawing.Point(3, 3);
            this.NewMessageThemeLabel.Name = "NewMessageThemeLabel";
            this.NewMessageThemeLabel.Size = new System.Drawing.Size(134, 17);
            this.NewMessageThemeLabel.TabIndex = 0;
            this.NewMessageThemeLabel.Text = "Тема сообщения";
            // 
            // UserImageLabel
            // 
            this.UserImageLabel.AutoSize = true;
            this.UserImageLabel.Image = ((System.Drawing.Image)(resources.GetObject("UserImageLabel.Image")));
            this.UserImageLabel.Location = new System.Drawing.Point(11, 557);
            this.UserImageLabel.MaximumSize = new System.Drawing.Size(32, 32);
            this.UserImageLabel.MinimumSize = new System.Drawing.Size(32, 32);
            this.UserImageLabel.Name = "UserImageLabel";
            this.UserImageLabel.Size = new System.Drawing.Size(32, 32);
            this.UserImageLabel.TabIndex = 1;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserLabel.Location = new System.Drawing.Point(49, 555);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(113, 17);
            this.UserLabel.TabIndex = 2;
            this.UserLabel.Text = "Пользователь";
            // 
            // UserEmail
            // 
            this.UserEmail.AutoSize = true;
            this.UserEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserEmail.ForeColor = System.Drawing.SystemColors.GrayText;
            this.UserEmail.Location = new System.Drawing.Point(50, 570);
            this.UserEmail.Name = "UserEmail";
            this.UserEmail.Size = new System.Drawing.Size(43, 15);
            this.UserEmail.TabIndex = 3;
            this.UserEmail.Text = "email";
            // 
            // SMTPConnInfo
            // 
            this.SMTPConnInfo.AutoSize = true;
            this.SMTPConnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SMTPConnInfo.Location = new System.Drawing.Point(489, 555);
            this.SMTPConnInfo.Name = "SMTPConnInfo";
            this.SMTPConnInfo.Size = new System.Drawing.Size(151, 17);
            this.SMTPConnInfo.TabIndex = 4;
            this.SMTPConnInfo.Text = "smtp.email.com:465";
            // 
            // SMTPConnStatus
            // 
            this.SMTPConnStatus.AutoSize = true;
            this.SMTPConnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SMTPConnStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SMTPConnStatus.Location = new System.Drawing.Point(490, 574);
            this.SMTPConnStatus.Name = "SMTPConnStatus";
            this.SMTPConnStatus.Size = new System.Drawing.Size(115, 15);
            this.SMTPConnStatus.TabIndex = 5;
            this.SMTPConnStatus.Text = "ПОДКЛЮЧЕНИЕ";
            // 
            // IMAPConnInfo
            // 
            this.IMAPConnInfo.AutoSize = true;
            this.IMAPConnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IMAPConnInfo.Location = new System.Drawing.Point(670, 554);
            this.IMAPConnInfo.Name = "IMAPConnInfo";
            this.IMAPConnInfo.Size = new System.Drawing.Size(151, 17);
            this.IMAPConnInfo.TabIndex = 6;
            this.IMAPConnInfo.Text = "imap.email.com:465";
            // 
            // IMAPConnStatus
            // 
            this.IMAPConnStatus.AutoSize = true;
            this.IMAPConnStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IMAPConnStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.IMAPConnStatus.Location = new System.Drawing.Point(671, 574);
            this.IMAPConnStatus.Name = "IMAPConnStatus";
            this.IMAPConnStatus.Size = new System.Drawing.Size(115, 15);
            this.IMAPConnStatus.TabIndex = 7;
            this.IMAPConnStatus.Text = "ПОДКЛЮЧЕНИЕ";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 596);
            this.Controls.Add(this.IMAPConnStatus);
            this.Controls.Add(this.IMAPConnInfo);
            this.Controls.Add(this.SMTPConnStatus);
            this.Controls.Add(this.SMTPConnInfo);
            this.Controls.Add(this.UserEmail);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.UserImageLabel);
            this.Controls.Add(this.MainTab);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 635);
            this.MinimumSize = new System.Drawing.Size(850, 635);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mailer SMTP | IMAP клиент";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.MainTab.ResumeLayout(false);
            this.InboxPage.ResumeLayout(false);
            this.InboxPage.PerformLayout();
            this.InboxPanel.ResumeLayout(false);
            this.InboxPanel.PerformLayout();
            this.SentPage.ResumeLayout(false);
            this.SentPage.PerformLayout();
            this.SentPanel.ResumeLayout(false);
            this.SentPanel.PerformLayout();
            this.MessageTab.ResumeLayout(false);
            this.MessageTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage InboxPage;
        private System.Windows.Forms.TabPage SentPage;
        private System.Windows.Forms.TabPage MessageTab;
        private System.Windows.Forms.Label InboxStatus;
        private System.Windows.Forms.Label SentStatus;
        private System.Windows.Forms.Label UserImageLabel;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label UserEmail;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label SMTPConnInfo;
        private System.Windows.Forms.Label SMTPConnStatus;
        private System.Windows.Forms.Label IMAPConnInfo;
        private System.Windows.Forms.Label IMAPConnStatus;
        private System.Windows.Forms.TextBox NewMessageEmailTextBox;
        private System.Windows.Forms.Label NewMessageReceiverLabel;
        private System.Windows.Forms.TextBox NewMessageSubjectTextBox;
        private System.Windows.Forms.Label NewMessageThemeLabel;
        private System.Windows.Forms.Label NewMessageSendingStatus;
        private System.Windows.Forms.Button NewMessageSendButton;
        private System.Windows.Forms.TextBox NewMessageBody;
        private System.Windows.Forms.ListView InboxListView;
        private System.Windows.Forms.ListView SentListView;
        private System.Windows.Forms.Panel InboxPanel;
        private System.Windows.Forms.Label InboxFrom;
        private System.Windows.Forms.Label InboxDateTime;
        private System.Windows.Forms.Label InboxSubject;
        private System.Windows.Forms.TextBox InboxMessage;
        private System.Windows.Forms.Panel SentPanel;
        private System.Windows.Forms.Label SentTo;
        private System.Windows.Forms.Label SentDateTime;
        private System.Windows.Forms.Label SentSubject;
        private System.Windows.Forms.TextBox SentMessage;
    }
}

