using System.Collections.Generic;
using System.IO;

namespace WcApi.Files
{
    public static class FindFiles
    {
        public static string[] SearchAllFiles(string directory)
        {
            List<string> files = new List<string>();

            try
            {
                foreach (string r in Directory.GetFiles(directory))
                    files.Add(r);

                foreach (string d in Directory.GetDirectories(directory))
                {
                    foreach (string f in Directory.GetFiles(d))
                        files.Add(f);
                }

                return files.ToArray();
            }
            catch
            {
                return files.ToArray();
            }
        }
    }
}
