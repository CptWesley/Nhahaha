using System.Globalization;

namespace Nhahaha
{
    /// <summary>
    /// Static class used for creating a localized laughter engine based on the culture info of the user.
    /// </summary>
    public static class LocalizedLaughter
    {
        /// <summary>
        /// Creates a laughter engine for the given culture.
        /// </summary>
        /// <param name="cultureInfo">Culture used for generating the engine.</param>
        /// <returns>A laughter engine for the given culture.</returns>
        public static Laughter Create(CultureInfo cultureInfo)
        {
            switch (cultureInfo.TwoLetterISOLanguageName)
            {
                case "es":
                    return new SpanishLaughter();
                case "th":
                    return new ThaiLaughter();
                case "jp":
                    return new JapaneseLaughter();
                case "ru":
                    return new RussianLaughter();
                case "ko":
                    return new KoreanLaughter();
                case "pt":
                    return new PortugeseLaughter();
                case "el":
                    return new GreekLaughter();
                case "da":
                    return new DanishLaughter();
                default:
                    return new InternationalLaughter();
            }
        }

        /// <summary>
        /// Creates a laughter engine for the current culture.
        /// </summary>
        /// <returns>A laughter engine for the current culture.</returns>
        public static Laughter Create()
            => Create(CultureInfo.CurrentCulture);
    }
}
