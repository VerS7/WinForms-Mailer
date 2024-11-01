using Newtonsoft.Json;
using System.IO;


namespace Mailer
{
    /// <summary>
    /// Стандартная конфигурация приложения
    /// </summary>
    public class ApplicationConfig
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int MaxMessages { get; set; }
    }

    /// <summary>
    /// Загрузчик конфигурации приложения
    /// </summary>
    public class ApplicationData
    {
        private static ApplicationData _instance;
        private ApplicationConfig _config;
        public string relFilePath = "config.json";

        private ApplicationData()
        {
            Read();
        }

        /// <summary>
        /// Читает JSON с конфигом. Если его нет, то создаёт его по стандартному шаблону
        /// </summary>
        private void Read()
        {
            if (File.Exists(relFilePath))
            {
                _config = JsonConvert.DeserializeObject<ApplicationConfig>(File.ReadAllText(relFilePath));
            }
            else
            {
                Write();
                Read();
            }
        }

        /// <summary>
        /// Записывает конфиг в JSON. Если конфига нет, то создаётся стандартный и записывается
        /// </summary>
        private void Write()
        {
            if (_config == null) 
            {
                string json = JsonConvert.SerializeObject(new ApplicationConfig { Email = "", Password = "", MaxMessages = 30 });
                File.WriteAllText(relFilePath, json);
            }
            else
            {
                string json = JsonConvert.SerializeObject(_config);
                File.WriteAllText(relFilePath, json);
            }
        }

        /// <summary>
        /// Возвращает instance конфига
        /// </summary>
        public static ApplicationConfig GetConfig()
        {
            if (_instance == null) 
            {
                _instance = new ApplicationData();
            }
            return _instance._config;
        }

        /// <summary>
        /// Сохраняет конфиг
        /// </summary>
        public static void Save()
        {
            if (_instance == null) _instance = new ApplicationData();
            _instance.Write();
        }
    }
}
