using System;
using System.Collections.Generic;

namespace AccountsManagerLib
{
    public class LoginManager
    {
        private readonly Dictionary<string, string> _credentials = new()
        {
            { "user_11", "secret@user11" },
            { "user_22", "secret@user22" }
        };

        public string Login(string userId, string password)
        {
            if (string.IsNullOrWhiteSpace(userId) || string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("User ID and password must be provided.");

            if (_credentials.ContainsKey(userId) && _credentials[userId] == password)
                return $"Welcome {userId}!!!";

            return "Invalid user id/password";
        }
    }
}

