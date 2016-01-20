using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SJC.Base64VLQ
{
    public class Base64VLQEncoding
    {
        private static int VLQ_BASE_SHIFT = 5;

        // binary: 100000
        private static int VLQ_BASE = 1 << VLQ_BASE_SHIFT;

        // binary: 011111
        private static int VLQ_BASE_MASK = VLQ_BASE - 1;

        // binary: 100000
        private static int VLQ_CONTINUATION_BIT = VLQ_BASE;

        /// <summary>
        /// Converts from a two-complement value to a value where the sign bit is
        /// placed in the least significant bit.For example, as decimals:
        /// 1 becomes 2 (10 binary), -1 becomes 3 (11 binary)
        /// 2 becomes 4 (100 binary), -2 becomes 5 (101 binary)
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        private static int ToVLQSigned(int val)
        {
            return val < 0 ? ((-val) << 1) + 1 : (val << 1) + 0;
        }

        public static string Encode(int val)
        {
            string encoded = string.Empty;

            int digit;

            var vlq = ToVLQSigned(val);

            do
            {
                digit = vlq & VLQ_BASE_MASK;
                //vlq >>>= VLQ_BASE_SHIFT;
                vlq = (int)((uint)vlq >> VLQ_BASE_SHIFT);
                if (vlq > 0)
                {
                    //Note: There are still more digits in this value, so we must make sure the continuation bit is marked.
                    digit |= VLQ_CONTINUATION_BIT;
                }
                encoded += Base64Encoding.Encode(digit);
            } while (vlq > 0);

            return encoded;
        }
    }
}
