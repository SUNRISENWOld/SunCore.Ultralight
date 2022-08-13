using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SunCore_Ultralight.SystemManagement.Native_win32.NT.Media
{
    public class MP3Player
    {
        [DllImport("Winmm.dll", SetLastError = true)]
        static extern int mciSendString(string lpszCommand, [MarshalAs(UnmanagedType.LPStr)] StringBuilder lpszReturnString, int cchReturn, IntPtr hwndCallback);

        public void Play(string FileLocation)
        {
            StringBuilder sb = new StringBuilder();
            string sFileName = FileLocation;
            string sAliasName = "MP3";
            int nRet = mciSendString("open \"" + sFileName + "\" alias " + sAliasName, sb, 0, IntPtr.Zero);
            nRet = mciSendString("play " + sAliasName, sb, 0, IntPtr.Zero);
        }
    }
}
