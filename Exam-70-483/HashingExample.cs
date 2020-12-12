using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Exam_70_483
{
    public class HashingExample
    {
        public string Test()
        {
            HashAlgorithm sha = SHA256.Create();
            var hashBytes = sha.ComputeHash(Encoding.Default.GetBytes("texto a criptografar"));
            var hash = Convert.ToBase64String(hashBytes);
            Console.WriteLine(hash);
            return "";
        }
    }
}
