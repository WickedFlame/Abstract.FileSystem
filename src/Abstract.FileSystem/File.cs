using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Abstract.FileSystem
{
    /// <summary>
    /// Abstraction Layer for System.IO.File
    /// </summary>
    public static class File
    {
        private static IFileService _fileService;

        static File()
        {
            _fileService = new FileService();
        }

        /// <summary>
        /// Abstarction layer factory for <see cref="IFileService"/>.
        /// </summary>
        public static IFileService Factory
        {
            get
            {
                if (_fileService == null)
                {
                    _fileService = new FileService();
                }

                return _fileService;
            }
        }

        /// <summary>
        /// Setup the factory for accessing File
        /// </summary>
        /// <param name="service"></param>
        public static void Setup(Func<IFileService> service)
        {
            _fileService = service.Invoke();
        }

        /// <summary>
        /// Appends lines to a file, and then closes the file.If the specified file does
        /// not exist, this method creates a file, writes the specified lines to the file,
        /// and then closes the file.
        /// </summary>
        /// <param name="path">The file to append the lines to. The file is created if it doesn't already exist.</param>
        /// <param name="contents">The lines to append to the file.</param>
        public static void AppendAllLines(string path, IEnumerable<string> contents)
        {
            _fileService.AppendAllLines(path, contents);
        }

        /// <summary>
        /// Appends lines to a file by using a specified encoding, and then closes the file.
        /// If the specified file does not exist, this method creates a file, writes the
        /// specified lines to the file, and then closes the file.
        /// </summary>
        /// <param name="path">The file to append the lines to. The file is created if it doesn't already exist.</param>
        /// <param name="contents">The lines to append to the file.</param>
        /// <param name="encoding">The character encoding to use.</param>
        public static void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding)
        {
            _fileService.AppendAllLines(path, contents, encoding);
        }

        /// <summary>
        /// Opens a file, appends the specified string to the file, and then closes the file.
        /// If the file does not exist, this method creates a file, writes the specified
        /// string to the file, then closes the file.
        /// </summary>
        /// <param name="path">The file to append the specified string to.</param>
        /// <param name="contents">The string to append to the file.</param>
        public static void AppendAllText(string path, string contents)
        {
            _fileService.AppendAllText(path, contents);
        }

        /// <summary>
        /// Appends the specified string to the file, creating the file if it does not already exist.
        /// </summary>
        /// <param name="path">The file to append the specified string to.</param>
        /// <param name="contents">The string to append to the file.</param>
        /// <param name="encoding">The character encoding to use.</param>
        public static void AppendAllText(string path, string contents, Encoding encoding)
        {
            _fileService.AppendAllText(path, contents, encoding);
        }

        /// <summary>
        /// Creates a System.IO.StreamWriter that appends UTF-8 encoded text to an existing file, or to a new file if the specified file does not exist.
        /// </summary>
        /// <param name="path">The path to the file to append to.</param>
        /// <returns>A stream writer that appends UTF-8 encoded text to the specified file or to a new file.</returns>
        public static StreamWriter AppendText(string path)
        {
            return _fileService.AppendText(path);
        }

        /// <summary>
        /// Copies an existing file to a new file. Overwriting a file of the same name is not allowed.
        /// </summary>
        /// <param name="sourceFileName">The file to copy.</param>
        /// <param name="destFileName">The name of the destination file. This cannot be a directory or an existing file.</param>
        public static void Copy(string sourceFileName, string destFileName)
        {
            _fileService.Copy(sourceFileName, destFileName);
        }

        /// <summary>
        /// Copies an existing file to a new file. Overwriting a file of the same name is allowed.
        /// </summary>
        /// <param name="sourceFileName">The file to copy.</param>
        /// <param name="destFileName">The name of the destination file. This cannot be a directory.</param>
        /// <param name="overwrite">true if the destination file can be overwritten; otherwise, false.</param>
        public static void Copy(string sourceFileName, string destFileName, bool overwrite)
        {
            _fileService.Copy(sourceFileName, destFileName, overwrite);
        }

        /// <summary>
        /// Creates or overwrites a file in the specified path.
        /// </summary>
        /// <param name="path">The path and name of the file to create.</param>
        /// <returns>A System.IO.FileStream that provides read/write access to the file specified in path.</returns>
        public static FileStream Create(string path)
        {
            return _fileService.Create(path);
        }

        /// <summary>
        /// Creates or overwrites the specified file.
        /// </summary>
        /// <param name="path">The name of the file.</param>
        /// <param name="bufferSize">The number of bytes buffered for reads and writes to the file.</param>
        /// <returns>A System.IO.FileStream with the specified buffer size that provides read/write access to the file specified in path.</returns>
        public static FileStream Create(string path, int bufferSize)
        {
            return _fileService.Create(path, bufferSize);
        }

        /// <summary>
        /// Creates or overwrites the specified file, specifying a buffer size and a System.IO.FileOptions value that describes how to create or overwrite the file.
        /// </summary>
        /// <param name="path">The name of the file.</param>
        /// <param name="bufferSize">The number of bytes buffered for reads and writes to the file.</param>
        /// <param name="options">One of the System.IO.FileOptions values that describes how to create or overwrite the file.</param>
        /// <returns>A new file with the specified buffer size.</returns>
        public static FileStream Create(string path, int bufferSize, FileOptions options)
        {
            return _fileService.Create(path, bufferSize, options);
        }

        /// <summary>
        /// Creates or opens a file for writing UTF-8 encoded text. If the file already exists, its contents are overwritten.
        /// </summary>
        /// <param name="path">The file to be opened for writing.</param>
        /// <returns>A System.IO.StreamWriter that writes to the specified file using UTF-8 encoding.</returns>
        public static StreamWriter CreateText(string path)
        {
            return _fileService.CreateText(path);
        }

        /// <summary>
        /// Decrypts a file that was encrypted by the current account using the System.IO.File.Encrypt(System.String) method.
        /// </summary>
        /// <param name="path">A path that describes a file to decrypt.</param>
        public static void Decrypt(string path)
        {
            _fileService.Decrypt(path);
        }

        /// <summary>
        /// Deletes the specified file.
        /// </summary>
        /// <param name="path">The name of the file to be deleted. Wildcard characters are not supported.</param>
        public static void Delete(string path)
        {
            _fileService.Delete(path);
        }

        /// <summary>
        /// Encrypts a file so that only the account used to encrypt the file can decrypt it.
        /// </summary>
        /// <param name="path">A path that describes a file to encrypt.</param>
        public static void Encrypt(string path)
        {
            _fileService.Encrypt(path);
        }

        /// <summary>
        /// Determines whether the specified file exists.
        /// </summary>
        /// <param name="path">The file to check.</param>
        /// <returns>true if the caller has the required permissions and path contains the name of an existing file; 
        /// otherwise, false. This method also returns false if path is null, an invalid path, or a zero-length string. 
        /// If the caller does not have sufficient permissions to read the specified file, no exception is thrown and the 
        /// method returns false regardless of the existence of path.
        /// </returns>
        public static bool Exists(string path)
        {
            return _fileService.Exists(path);
        }

        /// <summary>
        /// Gets the System.IO.FileAttributes of the file on the path.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        /// <returns>The System.IO.FileAttributes of the file on the path.</returns>
        public static FileAttributes GetAttributes(string path)
        {
            return _fileService.GetAttributes(path);
        }

        /// <summary>
        /// Returns the creation date and time of the specified file or directory.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain creation date and time information.</param>
        /// <returns>A System.DateTime structure set to the creation date and time for the specified file or directory. This value is expressed in local time.</returns>
        public static DateTime GetCreationTime(string path)
        {
            return _fileService.GetCreationTime(path);
        }

        /// <summary>
        /// Returns the creation date and time, in coordinated universal time (UTC), of the specified file or directory.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain creation date and time information.</param>
        /// <returns>A System.DateTime structure set to the creation date and time for the specified file or directory. This value is expressed in UTC time.</returns>
        public static DateTime GetCreationTimeUtc(string path)
        {
            return _fileService.GetCreationTimeUtc(path);
        }

        /// <summary>
        /// Returns the date and time the specified file or directory was last accessed.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain access date and time information.</param>
        /// <returns>A System.DateTime structure set to the date and time that the specified file or directory was last accessed. This value is expressed in local time.</returns>
        public static DateTime GetLastAccessTime(string path)
        {
            return _fileService.GetLastAccessTime(path);
        }

        /// <summary>
        /// Returns the date and time, in coordinated universal time (UTC), that the specified file or directory was last accessed.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain access date and time information.</param>
        /// <returns>A System.DateTime structure set to the date and time that the specified file or directory was last accessed. This value is expressed in UTC time.</returns>
        public static DateTime GetLastAccessTimeUtc(string path)
        {
            return _fileService.GetLastAccessTimeUtc(path);
        }

        /// <summary>
        /// Returns the date and time the specified file or directory was last written to.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain write date and time information.</param>
        /// <returns>A System.DateTime structure set to the date and time that the specified file or directory was last written to. This value is expressed in local time.</returns>
        public static DateTime GetLastWriteTime(string path)
        {
            return _fileService.GetLastWriteTime(path);
        }

        /// <summary>
        /// Returns the date and time, in coordinated universal time (UTC), that the specified file or directory was last written to.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain write date and time information.</param>
        /// <returns>A System.DateTime structure set to the date and time that the specified file or directory was last written to. This value is expressed in UTC time.</returns>
        public static DateTime GetLastWriteTimeUtc(string path)
        {
            return _fileService.GetLastWriteTimeUtc(path);
        }

        /// <summary>
        /// Moves a specified file to a new location, providing the option to specify a new file name.
        /// </summary>
        /// <param name="sourceFileName">The name of the file to move. Can include a relative or absolute path.</param>
        /// <param name="destFileName">The new path and name for the file.</param>
        public static void Move(string sourceFileName, string destFileName)
        {
            _fileService.Move(sourceFileName, destFileName);
        }

        /// <summary>
        /// Opens a System.IO.FileStream on the specified path, with the specified mode and access.
        /// </summary>
        /// <param name="path">The file to open.</param>
        /// <param name="mode">A System.IO.FileMode value that specifies whether a file is created if one does not exist, and determines whether the contents of existing files are retained or overwritten.</param>
        /// <param name="access">A System.IO.FileAccess value that specifies the operations that can be performed on the file.</param>
        /// <returns>An unshared System.IO.FileStream that provides access to the specified file, with the specified mode and access.</returns>
        public static FileStream Open(string path, FileMode mode, FileAccess access)
        {
            return _fileService.Open(path, mode, access);
        }

        /// <summary>
        /// Opens a System.IO.FileStream on the specified path, having the specified mode with read, write, or read/write access and the specified sharing option.
        /// </summary>
        /// <param name="path">The file to open.</param>
        /// <param name="mode">A System.IO.FileMode value that specifies whether a file is created if one does not exist, and determines whether the contents of existing files are retained or overwritten.</param>
        /// <param name="access">A System.IO.FileAccess value that specifies the operations that can be performed on the file.</param>
        /// <param name="share">A System.IO.FileShare value specifying the type of access other threads have to the file.</param>
        /// <returns>A System.IO.FileStream on the specified path, having the specified mode with read, write, or read/write access and the specified sharing option.</returns>
        public static FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
        {
            return _fileService.Open(path, mode, access, share);
        }

        /// <summary>
        /// Opens a System.IO.FileStream on the specified path with read/write access.
        /// </summary>
        /// <param name="path">The file to open.</param>
        /// <param name="mode">A System.IO.FileMode value that specifies whether a file is created if one does not exist, and determines whether the contents of existing files are retained or overwritten.</param>
        /// <returns>A System.IO.FileStream opened in the specified mode and path, with read/write access and not shared.</returns>
        public static FileStream Open(string path, FileMode mode)
        {
            return _fileService.Open(path, mode);
        }

        /// <summary>
        /// Opens an existing file for reading.
        /// </summary>
        /// <param name="path">The file to be opened for reading.</param>
        /// <returns>A read-only System.IO.FileStream on the specified path.</returns>
        public static FileStream OpenRead(string path)
        {
            return _fileService.OpenRead(path);
        }

        /// <summary>
        /// Opens an existing UTF-8 encoded text file for reading.
        /// </summary>
        /// <param name="path">The file to be opened for reading.</param>
        /// <returns>A System.IO.StreamReader on the specified path.</returns>
        public static StreamReader OpenText(string path)
        {
            return _fileService.OpenText(path);
        }

        /// <summary>
        /// Opens an existing file or creates a new file for writing.
        /// </summary>
        /// <param name="path">The file to be opened for writing.</param>
        /// <returns>An unshared System.IO.FileStream object on the specified path with System.IO.FileAccess.Write access.</returns>
        public static FileStream OpenWrite(string path)
        {
            return _fileService.OpenWrite(path);
        }

        /// <summary>
        /// Opens a binary file, reads the contents of the file into a byte array, and then closes the file.
        /// </summary>
        /// <param name="path">The file to open for reading.</param>
        /// <returns>A byte array containing the contents of the file.</returns>
        public static byte[] ReadAllBytes(string path)
        {
            return _fileService.ReadAllBytes(path);
        }

        /// <summary>
        /// Opens a text file, reads all lines of the file, and then closes the file.
        /// </summary>
        /// <param name="path">The file to open for reading.</param>
        /// <returns>A string array containing all lines of the file.</returns>
        public static string[] ReadAllLines(string path)
        {
            return _fileService.ReadAllLines(path);
        }

        /// <summary>
        /// Opens a file, reads all lines of the file with the specified encoding, and then closes the file.
        /// </summary>
        /// <param name="path">The file to open for reading.</param>
        /// <param name="encoding">The encoding applied to the contents of the file.</param>
        /// <returns>A string array containing all lines of the file.</returns>
        public static string[] ReadAllLines(string path, Encoding encoding)
        {
            return _fileService.ReadAllLines(path, encoding);
        }

        /// <summary>
        /// Opens a text file, reads all lines of the file, and then closes the file.
        /// </summary>
        /// <param name="path">The file to open for reading.</param>
        /// <returns>A string containing all lines of the file.</returns>
        public static string ReadAllText(string path)
        {
            return _fileService.ReadAllText(path);
        }

        /// <summary>
        /// Opens a file, reads all lines of the file with the specified encoding, and then closes the file.
        /// </summary>
        /// <param name="path">The file to open for reading.</param>
        /// <param name="encoding">The encoding applied to the contents of the file.</param>
        /// <returns>A string containing all lines of the file.</returns>
        public static string ReadAllText(string path, Encoding encoding)
        {
            return _fileService.ReadAllText(path, encoding);
        }

        /// <summary>
        /// Reads the lines of a file.
        /// </summary>
        /// <param name="path">The file to read.</param>
        /// <returns>All the lines of the file, or the lines that are the result of a query.</returns>
        public static IEnumerable<string> ReadLines(string path)
        {
            return _fileService.ReadLines(path);
        }

        /// <summary>
        /// Read the lines of a file that has a specified encoding.
        /// </summary>
        /// <param name="path">The file to read.</param>
        /// <param name="encoding">The encoding that is applied to the contents of the file.</param>
        /// <returns>All the lines of the file, or the lines that are the result of a query.</returns>
        public static IEnumerable<string> ReadLines(string path, Encoding encoding)
        {
            return _fileService.ReadLines(path, encoding);
        }

        /// <summary>
        /// Replaces the contents of a specified file with the contents of another file, deleting the original file, and creating a backup of the replaced file and optionally ignores merge errors.
        /// </summary>
        /// <param name="sourceFileName">The name of a file that replaces the file specified by destinationFileName.</param>
        /// <param name="destinationFileName">The name of the file being replaced.</param>
        /// <param name="destinationBackupFileName">The name of the backup file.</param>
        /// <param name="ignoreMetadataErrors">true to ignore merge errors (such as attributes and access control lists (ACLs)) from the replaced file to the replacement file; otherwise, false.</param>
        public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
            _fileService.Replace(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors);
        }

        /// <summary>
        /// Replaces the contents of a specified file with the contents of another file, deleting the original file, and creating a backup of the replaced file.
        /// </summary>
        /// <param name="sourceFileName">The name of a file that replaces the file specified by destinationFileName.</param>
        /// <param name="destinationFileName">The name of the file being replaced.</param>
        /// <param name="destinationBackupFileName">The name of the backup file.</param>
        public static void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName)
        {
            _fileService.Replace(sourceFileName, destinationFileName, destinationBackupFileName);
        }

        /// <summary>
        /// Sets the specified System.IO.FileAttributes of the file on the specified path.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        /// <param name="fileAttributes">A bitwise combination of the enumeration values.</param>
        public static void SetAttributes(string path, FileAttributes fileAttributes)
        {
            _fileService.SetAttributes(path, fileAttributes);
        }

        /// <summary>
        /// Sets the date and time the file was created.
        /// </summary>
        /// <param name="path">The file for which to set the creation date and time information.</param>
        /// <param name="creationTime">A System.DateTime containing the value to set for the creation date and time of path. This value is expressed in local time.</param>
        public static void SetCreationTime(string path, DateTime creationTime)
        {
            _fileService.SetCreationTime(path, creationTime);
        }

        /// <summary>
        /// Sets the date and time, in coordinated universal time (UTC), that the file was created.
        /// </summary>
        /// <param name="path">The file for which to set the creation date and time information.</param>
        /// <param name="creationTimeUtc">A System.DateTime containing the value to set for the creation date and time of path. This value is expressed in UTC time.</param>
        public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
        {
            _fileService.SetCreationTimeUtc(path, creationTimeUtc);
        }

        /// <summary>
        /// Sets the date and time the specified file was last accessed.
        /// </summary>
        /// <param name="path">The file for which to set the access date and time information.</param>
        /// <param name="lastAccessTime">A System.DateTime containing the value to set for the last access date and time of path. This value is expressed in local time.</param>
        public static void SetLastAccessTime(string path, DateTime lastAccessTime)
        {
            _fileService.SetLastAccessTime(path, lastAccessTime);
        }

        /// <summary>
        /// Sets the date and time, in coordinated universal time (UTC), that the specified file was last accessed.
        /// </summary>
        /// <param name="path">The file for which to set the access date and time information.</param>
        /// <param name="lastAccessTimeUtc">A System.DateTime containing the value to set for the last access date and time of path. This value is expressed in UTC time.</param>
        public static void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
        {
            _fileService.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
        }

        /// <summary>
        /// Sets the date and time that the specified file was last written to.
        /// </summary>
        /// <param name="path">The file for which to set the date and time information.</param>
        /// <param name="lastWriteTime">A System.DateTime containing the value to set for the last write date and time of path. This value is expressed in local time.</param>
        public static void SetLastWriteTime(string path, DateTime lastWriteTime)
        {
            _fileService.SetLastWriteTime(path, lastWriteTime);
        }

        /// <summary>
        /// Sets the date and time, in coordinated universal time (UTC), that the specified file was last written to.
        /// </summary>
        /// <param name="path">The file for which to set the date and time information.</param>
        /// <param name="lastWriteTimeUtc">A System.DateTime containing the value to set for the last write date and time of path. This value is expressed in UTC time.</param>
        public static void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        {
            _fileService.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
        }

        /// <summary>
        /// Creates a new file, writes the specified byte array to the file, and then closes the file. If the target file already exists, it is overwritten.
        /// </summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="bytes">The bytes to write to the file.</param>
        public static void WriteAllBytes(string path, byte[] bytes)
        {
            _fileService.WriteAllBytes(path, bytes);
        }

        /// <summary>
        /// Creates a new file, writes a collection of strings to the file, and then closes the file.
        /// </summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="contents">The lines to write to the file.</param>
        public static void WriteAllLines(string path, IEnumerable<string> contents)
        {
            _fileService.WriteAllLines(path, contents);
        }

        /// <summary>
        /// Creates a new file by using the specified encoding, writes a collection of strings to the file, and then closes the file.
        /// </summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="contents">The lines to write to the file.</param>
        /// <param name="encoding">The character encoding to use.</param>
        public static void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding)
        {
            _fileService.WriteAllLines(path, contents, encoding);
        }

        /// <summary>
        /// Creates a new file, write the specified string array to the file, and then closes the file.
        /// </summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="contents">The string array to write to the file.</param>
        public static void WriteAllLines(string path, string[] contents)
        {
            _fileService.WriteAllLines(path, contents);
        }

        /// <summary>
        /// Creates a new file, writes the specified string array to the file by using the specified encoding, and then closes the file.
        /// </summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="contents">The string array to write to the file.</param>
        /// <param name="encoding">An System.Text.Encoding object that represents the character encoding applied to the string array.</param>
        public static void WriteAllLines(string path, string[] contents, Encoding encoding)
        {
            _fileService.WriteAllLines(path, contents, encoding);
        }

        /// <summary>
        /// Creates a new file, writes the specified string to the file, and then closes the file. If the target file already exists, it is overwritten.
        /// </summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="contents">The string to write to the file.</param>
        public static void WriteAllText(string path, string contents)
        {
            _fileService.WriteAllText(path, contents);
        }

        /// <summary>
        /// Creates a new file, writes the specified string to the file using the specified encoding, and then closes the file. If the target file already exists, it is overwritten.
        /// </summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="contents">The string to write to the file.</param>
        /// <param name="encoding">The encoding to apply to the string.</param>
        public static void WriteAllText(string path, string contents, Encoding encoding)
        {
            _fileService.WriteAllText(path, contents, encoding);
        }
    }
}
