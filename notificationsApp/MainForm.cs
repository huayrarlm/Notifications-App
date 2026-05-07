using notificationsApp.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace notificationsApp
{
    public partial class MainForm : Form
    {
        private readonly ILogger _logger;
        private readonly List<INotificationService> _services;
        public MainForm(ILogger logger, IEnumerable<INotificationService> services)
        {
            InitializeComponent();
            _logger = logger;
            _services = services.ToList();

            if (_logger is Logger concreteLogger)
            {
                concreteLogger.OnLog += msg =>
                    richTextBoxLogs.Invoke((MethodInvoker)(() => richTextBoxLogs.AppendText(msg + Environment.NewLine)));
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Заполняем ComboBox названиями сервисов [cite: 9]
            comboBoxServices.DataSource = _services;
            comboBoxServices.DisplayMember = "ServiceName";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text;

            // Валидация: пустое сообщение нельзя отправить [cite: 18]
            if (string.IsNullOrWhiteSpace(message))
            {
                string error = "Ошибка: Сообщение не может быть пустым!";
                _logger.Error(error);
                MessageBox.Show(error);
                return;
            }

            var selectedService = (INotificationService)comboBoxServices.SelectedItem;

            try
            {
                // Используем NotificationSender для вызова Send [cite: 16]
                var senderService = new NotificationSender(selectedService);
                senderService.SendNotification(message);
            }
            catch (Exception ex)
            {
                // Перехват исключений (например, из SmsService) [cite: 19]
                _logger.Error($"Сбой сервиса {selectedService.ServiceName}: {ex.Message}");
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }

            if (message.ToLower().Contains("deadline"))
            {
                _logger.Error("!!! КРИТИЧЕСКАЯ ПАНИКА: ДЕДЛАЙН БЛИЗКО !!!");
                richTextBoxLogs.SelectionColor = Color.Red; // Если хочешь немного магии в UI
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _logger.Info("Приложение завершает работу по запросу пользователя.");
            this.Close();
        }
    }
}
