using Microsoft.Extensions.DependencyInjection;
using notificationsApp.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notificationsApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                // 4. Получаем экземпляр главной формы через контейнер 
                var mainForm = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // Логгер — один на всё приложение (Singleton) [cite: 23]
            services.AddSingleton<ILogger, Logger>();

            // Сервисы уведомлений [cite: 14, 21]
            services.AddTransient<INotificationService, EmailService>();
            services.AddTransient<INotificationService, SmsService>();
            services.AddTransient<INotificationService, PushNotificationService>();

            // Регистрация формы 
            services.AddTransient<MainForm>();
        }
    }
}
