using DI.Core;

namespace DI.Notification
{
    public interface INotificationService
    {
        void NotifyUsernameChanged(User user);
    }
}