using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Abstract.FileSystem
{
    public partial class FileService : IFileService
    {
        /// <summary>
        /// Appends lines to a file, and then closes the file.If the specified file does
        /// not exist, this method creates a file, writes the specified lines to the file,
        /// and then closes the file.
        /// </summary>
        /// <param name="path">The file to append the lines to. The file is created if it doesn't already exist.</param>
        /// <param name="contents">The lines to append to the file.</param>
        public void AppendAllLines(string path, IEnumerable<string> contents)
        {
            System.IO.File.AppendAllLines(path, contents);
        }

        /// <summary>
        /// Appends lines to a file by using a specified encoding, and then closes the file.
        /// If the specified file does not exist, this method creates a file, writes the
        /// specified lines to the file, and then closes the file.
        /// </summary>
        /// <param name="path">The file to append the lines to. The file is created if it doesn't already exist.</param>
        /// <param name="contents">The lines to append to the file.</param>
        /// <param name="encoding">The character encoding to use.</param>
        public void AppendAllLines(string path, IEnumerable<string> contents, Encoding encoding)
        {
            System.IO.File.AppendAllLines(path, contents, encoding);
        }

        /// <summary>
        /// Opens a file, appends the specified string to the file, and then closes the file.
        /// If the file does not exist, this method creates a file, writes the specified
        /// string to the file, then closes the file.
        /// </summary>
        /// <param name="path">The file to append the specified string to.</param>
        /// <param name="contents">The string to append to the file.</param>
        public void AppendAllText(string path, string contents)
        {
            System.IO.File.AppendAllText(path, contents);
        }

        /// <summary>
        /// Appends the specified string to the file, creating the file if it does not already exist.
        /// </summary>
        /// <param name="path">The file to append the specified string to.</param>
        /// <param name="contents">The string to append to the file.</param>
        /// <param name="encoding">The character encoding to use.</param>
        public void AppendAllText(string path, string contents, Encoding encoding)
        {
            System.IO.File.AppendAllText(path, contents, encoding);
        }

        /// <summary>
        /// Creates a System.IO.StreamWriter that appends UTF-8 encoded text to an existing file, or to a new file if the specified file does not exist.
        /// </summary>
        /// <param name="path">The path to the file to append to.</param>
        /// <returns>A stream writer that appends UTF-8 encoded text to the specified file or to a new file.</returns>
        public StreamWriter AppendText(string path)
        {
            return System.IO.File.AppendText(path);
        }

        /// <summary>
        /// Copies an existing file to a new file. Overwriting a file of the same name is not allowed.
        /// </summary>
        /// <param name="sourceFileName">The file to copy.</param>
        /// <param name="destFileName">The name of the destination file. This cannot be a directory or an existing file.</param>
        public void Copy(string sourceFileName, string destFileName)
        {
            System.IO.File.Copy(sourceFileName, destFileName);
        }

        /// <summary>
        /// Copies an existing file to a new file. Overwriting a file of the same name is allowed.
        /// </summary>
        /// <param name="sourceFileName">The file to copy.</param>
        /// <param name="destFileName">The name of the destination file. This cannot be a directory.</param>
        /// <param name="overwrite">true if the destination file can be overwritten; otherwise, false.</param>
        public void Copy(string sourceFileName, string destFileName, bool overwrite)
        {
            System.IO.File.Copy(sourceFileName, destFileName, overwrite);
        }

        /// <summary>
        /// Creates or overwrites a file in the specified path.
        /// </summary>
        /// <param name="path">The path and name of the file to create.</param>
        /// <returns>A System.IO.FileStream that provides read/write access to the file specified in path.</returns>
        public FileStream Create(string path)
        {
            return System.IO.File.Create(path);
        }

        /// <summary>
        /// Creates or overwrites the specified file.
        /// </summary>
        /// <param name="path">The name of the file.</param>
        /// <param name="bufferSize">The number of bytes buffered for reads and writes to the file.</param>
        /// <returns>A System.IO.FileStream with the specified buffer size that provides read/write access to the file specified in path.</returns>
        public FileStream Create(string path, int bufferSize)
        {
            return System.IO.File.Create(path, bufferSize);
        }

        /// <summary>
        /// Creates or overwrites the specified file, specifying a buffer size and a System.IO.FileOptions value that describes how to create or overwrite the file.
        /// </summary>
        /// <param name="path">The name of the file.</param>
        /// <param name="bufferSize">The number of bytes buffered for reads and writes to the file.</param>
        /// <param name="options">One of the System.IO.FileOptions values that describes how to create or overwrite the file.</param>
        /// <returns>A new file with the specified buffer size.</returns>
        public FileStream Create(string path, int bufferSize, FileOptions options)
        {
            return System.IO.File.Create(path, bufferSize, options);
        }

        /// <summary>
        /// Creates or opens a file for writing UTF-8 encoded text. If the file already exists, its contents are overwritten.
        /// </summary>
        /// <param name="path">The file to be opened for writing.</param>
        /// <returns>A System.IO.StreamWriter that writes to the specified file using UTF-8 encoding.</returns>
        public StreamWriter CreateText(string path)
        {
            return System.IO.File.CreateText(path);
        }

        /// <summary>
        /// Decrypts a file that was encrypted by the current account using the System.IO.File.Encrypt(System.String) method.
        /// </summary>
        /// <param name="path">A path that describes a file to decrypt.</param>
        public void Decrypt(string path)
        {
            System.IO.File.Decrypt(path);
        }

        /// <summary>
        /// Deletes the specified file.
        /// </summary>
        /// <param name="path">The name of the file to be deleted. Wildcard characters are not supported.</param>
        public void Delete(string path)
        {
            System.IO.File.Delete(path);
        }

        /// <summary>
        /// Encrypts a file so that only the account used to encrypt the file can decrypt it.
        /// </summary>
        /// <param name="path">A path that describes a file to encrypt.</param>
        public void Encrypt(string path)
        {
            System.IO.File.Encrypt(path);
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
        public bool Exists(string path)
        {
            return System.IO.File.Exists(path);
        }

        /// <summary>
        /// Gets the System.IO.FileAttributes of the file on the path.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        /// <returns>The System.IO.FileAttributes of the file on the path.</returns>
        public FileAttributes GetAttributes(string path)
        {
            return System.IO.File.GetAttributes(path);
        }

        /// <summary>
        /// Returns the creation date and time of the specified file or directory.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain creation date and time information.</param>
        /// <returns>A System.DateTime structure set to the creation date and time for the specified file or directory. This value is expressed in local time.</returns>
        public DateTime GetCreationTime(string path)
        {
            return System.IO.File.GetCreationTime(path);
        }

        /// <summary>
        /// Returns the creation date and time, in coordinated universal time (UTC), of the specified file or directory.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain creation date and time information.</param>
        /// <returns>A System.DateTime structure set to the creation date and time for the specified file or directory. This value is expressed in UTC time.</returns>
        public DateTime GetCreationTimeUtc(string path)
        {
            return System.IO.File.GetCreationTimeUtc(path);
        }

        /// <summary>
        /// Returns the date and time the specified file or directory was last accessed.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain access date and time information.</param>
        /// <returns>A System.DateTime structure set to the date and time that the specified file or directory was last accessed. This value is expressed in local time.</returns>
        public DateTime GetLastAccessTime(string path)
        {
            return System.IO.File.GetLastAccessTime(path);
        }

        /// <summary>
        /// Returns the date and time, in coordinated universal time (UTC), that the specified file or directory was last accessed.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain access date and time information.</param>
        /// <returns>A System.DateTime structure set to the date and time that the specified file or directory was last accessed. This value is expressed in UTC time.</returns>
        public DateTime GetLastAccessTimeUtc(string path)
        {
            return System.IO.File.GetLastAccessTimeUtc(path);
        }

        /// <summary>
        /// Returns the date and time the specified file or directory was last written to.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain write date and time information.</param>
        /// <returns>A System.DateTime structure set to the date and time that the specified file or directory was last written to. This value is expressed in local time.</returns>
        public DateTime GetLastWriteTime(string path)
        {
            return System.IO.File.GetLastWriteTime(path);
        }

        /// <summary>
        /// Returns the date and time, in coordinated universal time (UTC), that the specified file or directory was last written to.
        /// </summary>
        /// <param name="path">The file or directory for which to obtain write date and time information.</param>
        /// <returns>A System.DateTime structure set to the date and time that the specified file or directory was last written to. This value is expressed in UTC time.</returns>
        public DateTime GetLastWriteTimeUtc(string path)
        {
            return System.IO.File.GetLastWriteTimeUtc(path);
        }

        /// <summary>
        /// /// <summary>
        /// Moves a specified file to a new location, providing the option to specify a new file name.
        /// </summary>
        /// <param name="sourceFileName">The name of the file to move. Can include a relative or absolute path.</param>
        /// <param name="destFileName">The new path and name for the file.</param>
        public void Move(string sourceFileName, string destFileName)
        {
            System.IO.File.Move(sourceFileName, destFileName);
        }

        /// <summary>
        /// Opens a System.IO.FileStream on the specified path, having the specified mode with read, write, or read/write access and the specified sharing option.
        /// </summary>
        /// <param name="path">The file to open.</param>
        /// <param name="mode">A System.IO.FileMode value that specifies whether a file is created if one does not exist, and determines whether the contents of existing files are retained or overwritten.</param>
        /// <param name="access">A System.IO.FileAccess value that specifies the operations that can be performed on the file.</param>
        /// <param name="share">A System.IO.FileShare value specifying the type of access other threads have to the file.</param>
        /// <returns>A System.IO.FileStream on the specified path, having the specified mode with read, write, or read/write access and the specified sharing option.</returns>
        public FileStream Open(string path, FileMode mode, FileAccess access)
        {
            return System.IO.File.Open(path, mode, access);
        }

        /// <summary>
        /// Opens a System.IO.FileStream on the specified path, having the specified mode with read, write, or read/write access and the specified sharing option.
        /// </summary>
        /// <param name="path">The file to open.</param>
        /// <param name="mode">A System.IO.FileMode value that specifies whether a file is created if one does not exist, and determines whether the contents of existing files are retained or overwritten.</param>
        /// <param name="access">A System.IO.FileAccess value that specifies the operations that can be performed on the file.</param>
        /// <param name="share">A System.IO.FileShare value specifying the type of access other threads have to the file.</param>
        /// <returns>A System.IO.FileStream on the specified path, having the specified mode with read, write, or read/write access and the specified sharing option.</returns>
        public FileStream Open(string path, FileMode mode, FileAccess access, FileShare share)
        {
            return System.IO.File.Open(path, mode, access, share);
        }

        /// <summary>
        /// Opens a System.IO.FileStream on the specified path with read/write access.
        /// </summary>
        /// <param name="path">The file to open.</param>
        /// <param name="mode">A System.IO.FileMode value that specifies whether a file is created if one does not exist, and determines whether the contents of existing files are retained or overwritten.</param>
        /// <returns>A System.IO.FileStream opened in the specified mode and path, with read/write access and not shared.</returns>
        public FileStream Open(string path, FileMode mode)
        {
            return System.IO.File.Open(path, mode);
        }

        /// <summary>
        /// Opens an existing file for reading.
        /// </summary>
        /// <param name="path">The file to be opened for reading.</param>
        /// <returns>A read-only System.IO.FileStream on the specified path.</returns>
        public FileStream OpenRead(string path)
        {
            return System.IO.File.OpenRead(path);
        }

        /// <summary>
        /// Opens an existing UTF-8 encoded text file for reading.
        /// </summary>
        /// <param name="path">The file to be opened for reading.</param>
        /// <returns>A System.IO.StreamReader on the specified path.</returns>
        public StreamReader OpenText(string path)
        {
            return System.IO.File.OpenText(path);
        }

        /// <summary>
        /// Opens an existing file or creates a new file for writing.
        /// </summary>
        /// <param name="path">The file to be opened for writing.</param>
        /// <returns>An unshared System.IO.FileStream object on the specified path with System.IO.FileAccess.Write access.</returns>
        public FileStream OpenWrite(string path)
        {
            return System.IO.File.OpenWrite(path);
        }

        /// <summary>
        /// Opens a binary file, reads the contents of the file into a byte array, and then closes the file.
        /// </summary>
        /// <param name="path">The file to open for reading.</param>
        /// <returns>A byte array containing the contents of the file.</returns>
        public byte[] ReadAllBytes(string path)
        {
            return System.IO.File.ReadAllBytes(path);
        }

        /// <summary>
        /// Opens a text file, reads all lines of the file, and then closes the file.
        /// </summary>
        /// <param name="path">The file to open for reading.</param>
        /// <returns>A string array containing all lines of the file.</returns>
        public string[] ReadAllLines(string path)
        {
            return System.IO.File.ReadAllLines(path);
        }

        /// <summary>
        /// Opens a file, reads all lines of the file with the specified encoding, and then closes the file.
        /// </summary>
        /// <param name="path">The file to open for reading.</param>
        /// <param name="encoding">The encoding applied to the contents of the file.</param>
        /// <returns>A string array containing all lines of the file.</returns>
        public string[] ReadAllLines(string path, Encoding encoding)
        {
            return System.IO.File.ReadAllLines(path, encoding);
        }

        /// <summary>
        /// Opens a text file, reads all lines of the file, and then closes the file.
        /// </summary>
        /// <param name="path">The file to open for reading.</param>
        /// <returns>A string containing all lines of the file.</returns>
        public string ReadAllText(string path)
        {
            return System.IO.File.ReadAllText(path);
        }

        /// <summary>
        /// Opens a file, reads all lines of the file with the specified encoding, and then closes the file.
        /// </summary>
        /// <param name="path">The file to open for reading.</param>
        /// <param name="encoding">The encoding applied to the contents of the file.</param>
        /// <returns>A string containing all lines of the file.</returns>
        public string ReadAllText(string path, Encoding encoding)
        {
            return System.IO.File.ReadAllText(path, encoding);
        }

        /// <summary>
        /// Reads the lines of a file.
        /// </summary>
        /// <param name="path">The file to read.</param>
        /// <returns>All the lines of the file, or the lines that are the result of a query.</returns>
        public IEnumerable<string> ReadLines(string path)
        {
            return System.IO.File.ReadLines(path);
        }

        /// <summary>
        /// Read the lines of a file that has a specified encoding.
        /// </summary>
        /// <param name="path">The file to read.</param>
        /// <param name="encoding">The encoding that is applied to the contents of the file.</param>
        /// <returns>All the lines of the file, or the lines that are the result of a query.</returns>
        public IEnumerable<string> ReadLines(string path, Encoding encoding)
        {
            return System.IO.File.ReadLines(path, encoding);
        }

        /// <summary>
        /// Replaces the contents of a specified file with the contents of another file, deleting the original file, and creating a backup of the replaced file and optionally ignores merge errors.
        /// </summary>
        /// <param name="sourceFileName">The name of a file that replaces the file specified by destinationFileName.</param>
        /// <param name="destinationFileName">The name of the file being replaced.</param>
        /// <param name="destinationBackupFileName">The name of the backup file.</param>
        /// <param name="ignoreMetadataErrors">true to ignore merge errors (such as attributes and access control lists (ACLs)) from the replaced file to the replacement file; otherwise, false.</param>
        public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName, bool ignoreMetadataErrors)
        {
            System.IO.File.Replace(sourceFileName, destinationFileName, destinationBackupFileName, ignoreMetadataErrors);
        }

        /// <summary>
        /// Replaces the contents of a specified file with the contents of another file, deleting the original file, and creating a backup of the replaced file.
        /// </summary>
        /// <param name="sourceFileName">The name of a file that replaces the file specified by destinationFileName.</param>
        /// <param name="destinationFileName">The name of the file being replaced.</param>
        /// <param name="destinationBackupFileName">The name of the backup file.</param>
        public void Replace(string sourceFileName, string destinationFileName, string destinationBackupFileName)
        {
            System.IO.File.Replace(sourceFileName, destinationFileName, destinationBackupFileName);
        }

        /// <summary>
        /// Sets the specified System.IO.FileAttributes of the file on the specified path.
        /// </summary>
        /// <param name="path">The path to the file.</param>
        /// <param name="fileAttributes"A bitwise combination of the enumeration values.></param>
        public void SetAttributes(string path, FileAttributes fileAttributes)
        {
            System.IO.File.SetAttributes(path, fileAttributes);
        }

        /// <summary>
        /// Sets the date and time the file was created.
        /// </summary>
        /// <param name="path">The file for which to set the creation date and time information.</param>
        /// <param name="creationTime">A System.DateTime containing the value to set for the creation date and time of path. This value is expressed in local time.</param>
        public void SetCreationTime(string path, DateTime creationTime)
        {
            System.IO.File.SetCreationTime(path, creationTime);
        }

        /// <summary>
        /// Sets the date and time, in coordinated universal time (UTC), that the file was created.
        /// </summary>
        /// <param name="path">The file for which to set the creation date and time information.</param>
        /// <param name="creationTimeUtc">A System.DateTime containing the value to set for the creation date and time of path. This value is expressed in UTC time.</param>
        public void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
        {
            System.IO.File.SetCreationTimeUtc(path, creationTimeUtc);
        }

        /// <summary>
        /// Sets the date and time the specified file was last accessed.
        /// </summary>
        /// <param name="path">The file for which to set the access date and time information.</param>
        /// <param name="lastAccessTime">A System.DateTime containing the value to set for the last access date and time of path. This value is expressed in local time.</param>
        public void SetLastAccessTime(string path, DateTime lastAccessTime)
        {
            System.IO.File.SetLastAccessTime(path, lastAccessTime);
        }

        /// <summary>
        /// Sets the date and time, in coordinated universal time (UTC), that the specified file was last accessed.
        /// </summary>
        /// <param name="path">The file for which to set the access date and time information.</param>
        /// <param name="lastAccessTimeUtc">A System.DateTime containing the value to set for the last access date and time of path. This value is expressed in UTC time.</param>
        public void SetLastAccessTimeUtc(string path, DateTime lastAccessTimeUtc)
        {
            System.IO.File.SetLastAccessTimeUtc(path, lastAccessTimeUtc);
        }

        /// <summary>
        /// Sets the date and time that the specified file was last written to.
        /// </summary>
        /// <param name="path">The file for which to set the date and time information.</param>
        /// <param name="lastWriteTime">A System.DateTime containing the value to set for the last write date and time of path. This value is expressed in local time.</param>
        public void SetLastWriteTime(string path, DateTime lastWriteTime)
        {
            System.IO.File.SetLastWriteTime(path, lastWriteTime);
        }

        /// <summary>
        /// Sets the date and time, in coordinated universal time (UTC), that the specified file was last written to.
        /// </summary>
        /// <param name="path">The file for which to set the date and time information.</param>
        /// <param name="lastWriteTimeUtc">A System.DateTime containing the value to set for the last write date and time of path. This value is expressed in UTC time.</param>
        public void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        {
            System.IO.File.SetLastWriteTimeUtc(path, lastWriteTimeUtc);
        }

        /// <summary>
        /// Creates a new file, writes the specified byte array to the file, and then closes the file. If the target file already exists, it is overwritten.
        /// </summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="bytes">The bytes to write to the file.</param>
        public void WriteAllBytes(string path, byte[] bytes)
        {
            System.IO.File.WriteAllBytes(path, bytes);
        }

        /// <summary>
        /// Creates a new file, writes a collection of strings to the file, and then closes the file.
        /// </summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="contents">The lines to write to the file.</param>
        public void WriteAllLines(string path, IEnumerable<string> contents)
        {
            System.IO.File.WriteAllLines(path, contents);
        }

        /// <summary>
        /// Creates a new file by using the specified encoding, writes a collection of strings to the file, and then closes the file.
        /// </summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="contents">The lines to write to the file.</param>
        /// <param name="encoding">The character encoding to use.</param>
        public void WriteAllLines(string path, IEnumerable<string> contents, Encoding encoding)
        {
            System.IO.File.WriteAllLines(path, contents, encoding);
        }

        /// <summary>
        /// Creates a new file, write the specified string array to the file, and then closes the file.
        /// </summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="contents">The string array to write to the file.</param>
        public void WriteAllLines(string path, string[] contents)
        {
            System.IO.File.WriteAllLines(path, contents);
        }

        /// <summary>
        /// Creates a new file, writes the specified string array to the file by using the specified encoding, and then closes the file.
        /// </summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="contents">The string array to write to the file.</param>
        /// <param name="encoding">An System.Text.Encoding object that represents the character encoding applied to the string array.</param>
        public void WriteAllLines(string path, string[] contents, Encoding encoding)
        {
            System.IO.File.WriteAllLines(path, contents, encoding);
        }

        /// <summary>
        /// Creates a new file, writes the specified string to the file, and then closes the file. If the target file already exists, it is overwritten.
        /// </summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="contents">The string to write to the file.</param>
        public void WriteAllText(string path, string contents)
        {
            System.IO.File.WriteAllText(path, contents);
        }

        /// <summary>
        /// Creates a new file, writes the specified string to the file using the specified encoding, and then closes the file. If the target file already exists, it is overwritten.
        /// </summary>
        /// <param name="path">The file to write to.</param>
        /// <param name="contents">The string to write to the file.</param>
        /// <param name="encoding">The encoding to apply to the string.</param>
        public void WriteAllText(string path, string contents, Encoding encoding)
        {
            System.IO.File.WriteAllText(path, contents, encoding);
        }
    }
}
