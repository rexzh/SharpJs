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
        [Operator("delete ", 1, true)]
        public static bool Delete(System.Object property)
        {
            return false;
        }

        [Operator(" === ")]
        public static bool ExactEqual(object l, object r)
        {
            return false;
        }

        [Operator(" !== ")]
        public static bool NotExactEqual(object l, object r)
        {
            return false;
        }

        [Operator(" >>> ")]
        public static Number UnsignedRightShift(Number l, Number r)
        {
            return 0;
        }

        [Operator("", 1, true)]
        public static T CastTo<T>(object o)
        {
            return (T)o;
        }
    }
}
