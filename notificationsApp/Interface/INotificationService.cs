using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace notificationsApp.Interface
{
    public interface INotificationService
    {
        string ServiceName { get; }
        void Send(string message);
    }
}
