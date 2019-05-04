namespace Nhahaha.Tests
{
    /// <summary>
    /// Test class for the <see cref="SpanishLaughter"/> class.
    /// </summary>
    public class SpanishLaughterTests : LaughterTests
    {
        /// <inheritdoc/>
        protected override string GetExpectedOnce()
            => "ja";

        /// <inheritdoc/>
        protected override Laughter GetInstance()
            => new SpanishLaughter();
    }
}
