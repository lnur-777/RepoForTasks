using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringReverseClient
{
    public static class TextOperation
    {
        public static string[] Read(string path)
        {
            var allText = File.ReadAllLines(path);
            return allText;
        }

        public static void Write(string[] allText, string path)
        {
            File.WriteAllLines(path, allText);
        }
    }
}
