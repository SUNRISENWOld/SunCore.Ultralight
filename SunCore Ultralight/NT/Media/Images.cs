using System;
using System.Net;
using System.Drawing;

namespace SunCore.Ultralight.NT.Media
{
    // Update 1.1.1 (not published)
    public static class Images
    {
        public static Image GetFromStream(string url)
        {
            var request = WebRequest.Create(url);
            
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                return Image.FromStream(stream);
            }
        }

        public static Image GetFromFile(string Location)
        {
            return Image.FromFile(Location);
        }
    }
}
