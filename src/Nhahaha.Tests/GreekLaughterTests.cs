namespace Nhahaha.Tests
{
    /// <summary>
    /// Test class for the <see cref="GreekLaughter"/> class.
    /// </summary>
    public class GreekLaughterTests : LaughterTests
    {
        /// <inheritdoc/>
        protected override string GetExpectedOnce()
            => "xa";

        /// <inheritdoc/>
        protected override Laughter GetInstance()
            => new GreekLaughter();
    }
}
