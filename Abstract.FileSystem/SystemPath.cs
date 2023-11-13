using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Abstract.FileSystem
{
    public class SystemPath
    {
        internal const char WinSeparator = '\\';
        internal const char UncSeparator = '\\';
        internal const char UnixSeparator = '/';

        public static SystemPath Create(string path)
        {
            return new SystemPath(path);
        }

        static SystemPath()
        {
            OsType = RuntimeInformation.IsOSPlatform(OSPlatform.Windows) ? OsType.Windows : OsType.Unix;
        }

        private readonly string _path;

        private SystemPath(string path)
        {
            _path = NormalizePath(path);
        }

        public static implicit operator SystemPath(string path)
        {
            if (path is null)
            {
                return null;
            }

            return new SystemPath(path);
        }

        public static implicit operator string(SystemPath path)
        {
            return path?.ToString();
        }

        public static OsType OsType { get; }

        public static SystemPath operator /(SystemPath left, string right)
        {
            return new SystemPath(Combine(left, right));
        }

        public static SystemPath operator +(SystemPath left, string right)
        {
            return new SystemPath(left.ToString() + right);
        }

        public static bool operator ==(SystemPath a, SystemPath b)
        {
            return EqualityComparer<SystemPath>.Default.Equals(a, b);
        }

        public static bool operator !=(SystemPath a, SystemPath b)
        {
            return !EqualityComparer<SystemPath>.Default.Equals(a, b);
        }

        protected bool Equals(SystemPath other)
        {
            var stringComparison = OsType == OsType.Unix ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal;
            return string.Equals(_path, other._path, stringComparison);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(objA: null, obj))
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != GetType())
                return false;
            return Equals((SystemPath)obj);
        }

        public override int GetHashCode()
        {
            return _path?.GetHashCode() ?? 0;
        }

        public override string ToString()
        {
            return ((IFormattable)this).ToString(format: null, formatProvider: null);
        }

        public static string NormalizePath(string path)
        {
            if (OsType == OsType.Unix)
            {
                return path.Replace(WinSeparator, UnixSeparator);
            }

            return path.Replace(UnixSeparator, WinSeparator);
        }

        public static string Combine(SystemPath path, params string[] elements)
        {
            throw new NotImplementedException();
        }

        internal static bool IsWinRoot(string root)
        => root?.Length == 2 &&
           char.IsLetter(root[index: 0]) &&
           root[index: 1] == ':';

        internal static bool IsUnixRoot(string root)
            => root?.Length == 1 &&
               root[index: 0] == UnixSeparator;

        internal static bool IsUncRoot(string root)
            => root?.Length >= 3 &&
               root[index: 0] == UncSeparator &&
               root[index: 1] == UncSeparator &&
               root.Skip(count: 2).All(char.IsLetterOrDigit);
    }

}
