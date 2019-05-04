using System.Globalization;
using Xunit;
using static AssertNet.Xunit.Assertions;

namespace Nhahaha.Tests
{
    /// <summary>
    /// Test class for the <see cref="LocalizedLaughter"/> class.
    /// </summary>
    public static class LocalizedLaughterTests
    {
        /// <summary>
        /// Checks that we can create the spanish culture laughter correctly.
        /// </summary>
        [Fact]
        public static void SpanishTest()
            => AssertThat(LocalizedLaughter.Create(new CultureInfo("es"))).IsExactlyInstanceOf<SpanishLaughter>();

        /// <summary>
        /// Checks that we can create the international culture laughter correctly.
        /// </summary>
        [Fact]
        public static void InternationalTest()
            => AssertThat(LocalizedLaughter.Create(new CultureInfo("en"))).IsExactlyInstanceOf<InternationalLaughter>();
    }
}
