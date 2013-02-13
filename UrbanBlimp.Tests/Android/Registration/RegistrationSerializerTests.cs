using System.Collections.Generic;
using NUnit.Framework;
using UrbanBlimp.Android;

namespace UrbanBlimp.Tests.Android
{
    [TestFixture]
    public class RegistrationSerializerTests
    {
        [Test]
        public void Single2()
        {
            var registration = new AddRegistrationRequest
            {
                Alias = "alias",
                Tags = new List<string> { "tag1", "tag2" },
            };
            var text = registration.Serialize().FormatAsJson();
            var expected = @"
{
  'alias': 'alias',
  'tags': [
    'tag1',
    'tag2'
  ]
}".Replace("\r\n", "\n");
            Assert.AreEqual(expected, text);
        }
    }
}