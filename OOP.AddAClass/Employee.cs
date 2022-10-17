namespace OOP.AddAClass
{
    class Employee
    {
        private string _firstName;
        private string _lastName;

        public string FirstName
        {
            set
            {
                _firstName = value;
            }
            get
            {
                return _firstName;
            }
        }
        public string LastName 
        { 
            //Expression-bodied property accessors
            get => _lastName; 
            set => _lastName = value; 
        }
        
        public int Age { get; set; }
        //Auto-implemented property

        public Employee() // default olarak mevcut
        {
            System.Console.WriteLine("Yapılandırıcı method çalıştı...");
        }

        public Employee(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        public override string? ToString()
        {
            return $"{FirstName,-20} {LastName,-15} {Age, 5}";
            // - ifadeler sola, + ifadeler sağa yaslama
            // içerdeki sayılar karakter sayısı kadar boşluk oluşturma
        }
    }
}