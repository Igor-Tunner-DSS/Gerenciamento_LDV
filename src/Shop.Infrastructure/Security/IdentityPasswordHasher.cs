using System;
using System.Collections.Generic;
using System.Text;
using LDV.Shop.Core.Abstractions;
using LDV.Shop.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace LDV.Shop.Infrastructure.Security
{
    public class IdentityPasswordHasher : IPasswordHasher
    {
        private readonly PasswordHasher<Customer> _hasher = new();
        public string Hash(string password)
        {
            return _hasher.HashPassword(null!, password);
        }
        public bool Verify(string hash, string password)
        {
            return _hasher.VerifyHashedPassword(null!, hash, password) != PasswordVerificationResult.Failed;
        }
    }
}
