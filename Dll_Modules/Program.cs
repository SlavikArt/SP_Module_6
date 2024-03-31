using Geometry;
using TextProcessing;

namespace Dll_Modules
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Geometry.dll
            Console.WriteLine("Площа квадрата зі стороною 5: " + Area.Square(5));
            Console.WriteLine("Площа прямокутника зі сторонами 5 та 6: " + Area.Rectangle(5, 6));
            Console.WriteLine("Площа трикутника з основою 5 та висотою 6: " + Area.Triangle(5, 6));
            Console.WriteLine("Площа трикутника зі сторонами 5, 6, 7 (за формулою Герона): " + Area.Triangle(5, 6, 7));
            Console.WriteLine("Площа кола з радіусом 5: " + Area.Circle(5));
            Console.WriteLine("Площа паралелограма з основою 5 та висотою 6: " + Area.Parallelogram(5, 6));
            Console.WriteLine("Площа трапеції з основами 5 та 6 та висотою 7: " + Area.Trapezoid(5, 6, 7));

            Console.WriteLine();

            // TextProcessing.dll
            Console.WriteLine("Чи є 'сир і рис' паліндромом? " + Operations.IsPalindrome("сир і рис"));
            Console.WriteLine("Кількість символів у слові 'Україна': " + Operations.CharacterCount("Україна"));
            Console.WriteLine("Кількість слів у 'Як умру, то поховайте.': " + Operations.WordCount("Як умру, то поховайте."));
            Console.WriteLine("Кількість 'о' у 'Як умру, то поховайте.': " + Operations.CharCount("Як умру, то поховайте.", 'о'));
            Console.WriteLine("Чи містить 'Як умру, то поховайте.' слово 'то'? " + Operations.ContainsWord("Як умру, то поховайте.", "то"));
            Console.WriteLine("'сир' у верхньому регістрі: " + Operations.ToUpperCase("сир"));
            Console.WriteLine("'рис' у нижньому регістрі: " + Operations.ToLowerCase("рис"));
            Console.WriteLine("Чи складається 'Україна' тільки з букв? " + Operations.IsAllLetters("Україна"));
            Console.WriteLine("Чи складається '12345' тільки з цифр? " + Operations.IsAllDigits("1234"));
            Console.WriteLine("Чи складається '    ' тільки з пробілів? " + Operations.IsAllWhitespace("    "));
        }
    }
}
