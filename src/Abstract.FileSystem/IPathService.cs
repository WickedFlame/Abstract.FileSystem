namespace Abstract.FileSystem
{
    /// <summary>
    /// Abstract service for System.IO.Path
    /// </summary>
    public interface IPathService
    {
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
        /// </returns>
        string ChangeExtension(string path, string extension);
        
        /// <summary>
        /// Combines two strings into a path.
        /// </summary>
        /// <param name="path1">The first path to combine.</param>
        /// <param name="path2">The second path to combine.</param>
        /// <returns>The combined paths. If one of the specified paths is a zero-length string, this
        /// method returns the other path. If path2 contains an absolute path, this method
        /// returns path2.</returns>
        string Combine(string path1, string path2);
        
        /// <summary>
        /// Combines three strings into a path.
        /// </summary>
        /// <param name="path1">The first path to combine.</param>
        /// <param name="path2">The second path to combine.</param>
        /// <param name="path3">The third path to combine.</param>
        /// <returns>The combined paths.</returns>
        string Combine(string path1, string path2, string path3);
        
        /// <summary>
        /// Combines four strings into a path.
        /// </summary>
        /// <param name="path1">The first path to combine.</param>
        /// <param name="path2">The second path to combine.</param>
        /// <param name="path3">The third path to combine.</param>
        /// <param name="path4">The fourth path to combine.</param>
        /// <returns>The combined paths.</returns>
        string Combine(string path1, string path2, string path3, string path4);
        
        /// <summary>
        /// Combines an array of strings into a path.
        /// </summary>
        /// <param name="paths">An array of parts of the path.</param>
        /// <returns>The combined paths.</returns>
        string Combine(params string[] paths);
        
        /// <summary>
        /// Returns the directory information for the specified path string.
        /// </summary>
        /// <param name="path">The path of a file or directory.</param>
        /// <returns>Directory information for path, or null if path denotes a root directory or is null. Returns System.String.Empty if path does not contain directory information.</returns>
        string GetDirectoryName(string path);
        
        /// <summary>
        /// Returns the extension of the specified path string.
        /// </summary>
        /// <param name="path">The path string from which to get the extension.</param>
        /// <returns>The extension of the specified path (including the period "."), or null, or System.String.Empty.
        /// If path is null, System.IO.Path.GetExtension(System.String) returns null. If
        /// path does not have extension information, System.IO.Path.GetExtension(System.String)
        /// returns System.String.Empty.</returns>
        string GetExtension(string path);
        
        /// <summary>
        /// Returns the file name and extension of the specified path string.
        /// </summary>
        /// <param name="path">The path string from which to obtain the file name and extension.</param>
        /// <returns>The characters after the last directory character in path. If the last character
        /// of path is a directory or volume separator character, this method returns System.String.Empty.
        /// If path is null, this method returns null.</returns>
        string GetFileName(string path);
        
        /// <summary>
        /// Returns the file name of the specified path string without the extension.
        /// </summary>
        /// <param name="path">The path of the file.</param>
        /// <returns>The string returned by System.IO.Path.GetFileName(System.String), minus the last period (.) and all characters following it.</returns>
        string GetFileNameWithoutExtension(string path);
        
        /// <summary>
        /// Returns the absolute path for the specified path string.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain absolute path information.</param>
        /// <returns>The fully qualified location of path, such as "C:\MyFile.txt".</returns>
        string GetFullPath(string path);
        
        /// <summary>
        /// Gets an array containing the characters that are not allowed in file names.
        /// </summary>
        /// <returns>An array containing the characters that are not allowed in file names.</returns>
        char[] GetInvalidFileNameChars();
        
        /// <summary>
        /// Gets an array containing the characters that are not allowed in path names.
        /// </summary>
        /// <returns>An array containing the characters that are not allowed in path names.</returns>
        char[] GetInvalidPathChars();
        
        /// <summary>
        /// Gets the root directory information of the specified path.
        /// </summary>
        /// <param name="path">The path from which to obtain root directory information.</param>
        /// <returns>The root directory of path, such as "C:\", or null if path is null, or an empty string if path does not contain root directory information.</returns>
        string GetPathRoot(string path);
        
        /// <summary>
        /// Returns a random folder name or file name.
        /// </summary>
        /// <returns>A random folder name or file name.</returns>
        string GetRandomFileName();
        
        /// <summary>
        /// Creates a uniquely named, zero-byte temporary file on disk and returns the full path of that file.
        /// </summary>
        /// <returns>The full path of the temporary file.</returns>
        string GetTempFileName();
        
        /// <summary>
        /// Returns the path of the current user's temporary folder.
        /// </summary>
        /// <returns>The path to the temporary folder, ending with a backslash.</returns>
        string GetTempPath();
        
        /// <summary>
        /// Determines whether a path includes a file name extension.
        /// </summary>
        /// <param name="path">The path to search for an extension.</param>
        /// <returns>true if the characters that follow the last directory separator (\\ or /) or
        /// volume separator (:) in the path include a period (.) followed by one or more
        /// characters; otherwise, false.</returns>
        bool HasExtension(string path);
        
        /// <summary>
        /// Gets a value indicating whether the specified path string contains a root.
        /// </summary>
        /// <param name="path">The path to test.</param>
        /// <returns>true if path contains a root; otherwise, false.</returns>
        bool IsPathRooted(string path);
    }
}
