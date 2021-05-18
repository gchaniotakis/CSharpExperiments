using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CSharpExperiments
{
    public class User
    {
        public string UserName { get; set; }
        public string PassWord { get; set; }

        public User(string username, string password)
        {
            UserName = username;
            PassWord = UserManagement.ComputeSha256Hash(password);
        }

        public bool Authenticate(string password)
        {
            return UserManagement.ComputeSha256Hash(password) == PassWord;
        }
    }
    
    
    
    public static class UserManagement
    {
        public static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

        public static string TypePassword()
        {
            var pass = string.Empty;
            ConsoleKey key;
            do
            {
                var keyInfo = Console.ReadKey(intercept: true);
                key = keyInfo.Key;

                if (key == ConsoleKey.Backspace && pass.Length > 0)
                {
                    Console.Write("\b \b");
                    pass = pass[0..^1];
                }
                else if (!char.IsControl(keyInfo.KeyChar))
                {
                    Console.Write("*");
                    pass += keyInfo.KeyChar;
                }
            } while (key != ConsoleKey.Enter);

            return pass;
        }
    }
}
