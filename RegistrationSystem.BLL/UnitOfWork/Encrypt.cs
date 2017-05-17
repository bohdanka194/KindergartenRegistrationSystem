using System.Security.Cryptography;
using System.Text;

namespace RegistrationSystem.Common.UnitOfWork
{
    public static class Encrypt
    {
        public static string GenerateHash(string password, string login)
        {
            //login - admin
            //password - 123456
            //2daceebc4e31654d326ae7889b397ed50ff7e5afff374d1f89525865fd87efe0
            byte[] plainText, salt;

            plainText = Encoding.UTF8.GetBytes(password);
            salt = Encoding.UTF8.GetBytes(login);
            HashAlgorithm algorithm = new SHA256Managed();

            byte[] plainTextWithSaltBytes =
              new byte[plainText.Length + salt.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainText[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[plainText.Length + i] = salt[i];
            }

            plainTextWithSaltBytes = algorithm.ComputeHash(plainTextWithSaltBytes);

            StringBuilder stringHash = new StringBuilder();
            for (int i = 0; i < plainTextWithSaltBytes.Length; i++)
            {
                stringHash.Append(plainTextWithSaltBytes[i].ToString("x2"));
            }

            return stringHash.ToString(); ;
        }
    }
}
