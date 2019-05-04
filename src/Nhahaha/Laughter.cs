using System.Text;

namespace Nhahaha
{
    /// <summary>
    /// Abstract class for producing laughter.
    /// </summary>
    public abstract class Laughter
    {
        private const int DefaultLaughterAmount = 3;

        /// <summary>
        /// Laughs the default amount of times.
        /// </summary>
        /// <returns>The produced localized laughter.</returns>
        public string Laugh()
            => Laugh(DefaultLaughterAmount);

        /// <summary>
        /// Laughs the default amount of times.
        /// </summary>
        /// <param name="capitalized">Determines whether or not the first letter should be capitalized.</param>
        /// <returns>The produced localized laughter.</returns>
        public string Laugh(bool capitalized)
            => Laugh(DefaultLaughterAmount, capitalized);

        /// <summary>
        /// Laughs the given amount of times.
        /// </summary>
        /// <param name="times">The number of times to laugh.</param>
        /// <returns>The produced localized laughter.</returns>
        public string Laugh(int times)
        {
            StringBuilder sb = new StringBuilder();
            string laugh = LaughOnce();
            for (int i = 0; i < times; i++)
            {
                sb.Append(laugh);
            }

            return sb.ToString();
        }

        /// <summary>
        /// Laughs the given amount of times.
        /// </summary>
        /// <param name="times">The number of times to laugh.</param>
        /// <param name="capitalized">Determines whether or not the first letter should be capitalized.</param>
        /// <returns>The produced localized laughter.</returns>
        public string Laugh(int times, bool capitalized)
        {
            string laughter = Laugh(times);

            if (capitalized)
            {
                laughter = CapitalizeFirstLetter(laughter);
            }

            return laughter;
        }

        /// <summary>
        /// Laughs once.
        /// </summary>
        /// <returns>The localized laughter.</returns>
        public abstract string LaughOnce();

        /// <summary>
        /// Laughs once.
        /// </summary>
        /// <param name="capitalized">Determines whether or not the first letter should be capitalized.</param>
        /// <returns>The localized laughter.</returns>
        public string LaughOnce(bool capitalized)
        {
            string laughter = LaughOnce();

            if (capitalized)
            {
                laughter = CapitalizeFirstLetter(laughter);
            }

            return laughter;
        }

        /// <summary>
        /// Capitalizes the first letter of a string.
        /// </summary>
        /// <param name="text">String to capitalize the first letter of.</param>
        /// <returns>The given string with the first letter capitalized.</returns>
        private static string CapitalizeFirstLetter(string text)
            => char.ToUpperInvariant(text[0]) + text.Substring(1);
    }
}
