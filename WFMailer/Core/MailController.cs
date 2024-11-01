using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit;
using MimeKit;
using MailKit.Net.Imap;
using MailKit.Net.Smtp;


namespace WFMailer
{
    /// <summary>
    /// Email-сообщение
    /// </summary>
    public class Email
    {
        public string From { get; private set; }
        public string To { get; private set; }
        public string Subject { get; private set; }
        public DateTimeOffset Date { get; private set; }
        public string TextBody { get; private set; }
        public string HtmlBody { get; private set; }

        public Email(string from, string to, string subject, DateTimeOffset date, string textBody, string htmlBody)
        {
            From = from;
            To = to;
            Subject = subject;
            Date = date;
            TextBody = textBody;
            HtmlBody = htmlBody;
        }
    }

    /// <summary>
    /// Email-контроллер для отправки и получения сообщений
    /// </summary>
    public class MailController
    {
        public event EventHandler OnConnectSuccess;
        public event EventHandler OnConnectError;

        public event EventHandler OnMessageSend;
        public event EventHandler OnMessageSendError;

        public string Email;
        public string Password;
        public string Domain;
        public int Imapport;
        public int Smtpport;
        public bool IsBusy = false;

        private int _connectCounter;
        private readonly string _IMAPdomain;
        private readonly string _SMTPdomain;

        private readonly SmtpClient _smtpClient = new SmtpClient();
        private readonly ImapClient _imapClient = new ImapClient();

        public MailController(string email, string password, string domain, int IMAPport, int SMTPport)
        {
            Email = email;
            Password = password;
            Domain = domain;
            Imapport = IMAPport;
            Smtpport = SMTPport;
            _IMAPdomain = "imap." + Domain;
            _SMTPdomain = "smtp." + Domain;

            _imapClient.Timeout = 10000;
            _smtpClient.Timeout = 10000;

            _imapClient.Connected += async (sender, e) => { await IMAPAuthenticate(); };
            _smtpClient.Connected += async (sender, e) => { await SMTPAuthenticate(); };
        }

        /// <summary>
        /// Проверка на авторизацию в SMTP и IMAP
        /// </summary>
        public bool IsAuthenticated()
        {
            return _imapClient.IsAuthenticated && _smtpClient.IsAuthenticated;
        }

        /// <summary>
        /// Подключается к SMTP и IMAP серверам
        /// </summary>
        public async Task Connect()
        {
            try
            {
                await _imapClient.ConnectAsync(_IMAPdomain, Imapport, true);
                await _smtpClient.ConnectAsync(_SMTPdomain, Smtpport, true);
            }
            catch { OnConnectError.Invoke(this, EventArgs.Empty); }
        }

        /// <summary>
        /// Отправляет сообщение по SMTP протоколу
        /// </summary>
        public async Task SendMessage(string to, string subject, string message)
        {
            IsBusy = true;

            var msg = new MimeMessage();

            msg.From.Add(new MailboxAddress(Email, Email));
            msg.To.Add(new MailboxAddress(to, to));
            msg.Subject = subject;

            msg.Body = new TextPart("Plain")
            {
                Text = message
            };

            try
            {
                await _smtpClient.SendAsync(msg);
                OnMessageSend?.Invoke(this, EventArgs.Empty);
                IsBusy = false;
            } catch { IsBusy = false; OnMessageSendError?.Invoke(this, EventArgs.Empty); }
        }

        /// <summary>
        /// Получает все сообещния из вкладки "Входящие"
        /// </summary>
        public async Task<(int, List<Email>)> GetInboxMessages(int messageCount)
        {
            IsBusy = true;
            List<Email> messages = new List<Email>();
            var inbox = _imapClient.Inbox;
            await inbox.OpenAsync(FolderAccess.ReadOnly);
            int count = inbox.Count;

            for (int i = 0; i < messageCount; i++)
            {
                if ((inbox.Count - i - 1) < 0) { await inbox.CloseAsync(); break; }

                var message = await inbox.GetMessageAsync(inbox.Count - i - 1);
                messages.Add(
                    new Email(
                        message.From.Last().ToString(),
                        message.To.Last().ToString(),
                        message.Subject.ToString(),
                        message.Date,
                        !(string.IsNullOrEmpty(message.TextBody)) ? message.TextBody : "",
                        !(string.IsNullOrEmpty(message.HtmlBody)) ? message.HtmlBody : ""
                        )
                    );
            }
            IsBusy = false;
            return (inbox.Count, messages);
        }

        /// <summary>
        /// Получает все сообещния из вкладки "Отправленные"
        /// </summary>
        public async Task<(int, List<Email>)> GetSentMessages(int messageCount)
        {
            IsBusy = true;
            List<Email> messages = new List<Email>();
            var sent = _imapClient.GetFolder(SpecialFolder.Sent);
            await sent.OpenAsync(FolderAccess.ReadOnly);
            int count = sent.Count;

            for (int i = 0; i < messageCount; i++)
            {
                if ((sent.Count - i - 1) < 0) { await sent.CloseAsync(); break; }

                var message = await sent.GetMessageAsync(sent.Count - i - 1);
                messages.Add(
                    new Email(
                        message.To.Last().ToString(),
                        message.From.Last().ToString(),
                        message.Subject.ToString(),
                        message.Date,
                        !(string.IsNullOrEmpty(message.TextBody)) ? message.TextBody : "",
                        !(string.IsNullOrEmpty(message.HtmlBody)) ? message.HtmlBody : ""
                        )
                    );
            }
            IsBusy = false;
            return (sent.Count, messages);
        }


        /// <summary>
        /// Аутентификация IMAP сервера
        /// </summary>
        private async Task IMAPAuthenticate()
        {
            try
            {
                await _imapClient.AuthenticateAsync(Email, Password);
                _connectCounter++;
                if (_connectCounter == 2)
                {
                    OnConnectSuccess?.Invoke(this, EventArgs.Empty);
                }
            }
            catch { OnConnectError.Invoke(this, EventArgs.Empty); }
        }

        /// <summary>
        /// Аутентификация SMTP сервера
        /// </summary>
        private async Task SMTPAuthenticate()
        {
            try
            {
                await _smtpClient.AuthenticateAsync(Email, Password);
                _connectCounter++;
                if (_connectCounter == 2)
                {
                    OnConnectSuccess?.Invoke(this, EventArgs.Empty);
                }
            }
            catch { OnConnectError.Invoke(this, EventArgs.Empty); }
        }
    }
}
