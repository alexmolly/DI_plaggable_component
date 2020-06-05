using Autofac;
using DI.Notification;

namespace DI
{
    class ProgramModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<ConsoleNotification>().As<INotificationService>();
            builder.RegisterType<UserService>().AsSelf();
        }
    }
}