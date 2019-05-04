namespace Nhahaha.Tests
{
    /// <summary>
    /// Test class for the <see cref="PortugeseLaughter"/> class.
    /// </summary>
    public class PortugeseLaughterTests : LaughterTests
    {
        /// <inheritdoc/>
        protected override string GetExpectedOnce()
            => "hue";

        /// <inheritdoc/>
        protected override Laughter GetInstance()
            => new PortugeseLaughter();
    }
}
