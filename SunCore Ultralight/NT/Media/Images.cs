using System;
using System.Net;
using System.Drawing;

namespace SunCore.Ultralight.NT.Media
{
    public class Images
    {
        public Image GetFromStream(string url)
        {
            var request = WebRequest.Create(url);
            
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                return Image.FromStream(stream);
            }
        }

        public Image GetFromFile(string Location)
        {
            return Image.FromFile(Location);
        }
    }
}
