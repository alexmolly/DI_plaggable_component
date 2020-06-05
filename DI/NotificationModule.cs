using Autofac;
using DI.Notification;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DI
{
    internal class NotificationModule :Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var notificationServiceTypes = Directory.EnumerateFiles(Environment.CurrentDirectory)
                .Where(fileName => fileName.Contains("DI") && fileName.EndsWith("Notification.dll"))
                .Select(filePath => Assembly.LoadFrom(filePath))
                .SelectMany(assembly => assembly.GetTypes()
                .Where(type => typeof(INotificationService).IsAssignableFrom(type) && type.IsClass));

            foreach (var notificationServiceType in notificationServiceTypes)
            {
                builder.RegisterType(notificationServiceType).As<INotificationService>();

            }

        }
    }
}
