namespace Nhahaha.Tests
{
    /// <summary>
    /// Test class for the <see cref="InternationalLaughter"/> class.
    /// </summary>
    public class InternationalLaughterTests : LaughterTests
    {
        /// <inheritdoc/>
        protected override string GetExpectedOnce()
            => "ha";

        /// <inheritdoc/>
        protected override Laughter GetInstance()
            => new InternationalLaughter();
    }
}
