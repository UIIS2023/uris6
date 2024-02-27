﻿using complaint.Entities;
using System.Security.Cryptography;

namespace complaint.Data
{
    public class UserMockRepository : IUserRepository
    {
        public static List<User> Users { get; set; } = new List<User>();
        private readonly static int iterations = 1000;

        public UserMockRepository()
        {
            FillData();
        }


        private static void FillData()
        {
            var user1 = HashPassword("testpassword");

            Users.AddRange(new List<User>
            {
                new User
                {
                    userId = Guid.Parse("EF0FD26B-4846-42D6-AE99-EBE813811677"),
                    firstName = "Ivana",
                    lastName = "Gvero",
                    userName = "ivana",
                    email = "ivana.gvero@gmail.com",
                    password = user1.Item1,
                    salt = user1.Item2
                }
            });
        }

        public bool UserWithCredentialsExists(string username, string password)
        {

            User user = Users.FirstOrDefault(u => u.userName == username);

            if (user == null)
            {
                return false;
            }


            if (VerifyPassword(password, user.password, user.salt))
            {
                return true;
            }
            return false;
        }


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
