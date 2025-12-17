namespace Abstract.FileSystem.Test
{
    public class PathTests
    {
        private Mock<IPathService> _service;

        [SetUp]
        public void Setup()
        {
            _service = new Mock<IPathService>();
            Path.Setup(() => _service.Object);
        }

        [Test]
        public void Path_ChangeExtension()
        {
            Path.ChangeExtension("path", "extension");
            _service.Verify(x => x.ChangeExtension("path", "extension"), Times.Once());
        }

        [Test]
        public void Path_Combine()
        {
            Path.Combine("path", "path2");
            _service.Verify(x => x.Combine("path", "path2"), Times.Once());
        }

        [Test]
        public void Path_Combine_3()
        {
            Path.Combine("path", "path2", "path3");
            _service.Verify(x => x.Combine("path", "path2", "path3"), Times.Once());
        }

        [Test]
        public void Path_Combine_4()
        {
            Path.Combine("path", "path2", "path3", "path4");
            _service.Verify(x => x.Combine("path", "path2", "path3", "path4"), Times.Once());
        }

        [Test]
        public void Path_Combine_Array()
        {
            Path.Combine(new string[] { "path", "path2", "path3", "path4" });
            _service.Verify(x => x.Combine(It.IsAny<string[]>()), Times.Once());
        }

        [Test]
        public void Path_GetDirectoryName()
        {
            Path.GetDirectoryName("path");
            _service.Verify(x => x.GetDirectoryName("path"), Times.Once());
        }

        [Test]
        public void Path_GetExtension()
        {
            Path.GetExtension("path");
            _service.Verify(x => x.GetExtension("path"), Times.Once());
        }

        [Test]
        public void Path_GetFileName()
        {
            Path.GetFileName("path");
            _service.Verify(x => x.GetFileName("path"), Times.Once());
        }

        [Test]
        public void Path_GetFileNameWithoutExtension()
        {
            Path.GetFileNameWithoutExtension("path");
            _service.Verify(x => x.GetFileNameWithoutExtension("path"), Times.Once());
        }

        [Test]
        public void Path_GetFullPath()
        {
            Path.GetFullPath("path");
            _service.Verify(x => x.GetFullPath("path"), Times.Once());
        }

        [Test]
        public void Path_GetInvalidFileNameChars()
        {
            Path.GetInvalidFileNameChars();
            _service.Verify(x => x.GetInvalidFileNameChars(), Times.Once());
        }

        [Test]
        public void Path_GetInvalidPathChars()
        {
            Path.GetInvalidPathChars();
            _service.Verify(x => x.GetInvalidPathChars(), Times.Once());
        }

        [Test]
        public void Path_GetPathRoot()
        {
            Path.GetPathRoot("path");
            _service.Verify(x => x.GetPathRoot("path"), Times.Once());
        }

        [Test]
        public void Path_GetRandomFileName()
        {
            Path.GetRandomFileName();
            _service.Verify(x => x.GetRandomFileName(), Times.Once());
        }

        [Test]
        public void Path_GetTempFileName()
        {
            Path.GetTempFileName();
            _service.Verify(x => x.GetTempFileName(), Times.Once());
        }

        [Test]
        public void Path_GetTempPath()
        {
            Path.GetTempPath();
            _service.Verify(x => x.GetTempPath(), Times.Once());
        }

        [Test]
        public void Path_HasExtension()
        {
            Path.HasExtension("path");
            _service.Verify(x => x.HasExtension("path"), Times.Once());
        }

        [Test]
        public void Path_IsPathRooted()
        {
            Path.IsPathRooted("path");
            _service.Verify(x => x.IsPathRooted("path"), Times.Once());
        }
    }
}
