namespace Abstract.FileSystem
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

        /// <summary>
        /// Remove the leading slash from the SystemPath
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string RemoveLeadingSlash(this SystemPath path)
        {
            return path.ToString().RemoveLeadingSlash();
        }

        /// <summary>
        /// Remove the trailing slash from the SystemPath
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string RemoveTrailingSlash(this SystemPath path)
        {
            return path.ToString().RemoveTrailingSlash();
        }
    }
}
