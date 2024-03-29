﻿using Buyer.Entities;
using System.Security.Cryptography;

namespace Buyer.Data
{
    public class UserMockRepository : IUserRepository
    {
        public static List<User> Users { get; set; } = new List<User>();
        private readonly static int iterations = 1000;

        public UserMockRepository()
        {
            FillData();
        }

        /// <summary>
        /// Metoda koja upisuje testne podatke
        /// </summary>
        private static void FillData()
        {
            var user1 = HashPassword("testpassword");

            Users.AddRange(new List<User>
            {
                new User
                {
                    Id = Guid.Parse("CFD7FA84-8A27-4119-B6DB-5CFC1B0C94E1"),
                    FirstName = "Amila",
                    LastName = "Salihbegovic",
                    UserName = "mila",
                    Email = "petar.petrovic@testmail.com",
                    Password = user1.Item1,
                    Salt = user1.Item2
                }
            });
        }

        /// <summary>
        ///Searching for user with same credentials
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool UserWithCredentialsExists(string? username, string password)
        {
            //If its Ok
            User user = Users.FirstOrDefault(u => u.UserName == username);

            if (user == null)
            {
                return false;
            }

            //If there is a user with username, checking password
            if (VerifyPassword(password, user.Password, user.Salt))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Hash password
        /// </summary>
        /// <param name="password">Password</param>
        /// <returns>Generated hash and salt</returns>
        private static Tuple<string, string> HashPassword(string password)
        {
            var sBytes = new byte[password.Length];
            new RNGCryptoServiceProvider().GetNonZeroBytes(sBytes);
            var salt = Convert.ToBase64String(sBytes);

            var derivedBytes = new Rfc2898DeriveBytes(password, sBytes, iterations);

            return new Tuple<string, string>
            (
                Convert.ToBase64String(derivedBytes.GetBytes(256)),
                salt
            );
        }

        /// <summary>
        /// Checking password with hash
        /// </summary>
        /// <param name="password">password</param>
        /// <param name="savedHash">Hash</param>
        /// <param name="savedSalt">Salt</param>
        /// <returns></returns>
        public bool VerifyPassword(string password, string savedHash, string savedSalt)
        {
            var saltBytes = Convert.FromBase64String(savedSalt);
            var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, iterations);
            if (Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256)) == savedHash)
            {
                return true;
            }
            return false;
        }
    }
}

