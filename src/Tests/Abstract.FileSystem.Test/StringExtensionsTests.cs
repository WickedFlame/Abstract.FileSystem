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
    }
}
