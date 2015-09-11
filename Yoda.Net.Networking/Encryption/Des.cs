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
        public static void Encrypt(ref PiggStream data, byte[] encryptionKey)
        {

            data = new PiggStream(Des.encrypt(data.toArray(), encryptionKey));
        }
        public static void Decrypt(ref PiggStream data, byte[] encryptionKey)
        {
            data = new PiggStream(Des.decrypt(data.toArray(), encryptionKey));
        }

        private static byte[] decrypt(byte[] plainText, byte[] key)
        {
            var provider = createProvider(key);

            return provider.CreateDecryptor().TransformFinalBlock(plainText, 0, plainText.Length);
        }

        private static byte[] encrypt(byte[] plainText, byte[] key)
        {
            var provider = createProvider(key);

            return provider.CreateEncryptor().TransformFinalBlock(plainText, 0, plainText.Length);
        }
        private static DESCryptoServiceProvider createProvider(byte[] key)
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
