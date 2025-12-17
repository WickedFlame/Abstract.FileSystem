using System.IO;

namespace Abstract.FileSystem.Test
{
    public class DirectoryTests
    {
        private Mock<IDirectoryService> _service;

        [SetUp]
        public void Setup ()
        {
            _service = new Mock<IDirectoryService>();
            Directory.Setup(() => _service.Object);
        }

        [Test]
        public void Directory_CreateDirectory()
        {
            Directory.CreateDirectory("path");
            _service.Verify(x => x.CreateDirectory("path"), Times.Once());
        }

        [Test]
        public void Directory_Delete()
        {
            Directory.Delete("path");
            _service.Verify(x => x.Delete("path"), Times.Once());
        }

        [Test]
        public void Directory_Delete_Recursive()
        {
            Directory.Delete("path", true);
            _service.Verify(x => x.Delete("path", true), Times.Once());
        }

        [Test]
        public void Directory_EnumerateDirectories()
        {
            Directory.EnumerateDirectories("path");
            _service.Verify(x => x.EnumerateDirectories("path"), Times.Once());
        }

        [Test]
        public void Directory_EnumerateDirectories_Pattern()
        {
            Directory.EnumerateDirectories("path", "pattern");
            _service.Verify(x => x.EnumerateDirectories("path", "pattern"), Times.Once());
        }

        [Test]
        public void Directory_EnumerateDirectories_Pattern_Option()
        {
            Directory.EnumerateDirectories("path", "pattern", SearchOption.AllDirectories);
            _service.Verify(x => x.EnumerateDirectories("path", "pattern", SearchOption.AllDirectories), Times.Once());
        }

        [Test]
        public void Directory_EnumerateFiles()
        {
            Directory.EnumerateFiles("path");
            _service.Verify(x => x.EnumerateFiles("path"), Times.Once());
        }

        [Test]
        public void Directory_EnumerateFiles_Pattern()
        {
            Directory.EnumerateFiles("path", "pattern");
            _service.Verify(x => x.EnumerateFiles("path", "pattern"), Times.Once());
        }

        [Test]
        public void Directory_EnumerateFiles_Pattern_Option()
        {
            Directory.EnumerateFiles("path", "pattern", SearchOption.AllDirectories);
            _service.Verify(x => x.EnumerateFiles("path", "pattern", SearchOption.AllDirectories), Times.Once());
        }

        [Test]
        public void Directory_EnumerateFileSystemEntries_Pattern_Option()
        {
            Directory.EnumerateFileSystemEntries("path", "pattern", SearchOption.AllDirectories);
            _service.Verify(x => x.EnumerateFileSystemEntries("path", "pattern", SearchOption.AllDirectories), Times.Once());
        }

        [Test]
        public void Directory_EnumerateFileSystemEntries()
        {
            Directory.EnumerateFileSystemEntries("path");
            _service.Verify(x => x.EnumerateFileSystemEntries("path"), Times.Once());
        }

        [Test]
        public void Directory_EnumerateFileSystemEntries_Pattern()
        {
            Directory.EnumerateFileSystemEntries("path", "pattern");
            _service.Verify(x => x.EnumerateFileSystemEntries("path", "pattern"), Times.Once());
        }

        [Test]
        public void Directory_Exists()
        {
            Directory.Exists("path");
            _service.Verify(x => x.Exists("path"), Times.Once());
        }

        [Test]
        public void Directory_GetCreationTime()
        {
            Directory.GetCreationTime("path");
            _service.Verify(x => x.GetCreationTime("path"), Times.Once());
        }

        [Test]
        public void Directory_GetCreationTimeUtc()
        {
            Directory.GetCreationTimeUtc("path");
            _service.Verify(x => x.GetCreationTimeUtc("path"), Times.Once());
        }

        [Test]
        public void Directory_GetCurrentDirectory()
        {
            Directory.GetCurrentDirectory();
            _service.Verify(x => x.GetCurrentDirectory(), Times.Once());
        }

        [Test]
        public void Directory_GetDirectories_Pattern()
        {
            Directory.GetDirectories("path", "pattern");
            _service.Verify(x => x.GetDirectories("path", "pattern"), Times.Once());
        }

        [Test]
        public void Directory_GetDirectories()
        {
            Directory.GetDirectories("path");
            _service.Verify(x => x.GetDirectories("path"), Times.Once());
        }

        [Test]
        public void Directory_GetDirectories_Pattern_Options()
        {
            Directory.GetDirectories("path", "pattern", SearchOption.AllDirectories);
            _service.Verify(x => x.GetDirectories("path", "pattern", SearchOption.AllDirectories), Times.Once());
        }

        [Test]
        public void Directory_GetDirectoryRoot()
        {
            Directory.GetDirectoryRoot("path");
            _service.Verify(x => x.GetDirectoryRoot("path"), Times.Once());
        }

        [Test]
        public void Directory_GetFiles()
        {
            Directory.GetFiles("path");
            _service.Verify(x => x.GetFiles("path"), Times.Once());
        }

        [Test]
        public void Directory_GetFiles_Pattern()
        {
            Directory.GetFiles("path", "pattern");
            _service.Verify(x => x.GetFiles("path", "pattern"), Times.Once());
        }

        [Test]
        public void Directory_GetFiles_Pattern_Options()
        {
            Directory.GetFiles("path", "pattern", SearchOption.AllDirectories);
            _service.Verify(x => x.GetFiles("path", "pattern", SearchOption.AllDirectories), Times.Once());
        }

        [Test]
        public void Directory_GetFileSystemEntries()
        {
            Directory.GetFileSystemEntries("path");
            _service.Verify(x => x.GetFileSystemEntries("path"), Times.Once());
        }

        [Test]
        public void Directory_GetFileSystemEntries_Pattern()
        {
            Directory.GetFileSystemEntries("path", "pattern");
            _service.Verify(x => x.GetFileSystemEntries("path", "pattern"), Times.Once());
        }

        [Test]
        public void Directory_GetFileSystemEntries_Pattern_Options()
        {
            Directory.GetFileSystemEntries("path", "pattern", SearchOption.AllDirectories);
            _service.Verify(x => x.GetFileSystemEntries("path", "pattern", SearchOption.AllDirectories), Times.Once());
        }

        [Test]
        public void Directory_GetLastAccessTime()
        {
            Directory.GetLastAccessTime("path");
            _service.Verify(x => x.GetLastAccessTime("path"), Times.Once());
        }

        [Test]
        public void Directory_GetLastAccessTimeUtc()
        {
            Directory.GetLastAccessTimeUtc("path");
            _service.Verify(x => x.GetLastAccessTimeUtc("path"), Times.Once());
        }

        [Test]
        public void Directory_GetLastWriteTime()
        {
            Directory.GetLastWriteTime("path");
            _service.Verify(x => x.GetLastWriteTime("path"), Times.Once());
        }

        [Test]
        public void Directory_GetLastWriteTimeUtc()
        {
            Directory.GetLastWriteTimeUtc("path");
            _service.Verify(x => x.GetLastWriteTimeUtc("path"), Times.Once());
        }

        [Test]
        public void Directory_GetLogicalDrives()
        {
            Directory.GetLogicalDrives();
            _service.Verify(x => x.GetLogicalDrives(), Times.Once());
        }

        [Test]
        public void Directory_GetParent()
        {
            Directory.GetParent("path");
            _service.Verify(x => x.GetParent("path"), Times.Once());
        }

        [Test]
        public void Directory_Move()
        {
            Directory.Move("source", "desination");
            _service.Verify(x => x.Move("source", "desination"), Times.Once());
        }

        [Test]
        public void Directory_SetCreationTime()
        {
            Directory.SetCreationTime("source", DateTime.MinValue);
            _service.Verify(x => x.SetCreationTime("source", DateTime.MinValue), Times.Once());
        }

        [Test]
        public void Directory_SetCreationTimeUtc()
        {
            Directory.SetCreationTimeUtc("source", DateTime.MinValue);
            _service.Verify(x => x.SetCreationTimeUtc("source", DateTime.MinValue), Times.Once());
        }

        [Test]
        public void Directory_SetCurrentDirectory()
        {
            Directory.SetCurrentDirectory("path");
            _service.Verify(x => x.SetCurrentDirectory("path"), Times.Once());
        }

        [Test]
        public void Directory_SetLastAccessTime()
        {
            Directory.SetLastAccessTime("path", DateTime.MinValue);
            _service.Verify(x => x.SetLastAccessTime("path", DateTime.MinValue), Times.Once());
        }

        [Test]
        public void Directory_SetLastAccessTimeUtc()
        {
            Directory.SetLastAccessTimeUtc("path", DateTime.MinValue);
            _service.Verify(x => x.SetLastAccessTimeUtc("path", DateTime.MinValue), Times.Once());
        }

        [Test]
        public void Directory_SetLastWriteTime()
        {
            Directory.SetLastWriteTime("path", DateTime.MinValue);
            _service.Verify(x => x.SetLastWriteTime("path", DateTime.MinValue), Times.Once());
        }

        [Test]
        public void Directory_SetLastWriteTimeUtc()
        {
            Directory.SetLastWriteTimeUtc("path", DateTime.MinValue);
            _service.Verify(x => x.SetLastWriteTimeUtc("path", DateTime.MinValue), Times.Once());
        }
    }
}
