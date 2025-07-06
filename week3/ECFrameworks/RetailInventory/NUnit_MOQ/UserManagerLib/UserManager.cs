using System;

namespace UserManagerLib
{
    public class UserManager
    {
        public string CreateUser(string panCardNo)
        {
            if (string.IsNullOrWhiteSpace(panCardNo))
                throw new NullReferenceException("PAN cannot be empty.");

            if (panCardNo.Length != 10)
                throw new FormatException("PAN must be exactly 10 characters.");

            return "User Created Successfully";
        }
    }
}
