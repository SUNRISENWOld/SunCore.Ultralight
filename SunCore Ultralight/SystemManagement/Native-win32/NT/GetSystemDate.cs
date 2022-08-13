using System;

namespace SunCore_Ultralight.SystemManagement.Native_win32.NT
{
    public static class GetSystemDate
    {
        public static string GetDateAsString(string Type)
        {
            return DateTime.Now.ToString(Type);
        }

        public static DateTime GetDateAsDateTime(string Type)
        {
            return Convert.ToDateTime(GetDateAsString(Type));
        }
    }
}
