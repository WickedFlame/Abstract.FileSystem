using System;
using System.Collections.Generic;
using System.Text;

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
    }
}
