using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithDI
{
    public class User
    {
        private IConsoleNotification _notificationService;
        public string UserName { get; set; }

        public User(string userName, IConsoleNotification notificationService)
        {
            UserName = userName;
            _notificationService = notificationService;
        }

        public void ChangeUserName(string newUserName)
        {
            UserName = newUserName;
            _notificationService.NotifiyUserNameChanged(this);
        }
    }

}
