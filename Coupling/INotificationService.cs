using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling
{
    public interface INotificationService
    {
        void SendNotification(string msg);
    }
}
