﻿using System.Security.Cryptography;
using System.Text;

namespace HMS.Utils
{
    public class EncryptDecrypt
    {
        public static string? IV="vigneshkumarkkkk";  // 16 chars = 128 bytes
        public static string? Key= "UHWCeDNzFSzqQxojbIIFThfYiJzLkNlh";   // 32 chars = 256 bytes

        public static string Encrypt(string decrypted)
        {
            try
            {
                byte[] textbytes = ASCIIEncoding.ASCII.GetBytes(decrypted);
                var encdec = Aes.Create();
                encdec.BlockSize = 128;
                encdec.KeySize = 256;
                encdec.Key = ASCIIEncoding.ASCII.GetBytes(Key);
                encdec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
                encdec.Padding = PaddingMode.PKCS7;
                encdec.Mode = CipherMode.CBC;

                ICryptoTransform icrypt = encdec.CreateEncryptor(encdec.Key, encdec.IV);

                byte[] enc = icrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);
                icrypt.Dispose();

                return Convert.ToBase64String(enc);
            }
            catch
            {
                throw;
            }
        }

        public static string Decrypt(string encrypted)
        {
            try
            {
                byte[] encbytes = Convert.FromBase64String(encrypted);
                var encdec = Aes.Create();
                encdec.BlockSize = 128;
                encdec.KeySize = 256;
                encdec.Key = ASCIIEncoding.ASCII.GetBytes(Key);
                encdec.IV = ASCIIEncoding.ASCII.GetBytes(IV);
                encdec.Padding = PaddingMode.PKCS7;
                encdec.Mode = CipherMode.CBC;

                ICryptoTransform icrypt = encdec.CreateDecryptor(encdec.Key, encdec.IV);

                byte[] dec = icrypt.TransformFinalBlock(encbytes, 0, encbytes.Length);
                icrypt.Dispose();

                return ASCIIEncoding.ASCII.GetString(dec);
            }
            catch
            {
                throw;
            }
        }
    }
}
