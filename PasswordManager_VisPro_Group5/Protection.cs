using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager_VisPro_Group5
{
    internal class Protection
    {
        public static byte[] ProtectData(string data)
        {
            // Convert the string data to bytes
            byte[] rawData = Encoding.UTF8.GetBytes(data);

            // Use DPAPI to encrypt the data
            byte[] encryptedData = ProtectedData.Protect(rawData, null, DataProtectionScope.CurrentUser);

            return encryptedData;
        }

        public static string UnprotectData(byte[] encryptedData)
        {
            // Use DPAPI to decrypt the data
            byte[] rawData = ProtectedData.Unprotect(encryptedData, null, DataProtectionScope.CurrentUser);

            // Convert the decrypted bytes back to string
            string data = Encoding.UTF8.GetString(rawData);

            return data;
        }

        ////Example usage
        //string originalData = "SensitiveUserData";

        ////Protect the data
        //byte[] encryptedData = ProtectData(originalData);
        //MessageBox.Show($"Encrypted Data: {Convert.ToBase64String(encryptedData)}");

        ////Unprotect the data
        //string decryptedData = UnprotectData(encryptedData);
        //MessageBox.Show($"Decrypted Data: {decryptedData}");
    }
}
