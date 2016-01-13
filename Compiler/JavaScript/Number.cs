namespace JavaScript
{
    [ScriptDefaultValue(Value = "0")]
    [RenameClass("Number")]
    public class Number : Object
    {
        public static Number operator +(Number l, Number r)
        {
            return 0;
        }

        public static Number operator -(Number l, Number r)
        {
            return 0;
        }

        public static Number operator *(Number l, Number r)
        {
            return 0;
        }

        public static Number operator /(Number l, Number r)
        {
            return 0;
        }

        public static Number operator %(Number l, Number r)
        {
            return 0;
        }

        public static Number operator ++(Number n)
        {
            return 0;
        }

        public static Number operator --(Number n)
        {
            return 0;
        }

        public static implicit operator Number(byte n)
        {
            return null;
        }

        public static explicit operator byte (Number n)
        {
            return 0;
        }

        public static implicit operator Number(sbyte n)
        {
            return null;
        }

        public static explicit operator sbyte (Number n)
        {
            return 0;
        }

        public static implicit operator Number(short n)
        {
            return null;
        }

        public static explicit operator short (Number n)
        {
            return 0;
        }

        public static implicit operator Number(ushort n)
        {
            return null;
        }

        public static explicit operator ushort (Number n)
        {
            return 0;
        }

        public static implicit operator Number(int n)
        {
            return null;
        }

        public static explicit operator int (Number n)
        {
            return 0;
        }

        public static implicit operator Number(uint n)
        {
            return null;
        }

        public static explicit operator uint (Number n)
        {
            return 0;
        }

        public static implicit operator Number(long n)
        {
            return null;
        }

        public static explicit operator long (Number n)
        {
            return 0;
        }

        public static implicit operator Number(ulong n)
        {
            return null;
        }

        public static explicit operator ulong (Number n)
        {
            return 0;
        }

        public static implicit operator Number(float n)
        {
            return null;
        }

        public static explicit operator float (Number n)
        {
            return 0;
        }

        public static implicit operator Number(double n)
        {
            return null;
        }

        public static explicit operator double (Number n)
        {
            return 0;
        }

        public static implicit operator Number(decimal n)
        {
            return null;
        }

        public static explicit operator decimal (Number n)
        {
            return 0;
        }

        public Number(short value)
        {
        }

        public Number(ushort value)
        {
        }

        public Number(uint value)
        {
        }

        public Number(long value)
        {
        }

        public Number(ulong value)
        {
        }

        public Number(float value)
        {
        }

        public Number(double value)
        {
        }

        public string ToExponential(int digitsAfterDecimal)
        {
            return null;
        }

        public string ToExponential()
        {
            return null;
        }

        public string ToFixed(int digitsAfterDecimal)
        {
            return null;
        }

        public string ToFixed()
        {
            return null;
        }

        public string ToPrecision(int digitsAfterDecimal)
        {
            return null;
        }

        public string ToPrecision()
        {
            return null;
        }

        public string ToString(int radix)
        {
            return "[Number]";
        }
        /*
        public Decimal ValueOf()
        {
            return this;
        }
        */
    }
}
