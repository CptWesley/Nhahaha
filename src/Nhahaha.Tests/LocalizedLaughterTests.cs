using System.Globalization;
using System.Threading;
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
        /// Checks that we can create the Spanish culture laughter correctly.
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

        /// <summary>
        /// Checks that we can create the Thai culture laughter correctly.
        /// </summary>
        [Fact]
        public static void ThaiTest()
            => AssertThat(LocalizedLaughter.Create(new CultureInfo("th"))).IsExactlyInstanceOf<ThaiLaughter>();

        /// <summary>
        /// Checks that we can create the Japanese culture laughter correctly.
        /// </summary>
        [Fact]
        public static void JapaneseTest()
            => AssertThat(LocalizedLaughter.Create(new CultureInfo("jp"))).IsExactlyInstanceOf<JapaneseLaughter>();

        /// <summary>
        /// Checks that we can create the correct laughter from the current thread culture.
        /// </summary>
        [Fact]
        public static void CurrentCultureTest()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("es");
            AssertThat(LocalizedLaughter.Create()).IsExactlyInstanceOf<SpanishLaughter>();
        }
    }
}
