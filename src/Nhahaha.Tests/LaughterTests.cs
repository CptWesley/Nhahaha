using Xunit;
using static AssertNet.Xunit.Assertions;

namespace Nhahaha.Tests
{
    /// <summary>
    /// Test class for the <see cref="Laughter"/> class.
    /// </summary>
    public abstract class LaughterTests
    {
        private Laughter laughter;

        /// <summary>
        /// Creates a new instance of the <see cref="LaughterTests"/> class.
        /// </summary>
        public LaughterTests()
            => laughter = GetInstance();

        /// <summary>
        /// Gets an instance of <see cref="Laughter"/> under test.
        /// </summary>
        /// <returns>A <see cref="Laughter"/> instance for tetsing.</returns>
        protected abstract Laughter GetInstance();

        /// <summary>
        /// Gets the expected single laugh string.
        /// </summary>
        /// <returns>The expected single laugh string.</returns>
        protected abstract string GetExpectedOnce();

        /// <summary>
        /// Checks that the laugh once is the expected laugh.
        /// </summary>
        [Fact]
        public void OnceTest()
            => AssertThat(laughter.LaughOnce()).IsEqualTo(GetExpectedOnce());

        /// <summary>
        /// Checks that the default laughter is repeated a correct amount of times when capitalization is explicitly enabled.
        /// </summary>
        [Fact]
        public void OnceCapitalizedTrueTest()
        {
            string once = laughter.LaughOnce(true);
            AssertThat(char.IsUpper(once[0])).IsTrue();
            AssertThat(once.Substring(1).ToCharArray()).AllSatisfy(c => char.IsLower(c));
        }

        /// <summary>
        /// Checks that the laughter is repeated a correct amount of times when capitalization is explicitly disabled.
        /// </summary>
        [Fact]
        public void OnceCapitalizeFalseTest()
        {
            string once = laughter.LaughOnce(false);
            AssertThat(once.ToCharArray()).AllSatisfy(c => char.IsLower(c));
        }

        /// <summary>
        /// Checks that the non-capitalized calls are strictly lower case.
        /// </summary>
        [Fact]
        public void OnlyLowerCaseTest()
        {
            string once = laughter.LaughOnce();
            AssertThat(once.ToCharArray()).AllSatisfy(c => char.IsLower(c));
        }

        /// <summary>
        /// Checks that the laughter is repeated a correct amount of times.
        /// </summary>
        [Fact]
        public void AmountTest()
        {
            string once = laughter.LaughOnce();
            AssertThat(laughter.Laugh(2)).IsEqualTo($"{once}{once}");
            AssertThat(laughter.Laugh(6)).IsEqualTo($"{once}{once}{once}{once}{once}{once}");
        }

        /// <summary>
        /// Checks that the laughter is repeated a correct amount of times when capitalization is explicitly enabled.
        /// </summary>
        [Fact]
        public void AmountCapitalizedTrueTest()
        {
            string once = laughter.LaughOnce();
            string actual = laughter.Laugh(4, true);
            AssertThat(actual.ToLowerInvariant()).IsEqualTo($"{once}{once}{once}{once}");
            AssertThat(char.IsUpper(actual[0])).IsTrue();
            AssertThat(actual.Substring(1).ToCharArray()).AllSatisfy(c => char.IsLower(c));
        }

        /// <summary>
        /// Checks that the laughter is repeated a correct amount of times when capitalization is explicitly disabled.
        /// </summary>
        [Fact]
        public void AmountCapitalizeFalseTest()
        {
            string once = laughter.LaughOnce();
            string actual = laughter.Laugh(5, false);
            AssertThat(actual.ToLowerInvariant()).IsEqualTo($"{once}{once}{once}{once}{once}");
            AssertThat(actual.ToCharArray()).AllSatisfy(c => char.IsLower(c));
        }

        /// <summary>
        /// Checks that the default laughter is repeated a correct amount of times.
        /// </summary>
        [Fact]
        public void DefaultTest()
        {
            string once = laughter.LaughOnce();
            AssertThat(laughter.Laugh()).IsEqualTo($"{once}{once}{once}");
        }

        /// <summary>
        /// Checks that the default laughter is repeated a correct amount of times when capitalization is explicitly enabled.
        /// </summary>
        [Fact]
        public void DefaultCapitalizedTrueTest()
        {
            string once = laughter.LaughOnce();
            string actual = laughter.Laugh(true);
            AssertThat(actual.ToLowerInvariant()).IsEqualTo($"{once}{once}{once}");
            AssertThat(char.IsUpper(actual[0])).IsTrue();
            AssertThat(actual.Substring(1).ToCharArray()).AllSatisfy(c => char.IsLower(c));
        }

        /// <summary>
        /// Checks that the default laughter is repeated a correct amount of times when capitalization is explicitly disabled.
        /// </summary>
        [Fact]
        public void DefaultCapitalizeFalseTest()
        {
            string once = laughter.LaughOnce();
            string actual = laughter.Laugh(false);
            AssertThat(actual.ToLowerInvariant()).IsEqualTo($"{once}{once}{once}");
            AssertThat(actual.ToCharArray()).AllSatisfy(c => char.IsLower(c));
        }
    }
}
