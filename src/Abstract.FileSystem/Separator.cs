using Abstract.FileSystem.Internals;

namespace Abstract.FileSystem
{
    /// <summary>
    /// Enumeration for separators
    /// </summary>
    public class Separator : Enumeration
    {
        /// <summary>
        /// Define the separator
        /// </summary>
        /// <param name="name"></param>
        public Separator(string name) : base(name)
        {
        }

        /// <summary>
        /// Slash separator /
        /// </summary>
        public static readonly Separator Slash = new Separator("/");

        /// <summary>
        /// Backsalsh separator \
        /// </summary>
        public static readonly Separator Backslash = new Separator("\\");

        /// <summary>
        /// Separator for Windows systems \
        /// </summary>
        public static readonly Separator WinSeparator = new Separator("\\");

        /// <summary>
        /// Separator for Unix systems /
        /// </summary>
        public static readonly Separator UnixSeparator = new Separator("/");

        /// <summary>
        /// Separator for UNC Path \\
        /// </summary>

        public static readonly Separator UncSeparator = new Separator("\\\\");
    }
}
