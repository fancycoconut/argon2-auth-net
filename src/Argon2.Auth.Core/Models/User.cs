using System;
using System.Collections.Generic;

namespace Argon2.Auth.Core.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string PasswordHash { get; set; }
        public string Salt { get; set; }
        public int LoginAttempts { get; set; }
        public DateTime LastFailedLoginAttempt { get; set; }

        public string PasswordResetToken { get; set; }
        public DateTime PasswordResetTokenExpiryTime { get; set; }

        public bool AccountValidated { get; set; }
        public string AccountValidationToken { get; set; }
        public DateTime AccountValidationTokenExpiryTime { get; set; }

        public DateTime LastSignIn { get; set; }
        public bool Deleted { get; set; }

        public Dictionary<string, object> Metadata { get; set; }
    }
}
