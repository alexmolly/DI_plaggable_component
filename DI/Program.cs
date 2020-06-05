using Autofac;
using DI.Core;
using DI.Notification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    class Program
    {
        static void Main(string[] args)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.RegisterModule<ProgramModule>();
            containerBuilder.RegisterModule<NotificationModule>();


            var contaniner = containerBuilder.Build();

            var notificationService = contaniner.Resolve<INotificationService>();
            var userService = contaniner.Resolve<UserService>();

            var user1 = new User("Tim");
            userService.ChangeUserService(user1, "Robert");

            Console.ReadKey();
        }
    }
}
