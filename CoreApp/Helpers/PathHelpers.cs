using System.IO;

namespace CoreApp.Helpers
{
    public static class PathHelpers
    {
        public static string GetOutPath(string pathIn, string part = "-out")
        {
            return Path.Combine(Path.GetDirectoryName(pathIn), Path.GetFileNameWithoutExtension(pathIn) + part + Path.GetExtension(pathIn));
        }
    }
}
