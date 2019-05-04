namespace Nhahaha.Tests
{
    /// <summary>
    /// Test class for the <see cref="RussianLaughter"/> class.
    /// </summary>
    public class RussianLaughterTests : LaughterTests
    {
        /// <inheritdoc/>
        protected override string GetExpectedOnce()
            => "xa";

        /// <inheritdoc/>
        protected override Laughter GetInstance()
            => new RussianLaughter();
    }
}
