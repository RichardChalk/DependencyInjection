using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithDI
{
    public interface IConsoleNotification
    {
        void NotifiyUserNameChanged(User user);
    }
}
