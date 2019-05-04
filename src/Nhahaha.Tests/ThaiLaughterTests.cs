namespace Nhahaha.Tests
{
    /// <summary>
    /// Test class for the <see cref="ThaiLaughter"/> class.
    /// </summary>
    public class ThaiLaughterTests : LaughterTests
    {
        /// <inheritdoc/>
        protected override string GetExpectedOnce()
            => "5";

        /// <inheritdoc/>
        protected override Laughter GetInstance()
            => new ThaiLaughter();
    }
}
