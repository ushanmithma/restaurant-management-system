using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace rms
{
    class Common : Connection
    {
        // Common methods

        public bool isNotDigitOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return true;
            }

            return false;
        }

        public bool isNotValidEmail(string email)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (!rEmail.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool checkAlreadyExists(string column, string table, string value)
        {
            bool exists = ifRecordExists(column, table, value);
            return exists;
        }

        public bool checkAlreadyExistsOthers(int id, string column, string table, string value, string unique)
        {
            bool exists = ifRecordExistsOthers(id, column, table, value, unique);
            return exists;
        }

        public bool checkIfNotExists(string column, string table, string value)
        {
            bool notExists = ifRecordIsNotExists(column, table, value);
            return notExists;
        }

        private string hash = "f0xle@rn";

        public string encryptPassword(string val)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(val);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }

        public string decryptPassword(string val)
        {
            byte[] data = Convert.FromBase64String(val);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    return UTF8Encoding.UTF8.GetString(results);
                }
            }
        }
    }
}
