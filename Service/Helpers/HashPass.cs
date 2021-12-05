using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Service.Helpers
{
    public class HashPass
    {
        public static void CreateHash(string password, out byte[] hash)
        {
            using (var md5Hash = MD5.Create())
            {
                var sourceBytes = Encoding.UTF8.GetBytes(password);

                hash = md5Hash.ComputeHash(sourceBytes);
            }
        }
    }
}
