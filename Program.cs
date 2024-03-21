namespace Practice_interfaceAndIEnumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> studentNames = new List<string>
            {
                "Alice", "Bob", "Charlie", "David", "Emma",
                "Frank", "Grace", "Henry", "Ivy", "Jack",
                "Katie", "Liam", "Mia", "Noah", "Olivia",
                "Parker", "Quinn", "Ryan", "Sophia", "Tyler"
            };

            // Create a school class with the generated student names
            SchoolClass prog124 = new SchoolClass("Programming 124", studentNames);

            // Iterate over the class roster
            foreach (Student student in prog124)
            {
                Console.WriteLine(student);
            }
        }
    }
}