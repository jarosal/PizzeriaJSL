using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Pizzeria.Core.Enums;
using Pizzeria.Data;
using Pizzeria.Data.Models;

namespace Pizzeria.Core
{
    public static class UserHelper
    {
        private static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public static OperationResult AddUser(
            string login, 
            string password, 
            string firstname, 
            string lastname, 
            string email,
            string address, 
            string phone
            )
        {
            try
            {
                using (var db = new DatabaseContext())
                {
                    User user = new User
                    {
                        Login = login, 
                        PasswordHash = HashPassword(password), 
                        Firstname = firstname,
                        Lastname = lastname, 
                        Email = email, 
                        Address = address,
                        Phone = phone
                    };
                    db.User.Add(user);
                    db.SaveChanges();
                    return OperationResult.Success;
                }

            }
            catch (Exception e)
            {
                return OperationResult.Fail;
                
            }
        }

        public static OperationResult ValidateUser(string login, string password)
        {
            try
            {
                using (var db = new DatabaseContext())
                {
                    var user = db.User.First(u => u.Login == login);

                    return  HashPassword(password).Equals(user.PasswordHash)
                        ? OperationResult.Success
                        : OperationResult.Fail;
                }

            }
            catch (Exception e)
            {
                return OperationResult.Fail;
            }
        }

        public static User LoginUser(string login)
        {
            using (var db = new DatabaseContext())
            {
                var user = db.User.First(u => u.Login == login);

                return user;
            } 
        }
    }
}