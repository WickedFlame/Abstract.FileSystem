using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Abstract.FileSystem
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [DebuggerDisplay("{" + nameof(_path) + "}")]
    public class SystemPath
    {
        static SystemPath()
        {
            OsType = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? OsType.Windows : OsType.Unix;
        }

        private readonly string _path;

        /// <summary>
        /// Create a new SystemPath from a string path
        /// </summary>
        /// <param name="path"></param>
        public SystemPath(string path)
        {
            _path = FormatPath(path);
        }

        /// <summary>
        /// Cast a string path to a SystemPath
        /// </summary>
        /// <param name="path"></param>
        public static implicit operator SystemPath(string path)
        {
            if (path is null)
            {
                return null;
            }

            return new SystemPath(path);
        }

        /// <summary>
        /// Cast a SystemPath to a string path
        /// </summary>
        /// <param name="path"></param>
        public static implicit operator string(SystemPath path)
        {
            return path?.ToString();
        }

        /// <summary>
        /// Gets the type of OS. Defines the how the PathSeparator is used
        /// </summary>
        public static OsType OsType { get; }

        /// <summary>
        /// Combine a SystemPath and a string with the / separator
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static SystemPath operator /(SystemPath left, string right)
        {
            return new SystemPath(Combine(left, right));
        }

        /// <summary>
        /// Add a segment to the SystemPath without adding a separatro
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        public static SystemPath operator +(SystemPath left, string right)
        {
            return new SystemPath(left.ToString() + right);
        }

        /// <summary>
        /// Equalitycomparer of two SystemPaths
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator ==(SystemPath a, SystemPath b)
        {
            return EqualityComparer<SystemPath>.Default.Equals(a, b);
        }

        /// <summary>
        /// Unequalitycomparer of two SystemPaths
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool operator !=(SystemPath a, SystemPath b)
        {
            return !EqualityComparer<SystemPath>.Default.Equals(a, b);
        }

        /// <summary>
        /// Compare a SystemPath to this SystemPath
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        protected bool Equals(SystemPath other)
        {
            var stringComparison = OsType == OsType.Unix ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;
            return string.Equals(_path, other._path, stringComparison);
        }

        /// <summary>
        /// Compare a object to this SystemPath
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(objA: null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                if(obj is string str)
                {
                    return Equals(this, (SystemPath)str);
                }

                return false;
            }

            return Equals((SystemPath)obj);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return _path?.GetHashCode() ?? 0;
        }

        /// <summary>
        /// Format a path string based on the path settins of the OS
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static string FormatPath(string path)
        {
            if (OsType == OsType.Unix)
            {
                return path.Replace(Separator.WinSeparator, Separator.UnixSeparator);
            }

            return path.Replace(Separator.UnixSeparator, Separator.WinSeparator);
        }

        /// <summary>
        /// Combine a SystemPath and multiple further string segments
        /// </summary>
        /// <param name="path"></param>
        /// <param name="segments"></param>
        /// <returns></returns>
        public static string Combine(SystemPath path, params string[] segments)
        {
            var separator = OsType == OsType.Unix ? Separator.UnixSeparator : Separator.WinSeparator;

            var left = path?._path ?? string.Empty;
            foreach(var right in segments)
            {
                left = $"{left}{separator}{right}";
            }

            return left;
        }

        /// <summary>
        /// Get the string equivalent of this object
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _path;
        }
    }

}
