using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coupling
{
    internal class Order
    {
        private readonly INotificationService notificationService;

        public Order(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }
        public void PlaceOrder()
        {
            // To place the order;
            // This is tightly coupled 
            // here we cant decide from which mode the notification will send to the user.
            //EmailSender sender = new EmailSender();
            //sender.SendNotification("Order placed successfully");
            notificationService.SendNotification("Order placed successfully");
        }
    }
}
