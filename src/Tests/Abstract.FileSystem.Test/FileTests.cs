using Moq;
using System.Text;

namespace Abstract.FileSystem.Test
{
    public class FileTests
    {
        private Mock<IFileService> _service;

        [SetUp]
        public void Setup()
        {
            _service = new Mock<IFileService>();
            File.Setup(() => _service.Object);
        }

        [Test]
        public void File_AppendAllLines()
        {
            File.AppendAllLines("path", new[] { "test" });
            _service.Verify(x => x.AppendAllLines("path", It.IsAny<IEnumerable<string>>()), Times.Once());
        }

        [Test]
        public void File_AppendAllLines_Encoding()
        {
            File.AppendAllLines("path", new[] { "test" }, Encoding.UTF8);
            _service.Verify(x => x.AppendAllLines("path", It.IsAny<IEnumerable<string>>(), Encoding.UTF8), Times.Once());
        }

        [Test]
        public void File_AppendAllText()
        {
            File.AppendAllText("path", "content");
            _service.Verify(x => x.AppendAllText("path", "content"), Times.Once());
        }

        [Test]
        public void File_AppendAllText_Encoding()
        {
            File.AppendAllText("path", "content", Encoding.UTF8);
            _service.Verify(x => x.AppendAllText("path", "content", Encoding.UTF8), Times.Once());
        }

        [Test]
        public void File_AppendText()
        {
            File.AppendText("text");
            _service.Verify(x => x.AppendText("text"), Times.Once());
        }

        [Test]
        public void File_Copy()
        {
            File.Copy("source", "destination");
            _service.Verify(x => x.Copy("source", "destination"), Times.Once());
        }

        [Test]
        public void File_Copy_Overwrite()
        {
            File.Copy("source", "destination", true);
            _service.Verify(x => x.Copy("source", "destination", true), Times.Once());
        }

        [Test]
        public void File_Create()
        {
            File.Create("path");
            _service.Verify(x => x.Create("path"), Times.Once());
        }

        [Test]
        public void File_Create_BufferSize()
        {
            File.Create("path", 10);
            _service.Verify(x => x.Create("path", 10), Times.Once());
        }

        [Test]
        public void File_Create_BufferSize_Options()
        {
            File.Create("path", 10, FileOptions.Encrypted);
            _service.Verify(x => x.Create("path", 10, FileOptions.Encrypted), Times.Once());
        }

        [Test]
        public void File_CreateText()
        {
            File.CreateText("path");
            _service.Verify(x => x.CreateText("path"), Times.Once());
        }

        [Test]
        public void File_Decrypt()
        {
            File.Decrypt("path");
            _service.Verify(x => x.Decrypt("path"), Times.Once());
        }

        [Test]
        public void File_Delete()
        {
            File.Delete("path");
            _service.Verify(x => x.Delete("path"), Times.Once());
        }

        [Test]
        public void File_Encrypt()
        {
            File.Encrypt("path");
            _service.Verify(x => x.Encrypt("path"), Times.Once());
        }

        [Test]
        public void File_Exists()
        {
            File.Exists("path");
            _service.Verify(x => x.Exists("path"), Times.Once());
        }

        [Test]
        public void File_GetAttributes()
        {
            File.GetAttributes("path");
            _service.Verify(x => x.GetAttributes("path"), Times.Once());
        }

        [Test]
        public void File_GetCreationTime()
        {
            File.GetCreationTime("path");
            _service.Verify(x => x.GetCreationTime("path"), Times.Once());
        }

        [Test]
        public void File_GetCreationTimeUtc()
        {
            File.GetCreationTimeUtc("path");
            _service.Verify(x => x.GetCreationTimeUtc("path"), Times.Once());
        }

        [Test]
        public void File_GetLastAccessTime()
        {
            File.GetLastAccessTime("path");
            _service.Verify(x => x.GetLastAccessTime("path"), Times.Once());
        }

        [Test]
        public void File_GetLastAccessTimeUtc()
        {
            File.GetLastAccessTimeUtc("path");
            _service.Verify(x => x.GetLastAccessTimeUtc("path"), Times.Once());
        }

        [Test]
        public void File_GetLastWriteTime()
        {
            File.GetLastWriteTime("path");
            _service.Verify(x => x.GetLastWriteTime("path"), Times.Once());
        }

        [Test]
        public void File_GetLastWriteTimeUtc()
        {
            File.GetLastWriteTimeUtc("path");
            _service.Verify(x => x.GetLastWriteTimeUtc("path"), Times.Once());
        }

        [Test]
        public void File_Move()
        {
            File.Move("path", "dest");
            _service.Verify(x => x.Move("path", "dest"), Times.Once());
        }

        [Test]
        public void File_Open()
        {
            File.Open("path", FileMode.Open, FileAccess.Read);
            _service.Verify(x => x.Open("path", FileMode.Open, FileAccess.Read), Times.Once());
        }

        [Test]
        public void File_Open_Share()
        {
            File.Open("path", FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            _service.Verify(x => x.Open("path", FileMode.Open, FileAccess.Read, FileShare.ReadWrite), Times.Once());
        }

        [Test]
        public void File_Open_FileMode()
        {
            File.Open("path", FileMode.Open);
            _service.Verify(x => x.Open("path", FileMode.Open), Times.Once());
        }

        [Test]
        public void File_OpenRead()
        {
            File.OpenRead("path");
            _service.Verify(x => x.OpenRead("path"), Times.Once());
        }

        [Test]
        public void File_OpenText()
        {
            File.OpenText("path");
            _service.Verify(x => x.OpenText("path"), Times.Once());
        }

        [Test]
        public void File_OpenWrite()
        {
            File.OpenWrite("path");
            _service.Verify(x => x.OpenWrite("path"), Times.Once());
        }

        [Test]
        public void File_ReadAllBytes()
        {
            File.ReadAllBytes("path");
            _service.Verify(x => x.ReadAllBytes("path"), Times.Once());
        }

        [Test]
        public void File_ReadAllLines()
        {
            File.ReadAllLines("path");
            _service.Verify(x => x.ReadAllLines("path"), Times.Once());
        }

        [Test]
        public void File_ReadAllLines_Encoding()
        {
            File.ReadAllLines("path", Encoding.UTF8);
            _service.Verify(x => x.ReadAllLines("path", Encoding.UTF8), Times.Once());
        }

        [Test]
        public void File_ReadAllText()
        {
            File.ReadAllText("path");
            _service.Verify(x => x.ReadAllText("path"), Times.Once());
        }

        [Test]
        public void File_ReadAllText_Encoding()
        {
            File.ReadAllText("path", Encoding.UTF8);
            _service.Verify(x => x.ReadAllText("path", Encoding.UTF8), Times.Once());
        }

        [Test]
        public void File_ReadLines()
        {
            File.ReadLines("path");
            _service.Verify(x => x.ReadLines("path"), Times.Once());
        }

        [Test]
        public void File_ReadLines_Encoding()
        {
            File.ReadLines("path", Encoding.UTF8);
            _service.Verify(x => x.ReadLines("path", Encoding.UTF8), Times.Once());
        }

        [Test]
        public void File_Replace_Dest_Backup_Ignore()
        {
            File.Replace("path", "destination", "backup", false);
            _service.Verify(x => x.Replace("path", "destination", "backup", false), Times.Once());
        }

        [Test]
        public void File_Replace_Dest_Backup()
        {
            File.Replace("path", "destination", "backup");
            _service.Verify(x => x.Replace("path", "destination", "backup"), Times.Once());
        }

        [Test]
        public void File_SetAttributes()
        {
            File.SetAttributes("path", FileAttributes.Normal);
            _service.Verify(x => x.SetAttributes("path", FileAttributes.Normal), Times.Once());
        }

        [Test]
        public void File_SetCreationTime()
        {
            File.SetCreationTime("path", DateTime.MinValue);
            _service.Verify(x => x.SetCreationTime("path", DateTime.MinValue), Times.Once());
        }

        [Test]
        public void File_SetCreationTimeUtc()
        {
            File.SetCreationTimeUtc("path", DateTime.MinValue);
            _service.Verify(x => x.SetCreationTimeUtc("path", DateTime.MinValue), Times.Once());
        }

        [Test]
        public void File_SetLastAccessTime()
        {
            File.SetLastAccessTime("path", DateTime.MinValue);
            _service.Verify(x => x.SetLastAccessTime("path", DateTime.MinValue), Times.Once());
        }

        [Test]
        public void File_SetLastAccessTimeUtc()
        {
            File.SetLastAccessTimeUtc("path", DateTime.MinValue);
            _service.Verify(x => x.SetLastAccessTimeUtc("path", DateTime.MinValue), Times.Once());
        }

        [Test]
        public void File_SetLastWriteTime()
        {
            File.SetLastWriteTime("path", DateTime.MinValue);
            _service.Verify(x => x.SetLastWriteTime("path", DateTime.MinValue), Times.Once());
        }

        [Test]
        public void File_SetLastWriteTimeUtc()
        {
            File.SetLastWriteTimeUtc("path", DateTime.MinValue);
            _service.Verify(x => x.SetLastWriteTimeUtc("path", DateTime.MinValue), Times.Once());
        }

        [Test]
        public void File_WriteAllBytes()
        {
            File.WriteAllBytes("path", new byte[0]);
            _service.Verify(x => x.WriteAllBytes("path", new byte[0]), Times.Once());
        }

        [Test]
        public void File_WriteAllLines()
        {
            File.WriteAllLines("path", Enumerable.Empty<string>());
            _service.Verify(x => x.WriteAllLines("path", Enumerable.Empty<string>()), Times.Once());
        }

        [Test]
        public void File_WriteAllLines_Encoding()
        {
            File.WriteAllLines("path", Enumerable.Empty<string>(), Encoding.UTF8);
            _service.Verify(x => x.WriteAllLines("path", Enumerable.Empty<string>(), Encoding.UTF8), Times.Once());
        }

        [Test]
        public void File_WriteAllLines_Array()
        {
            File.WriteAllLines("path", new string[0]);
            _service.Verify(x => x.WriteAllLines("path", It.IsAny<string[]>()), Times.Once());
        }

        [Test]
        public void File_WriteAllLines_Array_Encoding()
        {
            File.WriteAllLines("path", new string[0], Encoding.UTF8);
            _service.Verify(x => x.WriteAllLines("path", It.IsAny<string[]>(), Encoding.UTF8), Times.Once());
        }

        [Test]
        public void File_WriteAllText()
        {
            File.WriteAllText("path", string.Empty);
            _service.Verify(x => x.WriteAllText("path", It.IsAny<string>()), Times.Once());
        }

        [Test]
        public void File_WriteAllText_Encoding()
        {
            File.WriteAllText("path", string.Empty, Encoding.UTF8);
            _service.Verify(x => x.WriteAllText("path", It.IsAny<string>(), Encoding.UTF8), Times.Once());
        }
    }
}