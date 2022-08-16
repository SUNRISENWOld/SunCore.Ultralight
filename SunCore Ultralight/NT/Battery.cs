using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SunCore.Ultralight.NT
{
    public static class Battery
    {
        public static int GetChargePercentage()
        {
            if (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Unknown) throw new BatteryNotFoundException("Battery not found.");
            PowerStatus powerStatus = SystemInformation.PowerStatus;
            int chargePercentage = (int)(powerStatus.BatteryLifePercent * 100);
            return chargePercentage;
        }

        public static bool IsCharging()
        {
            if (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Online) return true;
            else if (SystemInformation.PowerStatus.PowerLineStatus == PowerLineStatus.Offline) return false;
            else throw new BatteryNotFoundException("Battery not found.");
        }

        public class BatteryNotFoundException : Exception
        {
            public BatteryNotFoundException()
            {

            }

            public BatteryNotFoundException(string message) : base(message)
            {

            }
        }
    }
}
