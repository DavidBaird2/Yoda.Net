using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yoda.Net.Networking.Encryption
{
    public class Des
    {
        public static void encrypt(ref PiggStream data, byte[] encryptionKey)
        {

            data = new PiggStream(Des.Encrypt(data.toArray(), encryptionKey));
        }
        public static void decrypt(ref PiggStream data, byte[] encryptionKey)
        {
            data = new PiggStream(Des.Decrypt(data.toArray(), encryptionKey));
        }

        public static byte[] Decrypt(byte[] plainText, byte[] key)
        {
            var provider = CreateProvider(key);

            return provider.CreateDecryptor().TransformFinalBlock(plainText, 0, plainText.Length);
        }

        public static byte[] Encrypt(byte[] plainText, byte[] key)
        {
            var provider = CreateProvider(key);

            return provider.CreateEncryptor().TransformFinalBlock(plainText, 0, plainText.Length);
        }
        public static DESCryptoServiceProvider CreateProvider(byte[] key)
        {
            var provider = new DESCryptoServiceProvider();
            provider.Mode = CipherMode.ECB;
            provider.Padding = PaddingMode.PKCS7;
            provider.KeySize = 0x40;
            provider.Key = key;
            return provider;
        }
    }
}
