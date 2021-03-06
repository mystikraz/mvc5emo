﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Utils
{
    public class CustomPasswordHasher : IPasswordHasher
    {
        public string HashPassword(string password)
        {
            return Encrypt.GetMd5Hash(password);
        }

        public PasswordVerificationResult VerifyHashedPassword(string hashedPassword, string providedPassword)
        {
            if (hashedPassword == HashPassword(providedPassword))
            {
                return PasswordVerificationResult.Success;
            }
            return PasswordVerificationResult.Failed;
        }
    }
}