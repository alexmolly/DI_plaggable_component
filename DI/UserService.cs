using DI.Core;
using DI.Notification;
using System;

namespace DI
{
    class UserService
    {
        private INotificationService _notificationService;

        public UserService(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public void ChangeUserService(User user, string newUserName)
        {
            user.UserName = newUserName;
            _notificationService.NotifyUsernameChanged(user);
        }
    }
}