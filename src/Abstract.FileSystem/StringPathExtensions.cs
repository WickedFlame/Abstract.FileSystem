namespace Abstract.FileSystem.Test
{
    /// <summary>
    /// Extensions for paths
    /// </summary>
    public static class StringPathExtensions
    {
        /// <summary>
        /// Format a path string based on the path settins of the OS
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string FormatPath(this string path)
        {
            return SystemPath.FormatPath(path);
        }
    }
}
