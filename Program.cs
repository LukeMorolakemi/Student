namespace Student;



public class Student
{
    public static void Main(String[] args)
    {
        //string[] students = new string[] { "Luke", "Samuel", "James", "Thomas", "Adebayo", "Salami", "Tumise", "Kante", "Mbappe", "Samuel" };


        //List<int> studentAges = new List<int> { 20, 18, 22, 19, 21, 18, 23, 20, 19, 25 };

        //Console.WriteLine(studentAges.Contains(18));




        string[] students1 = new string[] { "Luke", "Samuel", "James", "Thomas", "Adebayo", "Salami", "Tumise", "Kante", "Mbappe", "Samuel" };


        List<int> studentAges2 = new List<int> { 20, 18, 22, 19, 21, 18, 23, 20, 19, 25 };

       
        bool isStudentage18 = studentAges2.Contains(18);


        Console.WriteLine("List of Students:");
        foreach (var student in students1)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("\nList of Student Ages:");
        foreach (var age in studentAges2)
        {
            Console.WriteLine(age);
        }

        if (isStudentage18)
        {
            Console.WriteLine("\nThere is a student whose age is 18 in the list.");
        }
        else
        {
            Console.WriteLine("\nThere is no student whose age is 18 in the list.");
        }

    }

}



