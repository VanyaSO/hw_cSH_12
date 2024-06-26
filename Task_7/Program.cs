namespace Task_7;

// Створіть запис Person. Необхідно зберігати інформацію про ім’я, прізвище, вік. Створіть масив записів
// Person. Напишіть код для пошуку людини із мінімальним
// і максимальним віком. Відобразіть середній вік людей
// (реалізуйте за допомогою extension method).

public static class ListExtensions
{
    public static Person MinPerson(this List<Person> list)
    {
        Person min = list[0];
        
        foreach (var p in list)
            if (p.Age < min.Age)
                min = p;
        
        return min;
    }
    
    public static Person MaxPerson(this List<Person> list)
    {
        Person max = list[0];
        
        foreach (var p in list)
            if (p.Age > max.Age)
                max = p;
        
        return max;
    }
    
    public static int AverageAge(this List<Person> list)
    {
        return list.Sum(p => p.Age) / list.Count;
    }
}

class Program
{
    
    static void Main(string[] args)
    {
        List<Person> listPersons = new List<Person>();
        listPersons.Add(new Person("John", "Doe", 30));
        listPersons.Add(new Person("Jane", "Smith", 18));
        listPersons.Add(new Person("Michael", "Johnson", 41));
        listPersons.Add(new Person("Emily", "Brown", 35));
        listPersons.Add(new Person("William", "Davis", 28));

        Console.WriteLine(listPersons.MinPerson());
        Console.WriteLine(listPersons.MaxPerson());
        Console.WriteLine(listPersons.AverageAge());
    }
}