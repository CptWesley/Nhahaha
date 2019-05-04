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
        /// Checks that we can create the Russian culture laughter correctly.
        /// </summary>
        [Fact]
        public static void RussianTest()
            => AssertThat(LocalizedLaughter.Create(new CultureInfo("ru"))).IsExactlyInstanceOf<RussianLaughter>();

        /// <summary>
        /// Checks that we can create the Korean culture laughter correctly.
        /// </summary>
        [Fact]
        public static void KoreanTest()
            => AssertThat(LocalizedLaughter.Create(new CultureInfo("ko"))).IsExactlyInstanceOf<KoreanLaughter>();

        /// <summary>
        /// Checks that we can create the Portugese culture laughter correctly.
        /// </summary>
        [Fact]
        public static void PortugeseTest()
            => AssertThat(LocalizedLaughter.Create(new CultureInfo("pt"))).IsExactlyInstanceOf<PortugeseLaughter>();

        /// <summary>
        /// Checks that we can create the Greek culture laughter correctly.
        /// </summary>
        [Fact]
        public static void GreekTest()
            => AssertThat(LocalizedLaughter.Create(new CultureInfo("el"))).IsExactlyInstanceOf<GreekLaughter>();

        /// <summary>
        /// Checks that we can create the Danish culture laughter correctly.
        /// </summary>
        [Fact]
        public static void DanishTest()
            => AssertThat(LocalizedLaughter.Create(new CultureInfo("da"))).IsExactlyInstanceOf<DanishLaughter>();

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
