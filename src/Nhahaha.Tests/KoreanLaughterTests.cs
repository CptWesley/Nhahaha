namespace Nhahaha.Tests
{
    /// <summary>
    /// Test class for the <see cref="KoreanLaughter"/> class.
    /// </summary>
    public class KoreanLaughterTests : LaughterTests
    {
        /// <inheritdoc/>
        protected override string GetExpectedOnce()
            => "ke";

        /// <inheritdoc/>
        protected override Laughter GetInstance()
            => new KoreanLaughter();
    }
}
