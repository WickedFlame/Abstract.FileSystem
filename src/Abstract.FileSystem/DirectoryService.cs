using System;
using System.Collections.Generic;
using System.IO;

namespace Abstract.FileSystem
{
    /// <summary>
    /// Wrapper fpr System.IO.Directory
    /// </summary>
    public class DirectoryService : IDirectoryService
    {
        /// <summary>
        /// Creates all directories and subdirectories in the specified path unless they already exist.
        /// </summary>
        /// <param name="path">The directory to create.</param>
        /// <returns>An object that represents the directory at the specified path. This object is returned regardless of whether a directory at the specified path already exists.</returns>
        public DirectoryInfo CreateDirectory (string path)
        {
            return System.IO.Directory.CreateDirectory(path);
        }

        /// <summary>
        /// Deletes an empty directory from a specified path.
        /// </summary>
        /// <param name="path">The name of the empty directory to remove. This directory must be writable and empty.</param>
        public void Delete (string path)
        {
            System.IO.Directory.Delete(path);
        }

        /// <summary>
        /// Deletes the specified directory and, if indicated, any subdirectories and files in the directory.
        /// </summary>
        /// <param name="path">The name of the directory to remove.</param>
        /// <param name="recursive">true to remove directories, subdirectories, and files in path; otherwise, false.</param>
        public void Delete (string path, bool recursive)
        {
            System.IO.Directory.Delete(path, recursive);
        }

        /// <summary>
        /// Returns an enumerable collection of directory names in a specified path.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <returns>An enumerable collection of the full names (including paths) for the directories in the directory specified by path.</returns>
        public IEnumerable<string> EnumerateDirectories (string path)
        {
            return System.IO.Directory.EnumerateDirectories(path);
        }

        /// <summary>
        /// Returns an enumerable collection of directory names that match a search pattern in a specified path.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of directories in path. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular expressions.</param>
        /// <returns>An enumerable collection of the full names (including paths) for the directories in the directory specified by path and that match the specified search pattern.</returns>
        public IEnumerable<string> EnumerateDirectories (string path, string searchPattern)
        {
            return System.IO.Directory.EnumerateDirectories(path, searchPattern);
        }

        /// <summary>
        /// Returns an enumerable collection of directory names that match a search pattern in a specified path, and optionally searches subdirectories.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of directories in path. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular expressions.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or should include all subdirectories. The default value is System.IO.SearchOption.TopDirectoryOnly.</param>
        /// <returns>An enumerable collection of the full names (including paths) for the directories in the directory specified by path and that match the specified search pattern and option.</returns>
        public IEnumerable<string> EnumerateDirectories (string path, string searchPattern, SearchOption searchOption)
        {
            return System.IO.Directory.EnumerateDirectories(path, searchPattern, searchOption);
        }

        /// <summary>
        /// Returns an enumerable collection of file names in a specified path.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <returns>An enumerable collection of the full names (including paths) for the files in the directory specified by path.</returns>
        public IEnumerable<string> EnumerateFiles(string path)
        {
            return System.IO.Directory.EnumerateFiles(path);
        }

        /// <summary>
        /// Returns an enumerable collection of file names that match a search pattern in a specified path.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of files in path. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular expressions.</param>
        /// <returns>An enumerable collection of the full names (including paths) for the files in the directory specified by path and that match the specified search pattern.</returns>
        public IEnumerable<string> EnumerateFiles(string path, string searchPattern)
        {
            return System.IO.Directory.EnumerateFiles(path, searchPattern);
        }

        /// <summary>
        /// Returns an enumerable collection of file names that match a search pattern in a specified path, and optionally searches subdirectories.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of files in path. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular expressions.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or should include all subdirectories. The default value is System.IO.SearchOption.TopDirectoryOnly.</param>
        /// <returns>An enumerable collection of the full names (including paths) for the files in the directory specified by path and that match the specified search pattern and option.</returns>
        public IEnumerable<string> EnumerateFiles (string path, string searchPattern, SearchOption searchOption)
        {
            return System.IO.Directory.EnumerateFiles (path, searchPattern, searchOption);
        }

        /// <summary>
        /// Returns an enumerable collection of file names and directory names that match a search pattern in a specified path, and optionally searches subdirectories.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against file-system entries in path. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular expressions.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include only the current directory or should include all subdirectories. The default value is System.IO.SearchOption.TopDirectoryOnly.</param>
        /// <returns>An enumerable collection of file-system entries in the directory specified by path and that match the specified search pattern and option.</returns>
        public IEnumerable<string> EnumerateFileSystemEntries (string path, string searchPattern, SearchOption searchOption)
        {
            return System.IO.Directory.EnumerateFileSystemEntries(path, searchPattern, searchOption);
        }

        /// <summary>
        /// Returns an enumerable collection of file names and directory names in a specified path.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <returns>An enumerable collection of file-system entries in the directory specified by path.</returns>
        public IEnumerable<string> EnumerateFileSystemEntries (string path)
        {
            return System.IO.Directory.EnumerateFileSystemEntries(path);
        }

        /// <summary>
        /// Returns an enumerable collection of file names and directory names that match a search pattern in a specified path.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of file-system entries in path. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular expressions.</param>
        /// <returns>An enumerable collection of file-system entries in the directory specified by path and that match the specified search pattern.</returns>
        public IEnumerable<string> EnumerateFileSystemEntries (string path, string searchPattern)
        {
            return System.IO.Directory.EnumerateFileSystemEntries (path, searchPattern);
        }

        /// <summary>
        /// Determines whether the given path refers to an existing directory on disk.
        /// </summary>
        /// <param name="path">The path to test.</param>
        /// <returns>true if path refers to an existing directory; false if the directory does not exist or an error occurs when trying to determine if the specified directory exists.</returns>
        public bool Exists (string path)
        {
            return System.IO.Directory.Exists (path);
        }

        /// <summary>
        /// Gets the creation date and time of a directory.
        /// </summary>
        /// <param name="path">The path of the directory.</param>
        /// <returns>A structure that is set to the creation date and time for the specified directory. This value is expressed in local time.</returns>
        public DateTime GetCreationTime (string path)
        {
            return System.IO.Directory.GetCreationTime (path);
        }

        /// <summary>
        /// Gets the creation date and time, in Coordinated Universal Time (UTC) format, of a directory.
        /// </summary>
        /// <param name="path">The path of the directory.</param>
        /// <returns>A structure that is set to the creation date and time for the specified directory. This value is expressed in UTC time.</returns>
        public DateTime GetCreationTimeUtc (string path)
        {
            return System.IO.Directory.GetCreationTimeUtc (path);
        }

        /// <summary>
        /// Gets the current working directory of the application.
        /// </summary>
        /// <returns>A string that contains the path of the current working directory, and does not end with a backslash (\).</returns>
        public string GetCurrentDirectory ()
        {
            return System.IO.Directory.GetCurrentDirectory ();
        }

        /// <summary>
        /// Returns the names of subdirectories (including their paths) that match the specified search pattern in the specified directory.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of subdirectories in path. This parameter can contain a combination of valid literal and wildcard characters, but it doesn't support regular expressions.</param>
        /// <returns>An array of the full names (including paths) of the subdirectories that match the search pattern in the specified directory, or an empty array if no directories are found.</returns>
        public string[] GetDirectories (string path, string searchPattern)
        {
            return System.IO.Directory.GetDirectories (path, searchPattern);
        }

        /// <summary>
        /// Returns the names of subdirectories (including their paths) in the specified directory.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <returns>An array of the full names (including paths) of subdirectories in the specified path, or an empty array if no directories are found.</returns>
        public string[] GetDirectories (string path)
        {
            return System.IO.Directory.GetDirectories(path);
        }

        /// <summary>
        /// Returns the names of the subdirectories (including their paths) that match the specified search pattern in the specified directory, and optionally searches subdirectories.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of subdirectories in path. This parameter can contain a combination of valid literal and wildcard characters, but it doesn't support regular expressions.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include all subdirectories or only the current directory.</param>
        /// <returns>An array of the full names (including paths) of the subdirectories that match the specified criteria, or an empty array if no directories are found.</returns>
        public string[] GetDirectories (string path, string searchPattern, SearchOption searchOption)
        {
            return System.IO.Directory.GetDirectories(path, searchPattern, searchOption);
        }

        /// <summary>
        /// Returns the volume information, root information, or both for the specified path.
        /// </summary>
        /// <param name="path">The path of a file or directory.</param>
        /// <returns>A string that contains the volume information, root information, or both for the specified path.</returns>
        public string GetDirectoryRoot (string path)
        {
            return System.IO.Directory.GetDirectoryRoot (path);
        }

        /// <summary>
        /// Returns the names of files (including their paths) in the specified directory.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <returns>An array of the full names (including paths) for the files in the specified directory, or an empty array if no files are found.</returns>
        public string[] GetFiles (string path)
        {
            return System.IO.Directory.GetFiles (path);
        }

        /// <summary>
        /// Returns the names of files (including their paths) that match the specified search pattern in the specified directory.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of files in path. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular expressions.</param>
        /// <returns>An array of the full names (including paths) for the files in the specified directory that match the specified search pattern, or an empty array if no files are found.</returns>
        public string[] GetFiles (string path, string searchPattern)
        {
            return System.IO.Directory.GetFiles(path, searchPattern);
        }

        /// <summary>
        /// Returns the names of files (including their paths) that match the specified search pattern in the specified directory, using a value to determine whether to search subdirectories.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of files in path. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular expressions.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation should include all subdirectories or only the current directory.</param>
        /// <returns>An array of the full names (including paths) for the files in the specified directory that match the specified search pattern and option, or an empty array if no files are found.</returns>
        public string[] GetFiles (string path, string searchPattern, SearchOption searchOption)
        {
            return System.IO.Directory.GetFiles(path, searchPattern, searchOption);
        }

        /// <summary>
        /// Returns the names of all files and subdirectories in a specified path.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <returns>An array of the names of files and subdirectories in the specified directory, or an empty array if no files or subdirectories are found.</returns>
        public string[] GetFileSystemEntries (string path)
        {
            return System.IO.Directory.GetFileSystemEntries (path);
        }

        /// <summary>
        /// Returns an array of file names and directory names that that match a search pattern in a specified path.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of file and directories in path. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular expressions.</param>
        /// <returns>An array of file names and directory names that match the specified search criteria, or an empty array if no files or directories are found.</returns>
        public string[] GetFileSystemEntries (string path, string searchPattern)
        {
            return System.IO.Directory.GetFileSystemEntries(path, searchPattern);
        }

        /// <summary>
        /// Returns an array of all the file names and directory names that match a search pattern in a specified path, and optionally searches subdirectories.
        /// </summary>
        /// <param name="path">The relative or absolute path to the directory to search. This string is not case-sensitive.</param>
        /// <param name="searchPattern">The search string to match against the names of files and directories in path. This parameter can contain a combination of valid literal path and wildcard (* and ?) characters, but it doesn't support regular expressions.</param>
        /// <param name="searchOption">One of the enumeration values that specifies whether the search operation shouldinclude only the current directory or should include all subdirectories. The default value is System.IO.SearchOption.TopDirectoryOnly.</param>
        /// <returns>An array of file the file names and directory names that match the specified search criteria, or an empty array if no files or directories are found.</returns>
        public string[] GetFileSystemEntries (string path, string searchPattern, SearchOption searchOption)
        {
            return System.IO.Directory.GetFileSystemEntries(path, searchPattern, searchOption);
        }

        /// <summary>
        /// Returns the date and time the specified file or directory was last accessed.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain access date and time information.</param>
        /// <returns>A structure that is set to the date and time the specified file or directory was last accessed. This value is expressed in local time.</returns>
        public DateTime GetLastAccessTime (string path)
        {
            return System.IO.Directory.GetLastAccessTime (path);
        }

        /// <summary>
        /// Returns the date and time, in Coordinated Universal Time (UTC) format, that the specified file or directory was last accessed.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain access date and time information.</param>
        /// <returns>A structure that is set to the date and time the specified file or directory was last accessed. This value is expressed in UTC time.</returns>
        public DateTime GetLastAccessTimeUtc (string path)
        {
            return System.IO.Directory.GetLastAccessTimeUtc (path);
        }

        /// <summary>
        /// Returns the date and time the specified file or directory was last written to.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain modification date and time information.</param>
        /// <returns>A structure that is set to the date and time the specified file or directory was last written to. This value is expressed in local time.</returns>
        public DateTime GetLastWriteTime (string path)
        {
            return System.IO.Directory.GetLastWriteTime (path);
        }

        /// <summary>
        /// Returns the date and time, in Coordinated Universal Time (UTC) format, that the specified file or directory was last written to.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain modification date and time information.</param>
        /// <returns>A structure that is set to the date and time the specified file or directory was last written to. This value is expressed in UTC time.</returns>
        public DateTime GetLastWriteTimeUtc (string path)
        {
            return System.IO.Directory.GetLastWriteTimeUtc(path);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public string[] GetLogicalDrives ()
        {
            return System.IO.Directory.GetLogicalDrives();
        }

        /// <summary>
        /// Retrieves the parent directory of the specified path, including both absolute and relative paths.
        /// </summary>
        /// <param name="path">The path for which to retrieve the parent directory.</param>
        /// <returns>The parent directory, or null if path is the root directory, including the root of a UNC server or share name.</returns>
        public DirectoryInfo GetParent(string path)
        {
            return System.IO.Directory.GetParent(path);
        }

        /// <summary>
        /// Moves a file or a directory and its contents to a new location.
        /// </summary>
        /// <param name="sourceDirName">The path of the file or directory to move.</param>
        /// <param name="destDirName">The path to the new location for sourceDirName. If sourceDirName is a file, then destDirName must also be a file name.</param>
        public void Move (string sourceDirName, string destDirName)
        {
            System.IO.Directory.Move(sourceDirName, destDirName);
        }

        /// <summary>
        /// Sets the creation date and time for the specified file or directory.
        /// </summary>
        /// <param name="path">The file or directory for which to set the creation date and time information.</param>
        /// <param name="creationTime">The date and time the file or directory was last written to. This value is expressed in local time.</param>
        public void SetCreationTime (string path, DateTime creationTime)
        {
            System.IO.Directory.SetCreationTime (path, creationTime);
        }

        /// <summary>
        /// Sets the creation date and time, in Coordinated Universal Time (UTC) format, for the specified file or directory.
        /// </summary>
        /// <param name="path">The file or directory for which to set the creation date and time information.</param>
        /// <param name="creationTimeUtc">The date and time the directory or file was created. This value is expressed in local time.</param>
        public void SetCreationTimeUtc (string path, DateTime creationTimeUtc)
        {
            System.IO.Directory.SetCreationTimeUtc (path, creationTimeUtc);
        }

        /// <summary>
        /// Sets the application's current working directory to the specified directory.
        /// </summary>
        /// <param name="path">The path to which the current working directory is set.</param>
        public void SetCurrentDirectory (string path)
        {
            System.IO.Directory.SetCurrentDirectory (path);
        }

        /// <summary>
        /// Sets the date and time the specified file or directory was last accessed.
        /// </summary>
        /// <param name="path">The file or directory for which to set the access date and time information.</param>
        /// <param name="lastAccessTime">An object that contains the value to set for the access date and time of path. This value is expressed in local time.</param>
        public void SetLastAccessTime (string path, DateTime lastAccessTime)
        {
            System.IO.Directory.SetLastAccessTime (path, lastAccessTime);
        }

        /// <summary>
        /// Sets the date and time, in Coordinated Universal Time (UTC) format, that the specified file or directory was last accessed.
        /// </summary>
        /// <param name="path">The file or directory for which to set the access date and time information.</param>
        /// <param name="lastAccessTimeUtc">An object that contains the value to set for the access date and time of path. This value is expressed in UTC time.</param>
        public void SetLastAccessTimeUtc (string path, DateTime lastAccessTimeUtc)
        {
            System.IO.Directory.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
        }

        /// <summary>
        /// Sets the date and time a directory was last written to.
        /// </summary>
        /// <param name="path">The path of the directory.</param>
        /// <param name="lastWriteTime">The date and time the directory was last written to. This value is expressed in local time.</param>
        public void SetLastWriteTime (string path, DateTime lastWriteTime)
        {
            System.IO.Directory.SetLastWriteTime (path, lastWriteTime);
        }

        /// <summary>
        /// Sets the date and time, in Coordinated Universal Time (UTC) format, that a directory was last written to.
        /// </summary>
        /// <param name="path">The path of the directory.</param>
        /// <param name="lastWriteTimeUtc">The date and time the directory was last written to. This value is expressed in UTC time.</param>
        public void SetLastWriteTimeUtc (string path, DateTime lastWriteTimeUtc)
        {
            System.IO.Directory.SetLastWriteTimeUtc(path , lastWriteTimeUtc);
        }
    }
}
