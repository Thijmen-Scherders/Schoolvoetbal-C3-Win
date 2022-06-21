using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ultimehoofdpijn_2_electric_boogaloo_FEAT_melancholie
{
    public class PasswordHelper
    {
        public static string Salt { get; set; } = "yablablo";

        public static bool CheckHash(string input, string expected, string salt = "")
        {
            var hashedInput = GetSha256Hash(input, salt);

            return hashedInput == expected;
        }

        public static string GetSha256Hash(string input, string salt = "")
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(input + salt));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }

            return hash.ToString();
        }

        public static void Example()
        {
            string password = "een wachtwoord";
            string salt = "yablablo";
            string passwordHashWithoutSalt = GetSha256Hash(password);

            bool passwordCorrect = CheckHash(password, passwordHashWithoutSalt);

            string passwordHashWithSalt = GetSha256Hash(password, salt);

            passwordCorrect = CheckHash(password, passwordHashWithSalt, salt);
        }
    }
}
