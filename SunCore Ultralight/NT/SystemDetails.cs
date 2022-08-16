using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace SunCore.Ultralight.NT
{
    public static class SystemDetails
    {
        public static int GetActiveWindowTrackingDelay() { return SystemInformation.ActiveWindowTrackingDelay; }
        public static ArrangeDirection GetArrangeDirection() { return SystemInformation.ArrangeDirection; }
        public static ArrangeStartingPosition GetArrangeStartingPosition() { return SystemInformation.ArrangeStartingPosition; }
        public static BootMode GetBootMode() { return SystemInformation.BootMode; }
        public static bool GetUIEffectsState() { return SystemInformation.UIEffectsEnabled; }
        public static string GetUserDomainName() { return SystemInformation.UserDomainName; }
        public static string GetComputerName() { return SystemInformation.ComputerName; }
        public static string GetUserName() { return SystemInformation.UserName; }
        public static Font GetMenuFont() { return SystemInformation.MenuFont; }
        public static bool GetPenExtensionsInstalled() { return SystemInformation.PenWindows; }
        public static LeftRightAlignment GetPopupMenuAlignment() { return SystemInformation.PopupMenuAlignment; }
        public static PowerLineStatus GetPowerLineStatus() { return SystemInformation.PowerStatus.PowerLineStatus; }
        public static int GetBatteryFullLifeTime() { return SystemInformation.PowerStatus.BatteryFullLifetime; }
        public static int GetBatteryLifeRemaining() { return SystemInformation.PowerStatus.BatteryLifeRemaining; }
        public static float GetBatteryLifePercent() { return SystemInformation.PowerStatus.BatteryLifePercent; }
        public static BatteryChargeStatus GetBatteryChargeStatus() { return SystemInformation.PowerStatus.BatteryChargeStatus; }
        public static Size GetBorder3DSize() { return SystemInformation.Border3DSize; }
        public static int GetBorder3DSizeWidth() { return SystemInformation.Border3DSize.Width; }
        public static int GetBorder3DSizeHeight() { return SystemInformation.Border3DSize.Height; }
        public static bool GetBorder3DSizeIsEmpty() { return SystemInformation.Border3DSize.IsEmpty; }
        public static int GetBorderMultiplierFactor() { return SystemInformation.BorderMultiplierFactor; }
        public static Size GetBorderSize() { return SystemInformation.BorderSize; }
        public static int GetBorderSizeWidth() { return SystemInformation.BorderSize.Width; }
        public static int GetBorderSizeHeight() { return SystemInformation.BorderSize.Height; }
        public static bool GetBorderSizeIsEmpty() { return SystemInformation.BorderSize.IsEmpty; }
        public static Size GetCaptionButtonSize() { return SystemInformation.CaptionButtonSize; }
        public static int GetCaptionButtonSizeWidth() { return SystemInformation.CaptionButtonSize.Width; }
        public static int GetCaptionButtonSizeHeight() { return SystemInformation.CaptionButtonSize.Height; }
        public static bool GetCaptionButtonSizeIsEmpty() { return SystemInformation.CaptionButtonSize.IsEmpty; }
        public static int GetCaptionHeight() { return SystemInformation.CaptionHeight; }
        public static int GetCaretBlinkTime() { return SystemInformation.CaretBlinkTime; }
        public static int GetCaretWidth() { return SystemInformation.CaretWidth; }
        public static Size GetCursorSize() { return SystemInformation.CursorSize; }
        public static int GetCursorSizeWidth() { return SystemInformation.CursorSize.Width; }
        public static int GetCursorSizeHeight() { return SystemInformation.CursorSize.Height; }
        public static bool GetCursorSizeIsEmpty() { return SystemInformation.CursorSize.IsEmpty; }
        public static bool GetDbcsEnabled() { return SystemInformation.DbcsEnabled; }
        public static bool GetDebugOS() { return SystemInformation.DebugOS; }
        public static Size GetDoubleClickSize() { return SystemInformation.DoubleClickSize; }
        public static int GetDoubleClickSizeWidth() { return SystemInformation.DoubleClickSize.Width; }
        public static int GetDoubleClickSizeHeight() { return SystemInformation.DoubleClickSize.Height; }
        public static bool GetDoubleClickSizeIsEmpty() { return SystemInformation.DoubleClickSize.IsEmpty; }
    }
}
