namespace MyAppNamespace;

internal class Program
{
    static Dictionary<string, string> pokedex = new Dictionary<string, string>();

    private static void Main()
    {
        // List<int> randomList = GetRandomList(5);

        // Console.WriteLine(randomList[0]);
        // Console.WriteLine(randomList[1]);
        // Console.WriteLine(randomList[2]);
        // Console.WriteLine(randomList[3]);
        // Console.WriteLine(randomList[4]);

        int age = 34;
        age = AddYear(age);
        Console.WriteLine(age);

        List<int> grades = new List<int>();
        grades.Add(10);

        AddGrade(grades, 15);

        Console.WriteLine(grades.Count);

    }

    private static void AddGrade(List<int> g, int grade) {
        List<int> g2 = g.ToList();
        g2.Add(grade);
    }
    private static int AddYear(int a) {
        a++;
        return a;
    }

    private static List<int> GetRandomList(int amountOfItems) {
        List<int> randomList = new List<int>();

        for (int i = 0 ; i < amountOfItems; i++) {
            randomList.Add(GetRandomNumber());
        }
        return randomList;
    }

    private static int GetRandomNumber() {
        Random rd = new Random();

        return rd.Next(14);
    }
    private static int PowerTo(int baseNumber, int exp) {
        int result = baseNumber;

        for (int i = 1; i < exp; i++) {
            result *= baseNumber;
        }

        return result;
    }

    private static int Square(int number = 1) {
        int result = number * number;

        return result;
    }

    private static double Square(double number) {
        double result = number * number;

        return result;
    }
}
