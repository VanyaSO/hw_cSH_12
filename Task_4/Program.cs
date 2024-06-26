namespace Task_4;

// Завдання 4
// Створіть метод розширення (extension method) для
// підрахунку кількості голосних у рядку. Напишіть код для тестування методу.

public static class StringExtension
{
    public static int CountVowels(this string str)
    {
        char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U', 'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э', 'ю', 'я', 'А', 'Е', 'Ё', 'И', 'О', 'У', 'Ы', 'Э', 'Ю', 'Я' };
        return str.Count(c => vowels.Contains(c));
    }
}

class Program
{
    static void Main(string[] args)
    {
        string strEng = "Hello summer";
        Console.WriteLine(strEng.CountVowels());
        
        string strRu = "Ура лето пришло";
        Console.WriteLine(strRu.CountVowels());
    }
}