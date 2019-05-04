namespace Nhahaha.Tests
{
    /// <summary>
    /// Test class for the <see cref="JapaneseLaughter"/> class.
    /// </summary>
    public class JapaneseLaughterTests : LaughterTests
    {
        /// <inheritdoc/>
        protected override string GetExpectedOnce()
            => "w";

        /// <inheritdoc/>
        protected override Laughter GetInstance()
            => new JapaneseLaughter();
    }
}
