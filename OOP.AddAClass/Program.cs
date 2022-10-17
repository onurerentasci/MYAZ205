namespace OOP.AddAClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Employee>()
            {
                new Employee(){ FirstName = "Ahmet", LastName = "Türkoğlu", Age = 21},
                new Employee("Mehmet", "Üstün", 15),
                new Employee("Merve", "Aslan", 42)
        };

            // Console.WriteLine($"{employee2.FirstName} {employee2.LastName} {employee2.Age}");
            // Console.WriteLine(employee3);
            //list.Add(employee);
            //list.Add(employee2);
            //list.Add(employee3);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}