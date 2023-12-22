
namespace Abstract.FileSystem
{
    /// <summary>
    /// 
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// Remove a leading slash
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string RemoveLeadingSlash(this string value)
        {
            if (value.StartsWith(Separator.Slash) || value.StartsWith(Separator.Backslash))
            {
                return value.Substring(1);
            }

            return value;
        }

        /// <summary>
        /// Remove a trailing slash
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string RemoveTrailingSlash(this string value)
        {
            if (value.EndsWith(Separator.Slash) || value.EndsWith(Separator.Backslash))
            {
                return value.Substring(0, value.Length - 1);
            }

            return value;
        }

        /// <summary>
        /// Add a leading slash or backslash based on the occurances in the string. If no slash is contained, the system default is added
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string EnsureLeadingSlash(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }

            var backslash = value.IndexOf(Separator.Backslash, System.StringComparison.Ordinal);
            if (backslash == 0)
            {
                return value;
            }

            var slash = value.IndexOf(Separator.Slash, System.StringComparison.Ordinal);
            if (slash == 0)
            {
                return value;
            }

            if (backslash > 0 && slash > 0)
            {
                if (backslash < slash)
                {
                    return $"{Separator.Backslash}{value}";
                }

                return $"{Separator.Slash}{value}";
            }

            if (backslash > 0)
            {
                return $"{Separator.Backslash}{value}";
            }

            if (slash > 0)
            {
                return $"{Separator.Slash}{value}";
            }

            var separator = SystemPath.OsType == OsType.Unix ? Separator.Slash : Separator.Backslash;
            return $"{separator}{value}";
        }

        /// <summary>
        /// Add a trailing slash or backslash based on the occurances in the string. If no slash is contained, the system default is added
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string EnsureTrailingSlash(this string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return value;
            }

            if (value.EndsWith(Separator.Backslash))
            {
                return value;
            }

            if (value.EndsWith(Separator.Slash))
            {
                return value;
            }

            var backslash = value.LastIndexOf(Separator.Backslash, System.StringComparison.Ordinal);
            var slash = value.LastIndexOf(Separator.Slash, System.StringComparison.Ordinal);
            if (backslash >= 0 && slash >= 0)
            {
                if (backslash > slash)
                {
                    return $"{value}{Separator.Backslash}";
                }

                return $"{value}{Separator.Slash}";
            }

            if (backslash >= 0)
            {
                return $"{value}{Separator.Backslash}";
            }

            if (slash >= 0)
            {
                return $"{value}{Separator.Slash}";
            }

            var separator = SystemPath.OsType == OsType.Unix ? Separator.Slash : Separator.Backslash;
            return $"{value}{separator}";
        }
    }
}
