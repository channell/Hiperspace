using Social.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    public static class Functions
    {
        
        public static double? Distance(Person? from, Person? to)
        {
            if (from?.Location?.Latitude == null || to?.Location?.Latitude == null) return null;
            if (from?.Location?.Longitude == null || to?.Location?.Longitude == null) return null;

            var latitudeDiff = from.Location.Longitude.Value - to.Location.Longitude.Value;
            var longitudeDiff = from.Location.Latitude.Value - to.Location.Latitude.Value;

            return Math.Sqrt(Math.Pow(latitudeDiff, 2.0) + Math.Pow(longitudeDiff, 2.0));
        }
       
    }
}
