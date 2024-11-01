using Mailer;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace WFMailer
{
    /// <summary>
    /// Форма входа в приложение
    /// </summary>
    public partial class Login : Form
    {
        public event EventHandler OnAuthComplete;

        private MailController _mailController;
        private readonly ApplicationConfig _config;

        private bool _isConnecting;
        private string _email;
        private string _password;

        public Login()
        {
            InitializeComponent();
            _config = ApplicationData.GetConfig();
        }

        /// <summary>
        /// Ивент загрузки формы
        /// </summary>
        private void Login_Load(object sender, EventArgs e)
        {
            PasswordEntry.Text = _config.Password;
            EmailEntry.Text = _config.Email;

            EmailStatus.Text = "";
            LoginStatus.Text = "";
        }

        /// <summary>
        /// Ивент клика кнопки LoginButton
        /// </summary>
        private async void LoginButton_Click(object sender, EventArgs e)
        {
            _email = EmailEntry.Text;
            _password = PasswordEntry.Text;

            if (_email == null || !EmailServices.IsValidAndExistEmail(_email))
            {
                EmailStatus.Text = "Некорректный email.";
                return;
            }

            if (_password.Length <= 0 || _email.Length <= 0 || _isConnecting)
            {
                return;
            }

            _isConnecting = true;
            LoginStatus.ForeColor = Color.Black;
            LoginStatus.Text = "Загрузка...";
            EmailStatus.Text = "";

            EmailService service = EmailServices.services[_email.Split('@')[1]];

            _mailController = new MailController(
                    _email,
                    _password,
                    service.Domain,
                    service.IMAPport,
                    service.SMTPport
                    );

            _mailController.OnConnectSuccess += OnSuccessAuth;
            _mailController.OnConnectError += OnErrorAuth;

            await _mailController.Connect();
        }

        /// <summary>
        /// Ивент на успешную аутентификацию
        /// </summary>
        private void OnSuccessAuth(object sender, EventArgs e)
        {
            _config.Email = _email;
            _config.Password = _password;
            ApplicationData.Save();

            var mainWindow = new MainWindow(_mailController);
            // Закрывает Login форму полностью при закрытии формы MainForm
            mainWindow.FormClosing += (sender_, e_) => { Close(); };

            Invoke((MethodInvoker)delegate
            {
                OnAuthComplete?.Invoke(_mailController, EventArgs.Empty);
                mainWindow.Show();
                // Прячет форму. На Close() отваливается весь поток
                Hide();
            });
        }

        /// <summary>
        /// Ивент на проваленную аутентификацию
        /// </summary>
        private void OnErrorAuth(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                LoginStatus.Text = "Не удалось подключиться";
                LoginStatus.ForeColor = Color.Red;
                _isConnecting = false;
            });
        }
    }
}
