namespace TextProcessingSourceCode
{
    public static class Operations
    {
        /// <summary>
        /// Перевіряє, чи є текст паліндромом.
        /// </summary>
        /// <param name="text">Текст для перевірки.</param>
        /// <returns>Повертає true, якщо текст є паліндромом, і false, якщо ні.</returns>
        public static bool IsPalindrome(string text)
        {
            return text == new string(text.Reverse().ToArray());
        }

        /// <summary>
        /// Підраховує кількість символів у тексті.
        /// </summary>
        /// <param name="text">Текст для підрахунку символів.</param>
        /// <returns>Кількість символів у тексті.</returns>
        public static int CharacterCount(string text)
        {
            return text.Length;
        }

        /// <summary>
        /// Підраховує кількість слів у тексті.
        /// </summary>
        /// <param name="text">Текст для підрахунку слів.</param>
        /// <returns>Кількість слів у тексті.</returns>
        public static int WordCount(string text)
        {
            return text.Split(new[] { ' ', '\t', '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries).Length;
        }

        /// <summary>
        /// Підраховує кількість входжень певного символу в текст.
        /// </summary>
        /// <param name="text">Текст для аналізу.</param>
        /// <param name="character">Символ для пошуку в тексті.</param>
        /// <returns>Кількість входжень символу в текст.</returns>
        public static int CharCount(string text, char character)
        {
            return text.Count(c => c == character);
        }

        /// <summary>
        /// Перевіряє, чи містить текст певне слово.
        /// </summary>
        /// <param name="text">Текст для перевірки.</param>
        /// <param name="word">Слово для пошуку в тексті.</param>
        /// <returns>Повертає true, якщо текст містить слово, і false, якщо ні.</returns>
        public static bool ContainsWord(string text, string word)
        {
            return text.Contains(word);
        }

        /// <summary>
        /// Перетворює текст на верхній регістр.
        /// </summary>
        /// <param name="text">Текст для перетворення.</param>
        /// <returns>Текст у верхньому регістрі.</returns>
        public static string ToUpperCase(string text)
        {
            return text.ToUpper();
        }

        /// <summary>
        /// Перетворює текст на нижній регістр.
        /// </summary>
        /// <param name="text">Текст для перетворення.</param>
        /// <returns>Текст у нижньому регістрі.</returns>
        public static string ToLowerCase(string text)
        {
            return text.ToLower();
        }

        /// <summary>
        /// Перевіряє, чи містить текст тільки букви.
        /// </summary>
        /// <param name="text">Текст для перевірки.</param>
        /// <returns>Повертає true, якщо текст містить тільки букви, і false, якщо ні.</returns>
        public static bool IsAllLetters(string text)
        {
            return text.All(char.IsLetter);
        }

        /// <summary>
        /// Перевіряє, чи містить текст тільки цифри.
        /// </summary>
        /// <param name="text">Текст для перевірки.</param>
        /// <returns>Повертає true, якщо текст містить тільки цифри, і false, якщо ні.</returns>
        public static bool IsAllDigits(string text)
        {
            return text.All(char.IsDigit);
        }

        /// <summary>
        /// Перевіряє, чи містить текст тільки пробіли.
        /// </summary>
        /// <param name="text">Текст для перевірки.</param>
        /// <returns>Повертає true, якщо текст містить тільки пробіли, і false, якщо ні.</returns>
        public static bool IsAllWhitespace(string text)
        {
            return text.All(char.IsWhiteSpace);
        }
    }
}
