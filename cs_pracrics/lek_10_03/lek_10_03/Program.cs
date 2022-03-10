using System;

namespace lek_10_03
{
    //!!!
    //polymorphism and inheritance(nasledovanie)
    //!!!

    //INHERITANCE
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    /*
    class Person 
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void Display ()
        {
            Console.WriteLine(Name);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Person vasya = new Person();
            vasya.Name = "vasya";
            vasya.Display();
        }
    }
    */
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!1!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!2!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    /*
    class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void Display()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person //this feature
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person vasya = new Person();
            vasya.Name = "vasya";
            vasya.Display();

            Employee Sam = new Employee();
            Sam.Name = "Sam";
            Sam.Display();
        }
    }
    */
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!2!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!3!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    /*
    class Person
    {
        private protected string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void Display()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person //this feature
    {
        public void Display() 
        {
            //!check _name's modificator!
            Console.WriteLine(_name);
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person vasya = new Person();
            vasya.Name = "vasya";
            vasya.Display();

            Employee Sam = new Employee();
            Sam.Name = "Sam";
            Sam.Display();
        }
    }
    */
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!3!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!4!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    /*
    class Person
    {
        public string Name
        {
            get;
            set;
        }
        public Person(string name)
        {
            Name = name;
        }

        public void Display()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person 
    {
        public string Company { get; set; }
        public Employee(string name, string company): base(name)
        {
            Company = company;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person vasya = new Person("Bill");
            vasya.Name = "vasya";
            vasya.Display();

            Employee Sam = new Employee("Tom", "Microsoft"); 
            
            Sam.Display();
        }
    }
    */
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!4!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!5!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    /*
    class Person
    {
        public string Name
        {
            get;
            set;
        }
        public Person(string name)
        {
            Name = name;
        }
        public Person()
        {
            Name = "unknown";
        }

        public void Display()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string company) : base()
        {
            Company = company;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person vasya = new Person();
            vasya.Display();

            Employee Sam = new Employee("Microsoft");

            Sam.Display();
        }
    }
    //result -
    //unknown
    //unknown
    */
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!5!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!6!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    /*
    class Person
    {
        public string Name
        {
            get;
            set;
        }
        public Person(string name)
        {
            Name = name;
        }
        public Person()
        {
            Name = "unknown";
        }

        public void Display()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string company) : base()
        {
            Company = company;
        }
        public Employee(string name,string company) : base(name)
        {
            Company = company;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person vasya = new Person();
            vasya.Display();

            Employee Sam = new Employee("Tom", "Microsoft");

            Sam.Display();
        }
    }
    */
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!6!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!7!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    class Person
    {
        public string Name
        {
            get;
            set;
        }
        public Person(string name)
        {
            Name = name;
        }
        public Person()
        {
            Name = "unknown";
        }

        public void Display()
        {
            Console.WriteLine(Name);
        }
    }
    class Employee : Person
    {
        public string Company { get; set; }
        public Employee(string company) : base()
        {
            Company = company;
        }
        public Employee(string name, string company) : base(name)
        {
            Company = company;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person vasya = new Person();
            vasya.Display();

            Employee Sam = new Employee("Tom", "Microsoft");

            Sam.Display();
        }
    }
    //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!7!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
    //...

}
