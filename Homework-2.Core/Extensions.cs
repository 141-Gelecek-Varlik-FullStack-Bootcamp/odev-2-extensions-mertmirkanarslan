using System;

namespace Homework_2.Core
{
    public static class Extensions
    {
        //Turkey is in the UTC+3 timezone. Let's make it UTC+2 (Central European Time) as it used to be.
        public static string ToOldDateTime(this DateTime oldTimezone)
        {
            return oldTimezone.AddHours(-1).ToLongTimeString();
        }
    }
}
