using Link_ExtensionMethods;
using System.Collections.Generic;
using System.Diagnostics;

internal class Program
{
    static List<int> integers;
    static List<string> strings;
    static List<double> doubles;
    static List<Patient> patients;
   




    private static void Main(string[] args)
    {
        integers = new List<int> { 5, 76, 3, 93, 143, 5, 11, 67, 5 };
        doubles = new List<double> { 1.23, 68.25, 44.55, 96.12, 393.4567, 2.45 };
        strings = new List<string> { "Hansi", "Pauli", "Heinzi", "Susi", "Pepi" };
        WriteList(integers);
        WriteList(doubles);
        WriteList(strings);

        //Befüllen der Listen mit folgenden Daten:
        patients = new List<Patient>();
        patients.Add(new Patient { Firstname = "Hansi", Lastname = "Huber", Age = 66, Costs = 1513 });
        patients.Add(new Patient { Firstname = "Heinzi", Lastname = "Prüller", Age = 77, Costs = 3100 });
        patients.Add(new Patient { Firstname = "Susi", Lastname = "Maurer", Age = 55, Costs = 2460 });
        patients.Add(new Patient { Firstname = "Gerti", Lastname = "Lehner", Age = 55, Costs = 2941 });
        patients.Add(new Patient { Firstname = "Pauli", Lastname = "Huber", Age = 44, Costs = 1471 });

        Console.WriteLine("Integers: -> Count,Max,Min,Sum,Average");
        Console.WriteLine(integers.Count());
        Console.WriteLine(integers.Max());
        Console.WriteLine(integers.Min());
        Console.WriteLine(integers.Sum());
        Console.WriteLine(integers.Average());
        Console.WriteLine("Doubles: -> Count,Max,Min,Sum,Average");
        Console.WriteLine(doubles.Count());
        Console.WriteLine(doubles.Max());
        Console.WriteLine(doubles.Min());
        Console.WriteLine(doubles.Sum());
        Console.WriteLine(doubles.Average());
        Console.WriteLine("Predicate - Test -> > als 70");
        List<int> NumbersGR70 = integers.Where(x => x > 70);
        foreach (int number in NumbersGR70)
        {
            Console.WriteLine(number);
        }
        Console.WriteLine("Predicate - Test Patienten-> > als 50");
        List<Patient> PatientenGR50 = patients.Where(x => x.Age > 50);
        foreach (Patient patient in PatientenGR50)
        {
            Console.WriteLine(patient);
        }
        Console.WriteLine("Reverse List");
        List<int> reverseList = integers.MyReverse();
        foreach (int number in reverseList)
        {
            Console.WriteLine(number);
        }
        List<int> ints = new List<int>();
        List<string> strings2 = new List<string>();
        ints = integers.Take(3);
        Console.WriteLine("Take");
        WriteList(ints);
        Console.WriteLine("Skip");
        ints = integers.Skip(3);
        WriteList(ints);
        Console.WriteLine("Distinct");
        ints = integers.Distinct();
        WriteList(ints);
        Console.WriteLine("Reverse");
        strings2 = strings.MyReverse();
        WriteList(strings2);
        Console.WriteLine("Ein Element");
        Console.WriteLine(strings.MyFirst());
        Console.WriteLine("Ein Element an stelle n");
        Console.WriteLine(strings.MyElementAt(2));
        Console.WriteLine("Take While");
        ints = integers.MyTakeWhile(x=> x < 143);
        WriteList(ints);
        Console.WriteLine("Skip While");
        ints = integers.MySkipWhile(x => x < 143);
        WriteList(ints);
        Console.WriteLine("Where");
        ints = integers.MyWhere(x => x == 5);
        WriteList(ints);
        Console.WriteLine("Select");
        strings2 = integers.MySelect(x => x.ToString() + "blbllb");
        WriteList(strings2);
        Console.WriteLine("Order by auf");
        ints = integers.MyOrderBy((a, b) => a.CompareTo(b));
        WriteList(ints);
        Console.WriteLine("Order by down");
        ints = integers.MyOrderBydown((a, b) => a.CompareTo(b));
        WriteList(ints);
    }

    public static void WriteList<T>(List<T> list)
    {
        foreach (T item in list)
        {
            Console.WriteLine(item);
        }
    }
}