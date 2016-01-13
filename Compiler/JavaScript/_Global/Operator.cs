using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavaScript
{
    [NonScript]
    public static class Operator
    {
        [RenameMember("===")]
        public static bool ExactEqual(object l, object r)
        {
            return false;
        }

        [RenameMember("!==")]
        public static bool NotExactEqual(object l, object r)
        {
            return false;
        }

        [RenameMember(">>>")]
        public static Number UnsignedRightShift(Number l, Number r)
        {
            return 0;
        }
    }
}
