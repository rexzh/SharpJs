namespace JavaScript
{
    [RenameClass("Date")]
    public class DateTime : Object
    {
        public DateTime(long misec)
        {
        }

        public DateTime(string str)
        {
        }

        public DateTime(uint year, uint month, uint day, uint hours, uint minutes, uint seconds, uint milliseconds)
        {
        }

        /// <summary>
        /// Day of the month(1-31)
        /// </summary>
        public uint GetDate() { return 0; }
        public void SetDate(uint dayOfMonth) { }

        /// <summary>
        /// Day of week(0-6)
        /// </summary>
        public uint GetDay() { return 0; }
        public void SetDay(uint dayOfWeek) { }

        public uint GetFullYear() { return 0; }
        public void SetFullYear(uint year) { }

        /// <summary>
        /// 0-23
        /// </summary>
        public uint GetHours() { return 0; }
        public void SetHours(uint hours) { }

        /// <summary>
        /// 0-999
        /// </summary>
        public uint GetMilliseconds() { return 0; }
        public void SetMilliseconds(uint millisec) { }

        /// <summary>
        /// 0-59
        /// </summary>
        public uint GetMinutes() { return 0; }
        public void SetMinutes(uint minutes) { }

        /// <summary>
        /// 0-11
        /// </summary>
        public uint GetMonth() { return 0; }
        public void SetMonth(uint month) { }

        public uint GetSeconds() { return 0; }
        public void SetSeconds(uint seconds) { }

        /// <summary>
        /// Returns the number of milliseconds since midnight Jan 1, 1970
        /// </summary>
        public uint GetTime() { return 0; }
        public void SetTime(uint time) { }

        public uint GetUTCFullYear() { return 0; }
        public void SetUTCFullYear(uint year) { }

        public uint GetUTCHours() { return 0; }
        public void SetUTCHours(uint hours) { }

        public uint GetUTCMilliseconds() { return 0; }
        public void SetUTCMilliseconds(uint milliseconds) { }

        public uint GetUTCMinutes() { return 0; }
        public void SetUTCMinutes(uint minutes) { }

        public uint GetUTCMonth() { return 0; }
        public void SetUTCMonth(uint month) { }

        public uint GetUTCSeconds() { return 0; }
        public void SetUTCSeconds(uint seconds) { }

        public uint GetUTCDate() { return 0; }
        public void SetUTCDate(uint date) { }

        /// <summary>
        /// Returns the time difference between GMT and local time, in minutes
        /// </summary>
        public uint TimezoneOffset
        {
            get { return 0; }
        }

        /// <summary>
        /// Returns the day of the week, according to universal time (from 0-6)
        /// </summary>	
        public uint UTCDay
        {
            get { return 0; }
        }

        /// <summary>
        /// Parses a date string and returns the number of milliseconds since midnight of January 1, 1970
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public static long Parse(string date)
        {
            return 0;
        }

        public string ToDateString()
        {
            return null;
        }

        public string ToLocaleDateString()
        {
            return null;
        }

        public string ToLocaleTimeString()
        {
            return null;
        }

        public string ToLocaleString()
        {
            return null;
        }

        public string ToTimeString()
        {
            return null;
        }

        public string ToUTCString()
        {
            return null;
        }

        /// <summary>
        /// Returns the number of milliseconds in a date string since midnight of January 1, 1970, according to universal time
        /// </summary>
        /// <returns></returns>
        [RenameMember("UTC")]
        public long UTC()
        {
            return 0;
        }

        /*
        public DateTime ValueOf()
        {
            return null;
        }
        */
    }
}
