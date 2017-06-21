using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Listing3_20_UsingAKeyContainerForStoringAnAsymmetricKey
{
    class Program
    {
        static void Main(string[] args)
        {
            string containerName = "SecretContainer";
            CspParameters csp = new CspParameters(){ KeyContainerName = containerName };
            byte[] encryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider(csp))
            {
                encryptedData = RSA.Encrypt(dataToEncrypt, false);      // I think we're supposed to use the object from the previous listing.
            }
        }
    }
}
