using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace CSharpExperiments
{
    public enum HashAlgorithms
    {
        SHA1,
        SHA256,
        SHA384,
        SHA512,
        MD5
    }
    public static class ReturnHash
    {
        public static string ComputeHash(string plainText, HashAlgorithms hashAlgorithm, byte[] saltBytes)
        {
            // Salt size
            saltBytes = new byte[8];

            // Convert Text to Array
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);

            // Create Array
            byte[] plainTextSaltBytes = new byte[plainTextBytes.Length + saltBytes.Length];

            // Copy Text into Array
            for (int i = 0; i < plainTextBytes.Length; i++)
            {
                plainTextSaltBytes[i] = plainTextBytes[i];
            }                

            // Append Salt
            for (int i = 0; i < saltBytes.Length; i++)
            {
                plainTextSaltBytes[plainTextBytes.Length + i] = saltBytes[i];
            }               

            // Algorithm
            HashAlgorithm hash;

            // Initialize Class
            switch (hashAlgorithm)
            {
                case HashAlgorithms.SHA1:
                    hash = new SHA1Managed();
                    break;

                case HashAlgorithms.SHA256:
                    hash = new SHA256Managed();
                    break;

                case HashAlgorithms.SHA384:
                    hash = new SHA384Managed();
                    break;

                case HashAlgorithms.SHA512:
                    hash = new SHA512Managed();
                    break;

                default:
                    hash = new MD5CryptoServiceProvider();
                    break;
            }

            byte[] hashBytes = hash.ComputeHash(plainTextSaltBytes);

            byte[] hashSaltBytes = new byte[hashBytes.Length + saltBytes.Length];

            // Hash to Array
            for (int i = 0; i < hashBytes.Length; i++)
            {
                hashSaltBytes[i] = hashBytes[i];
            }                

            // Append Salt
            for (int i = 0; i < saltBytes.Length; i++)
            {
                hashSaltBytes[hashBytes.Length + i] = saltBytes[i];
            }                

            // Convert result into a base64-encoded string.
            string hashValue = Convert.ToBase64String(hashSaltBytes);

            // Return Result
            return hashValue;
        }

        public static bool VerifyHash(string plainText, HashAlgorithms hashAlgorithm, string hashValue)
        {
            // Base64-encoded hash
            byte[] hashWithSaltBytes = Convert.FromBase64String(hashValue);

            // Hash without Salt
            int hashSizeInBits, hashSizeInBytes;

            // Size of hash is based on the specified algorithm.
            switch (hashAlgorithm)
            {
                case HashAlgorithms.SHA1:
                    hashSizeInBits = 160;
                    break;

                case HashAlgorithms.SHA256:
                    hashSizeInBits = 256;
                    break;

                case HashAlgorithms.SHA384:
                    hashSizeInBits = 384;
                    break;

                case HashAlgorithms.SHA512:
                    hashSizeInBits = 512;
                    break;

                default: // MD5
                    hashSizeInBits = 128;
                    break;
            }

            // Convert to bytes.
            hashSizeInBytes = hashSizeInBits / 8;

            // Verify Hash Length
            if (hashWithSaltBytes.Length < hashSizeInBytes)
            {
                return false;
            }               

            // Array to hold Salt
            byte[] saltBytes = new byte[hashWithSaltBytes.Length - hashSizeInBytes];

            // Salt to New Array
            for (int i = 0; i < saltBytes.Length; i++)
            {
                saltBytes[i] = hashWithSaltBytes[hashSizeInBytes + i];
            }                

            string expectedHashString = ComputeHash(plainText, hashAlgorithm, saltBytes);

            return hashValue == expectedHashString;
        }
    }

    public static class PasswordEncodingTest
    {
        
        public static void CommenceTest()
        {
            // Test Passwords
            string rightPassword = "TRUEPassword$";
            string wrongPassword = "FALSEPassword$";

            string passwordHashMD5 = ReturnHash.ComputeHash(rightPassword, HashAlgorithms.MD5, null);
            string passwordHashSha1 = ReturnHash.ComputeHash(rightPassword, HashAlgorithms.SHA1, null);
            string passwordHashSha256 = ReturnHash.ComputeHash(rightPassword, HashAlgorithms.SHA256, null);
            string passwordHashSha384 = ReturnHash.ComputeHash(rightPassword, HashAlgorithms.SHA384, null);
            string passwordHashSha512 = ReturnHash.ComputeHash(rightPassword, HashAlgorithms.SHA512, null);


            Console.WriteLine("Hash and Comparison--- \r\n");

            // md5
            Console.WriteLine($"MD5: {passwordHashMD5}");
            Console.WriteLine($"Right PW MD5: { ReturnHash.VerifyHash(rightPassword, HashAlgorithms.MD5, passwordHashMD5)}");
            Console.WriteLine($"Wrong PW MD5: { ReturnHash.VerifyHash(wrongPassword, HashAlgorithms.MD5, passwordHashMD5)}");
            Console.WriteLine("");
            // reference https://en.wikipedia.org/wiki/MD5
            // https://msdn.microsoft.com/en-us/library/system.security.cryptography.md5(v=vs.110).aspx

            // sha1
            Console.WriteLine($"SHA1: {passwordHashSha1}");
            Console.WriteLine($"Right PW SHA1: { ReturnHash.VerifyHash(rightPassword, HashAlgorithms.SHA1, passwordHashSha1)}");
            Console.WriteLine($"Wrong PW SHA1: { ReturnHash.VerifyHash(wrongPassword, HashAlgorithms.SHA1, passwordHashSha1)}");
            Console.WriteLine("");
            // reference https://en.wikipedia.org/wiki/SHA-1
            // https://msdn.microsoft.com/en-us/library/system.security.cryptography.sha1(v=vs.110).aspx

            // sha256
            Console.WriteLine($"SHA256: {passwordHashSha256}");
            Console.WriteLine($"Right PW SHA256: { ReturnHash.VerifyHash(rightPassword, HashAlgorithms.SHA256, passwordHashSha256)}");
            Console.WriteLine($"Wrong PW SHA256: { ReturnHash.VerifyHash(wrongPassword, HashAlgorithms.SHA256, passwordHashSha256)}");
            Console.WriteLine("");
            // reference https://en.wikipedia.org/wiki/SHA-2
            // https://msdn.microsoft.com/en-us/library/system.security.cryptography.sha256(v=vs.110).aspx

            // sha384
            Console.WriteLine($"SHA384: {passwordHashSha384}");
            Console.WriteLine($"Right PW SHA384: { ReturnHash.VerifyHash(rightPassword, HashAlgorithms.SHA384, passwordHashSha384)}");
            Console.WriteLine($"Wrong PW SHA384: { ReturnHash.VerifyHash(wrongPassword, HashAlgorithms.SHA384, passwordHashSha384)}");
            Console.WriteLine("");
            // reference https://msdn.microsoft.com/en-us/library/system.security.cryptography.sha384(v=vs.110).aspx

            // sha512
            Console.WriteLine($"SHA512: {passwordHashSha512}");
            Console.WriteLine($"Right PW SHA512: { ReturnHash.VerifyHash(rightPassword, HashAlgorithms.SHA512, passwordHashSha512)}");
            Console.WriteLine($"Wrong PW SHA512: { ReturnHash.VerifyHash(wrongPassword, HashAlgorithms.SHA512, passwordHashSha512)}");
            // reference https://msdn.microsoft.com/en-us/library/system.security.cryptography.sha512(v=vs.110).aspx

            Console.WriteLine("");
            Console.WriteLine("");


            Console.ReadKey();
        }
    }
}
