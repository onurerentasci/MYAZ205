namespace OOP.AddAClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();
            employee.Add(new Employee("Ahmet", "Yılmaz", 40));
            employee.AddRange(
                new Employee("Merve", "Aslan", 22),
                new Employee("Hamza", "Kaplan", 34),
                new Employee("Hasan", "Kaan", 54));

            Console.ReadLine();
        }
    }
}