using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract.FileSystem.Test
{
    public class SystemPathTests
    {
        [Test]
        public void SystemPath_Create()
        {
            var path = new SystemPath("path\\to\\file.txt");
            path.ToString().Should().Be("path\\to\\file.txt".FormatPath());
        }

        [Test]
        public void SystemPath_From_String()
        {
            var path = (SystemPath)"path\\to\\file.txt";
            path.ToString().Should().Be("path\\to\\file.txt".FormatPath());
        }

        [Test]
        public void SystemPath_From_String_Null()
        {
            ((SystemPath)((string)null)).Should().BeNull();
        }

        [Test]
        public void SystemPath_From_String_Slash()
        {
            var path = (SystemPath)"path" / "to" / "file.txt";
            path.ToString().Should().Be("path\\to\\file.txt".FormatPath());
        }

        [Test]
        public void SystemPath_From_String_Plus()
        {
            var path = new SystemPath("path") + "to";
            path.ToString().Should().Be("pathto".FormatPath());
        }

        [Test]
        public void SystemPath_Cast_To_String()
        {
            var path = new SystemPath("path\\to\\file.txt");
            ((string)path).Should().Be("path\\to\\file.txt".FormatPath());
        }

        [Test]
        public void SystemPath_Combine()
        {
            var path = SystemPath.Combine(new SystemPath("path"), new[] { "to", "file.txt" });
            path.ToString().Should().Be("path\\to\\file.txt".FormatPath());
        }

        [Test]
        public void SystemPath_Equals()
        {
            new SystemPath("path\\to\\file.txt").Equals(new SystemPath("path\\to\\file.txt")).Should().BeTrue();
        }

        [Test]
        public void SystemPath_Equals_False()
        {
            new SystemPath("path\\to\\file.txt").Equals(new SystemPath("invalid\\path\\to\\file.txt")).Should().BeFalse();
        }

        [Test]
        public void SystemPath_Equals_String()
        {
            new SystemPath("path\\to\\file.txt").Equals("path\\to\\file.txt".FormatPath()).Should().BeTrue();
        }

        [Test]
        public void SystemPath_Equals_String_False()
        {
            new SystemPath("path\\to\\file.txt").Equals("invalid\\path\\to\\file.txt".FormatPath()).Should().BeFalse();
        }

        [Test]
        public void SystemPath_Equals_InvalidType()
        {
            new SystemPath("path\\to\\file.txt").Equals(5).Should().BeFalse();
        }

        [Test]
        public void SystemPath_Equals_Operator()
        {
            (new SystemPath("path\\to\\file.txt") == new SystemPath("path\\to\\file.txt")).Should().BeTrue();
        }

        [Test]
        public void SystemPath_Equals_Operator_False()
        {
            (new SystemPath("path\\to\\file.txt") == new SystemPath("invalid\\path\\to\\file.txt")).Should().BeFalse();
        }

        [Test]
        public void SystemPath_Unequals_Operator()
        {
            (new SystemPath("path\\to\\file.txt") != new SystemPath("invalid\\path\\to\\file.txt")).Should().BeTrue();
        }

        [Test]
        public void SystemPath_unequals_Operator_False()
        {
            (new SystemPath("path\\to\\file.txt") != new SystemPath("path\\to\\file.txt")).Should().BeFalse();
        }
    }
}
