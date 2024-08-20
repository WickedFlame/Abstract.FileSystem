using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.FileSystem.Test
{
    public class StringExtensionsTests
    {
        [Test]
        public void StringExtensions_RemoveLeadingSlash_Slash()
        {
            "/test/leading/".RemoveLeadingSlash().Should().Be("test/leading/");
        }

        [Test]
        public void StringExtensions_RemoveLeadingSlash_Backslash()
        {
            "\\test\\leading\\".RemoveLeadingSlash().Should().Be("test\\leading\\");
        }

        [Test]
        public void StringExtensions_RemoveTrailingSlash_Slash()
        {
            "/test/leading/".RemoveTrailingSlash().Should().Be("/test/leading");
        }

        [Test]
        public void StringExtensions_RemoveTrailingSlash_Backslash()
        {
            "\\test\\leading\\".RemoveTrailingSlash().Should().Be("\\test\\leading");
        }





        [Test]
        public void StringExtensions_EnsureLeadingSlash_Backslash()
        {
            "test\\leading\\".EnsureLeadingSlash().Should().Be("\\test\\leading\\");
        }

        [Test]
        public void StringExtensions_EnsureLeadingSlash_Slash()
        {
            "test/leading/".EnsureLeadingSlash().Should().Be("/test/leading/");
        }

        [Test]
        public void StringExtensions_EnsureLeadingSlash_Backslash_Ok()
        {
            "\\test\\leading\\".EnsureLeadingSlash().Should().Be("\\test\\leading\\");
        }

        [Test]
        public void StringExtensions_EnsureLeadingSlash_Slash_Ok()
        {
            "/test/leading/".EnsureLeadingSlash().Should().Be("/test/leading/");
        }

        [Test]
        public void StringExtensions_EnsureLeadingSlash_Mix_Backslash()
        {
            "test\\leading/".EnsureLeadingSlash().Should().Be("\\test\\leading/");
        }

        [Test]
        public void StringExtensions_EnsureLeadingSlash_Mix_Slash()
        {
            "test/leading\\".EnsureLeadingSlash().Should().Be("/test/leading\\");
        }

        [Test]
        public void StringExtensions_EnsureLeadingSlash_System()
        {
            var separator = SystemPath.OsType == OsType.Unix ? "/" : "\\";
            $"test".EnsureLeadingSlash().Should().Be($"{separator}test");
        }

        [Test]
        public void StringExtensions_EnsureLeadingSlash_Null()
        {
            ((string)null).EnsureLeadingSlash().Should().BeNull();
        }





        [Test]
        public void StringExtensions_EnsureTrailingSlash_Backslash()
        {
            "\\test\\leading".EnsureTrailingSlash().Should().Be("\\test\\leading\\");
        }

        [Test]
        public void StringExtensions_EnsureTrailingSlash_Slash()
        {
            "/test/leading".EnsureTrailingSlash().Should().Be("/test/leading/");
        }

        [Test]
        public void StringExtensions_EnsureTrailingSlash_Backslash_Ok()
        {
            "\\test\\leading\\".EnsureTrailingSlash().Should().Be("\\test\\leading\\");
        }

        [Test]
        public void StringExtensions_EnsureTrailingSlash_Slash_Ok()
        {
            "/test/leading/".EnsureTrailingSlash().Should().Be("/test/leading/");
        }

        [Test]
        public void StringExtensions_EnsureTrailingSlash_Mix_Backslash()
        {
            "\\test/leading".EnsureTrailingSlash().Should().Be("\\test/leading/");
        }

        [Test]
        public void StringExtensions_EnsureTrailingSlash_Mix_Slash()
        {
            "/test\\leading".EnsureTrailingSlash().Should().Be("/test\\leading\\");
        }

        [Test]
        public void StringExtensions_EnsureTrailingSlash_System()
        {
            var separator = SystemPath.OsType == OsType.Unix ? "/" : "\\";
            $"test".EnsureTrailingSlash().Should().Be($"test{separator}");
        }

        [Test]
        public void StringExtensions_EnsureTrailingSlash_Null()
        {
            ((string) null).EnsureTrailingSlash().Should().BeNull();
        }

        [TestCase("c:\\test", true)]
        [TestCase("C:\\test\\case.exe", true)]
        [TestCase("\\\\test\\case", true)]
        [TestCase("\\test\\case.exe", false)]
        [TestCase("test\\case.exe", false)]
        [TestCase("", false)]
        [TestCase((string)null, false)]
        public void StringExtensions_IsAbslolutePath_Windows(string path, bool expected)
        {
            if (SystemPath.OsType == OsType.Unix)
            {
                throw new IgnoreException("Test is only for a Windows System");
            }

            path.IsAbslolutePath().Should().Be(expected);
        }

        [TestCase("", false)]
        [TestCase((string) null, false)]
        [TestCase("/test/case.exe", true)]
        [TestCase("test/case.exe", false)]
        public void StringExtensions_IsAbslolutePath_Unix(string path, bool expected)
        {
            if (SystemPath.OsType == OsType.Windows)
            {
                throw new IgnoreException("Test is only for a Unix System");
            }

            path.IsAbslolutePath().Should().Be(expected);
        }

        [Test]
        public void StringExtensions_IsAbslolutePath_Windows_Null()
        {
            if (SystemPath.OsType == OsType.Unix)
            {
                throw new IgnoreException("Test is only for a Windows System");
            }

            ((string)null).IsAbslolutePath().Should().Be(false);
        }

        [Test]
        public void StringExtensions_IsAbslolutePath_Unix_Null()
        {
            if (SystemPath.OsType == OsType.Windows)
            {
                throw new IgnoreException("Test is only for a Unix System");
            }

            ((string) null).IsAbslolutePath().Should().Be(false);
        }
    }
}
