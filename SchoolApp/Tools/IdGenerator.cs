﻿namespace SchoolApp.Tools
{
    internal static class IdGenerator
    {
        public static string Create(object obj)
        {
            long unixTimestamp = GetElapsedFromEpoch();
            string id = LongToString(unixTimestamp) + LongToString(obj.GetHashCode());
            //string guid = Guid.NewGuid() + "-" + id;
            return id;
        }

        private static long GetElapsedFromEpoch(Elapsed elapsed = Elapsed.micro)
        {
            TimeSpan epochTicks = new TimeSpan(new DateTime(1970, 1, 1).Ticks);
            TimeSpan unixTicks = new TimeSpan(DateTime.Now.Ticks) - epochTicks;
            switch (elapsed)
            {
                case Elapsed.sec: return (long)unixTicks.TotalSeconds;
                case Elapsed.milli: return (long)unixTicks.TotalMilliseconds;
                default: return (long)unixTicks.TotalMicroseconds;
            }
        }

        private static string LongToString(long value, string symbols = "0123456789abcdefghijklmnopqrstuvwxyz")
        {
            char[] baseChars = symbols.ToCharArray();
            string result = string.Empty;
            int targetBase = baseChars.Length;
            do
            {
                result = baseChars[value % targetBase] + result;
                value = value / targetBase;
            }
            while (value > 0);
            return result;
        }
    }

    public enum Elapsed
    {
        sec, milli, micro
    }
}
