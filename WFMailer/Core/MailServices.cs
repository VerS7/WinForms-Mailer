using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace WFMailer
{
    /// <summary>
    /// Email-сервис по типу gmail и т.п.
    /// </summary>
    public class EmailService
    {
        public string Domain;
        public int SMTPport;
        public int IMAPport;

        public EmailService(string domain, int smtpport, int imapport) 
        {
            Domain = domain;
            SMTPport = smtpport;
            IMAPport = imapport;
        }
    }

    static class EmailServices
    {
        /// <summary>
        /// Словарь email-сервисов
        /// </summary>
        public static readonly Dictionary<string, EmailService> services = new Dictionary<string, EmailService> 
        {
            { "yandex.ru", new EmailService("yandex.ru", 465, 993 ) },
            { "mail.ru", new EmailService("mail.ru", 465, 993) },
            { "gmail.com", new EmailService("gmail.com", 465, 993) }
        };

        /// <summary>
        /// Проверка на правильность Email'а
        /// </summary>
        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9]))\.){3}(?:(2(5[0-5]|[0-4][0-9])|1[0-9][0-9]|[1-9]?[0-9])|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])");
        }

        /// <summary>
        /// Проверка на правильность Email'а и наличие домена в списке доменов
        /// </summary>
        public static bool IsValidAndExistEmail(string email)
        {
            return IsValidEmail(email) && services.ContainsKey(email.Split('@')[1]);
        }
    }
}
