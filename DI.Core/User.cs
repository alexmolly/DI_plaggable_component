﻿namespace DI.Core
{
    public class User
    {
        public User(string userName)
        {
            UserName = userName;
        }

        public string UserName { get; set; }
    }
}