using MetadataExtractor;
using MetadataExtractor.Formats.Exif;

namespace ImageInfo
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("==>Main");
            var curDir = System.IO.Directory.GetCurrentDirectory();
            DirectoryInfo? di = System.IO.Directory.GetParent(curDir);  // -1
            if (di != null && di.Parent != null)
            {
                curDir = di.Parent.ToString();  // -2
            }

            di = System.IO.Directory.GetParent(curDir); // -3
            if (di != null)
                curDir = di.FullName;
            Console.WriteLine($"{curDir}");
            var fn = curDir + "\\Data\\" + "2024 05 24 001.dng";
            Console.WriteLine($"fn={fn}");

            var gps = ImageMetadataReader.ReadMetadata(fn)
                             .OfType<GpsDirectory>()
                             .FirstOrDefault();

            var location = gps.GetGeoLocation();

            Console.WriteLine("Image at {0},{1}", location.Latitude, location.Longitude);
            var url = $"https://www.google.com/maps/search/?api=1&query={location.Latitude.ToString()},{location.Longitude.ToString()}";
            Console.WriteLine(url);
        }
    }
}