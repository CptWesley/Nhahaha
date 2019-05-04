namespace Nhahaha.Tests
{
    /// <summary>
    /// Test class for the <see cref="DanishLaughter"/> class.
    /// </summary>
    public class DanishLaughterTests : LaughterTests
    {
        /// <inheritdoc/>
        protected override string GetExpectedOnce()
            => "hæ";

        /// <inheritdoc/>
        protected override Laughter GetInstance()
            => new DanishLaughter();
    }
}
