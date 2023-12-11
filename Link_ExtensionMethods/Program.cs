using Link_ExtensionMethods;

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


        //Befüllen der Listen mit folgenden Daten:
        patients = new List<Patient>();
        patients.Add(new Patient { Firstname = "Hansi", Lastname = "Huber", Age = 66, Costs = 1513 });
        patients.Add(new Patient { Firstname = "Heinzi", Lastname = "Prüller", Age = 77, Costs = 3100 });
        patients.Add(new Patient { Firstname = "Susi", Lastname = "Maurer", Age = 55, Costs = 2460 });
        patients.Add(new Patient { Firstname = "Gerti", Lastname = "Lehner", Age = 55, Costs = 2941 });
        patients.Add(new Patient { Firstname = "Pauli", Lastname = "Huber", Age = 44, Costs = 1471 });


       Console.WriteLine(integers.Count());
        Console.WriteLine(integers.Max());
        Console.WriteLine(integers.Min());
        Console.WriteLine(integers.Sum());
        Console.WriteLine(integers.Average());
    }
}