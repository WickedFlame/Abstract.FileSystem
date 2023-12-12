using System;

namespace Abstract.FileSystem
{
    /// <summary>
    /// Performs operations on System.String instances that contain file or directory path information. These operations are performed in a cross-platform manner.
    /// </summary>
    public static class Path
    {
        private static IPathService _pathService;

        static Path()
        {
            _pathService = new PathService();
            AltDirectorySeparatorChar = System.IO.Path.AltDirectorySeparatorChar;
            DirectorySeparatorChar = System.IO.Path.DirectorySeparatorChar;
            PathSeparator = System.IO.Path.PathSeparator;
            VolumeSeparatorChar = System.IO.Path.VolumeSeparatorChar;
        }

        /// <summary>
        /// Abstarction layer factory for <see cref="IFileService"/>.
        /// </summary>
        public static IPathService Factory
        {
            get
            {
                if (_pathService == null)
                {
                    _pathService = new PathService();
                }

                return _pathService;
            }
        }

        /// <summary>
        /// Setup the factory for accessing File
        /// </summary>
        /// <param name="service"></param>
        public static void Setup(Func<IPathService> service)
        {
            _pathService = service.Invoke();
        }

        /// <summary>
        /// Provides a platform-specific alternate character used to separate directory levels in a path string that reflects a hierarchical file system organization.
        /// </summary>
        public static readonly char AltDirectorySeparatorChar;
        
        /// <summary>
        /// Provides a platform-specific character used to separate directory levels in a path string that reflects a hierarchical file system organization.
        /// </summary>
        public static readonly char DirectorySeparatorChar;

        /// <summary>
        /// A platform-specific separator character used to separate path strings in environment variables.
        /// </summary>
        public static readonly char PathSeparator;

        /// <summary>
        /// Provides a platform-specific volume separator character.
        /// </summary>
        public static readonly char VolumeSeparatorChar;

        /// <summary>
        /// Changes the extension of a path string.
        /// </summary>
        /// <param name="path">The path information to modify. The path cannot contain any of the characters defined in System.IO.Path.GetInvalidPathChars.</param>
        /// <param name="extension">The new extension (with or without a leading period). Specify null to remove an existing extension from path.</param>
        /// <returns>The modified path information. On Windows-based desktop platforms, if path is
        /// null or an empty string (""), the path information is returned unmodified. If
        /// extension is null, the returned string contains the specified path with its extension
        /// removed. If path has no extension, and extension is not null, the returned path
        /// string contains extension appended to the end of path.
        public static string ChangeExtension(string path, string extension)
        {
            return _pathService.ChangeExtension(path, extension);
        }

        /// <summary>
        /// Combines two strings into a path.
        /// </summary>
        /// <param name="path1">The first path to combine.</param>
        /// <param name="path2">The second path to combine.</param>
        /// <returns>The combined paths. If one of the specified paths is a zero-length string, this
        /// method returns the other path. If path2 contains an absolute path, this method
        /// returns path2.</returns>
        public static string Combine(string path1, string path2)
        {
            return _pathService.Combine(path1, path2);
        }

        /// <summary>
        /// Combines three strings into a path.
        /// </summary>
        /// <param name="path1">The first path to combine.</param>
        /// <param name="path2">The second path to combine.</param>
        /// <param name="path3">The third path to combine.</param>
        /// <returns>The combined paths.</returns>
        public static string Combine(string path1, string path2, string path3)
        {
            return _pathService.Combine(path1, path2, path3);
        }

        /// <summary>
        /// Combines four strings into a path.
        /// </summary>
        /// <param name="path1">The first path to combine.</param>
        /// <param name="path2">The second path to combine.</param>
        /// <param name="path3">The third path to combine.</param>
        /// <param name="path4">The fourth path to combine.</param>
        /// <returns>The combined paths.</returns>
        public static string Combine(string path1, string path2, string path3, string path4)
        {
            return _pathService.Combine(path1, path2, path3, path4);
        }

        /// <summary>
        /// Combines an array of strings into a path.
        /// </summary>
        /// <param name="paths">An array of parts of the path.</param>
        /// <returns>The combined paths.</returns>
        public static string Combine(params string[] paths)
        {
            return _pathService.Combine(paths);
        }

        /// <summary>
        /// Returns the directory information for the specified path string.
        /// </summary>
        /// <param name="path">The path of a file or directory.</param>
        /// <returns>Directory information for path, or null if path denotes a root directory or is null. Returns System.String.Empty if path does not contain directory information.</returns>
        public static string GetDirectoryName(string path)
        {
            return _pathService.GetDirectoryName(path);
        }

        /// <summary>
        /// Returns the extension of the specified path string.
        /// </summary>
        /// <param name="path">The path string from which to get the extension.</param>
        /// <returns>The extension of the specified path (including the period "."), or null, or System.String.Empty.
        /// If path is null, System.IO.Path.GetExtension(System.String) returns null. If
        /// path does not have extension information, System.IO.Path.GetExtension(System.String)
        /// returns System.String.Empty.</returns>
        public static string GetExtension(string path)
        {
            return _pathService.GetExtension(path);
        }

        /// <summary>
        /// Returns the file name and extension of the specified path string.
        /// </summary>
        /// <param name="path">The path string from which to obtain the file name and extension.</param>
        /// <returns>The characters after the last directory character in path. If the last character
        /// of path is a directory or volume separator character, this method returns System.String.Empty.
        /// If path is null, this method returns null.</returns>
        public static string GetFileName(string path)
        {
            return _pathService.GetFileName(path);
        }

        /// <summary>
        /// Returns the file name of the specified path string without the extension.
        /// </summary>
        /// <param name="path">The path of the file.</param>
        /// <returns>The string returned by System.IO.Path.GetFileName(System.String), minus the last period (.) and all characters following it.</returns>
        public static string GetFileNameWithoutExtension(string path)
        {
            return _pathService.GetFileNameWithoutExtension(path);
        }

        /// <summary>
        /// Returns the absolute path for the specified path string.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain absolute path information.</param>
        /// <returns>The fully qualified location of path, such as "C:\MyFile.txt".</returns>
        public static string GetFullPath(string path)
        {
            return _pathService.GetFullPath(path);
        }

        /// <summary>
        /// Gets an array containing the characters that are not allowed in file names.
        /// </summary>
        /// <returns>An array containing the characters that are not allowed in file names.</returns>
        public static char[] GetInvalidFileNameChars()
        {
            return _pathService.GetInvalidFileNameChars();
        }

        /// <summary>
        /// Gets an array containing the characters that are not allowed in path names.
        /// </summary>
        /// <returns>An array containing the characters that are not allowed in path names.</returns>
        public static char[] GetInvalidPathChars()
        {
            return _pathService.GetInvalidPathChars();
        }

        /// <summary>
        /// Gets the root directory information of the specified path.
        /// </summary>
        /// <param name="path">The path from which to obtain root directory information.</param>
        /// <returns>The root directory of path, such as "C:\", or null if path is null, or an empty string if path does not contain root directory information.</returns>
        public static string GetPathRoot(string path)
        {
            return _pathService.GetPathRoot(path);
        }

        /// <summary>
        /// Returns a random folder name or file name.
        /// </summary>
        /// <returns>A random folder name or file name.</returns>
        public static string GetRandomFileName()
        {
            return _pathService.GetRandomFileName();
        }

        /// <summary>
        /// Creates a uniquely named, zero-byte temporary file on disk and returns the full path of that file.
        /// </summary>
        /// <returns>The full path of the temporary file.</returns>
        public static string GetTempFileName()
        {
            return _pathService.GetTempFileName();
        }

        /// <summary>
        /// Returns the path of the current user's temporary folder.
        /// </summary>
        /// <returns>The path to the temporary folder, ending with a backslash.</returns>
        public static string GetTempPath()
        {
            return _pathService.GetTempPath();
        }

        /// <summary>
        /// Determines whether a path includes a file name extension.
        /// </summary>
        /// <param name="path">The path to search for an extension.</param>
        /// <returns>true if the characters that follow the last directory separator (\\ or /) or
        /// volume separator (:) in the path include a period (.) followed by one or more
        /// characters; otherwise, false.</returns>
        public static bool HasExtension(string path)
        {
            return _pathService.HasExtension(path);
        }

        /// <summary>
        /// Gets a value indicating whether the specified path string contains a root.
        /// </summary>
        /// <param name="path">The path to test.</param>
        /// <returns>true if path contains a root; otherwise, false.</returns>
        public static bool IsPathRooted(string path)
        {
            return _pathService.IsPathRooted(path);
        }
    }
}
