using System;
using System.Security.Cryptography;
using System.Text;

namespace OgrenmeProje
{
    public static class Auth
    {

        public static string Hash(string plainTextPassword)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(plainTextPassword));

                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2")); 
                }

                return builder.ToString();
            }
        }
    }
}
