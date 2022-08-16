using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SunCore.Ultralight.NT
{
    public static class ScreenInformation
    {
        public static int GetPrimaryWidth() { return Screen.PrimaryScreen.Bounds.Width; }
        public static int GetPrimaryHeight() { return Screen.PrimaryScreen.Bounds.Height; }
        public static Screen[] GetScreens() { return Screen.AllScreens; }
        public static string GetPrimaryDeviceName() { return Screen.PrimaryScreen.DeviceName; }
        public static Type GetPrimaryType() { return Screen.PrimaryScreen.GetType(); }
        public static Rectangle GetPrimaryBounds() { return Screen.PrimaryScreen.Bounds; }
        public static int GetPrimaryBitsPerPixel() { return Screen.PrimaryScreen.BitsPerPixel; }
        public static int GetPrimaryWorkingAreaBottom() { return Screen.PrimaryScreen.WorkingArea.Bottom; }
        public static int GetPrimaryWorkingAreaHeight() { return Screen.PrimaryScreen.WorkingArea.Height; }
        public static bool GetPrimaryWorkingAreaIsEmpty() { return Screen.PrimaryScreen.WorkingArea.IsEmpty; }
        public static int GetPrimaryWorkingAreaLeft() { return Screen.PrimaryScreen.WorkingArea.Left; }
        public static int GetPrimaryWorkingAreaWidth() { return Screen.PrimaryScreen.WorkingArea.Width; }
        public static int GetPrimaryWorkingAreaTop() { return Screen.PrimaryScreen.WorkingArea.Top; }
        public static Point GetPrimaryWorkingAreaLocation() { return Screen.PrimaryScreen.WorkingArea.Location; }
        public static int GetPrimaryWorkingAreaRight() { return Screen.PrimaryScreen.WorkingArea.Right; }
        public static Size GetPrimaryWorkingAreaSize() { return Screen.PrimaryScreen.WorkingArea.Size; }
        public static int GetPrimaryWorkingAreaX() { return Screen.PrimaryScreen.WorkingArea.X; }
        public static int GetPrimaryWorkingAreaY() { return Screen.PrimaryScreen.WorkingArea.Y; }
    }
}
