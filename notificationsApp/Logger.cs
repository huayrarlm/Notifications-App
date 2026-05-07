using notificationsApp.Interface;
using System;
using System.IO;

namespace notificationsApp
{
    internal class Logger : ILogger
    {
        private readonly string _filePath = "log.txt";
        public event Action<string> OnLog;

        public void Info(string message)
        {
            Log("INFO", message);
        }

        public void Error(string message)
        {
            Log("ERROR", message);
        }

        private void Log(string level, string message)
        {
            string logEntry = $"{DateTime.Now:G} [{level}]: {message}";

            //[cite_start]// 1. Пишем в файл 
            File.AppendAllText(_filePath, logEntry + Environment.NewLine);

            //[cite_start]// 2. Уведомляем тех, кто подписан (нашу форму) 
            OnLog?.Invoke(logEntry);
        }
    }
}
