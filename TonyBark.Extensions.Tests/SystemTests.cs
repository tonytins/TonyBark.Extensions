// This project is licensed under the MIT license.
// See the LICENSE file in the project root for more information.
using System;
using Xunit;

namespace TonyBark.Extensions.Tests
{
    public class SystemTests
    {
        [Fact]
        public void HumanEraDT()
        {
            var actual = DateTime.Now.GetHoloceneYear();
            var expected = int.Parse($"{1}{DateTime.Now.Year}");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void HumanEraDTO()
        {
            var actual = DateTimeOffset.Now.GetHoloceneYear();
            var expected = int.Parse($"{1}{DateTimeOffset.Now.Year}");
            Assert.Equal(expected, actual);
        }
    }
}
