using Mailer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace WFMailer
{
    /// <summary>
    /// Основная форма приложения
    /// </summary>
    public partial class MainWindow : Form
    {
        private MailController _mailController;
        private List<Email> _inboxEmails;
        private List<Email> _sentEmails;

        public MainWindow(MailController mailController)
        {
            InitializeComponent();
            _mailController = mailController;

            // Подгрузка иконки сообщения
            var icons = new ImageList();
            icons.Images.Add(Properties.Resources.mail);
            InboxListView.SmallImageList = icons;
            SentListView.SmallImageList = icons;
        }

        /// <summary>
        /// Ивент загрузки формы
        /// </summary>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            // Стандартные статусы
            UserEmail.Text = _mailController.Email;

            SMTPConnInfo.Text = $"smtp.{_mailController.Domain}:{_mailController.Smtpport}";
            SMTPConnStatus.Text = "ПОДКЛЮЧЁН";

            IMAPConnInfo.Text = $"imap.{_mailController.Domain}:{_mailController.Imapport}";
            IMAPConnStatus.Text = "ПОДКЛЮЧЁН";

            InboxStatus.Text = "";
            SentStatus.Text = "";
            NewMessageSendingStatus.Text = "";

            // Отображение только одного столбца во всех ListView
            InboxListView.Columns.Add("", -2, HorizontalAlignment.Left);
            InboxListView.Columns[0].Width = InboxListView.ClientSize.Width;
            InboxListView.HeaderStyle = ColumnHeaderStyle.None;

            SentListView.Columns.Add("", -2, HorizontalAlignment.Left);
            SentListView.Columns[0].Width = InboxListView.ClientSize.Width;
            SentListView.HeaderStyle = ColumnHeaderStyle.None;

            // Подписка на ивент отправки нового сообщения
            _mailController.OnMessageSend += OnMessageSend;
            _mailController.OnMessageSendError += OnMessageSendError;

            UpdateInboxPanel();
            UpdateSentPanel();

            LoadInboxMessagesToList();
        }

        /// <summary>
        /// Ивент изменения таба
        /// </summary>
        private void MainTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (MainTab.SelectedIndex)
            {
                case 0:
                    if (!_mailController.IsBusy) LoadInboxMessagesToList();
                    break;
                case 1:
                    if (!_mailController.IsBusy) LoadSentMessagesToList();
                    break;
            }
        }

        /// <summary>
        /// Ивент изменения выбора элемента в списке входящих сообщений
        /// </summary>
        private void InboxListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateInboxPanel(_inboxEmails[InboxListView.SelectedIndices[0]]);
            }
            catch (ArgumentOutOfRangeException) { return; }
        }

        /// <summary>
        /// Ивент изменения выбора элемента в списке отправленных сообщений
        /// </summary>
        private void SentListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateSentPanel(_sentEmails[SentListView.SelectedIndices[0]]);
            }
            catch (ArgumentOutOfRangeException){ return; }
        }

        /// <summary>
        /// Ивент отправки нового сообщения
        /// </summary>
        private void NewMessageSendButton_Click(object sender, EventArgs e)
        {
            NewMessageSendingStatus.ForeColor = Color.Black;
            TrySendNewMessage();
        }


        /// <summary>
        /// Пытается отправить новое сообщение. При отсутствующих полях выводит статус
        /// </summary>
        private async void TrySendNewMessage()
        {
            if (string.IsNullOrEmpty(NewMessageSubjectTextBox.Text))
            {
                NewMessageSendingStatus.ForeColor = Color.Red;
                NewMessageSendingStatus.Text = "Не указана тема сообщения";
                return;
            }

            if (!EmailServices.IsValidEmail(NewMessageEmailTextBox.Text))
            {
                NewMessageSendingStatus.ForeColor = Color.Red;
                NewMessageSendingStatus.Text = "Некорректный Email получателя";
                return;
            }

            if (string.IsNullOrEmpty(NewMessageBody.Text))
            {
                NewMessageSendingStatus.ForeColor = Color.Red;
                NewMessageSendingStatus.Text = "Отсутствует текст сообщения";
                return;
            }

            NewMessageSendingStatus.Text = "Отправка сообщения...";
            await _mailController.SendMessage(NewMessageEmailTextBox.Text, NewMessageSubjectTextBox.Text, NewMessageBody.Text);
        }

        /// <summary>
        /// Ивент на успешную отправку нового сообщения
        /// </summary>
        private void OnMessageSend(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                NewMessageSendingStatus.ForeColor = Color.Green;
                NewMessageSendingStatus.Text = "Сообщение успешно отправлено";

                NewMessageSubjectTextBox.Text = "";
                NewMessageEmailTextBox.Text = "";
                NewMessageBody.Text = "";
            });
        }

        /// <summary>
        /// Ивент на проваленную отправку нового сообщения
        /// </summary>
        private void OnMessageSendError(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                NewMessageSendingStatus.ForeColor = Color.Red;
                NewMessageSendingStatus.Text = "Не удалось отправить сообщение";
            });
        }

        /// <summary>
        /// Загружает входящие сообщения в ListView
        /// </summary>
        private async void LoadInboxMessagesToList()
        {
            InboxStatus.Text = "Загрузка...";
            InboxListView.Items.Clear();
            UpdateInboxPanel();

            var result = await _mailController.GetInboxMessages(ApplicationData.GetConfig().MaxMessages);
            _inboxEmails = result.Item2;

            foreach (var email in _inboxEmails)
            {
                InboxListView.Items.Add(new ListViewItem(email.Subject, 0));
            }
            InboxStatus.Text = $"Всего: {result.Item1}";

            if (_inboxEmails.Count > 0) UpdateInboxPanel(_inboxEmails[0]);
        }

        /// <summary>
        /// Загружает отправленные сообщения в ListView
        /// </summary>
        private async void LoadSentMessagesToList()
        {
            SentStatus.Text = "Загрузка...";
            SentListView.Items.Clear();
            UpdateSentPanel();

            var result = await _mailController.GetSentMessages(ApplicationData.GetConfig().MaxMessages);
            _sentEmails = result.Item2;

            foreach (var email in _sentEmails)
            {
                SentListView.Items.Add(new ListViewItem(email.Subject, 0));
            }
            SentStatus.Text = $"Всего: {result.Item1}";

            if (_sentEmails.Count > 0) UpdateSentPanel(_sentEmails[0]);
        }

        /// <summary>
        /// Выводит на панель сообщений Email. null - очистка панели
        /// </summary>
        private void UpdateInboxPanel(Email email = null)
        {
            if (email == null)
            {
                InboxPanel.Visible = false;
            }
            else 
            {
                InboxPanel.Visible = true;
                InboxDateTime.Text = email?.Date.ToString("dd.MM.yyyy hh:mm:ss");
                InboxSubject.Text = email?.Subject;
                InboxFrom.Text = email?.From;
                InboxMessage.Text = email?.TextBody;
            }
        }

        /// <summary>
        /// Выводит на панель сообщений Email. null - очистка панели
        /// </summary>
        private void UpdateSentPanel(Email email = null)
        {
            if (email == null)
            {
                SentPanel.Visible = false;
            }
            else
            {
                SentPanel.Visible = true;
                SentDateTime.Text = email?.Date.ToString();
                SentSubject.Text = email?.Subject;
                SentTo.Text = email?.From;
                SentMessage.Text = email?.TextBody;
            }
        }
    }
}
