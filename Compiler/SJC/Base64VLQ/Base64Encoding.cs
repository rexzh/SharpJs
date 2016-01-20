using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJC.Base64VLQ
{
    public class Base64Encoding
    {
        private static char[] IntToCharMap = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".ToCharArray();
        public static char Encode(int n)
        {
            if (0 <= n || n < IntToCharMap.Length)
                return IntToCharMap[n];
            else
                throw new ArgumentOutOfRangeException(nameof(n));
        }
    }
}
